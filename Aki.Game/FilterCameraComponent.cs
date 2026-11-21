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
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020016ED RID: 5869
[NullableContext(2)]
[Nullable(0)]
public class FilterCameraComponent
{
	// Token: 0x0600E434 RID: 58420 RVA: 0x0042FFCE File Offset: 0x0042E1CE
	public FilterCameraComponent([Nullable(new byte[]
	{
		1,
		0
	})] Func<UniTask<bool>> openView, EUiViewName name)
	{
		this.OnOpenView = openView;
		this.ViewName = new EUiViewName?(name);
	}

	// Token: 0x170015C6 RID: 5574
	// (get) Token: 0x0600E435 RID: 58421 RVA: 0x0043000C File Offset: 0x0042E20C
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

	// Token: 0x0600E436 RID: 58422 RVA: 0x00430058 File Offset: 0x0042E258
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

	// Token: 0x0600E437 RID: 58423 RVA: 0x0043009B File Offset: 0x0042E29B
	public void ClosePhotograph()
	{
		this.ResetPhotographBeforeBlackScreen();
		this.ResetPhotographInBlackScreen();
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("FilterCameraComponent");
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroScreenFilterFrame 60", null);
		UiLayer.Instance.SetLayerActive(ELayerType.HUD, true);
	}

	// Token: 0x0600E438 RID: 58424 RVA: 0x004300D4 File Offset: 0x0042E2D4
	public void ResetPhotograph()
	{
		this.ResetPhotographBeforeBlackScreen();
		this.ResetPhotographInBlackScreen();
	}

	// Token: 0x0600E439 RID: 58425 RVA: 0x004300E2 File Offset: 0x0042E2E2
	private void ResetPhotographBeforeBlackScreen()
	{
		this.FightCameraActor = null;
		this.WidgetCameraActor = null;
		this.WidgetCineCameraComponent = null;
	}

	// Token: 0x0600E43A RID: 58426 RVA: 0x004300FC File Offset: 0x0042E2FC
	private void ResetPhotographInBlackScreen()
	{
		UiCameraModel.Instance.ClearDisplay();
		this.PhotographerComponent = null;
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

	// Token: 0x0600E43B RID: 58427 RVA: 0x00430178 File Offset: 0x0042E378
	public void RemoveEntityEvents()
	{
		foreach (ITagTask tagTask in this.Tasks)
		{
			tagTask.EndTask();
		}
		this.Tasks.Clear();
	}

	// Token: 0x0600E43C RID: 58428 RVA: 0x004301D4 File Offset: 0x0042E3D4
	private UniTask OpenBlackScreen()
	{
		FilterCameraComponent.<OpenBlackScreen>d__21 <OpenBlackScreen>d__;
		<OpenBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenBlackScreen>d__.<>1__state = -1;
		<OpenBlackScreen>d__.<>t__builder.Start<FilterCameraComponent.<OpenBlackScreen>d__21>(ref <OpenBlackScreen>d__);
		return <OpenBlackScreen>d__.<>t__builder.Task;
	}

	// Token: 0x0600E43D RID: 58429 RVA: 0x00430210 File Offset: 0x0042E410
	private UniTask CloseBlackScreen()
	{
		FilterCameraComponent.<CloseBlackScreen>d__22 <CloseBlackScreen>d__;
		<CloseBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseBlackScreen>d__.<>1__state = -1;
		<CloseBlackScreen>d__.<>t__builder.Start<FilterCameraComponent.<CloseBlackScreen>d__22>(ref <CloseBlackScreen>d__);
		return <CloseBlackScreen>d__.<>t__builder.Task;
	}

	// Token: 0x0600E43E RID: 58430 RVA: 0x0043024C File Offset: 0x0042E44C
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

	// Token: 0x0600E43F RID: 58431 RVA: 0x0043029C File Offset: 0x0042E49C
	private void AddEntityEvents()
	{
		this.AddTagTask(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]), new Action<int, bool>(this.OnTagChanged));
		this.AddTagTask(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]), new Action<int, bool>(this.OnTagChanged));
		this.AddTagTask(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"]), new Action<int, bool>(this.OnTagChanged));
	}

	// Token: 0x0600E440 RID: 58432 RVA: 0x0043031C File Offset: 0x0042E51C
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

	// Token: 0x0600E441 RID: 58433 RVA: 0x0043039E File Offset: 0x0042E59E
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

	// Token: 0x0600E442 RID: 58434 RVA: 0x004303D4 File Offset: 0x0042E5D4
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

	// Token: 0x0600E443 RID: 58435 RVA: 0x00430720 File Offset: 0x0042E920
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
		UiCameraPhotographerComponent uiCameraPhotographerComponent = this.SpawnPhotographerComponent(location, rotation, scale3D);
		if (this.WidgetCineCameraComponent != null)
		{
			this.WidgetCineCameraComponent.FocusSettings.ManualFocusDistance = 300f;
		}
		if (uiCameraPhotographerComponent != null)
		{
			uiCameraPhotographerComponent.SetPlayerSourceLocation(fvectorDouble2.Value);
		}
		if (uiCameraPhotographerComponent != null)
		{
			uiCameraPhotographerComponent.SetCameraInitializeTransform(cameraInitializeTransform);
		}
		if (uiCameraPhotographerComponent != null)
		{
			uiCameraPhotographerComponent.SetFov(60);
		}
		this.PhotographerComponent = uiCameraPhotographerComponent;
		UiCameraModel.Instance.GetOrCreateCamera().Enter(0.5f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null);
		this.InitializeDefaultPhotographOption();
	}

	// Token: 0x0600E444 RID: 58436 RVA: 0x0043085C File Offset: 0x0042EA5C
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

	// Token: 0x0600E445 RID: 58437 RVA: 0x004308F8 File Offset: 0x0042EAF8
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

	// Token: 0x0600E446 RID: 58438 RVA: 0x00430A6C File Offset: 0x0042EC6C
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

	// Token: 0x0600E447 RID: 58439 RVA: 0x00430AA8 File Offset: 0x0042ECA8
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

	// Token: 0x0600E448 RID: 58440 RVA: 0x00430AE4 File Offset: 0x0042ECE4
	private UCineCameraComponent GetWidgetCameraComponent()
	{
		BP_CineCamera_C widgetCameraActor = this.WidgetCameraActor;
		if (widgetCameraActor == null || !widgetCameraActor.IsValid())
		{
			return null;
		}
		return widgetCameraActor.GetCineCameraComponent();
	}

	// Token: 0x0600E449 RID: 58441 RVA: 0x00430B14 File Offset: 0x0042ED14
	private FightCameraLogicComponent GetFightCameraLogicComponent()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		if (fightCamera == null)
		{
			return null;
		}
		return fightCamera.GetComponent<FightCameraLogicComponent>();
	}

	// Token: 0x0600E44A RID: 58442 RVA: 0x00430B3C File Offset: 0x0042ED3C
	private UiCameraPhotographerComponent SpawnPhotographerComponent(FVectorDouble? location, FQuat rotation, FVectorDouble scale)
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
		UiCameraModel instance = UiCameraModel.Instance;
		instance.SwitchMode(EUiCameraMode.Photographer);
		UiCameraPhotographerComponent component = instance.GetOrCreateCamera().GetMode<UiCameraPhotographerMode>().GetComponent<UiCameraPhotographerComponent>();
		if (component != null)
		{
			component.SetActorTransform(actorTransform);
		}
		UiCameraDisplayComponent component2 = instance.GetOrCreateCamera().GetComponent<UiCameraDisplayComponent>();
		if (component2 != null)
		{
			component2.SetCameraFocalDistance(300f);
		}
		return component;
	}

	// Token: 0x0600E44B RID: 58443 RVA: 0x00430BC0 File Offset: 0x0042EDC0
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

	// Token: 0x0600E44C RID: 58444 RVA: 0x00430CA0 File Offset: 0x0042EEA0
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

	// Token: 0x0600E44D RID: 58445 RVA: 0x00430CFC File Offset: 0x0042EEFC
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
			UiCameraPhotographerComponent photographerComponent = this.PhotographerComponent;
			if (photographerComponent != null)
			{
				photographerComponent.AddCameraArmPitchInput(-num);
			}
			UiCameraPhotographerComponent photographerComponent2 = this.PhotographerComponent;
			if (photographerComponent2 != null)
			{
				photographerComponent2.AddCameraArmYawInput(-num2);
			}
		}
		this.LastMoveVector = new FVector?(pointerPosition);
	}

	// Token: 0x0600E44E RID: 58446 RVA: 0x00430D9F File Offset: 0x0042EF9F
	public void OnDragBegin()
	{
		this.CameraRotationLock = true;
	}

	// Token: 0x0600E44F RID: 58447 RVA: 0x00430DA8 File Offset: 0x0042EFA8
	public void OnDragEnded()
	{
		this.LastMoveVector = null;
		this.CameraRotationLock = false;
	}

	// Token: 0x0600E450 RID: 58448 RVA: 0x00430DBD File Offset: 0x0042EFBD
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
		UiCameraPhotographerComponent photographerComponent = this.PhotographerComponent;
		if (photographerComponent == null)
		{
			return;
		}
		photographerComponent.AddCameraArmPitchInput(-value);
	}

	// Token: 0x0600E451 RID: 58449 RVA: 0x00430DF9 File Offset: 0x0042EFF9
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
		UiCameraPhotographerComponent photographerComponent = this.PhotographerComponent;
		if (photographerComponent == null)
		{
			return;
		}
		photographerComponent.AddCameraArmYawInput(value);
	}

	// Token: 0x0400824F RID: 33359
	public FVector? LastMoveVector;

	// Token: 0x04008250 RID: 33360
	private BP_CineCamera_C WidgetCameraActor;

	// Token: 0x04008251 RID: 33361
	private ACameraActor FightCameraActor;

	// Token: 0x04008252 RID: 33362
	private UCineCameraComponent WidgetCineCameraComponent;

	// Token: 0x04008253 RID: 33363
	private readonly EUiViewName? ViewName;

	// Token: 0x04008254 RID: 33364
	public UiCameraPhotographerComponent PhotographerComponent;

	// Token: 0x04008255 RID: 33365
	[Nullable(1)]
	public readonly Dictionary<EPhotoSetupValueType, float> PhotographOptionMap = new Dictionary<EPhotoSetupValueType, float>();

	// Token: 0x04008256 RID: 33366
	public int? EntityDisableId = new int?(0);

	// Token: 0x04008257 RID: 33367
	public EntityHandle SetDisableEntity;

	// Token: 0x04008258 RID: 33368
	[Nullable(1)]
	private readonly List<ITagTask> Tasks = new List<ITagTask>();

	// Token: 0x04008259 RID: 33369
	public bool CameraRotationLock;

	// Token: 0x0400825A RID: 33370
	private float? ControlCameraRateInternal;

	// Token: 0x0400825B RID: 33371
	[Nullable(new byte[]
	{
		2,
		0
	})]
	public Func<UniTask<bool>> OnOpenView;
}
