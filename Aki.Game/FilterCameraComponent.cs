using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Character.Role.Common;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002209 RID: 8713
[NullableContext(2)]
[Nullable(0)]
public class FilterCameraComponent
{
	// Token: 0x06010F9F RID: 69535 RVA: 0x0042344A File Offset: 0x0042164A
	public FilterCameraComponent([Nullable(new byte[]
	{
		1,
		0
	})] Func<UniTask<bool>> openView, EUiViewName name)
	{
		this.OnOpenView = openView;
		this.ViewName = new EUiViewName?(name);
	}

	// Token: 0x1700158F RID: 5519
	// (get) Token: 0x06010FA0 RID: 69536 RVA: 0x00423488 File Offset: 0x00421688
	public float ControlCameraRate
	{
		get
		{
			if (this.ControlCameraRateInternal == null)
			{
				this.ControlCameraRateInternal = new float?((float)ConfigCommonParamById.GetIntConfig("ControlCameraRate").Value / 100f);
			}
			return this.ControlCameraRateInternal.Value;
		}
	}

	// Token: 0x06010FA1 RID: 69537 RVA: 0x004234D4 File Offset: 0x004216D4
	[NullableContext(0)]
	public UniTask<bool> TryOpenPhotograph()
	{
		FilterCameraComponent.<TryOpenPhotograph>d__15 <TryOpenPhotograph>d__;
		<TryOpenPhotograph>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<TryOpenPhotograph>d__.<>4__this = this;
		<TryOpenPhotograph>d__.<>1__state = -1;
		<TryOpenPhotograph>d__.<>t__builder.Start<FilterCameraComponent.<TryOpenPhotograph>d__15>(ref <TryOpenPhotograph>d__);
		return <TryOpenPhotograph>d__.<>t__builder.Task;
	}

	// Token: 0x06010FA2 RID: 69538 RVA: 0x00423517 File Offset: 0x00421717
	public void ClosePhotograph()
	{
		this.ResetPhotographBeforeBlackScreen();
		this.ResetPhotographInBlackScreen();
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("FilterCameraComponent");
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroScreenFilterFrame 60", null);
		UiLayer.Instance.SetLayerActive(ELayerType.HUD, true);
	}

	// Token: 0x06010FA3 RID: 69539 RVA: 0x00423550 File Offset: 0x00421750
	public void ResetPhotograph()
	{
		this.ResetPhotographBeforeBlackScreen();
		this.ResetPhotographInBlackScreen();
	}

	// Token: 0x06010FA4 RID: 69540 RVA: 0x0042355E File Offset: 0x0042175E
	private void ResetPhotographBeforeBlackScreen()
	{
		this.FightCameraActor = null;
		this.WidgetCameraActor = null;
		this.WidgetCineCameraComponent = null;
	}

	// Token: 0x06010FA5 RID: 69541 RVA: 0x00423578 File Offset: 0x00421778
	private void ResetPhotographInBlackScreen()
	{
		UiCameraManager.Destroy(0.5f, EViewTargetBlendFunction.VTBlend_Linear, 0f);
		this.UiCameraPhotographerStructure = null;
		this.ResetEntityEnable();
		this.PhotographOptionMap.Clear();
		this.RemoveEntityEvents();
		FightCameraLogicComponent fightCameraLogicComponent = this.GetFightCameraLogicComponent();
		if (fightCameraLogicComponent != null)
		{
			fightCameraLogicComponent.SetIsDitherEffectEnable(true);
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter != null)
		{
			SeamlessTravelController instance = SeamlessTravelController.Instance;
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			if (!instance.WasRoleEntityInSeamlessTraveling((characterActorComponent != null) ? characterActorComponent.Entity : null) && baseCharacter != null)
			{
				baseCharacter.SetDitherEffect(0f, ECharacterDitherType.Fight);
			}
		}
	}

	// Token: 0x06010FA6 RID: 69542 RVA: 0x004235FC File Offset: 0x004217FC
	public void RemoveEntityEvents()
	{
		foreach (ITagTask tagTask in this.Tasks)
		{
			tagTask.EndTask();
		}
		this.Tasks.Clear();
	}

	// Token: 0x06010FA7 RID: 69543 RVA: 0x00423658 File Offset: 0x00421858
	private UniTask OpenBlackScreen()
	{
		FilterCameraComponent.<OpenBlackScreen>d__21 <OpenBlackScreen>d__;
		<OpenBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenBlackScreen>d__.<>1__state = -1;
		<OpenBlackScreen>d__.<>t__builder.Start<FilterCameraComponent.<OpenBlackScreen>d__21>(ref <OpenBlackScreen>d__);
		return <OpenBlackScreen>d__.<>t__builder.Task;
	}

	// Token: 0x06010FA8 RID: 69544 RVA: 0x00423694 File Offset: 0x00421894
	private UniTask CloseBlackScreen()
	{
		FilterCameraComponent.<CloseBlackScreen>d__22 <CloseBlackScreen>d__;
		<CloseBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseBlackScreen>d__.<>1__state = -1;
		<CloseBlackScreen>d__.<>t__builder.Start<FilterCameraComponent.<CloseBlackScreen>d__22>(ref <CloseBlackScreen>d__);
		return <CloseBlackScreen>d__.<>t__builder.Task;
	}

	// Token: 0x06010FA9 RID: 69545 RVA: 0x004236D0 File Offset: 0x004218D0
	private void StopAutoMoving()
	{
		if (Global.BaseCharacter == null)
		{
			return;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(Global.BaseCharacter.EntityId);
		if (entityById == null)
		{
			return;
		}
		WorldEntity entity = entityById.Entity;
		if (entity == null)
		{
			return;
		}
		CharacterInputComponent component = entity.GetComponent<CharacterInputComponent>();
		if (component == null)
		{
			return;
		}
		component.InterruptAutoMoving("打开眼保护界面", true);
	}

	// Token: 0x06010FAA RID: 69546 RVA: 0x00423720 File Offset: 0x00421920
	private void AddEntityEvents()
	{
		this.AddTagTask(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]), new Action<int, bool>(this.OnTagChanged));
		this.AddTagTask(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]), new Action<int, bool>(this.OnTagChanged));
		this.AddTagTask(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"]), new Action<int, bool>(this.OnTagChanged));
	}

	// Token: 0x06010FAB RID: 69547 RVA: 0x004237A0 File Offset: 0x004219A0
	[NullableContext(1)]
	private void AddTagTask(int? tag, Action<int, bool> callback)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null && getCurrentEntity.Valid)
		{
			WorldEntity entity = getCurrentEntity.Entity;
			if (entity != null && entity.Valid)
			{
				BaseTagComponent component = getCurrentEntity.Entity.GetComponent<BaseTagComponent>();
				if (component == null)
				{
					return;
				}
				ITagTask tagTask = component.ListenForTagAddOrRemove(tag, delegate(int _1, bool _2)
				{
					callback(_1, _2);
				}, null);
				if (tagTask != null)
				{
					this.Tasks.Add(tagTask);
				}
				return;
			}
		}
	}

	// Token: 0x06010FAC RID: 69548 RVA: 0x00423822 File Offset: 0x00421A22
	private void OnTagChanged(int tagId, bool tagExists)
	{
		if (!tagExists)
		{
			return;
		}
		if (UiManager.Instance.IsViewOpen(this.ViewName.Value))
		{
			UiManager.Instance.CloseView(this.ViewName.Value, null);
		}
	}

	// Token: 0x06010FAD RID: 69549 RVA: 0x00423858 File Offset: 0x00421A58
	private bool CheckCanOpenPhotograph()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			return false;
		}
		if (PlotModel.Instance.IsInPlot)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GlobalFliterOpenTips", Array.Empty<object>());
			Log.Instance.Info(ELogModule.Photo, ELogAuthor.JYS, "无法设置滤镜:在剧情中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		WorldEntity entity = getCurrentEntity.Entity;
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent == null)
		{
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GlobalFliterOpenTips", Array.Empty<object>());
			Log.Instance.Info(ELogModule.Photo, ELogAuthor.JYS, "无法设置滤镜:在空中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GlobalFliterOpenTips", Array.Empty<object>());
			Log.Instance.Info(ELogModule.Photo, ELogAuthor.JYS, "无法设置滤镜:在水中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GlobalFliterOpenTips", Array.Empty<object>());
			Log.Instance.Info(ELogModule.Photo, ELogAuthor.JYS, "无法设置滤镜:在攀爬", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GlobalFliterOpenTips", Array.Empty<object>());
			Log.Instance.Info(ELogModule.Photo, ELogAuthor.JYS, "无法设置滤镜:在战斗中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GlobalFliterOpenTips", Array.Empty<object>());
			Log.Instance.Info(ELogModule.Photo, ELogAuthor.JYS, "无法设置滤镜:在技能中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.驾驶载具"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GlobalFliterOpenTips", Array.Empty<object>());
			Log.Instance.Info(ELogModule.Photo, ELogAuthor.JYS, "无法设置滤镜:在驾驶载具", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.FilterSettingView) || UiManager.Instance.IsViewOpen(EUiViewName.EyeProtectView))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GlobalFliterOpenTips", Array.Empty<object>());
			Log.Instance.Info(ELogModule.Photo, ELogAuthor.JYS, "无法设置滤镜:已经在滤镜界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (SceneTeamModel.Instance.IsPhantomTeam || SceneTeamModel.Instance.HasPhantomRole())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GlobalFliterOpenTips", Array.Empty<object>());
			Log.Instance.Info(ELogModule.Photo, ELogAuthor.JYS, "无法设置滤镜:在声骸编队", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		WorldEntity entity2 = getCurrentEntity.Entity;
		CharacterAnimationComponent characterAnimationComponent = (entity2 != null) ? entity2.GetComponent<CharacterAnimationComponent>() : null;
		if (characterAnimationComponent == null)
		{
			return false;
		}
		if (!(characterAnimationComponent.MainAnimInstance is ABP_BaseRole_C))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GlobalFliterOpenTips", Array.Empty<object>());
			Log.Instance.Info(ELogModule.Photo, ELogAuthor.JYS, "无法设置滤镜:实体状态机找不到", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return true;
	}

	// Token: 0x06010FAE RID: 69550 RVA: 0x00423BA4 File Offset: 0x00421DA4
	private void InitPhotographRelativeContent()
	{
		this.WidgetCameraActor = this.GetWidgetCameraActor();
		if (this.WidgetCameraActor == null)
		{
			return;
		}
		this.FightCameraActor = this.GetFightCameraActor();
		if (this.FightCameraActor == null)
		{
			return;
		}
		this.WidgetCineCameraComponent = this.GetWidgetCameraComponent();
		FightCameraLogicComponent fightCameraLogicComponent = this.GetFightCameraLogicComponent();
		if (fightCameraLogicComponent != null)
		{
			fightCameraLogicComponent.SetIsDitherEffectEnable(false);
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter != null)
		{
			baseCharacter.SetDitherEffect(1f, ECharacterDitherType.Fight);
		}
		FVectorDouble? fvectorDouble;
		if (baseCharacter == null)
		{
			fvectorDouble = null;
		}
		else
		{
			USkeletalMeshComponent mesh = baseCharacter.Mesh;
			fvectorDouble = ((mesh != null) ? new FVectorDouble?(mesh.D_GetSocketLocation(PhotographDefine.SPAWN_SOCKET_NAME)) : null);
		}
		FVectorDouble? fvectorDouble2 = fvectorDouble;
		FTransformDouble cameraInitializeTransform = this.FightCameraActor.D_GetTransform();
		FVectorDouble? location = fvectorDouble2;
		FQuat rotation = cameraInitializeTransform.GetRotation();
		FVector scale3D = cameraInitializeTransform.GetScale3D();
		UiCameraPhotographerStructure uiCameraPhotographerStructure = this.SpawnPhotographerStructure(location, rotation, scale3D);
		if (this.WidgetCineCameraComponent != null)
		{
			this.WidgetCineCameraComponent.FocusSettings.ManualFocusDistance = 300f;
		}
		if (uiCameraPhotographerStructure != null)
		{
			uiCameraPhotographerStructure.SetPlayerSourceLocation(fvectorDouble2.Value);
		}
		if (uiCameraPhotographerStructure != null)
		{
			uiCameraPhotographerStructure.SetCameraInitializeTransform(cameraInitializeTransform);
		}
		if (uiCameraPhotographerStructure != null)
		{
			uiCameraPhotographerStructure.SetFov(60);
		}
		this.UiCameraPhotographerStructure = uiCameraPhotographerStructure;
		UiCameraManager.Get().Enter(0.5f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null);
		this.InitializeDefaultPhotographOption();
	}

	// Token: 0x06010FAF RID: 69551 RVA: 0x00423CDC File Offset: 0x00421EDC
	private void InitializeDefaultPhotographOption()
	{
		IReadOnlyList<PhotoSetup> allPhotoSetupConfig = PhotographConfig.Instance.GetAllPhotoSetupConfig();
		if (allPhotoSetupConfig != null)
		{
			foreach (PhotoSetup photoSetup in allPhotoSetupConfig)
			{
				float value = -1f;
				int type = photoSetup.Type;
				if (type == 0)
				{
					value = (float)photoSetup.DefaultOptionIndex;
				}
				else if (type == 1)
				{
					float[] array = photoSetup.ValueRange();
					if (array != null && array.Length > 2)
					{
						value = array[2];
					}
				}
				this.SetPhotographOption((EPhotoSetupValueType)photoSetup.ValueType, value);
			}
		}
	}

	// Token: 0x06010FB0 RID: 69552 RVA: 0x00423D78 File Offset: 0x00421F78
	private void SetPhotographOption(EPhotoSetupValueType setupValueType, float value)
	{
		if (this.PhotographOptionMap.ContainsKey(setupValueType))
		{
			this.PhotographOptionMap[setupValueType] = value;
		}
		else
		{
			this.PhotographOptionMap.Add(setupValueType, value);
		}
		switch (setupValueType)
		{
		case EPhotoSetupValueType.MeshVisible:
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			bool flag = value == 1f;
			if (getCurrentEntity != null)
			{
				if (flag)
				{
					this.SetEntityEnable(getCurrentEntity, true);
					return;
				}
				this.SetEntityEnable(getCurrentEntity, false);
			}
			break;
		}
		case EPhotoSetupValueType.PlayerNameVisible:
		case EPhotoSetupValueType.PlayerLookAtCamera:
			break;
		case EPhotoSetupValueType.DepthOfFieldEnable:
			if (value == 1f)
			{
				float manualFocusDistance;
				float currentAperture;
				if (this.PhotographOptionMap.TryGetValue(EPhotoSetupValueType.DepthOfFieldDistance, out manualFocusDistance) && this.PhotographOptionMap.TryGetValue(EPhotoSetupValueType.DepthOfFieldRadius, out currentAperture) && this.WidgetCineCameraComponent != null)
				{
					this.WidgetCineCameraComponent.FocusSettings.ManualFocusDistance = manualFocusDistance;
					this.WidgetCineCameraComponent.CurrentAperture = currentAperture;
					return;
				}
			}
			else if (this.WidgetCineCameraComponent != null)
			{
				this.WidgetCineCameraComponent.FocusSettings.ManualFocusDistance = 35f;
				this.WidgetCineCameraComponent.CurrentAperture = 0f;
				return;
			}
			break;
		case EPhotoSetupValueType.DepthOfFieldDistance:
		{
			float num;
			if (this.PhotographOptionMap.TryGetValue(EPhotoSetupValueType.DepthOfFieldEnable, out num) && num == 1f && this.WidgetCineCameraComponent != null)
			{
				this.WidgetCineCameraComponent.FocusSettings.ManualFocusDistance = value;
				return;
			}
			break;
		}
		case EPhotoSetupValueType.DepthOfFieldRadius:
		{
			float num2;
			if (this.PhotographOptionMap.TryGetValue(EPhotoSetupValueType.DepthOfFieldEnable, out num2) && num2 == 1f && this.WidgetCineCameraComponent != null)
			{
				this.WidgetCineCameraComponent.CurrentAperture = value;
				return;
			}
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06010FB1 RID: 69553 RVA: 0x00423EEC File Offset: 0x004220EC
	private BP_CineCamera_C GetWidgetCameraActor()
	{
		WidgetCamera widgetCamera = CameraController.Instance.MainModel.WidgetCamera;
		if (widgetCamera == null)
		{
			return null;
		}
		WidgetCameraDisplayComponent component = widgetCamera.GetComponent<WidgetCameraDisplayComponent>();
		if (component == null || !component.Valid)
		{
			return null;
		}
		return component.CineCamera;
	}

	// Token: 0x06010FB2 RID: 69554 RVA: 0x00423F28 File Offset: 0x00422128
	public ACameraActor GetFightCameraActor()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		if (fightCamera == null)
		{
			return null;
		}
		FightCameraDisplayComponent component = fightCamera.GetComponent<FightCameraDisplayComponent>();
		if (component == null || !component.Valid)
		{
			return null;
		}
		return component.CameraActor;
	}

	// Token: 0x06010FB3 RID: 69555 RVA: 0x00423F64 File Offset: 0x00422164
	private UCineCameraComponent GetWidgetCameraComponent()
	{
		BP_CineCamera_C widgetCameraActor = this.WidgetCameraActor;
		if (widgetCameraActor == null || !widgetCameraActor.IsValid())
		{
			return null;
		}
		return widgetCameraActor.GetCineCameraComponent();
	}

	// Token: 0x06010FB4 RID: 69556 RVA: 0x00423F94 File Offset: 0x00422194
	private FightCameraLogicComponent GetFightCameraLogicComponent()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		if (fightCamera == null)
		{
			return null;
		}
		return fightCamera.GetComponent<FightCameraLogicComponent>();
	}

	// Token: 0x06010FB5 RID: 69557 RVA: 0x00423FBC File Offset: 0x004221BC
	private UiCameraPhotographerStructure SpawnPhotographerStructure(FVectorDouble? location, FQuat rotation, FVectorDouble scale)
	{
		if (location == null)
		{
			return null;
		}
		FTransformDouble actorTransform = new FTransformDouble();
		FVectorDouble value = location.Value;
		actorTransform.SetLocation(value);
		actorTransform.SetRotation(rotation);
		actorTransform.SetScale3D(scale);
		UiCamera uiCamera = UiCameraManager.Get();
		UiCameraPhotographerStructure uiCameraPhotographerStructure = uiCamera.PushStructure<UiCameraPhotographerStructure>();
		if (uiCameraPhotographerStructure != null)
		{
			uiCameraPhotographerStructure.SetActorTransform(actorTransform);
		}
		UiCameraPostEffectComponent uiCameraComponent = uiCamera.GetUiCameraComponent<UiCameraPostEffectComponent>();
		if (uiCameraComponent != null)
		{
			uiCameraComponent.SetCameraFocalDistance(300f);
		}
		return uiCameraPhotographerStructure;
	}

	// Token: 0x06010FB6 RID: 69558 RVA: 0x0042402C File Offset: 0x0042222C
	[NullableContext(1)]
	private void SetEntityEnable(EntityHandle handle, bool bEnable)
	{
		if (handle != null && handle.Valid)
		{
			WorldEntity entity = handle.Entity;
			if (entity != null && entity.Valid)
			{
				if (handle.Entity.Active == bEnable)
				{
					return;
				}
				if (!bEnable)
				{
					if (this.SetDisableEntity != null)
					{
						this.ResetEntityEnable();
					}
					this.SetDisableEntity = handle;
					if (handle.Entity != null)
					{
						this.EntityDisableId = new int?(handle.Entity.Disable("[FilterCameraComponent.SetEntityEnable] bEnable为false"));
					}
					return;
				}
				if (this.SetDisableEntity != null && handle.Id == this.SetDisableEntity.Id)
				{
					if (this.EntityDisableId != null)
					{
						handle.Entity.Enable(this.EntityDisableId.Value, "FilterCameraComponent.SetEntityEnable");
					}
					this.EntityDisableId = null;
					this.SetDisableEntity = null;
					return;
				}
				this.ResetEntityEnable();
				return;
			}
		}
	}

	// Token: 0x06010FB7 RID: 69559 RVA: 0x0042410C File Offset: 0x0042230C
	private void ResetEntityEnable()
	{
		if (this.SetDisableEntity != null && this.EntityDisableId != null)
		{
			WorldEntity entity = this.SetDisableEntity.Entity;
			if (entity != null)
			{
				entity.Enable(this.EntityDisableId.Value, "FilterCameraComponent.ResetEntityEnable");
			}
		}
		this.EntityDisableId = null;
		this.SetDisableEntity = null;
	}

	// Token: 0x06010FB8 RID: 69560 RVA: 0x00424168 File Offset: 0x00422368
	[NullableContext(1)]
	public void OnDragMoved(ULGUIPointerEventData eventData)
	{
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			return;
		}
		if (eventData == null)
		{
			return;
		}
		FVector pointerPosition = eventData.pointerPosition;
		if (this.LastMoveVector != null)
		{
			float num = (pointerPosition.Y - this.LastMoveVector.Value.Y) * this.ControlCameraRate;
			float num2 = (this.LastMoveVector.Value.X - pointerPosition.X) * this.ControlCameraRate;
			UiCameraPhotographerStructure uiCameraPhotographerStructure = this.UiCameraPhotographerStructure;
			if (uiCameraPhotographerStructure != null)
			{
				uiCameraPhotographerStructure.AddCameraArmPitchInput(-num);
			}
			UiCameraPhotographerStructure uiCameraPhotographerStructure2 = this.UiCameraPhotographerStructure;
			if (uiCameraPhotographerStructure2 != null)
			{
				uiCameraPhotographerStructure2.AddCameraArmYawInput(-num2);
			}
		}
		this.LastMoveVector = new FVector?(pointerPosition);
	}

	// Token: 0x06010FB9 RID: 69561 RVA: 0x0042420B File Offset: 0x0042240B
	public void OnDragBegin()
	{
		this.CameraRotationLock = true;
	}

	// Token: 0x06010FBA RID: 69562 RVA: 0x00424214 File Offset: 0x00422414
	public void OnDragEnded()
	{
		this.LastMoveVector = null;
		this.CameraRotationLock = false;
	}

	// Token: 0x06010FBB RID: 69563 RVA: 0x00424229 File Offset: 0x00422429
	[NullableContext(1)]
	public void OnInputUiLookUp(string axisName, float value)
	{
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.HelpView))
		{
			return;
		}
		if (value == 0f)
		{
			return;
		}
		UiCameraPhotographerStructure uiCameraPhotographerStructure = this.UiCameraPhotographerStructure;
		if (uiCameraPhotographerStructure == null)
		{
			return;
		}
		uiCameraPhotographerStructure.AddCameraArmPitchInput(-value);
	}

	// Token: 0x06010FBC RID: 69564 RVA: 0x00424265 File Offset: 0x00422465
	[NullableContext(1)]
	public void OnInputUiTurn(string axisName, float value)
	{
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.HelpView))
		{
			return;
		}
		if (value == 0f)
		{
			return;
		}
		UiCameraPhotographerStructure uiCameraPhotographerStructure = this.UiCameraPhotographerStructure;
		if (uiCameraPhotographerStructure == null)
		{
			return;
		}
		uiCameraPhotographerStructure.AddCameraArmYawInput(value);
	}

	// Token: 0x04008111 RID: 33041
	public FVector? LastMoveVector;

	// Token: 0x04008112 RID: 33042
	private BP_CineCamera_C WidgetCameraActor;

	// Token: 0x04008113 RID: 33043
	private ACameraActor FightCameraActor;

	// Token: 0x04008114 RID: 33044
	private UCineCameraComponent WidgetCineCameraComponent;

	// Token: 0x04008115 RID: 33045
	private readonly EUiViewName? ViewName;

	// Token: 0x04008116 RID: 33046
	public UiCameraPhotographerStructure UiCameraPhotographerStructure;

	// Token: 0x04008117 RID: 33047
	[Nullable(1)]
	public readonly Dictionary<EPhotoSetupValueType, float> PhotographOptionMap = new Dictionary<EPhotoSetupValueType, float>();

	// Token: 0x04008118 RID: 33048
	public int? EntityDisableId = new int?(0);

	// Token: 0x04008119 RID: 33049
	public EntityHandle SetDisableEntity;

	// Token: 0x0400811A RID: 33050
	[Nullable(1)]
	private readonly List<ITagTask> Tasks = new List<ITagTask>();

	// Token: 0x0400811B RID: 33051
	public bool CameraRotationLock;

	// Token: 0x0400811C RID: 33052
	private float? ControlCameraRateInternal;

	// Token: 0x0400811D RID: 33053
	[Nullable(new byte[]
	{
		2,
		0
	})]
	public Func<UniTask<bool>> OnOpenView;
}
