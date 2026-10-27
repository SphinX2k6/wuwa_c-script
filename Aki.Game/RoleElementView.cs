using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020027A3 RID: 10147
[NullableContext(2)]
[Nullable(0)]
public class RoleElementView : UiViewBase
{
	// Token: 0x06014D6C RID: 85356 RVA: 0x0054962F File Offset: 0x0054782F
	[NullableContext(1)]
	public RoleElementView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014D6D RID: 85357 RVA: 0x00549638 File Offset: 0x00547838
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickSwitch))
		};
	}

	// Token: 0x06014D6E RID: 85358 RVA: 0x005496D0 File Offset: 0x005478D0
	protected override UniTask OnBeforeStartAsync()
	{
		RoleElementView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleElementView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014D6F RID: 85359 RVA: 0x00549714 File Offset: 0x00547914
	protected UniTask RefreshAsync()
	{
		RoleElementView.<RefreshAsync>d__12 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RoleElementView.<RefreshAsync>d__12>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014D70 RID: 85360 RVA: 0x00549757 File Offset: 0x00547957
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.ShowRoleElementChangePreviewEffect, new Action<bool>(this.OnShowRoleElementChangePreviewEffect));
	}

	// Token: 0x06014D71 RID: 85361 RVA: 0x00549775 File Offset: 0x00547975
	protected override void OnAfterShow()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSystemChangeRole));
	}

	// Token: 0x06014D72 RID: 85362 RVA: 0x00549793 File Offset: 0x00547993
	[NullableContext(1)]
	private RoleElementItem InitItem()
	{
		RoleElementItem roleElementItem = new RoleElementItem();
		roleElementItem.SetRoleViewAgent(this.RoleViewAgent);
		roleElementItem.OnToggleCallback = new Action<int>(this.OnToggleClick);
		roleElementItem.CanToggleChange = new Func<int, bool>(this.CanToggleChange);
		return roleElementItem;
	}

	// Token: 0x06014D73 RID: 85363 RVA: 0x005497CA File Offset: 0x005479CA
	private void OnToggleClick(int gridIndex)
	{
		this.SelectGridByIndex(gridIndex);
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.RoleElement, false, false, false);
		if (this.RoleSwitchPreviewHandEffectHandle != 0)
		{
			this.ShowElementPreviewEffect();
		}
	}

	// Token: 0x06014D74 RID: 85364 RVA: 0x005497F0 File Offset: 0x005479F0
	private void SelectGridByIndex(int gridIndex)
	{
		this.CurSelectRoleId = this.DataList[gridIndex].Id;
		this.GenericScrollView.GetGenericLayout().SelectGridProxy(gridIndex, false);
		this.RefreshButtonState();
	}

	// Token: 0x06014D75 RID: 85365 RVA: 0x00549830 File Offset: 0x00547A30
	private void RefreshButtonState()
	{
		bool flag = this.RoleViewAgent.GetCurSelectRoleId() == this.CurSelectRoleId;
		UUIButtonComponent button = base.GetButton(2);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(!flag);
	}

	// Token: 0x06014D76 RID: 85366 RVA: 0x00549866 File Offset: 0x00547A66
	private bool CanToggleChange(int gridIndex)
	{
		return gridIndex != this.GenericScrollView.GetGenericLayout().GetSelectedGridIndex();
	}

	// Token: 0x06014D77 RID: 85367 RVA: 0x0054987E File Offset: 0x00547A7E
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSystemChangeRole));
		this.HideElementPreviewEffect();
	}

	// Token: 0x06014D78 RID: 85368 RVA: 0x005498A2 File Offset: 0x00547AA2
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ShowRoleElementChangePreviewEffect, new Action<bool>(this.OnShowRoleElementChangePreviewEffect));
	}

	// Token: 0x06014D79 RID: 85369 RVA: 0x005498C0 File Offset: 0x00547AC0
	protected void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014D7A RID: 85370 RVA: 0x005498CC File Offset: 0x00547ACC
	protected void OnClickSwitch()
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		bool? flag;
		if (baseCharacter == null)
		{
			flag = null;
		}
		else
		{
			BaseTagComponent component = baseCharacter.CharacterActorComponent.Entity.GetComponent<BaseTagComponent>();
			flag = ((component != null) ? new bool?(component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"])) : null);
		}
		bool? flag2 = flag;
		if (flag2.GetValueOrDefault())
		{
			ScrollingTipsController.Instance.ShowTipsByText(TextConfig.Instance.GetTextById("CanNotTransferInFight"));
			return;
		}
		if (this.CurSelectRoleId == 0)
		{
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.CurSelectRoleId);
		if (roleConfig == null)
		{
			return;
		}
		MainRoleController.Instance.SendRoleElementChangeRequest(roleConfig.Value.ElementId);
	}

	// Token: 0x06014D7B RID: 85371 RVA: 0x00549988 File Offset: 0x00547B88
	private void OnRoleSystemChangeRole(int roleId)
	{
		this.IsPlayingChangeSuccessEffect = true;
		UiLayer.Instance.SetShowMaskLayer("RoleElementView", true);
		this.RoleViewAgent.SetCurSelectRoleId(roleId);
		this.RoleViewAgent.CheckMainRoleToIdList(roleId);
		RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
		TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
		object obj;
		if (sceneRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = sceneRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiRoleDataComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.SetRoleDataId(roleId, curSelectRoleData.GetRoleSkinId());
		}
		this.RoleChangeShow(roleId);
		foreach (RoleElementItem roleElementItem in this.GenericScrollView.GetScrollItemList())
		{
			roleElementItem.RefreshState();
		}
		this.RefreshButtonState();
	}

	// Token: 0x06014D7C RID: 85372 RVA: 0x00549A58 File Offset: 0x00547C58
	private void OnShowRoleElementChangePreviewEffect(bool isShow)
	{
		if (isShow)
		{
			this.ShowElementPreviewEffect();
			return;
		}
		this.HideElementPreviewEffect();
	}

	// Token: 0x06014D7D RID: 85373 RVA: 0x00549A6A File Offset: 0x00547C6A
	private void RoleChangeShowSuccess()
	{
		UiLayer.Instance.SetShowMaskLayer("RoleElementView", false);
		this.IsPlayingChangeSuccessEffect = false;
		ScrollingTipsController.Instance.ShowTipsById("ElementTransferSuccess", Array.Empty<object>());
	}

	// Token: 0x06014D7E RID: 85374 RVA: 0x00549A98 File Offset: 0x00547C98
	private void ShowElementPreviewEffect()
	{
		if (this.IsPlayingChangeSuccessEffect)
		{
			return;
		}
		this.ShowElementPreviewEffectById(RoleConfig.Instance.GetRoleConfig(this.CurSelectRoleId).Value.ElementId);
	}

	// Token: 0x06014D7F RID: 85375 RVA: 0x00549AD4 File Offset: 0x00547CD4
	private void RoleChangeShow(int roleId)
	{
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(roleId).Value;
		ElementInfoConfig instance = ElementInfoConfig.Instance;
		ElementInfo? elementInfo;
		string text = (instance != null) ? ((instance.GetElementInfo(value.ElementId) != null) ? elementInfo.GetValueOrDefault().AudioEvent : null) : null;
		if (text != null)
		{
			AudioSystem.Instance.PostEvent(text);
		}
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.RoleElement_End, false, false, false);
		int? roleElementSwitchDelayTime = RoleConfig.Instance.GetRoleElementSwitchDelayTime();
		this.ShowElementSuccessEffectById(value.ElementId);
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.RoleChangeShowSuccess();
		}, (float)roleElementSwitchDelayTime.Value, null, null, true, 1f);
	}

	// Token: 0x06014D80 RID: 85376 RVA: 0x00549B8C File Offset: 0x00547D8C
	[return: Nullable(0)]
	private UniTask<int> CreateRoleElementEffect([Nullable(1)] string effectPathKey, USceneComponent parentComponent, FName? socketName, FTransformDouble? relativeTransform, string colorHex = null, string iconPath = null)
	{
		RoleElementView.<CreateRoleElementEffect>d__29 <CreateRoleElementEffect>d__;
		<CreateRoleElementEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
		<CreateRoleElementEffect>d__.<>4__this = this;
		<CreateRoleElementEffect>d__.effectPathKey = effectPathKey;
		<CreateRoleElementEffect>d__.parentComponent = parentComponent;
		<CreateRoleElementEffect>d__.socketName = socketName;
		<CreateRoleElementEffect>d__.relativeTransform = relativeTransform;
		<CreateRoleElementEffect>d__.colorHex = colorHex;
		<CreateRoleElementEffect>d__.iconPath = iconPath;
		<CreateRoleElementEffect>d__.<>1__state = -1;
		<CreateRoleElementEffect>d__.<>t__builder.Start<RoleElementView.<CreateRoleElementEffect>d__29>(ref <CreateRoleElementEffect>d__);
		return <CreateRoleElementEffect>d__.<>t__builder.Task;
	}

	// Token: 0x06014D81 RID: 85377 RVA: 0x00549C04 File Offset: 0x00547E04
	[NullableContext(1)]
	private void UpdetaColorAndIcon(int handle, FLinearColor lColor, bool isNeedSetIcon, UTexture texObj)
	{
		OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> niagaraComponent = EffectSystem.Instance.GetNiagaraComponent(handle);
		if (niagaraComponent.IsT2)
		{
			UNiagaraComponent asT = niagaraComponent.AsT2;
			UNiagaraSystem asset = asT.Asset;
			asT.SetAsset(null, true);
			asT.SetAsset(asset, true);
		}
		if (niagaraComponent.HasValue)
		{
			niagaraComponent.SetNiagaraVariableLinearColor("Color", lColor);
			if (isNeedSetIcon)
			{
				niagaraComponent.SetKuroNiagaraEmitterCustomTexture("Icon", "Mask", texObj);
			}
		}
	}

	// Token: 0x06014D82 RID: 85378 RVA: 0x00549C70 File Offset: 0x00547E70
	public void ShowElementSuccessEffectById(int elementId)
	{
		ElementInfo? elementInfo = ElementInfoConfig.Instance.GetElementInfo(elementId);
		if (elementInfo == null)
		{
			return;
		}
		TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
		UiModelBase model = sceneRoleActor.Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		USkeletalMeshComponent uskeletalMeshComponent = (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null;
		if (uskeletalMeshComponent == null)
		{
			return;
		}
		this.CreateRoleElementEffect("AttributeSwitchBodyEffect", sceneRoleActor.K2_GetRootComponent(), new FName?(CharacterNameDefines.Instance.ROOT), null, elementInfo.Value.ElementEffectColor, null).Forget<int>();
		this.CreateRoleElementEffect("AttributeSwitchHandEffect", uskeletalMeshComponent, new FName?(CharacterNameDefines.Instance.ELEMENT_EFFECT_SOCKET_NAME), null, elementInfo.Value.ElementEffectColor, elementInfo.Value.Icon3).Forget<int>();
	}

	// Token: 0x06014D83 RID: 85379 RVA: 0x00549D45 File Offset: 0x00547F45
	private void CreateRoleElementEffectFail()
	{
	}

	// Token: 0x06014D84 RID: 85380 RVA: 0x00549D48 File Offset: 0x00547F48
	public void ShowElementPreviewEffectById(int elementId)
	{
		ElementInfo? elementInfo = ElementInfoConfig.Instance.GetElementInfo(elementId);
		if (elementInfo == null)
		{
			return;
		}
		if (this.RoleSwitchPreviewHandEffectHandle != 0)
		{
			RoleElementView.<>c__DisplayClass33_0 CS$<>8__locals1 = new RoleElementView.<>c__DisplayClass33_0();
			CS$<>8__locals1.<>4__this = this;
			RoleElementView.<>c__DisplayClass33_0 CS$<>8__locals2 = CS$<>8__locals1;
			FColor fcolor = FColor.FromHex(elementInfo.Value.ElementEffectColor);
			CS$<>8__locals2.lColor = FLinearColor.FromSRGBColor(fcolor);
			ResourceSystem.Instance.LoadAsync<UTexture>(elementInfo.Value.Icon3, delegate([Nullable(2)] UTexture textureObject, string _)
			{
				CS$<>8__locals1.<>4__this.UpdetaColorAndIcon(CS$<>8__locals1.<>4__this.RoleSwitchPreviewHandEffectHandle, CS$<>8__locals1.lColor, true, textureObject);
			}, 100, this.MemoryTag);
		}
		else
		{
			TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
			FRotator frotator = new FRotator(0f, 0f, 0f);
			FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, 0.0);
			FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
			FVector fvector = fvectorDouble2;
			FTransformDouble value = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
			UiModelBase model = sceneRoleActor.Model;
			UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
			this.CreateRoleElementEffect("AttributePreviewHandEffect", (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null, new FName?(CharacterNameDefines.Instance.ELEMENT_EFFECT_SOCKET_NAME), new FTransformDouble?(value), elementInfo.Value.ElementEffectColor, elementInfo.Value.Icon3).ContinueWith(delegate(int handle)
			{
				this.RoleSwitchPreviewHandEffectHandle = handle;
				if (base.IsDestroyOrDestroying)
				{
					this.HideElementPreviewEffect();
				}
			}).Forget();
		}
		try
		{
			AActor actorByTag = UiSceneManager.Instance.GetActorByTag(ConfigCommonParamById.GetStringConfig("RoleElementPreviewEffectCase"));
			if (this.RoleSwitchPreviewBackEffectHandle == 0)
			{
				this.CreateRoleElementEffect("AttributePreviewBodyEffect", null, null, new FTransformDouble?(actorByTag.D_GetTransform()), null, null).ContinueWith(delegate(int handle)
				{
					this.RoleSwitchPreviewBackEffectHandle = handle;
					if (base.IsDestroyOrDestroying)
					{
						this.HideElementPreviewEffect();
					}
				}).Forget();
			}
		}
		catch (Exception)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.LK, "给角色属性切换预览特效寻找坐标参考case点失败，中断后续流程", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x06014D85 RID: 85381 RVA: 0x00549F4C File Offset: 0x0054814C
	public void HideElementPreviewEffect()
	{
		if (EffectSystem.Instance.IsValid(this.RoleSwitchPreviewHandEffectHandle))
		{
			EffectSystem.Instance.StopEffectById(this.RoleSwitchPreviewHandEffectHandle, "HideElementPreviewEffect", true, new bool?(true));
			this.RoleSwitchPreviewHandEffectHandle = 0;
		}
		if (this.RoleSwitchPreviewBackEffectHandle != 0)
		{
			EffectSystem.Instance.StopEffectById(this.RoleSwitchPreviewBackEffectHandle, "HideElementPreviewEffect", true, new bool?(true));
			this.RoleSwitchPreviewBackEffectHandle = 0;
		}
	}

	// Token: 0x04009CCD RID: 40141
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<RoleElementItem, MainRoleConfig> GenericScrollView;

	// Token: 0x04009CCE RID: 40142
	private List<MainRoleConfig> DataList;

	// Token: 0x04009CCF RID: 40143
	private int CurSelectRoleId;

	// Token: 0x04009CD0 RID: 40144
	private RoleViewAgent RoleViewAgent;

	// Token: 0x04009CD1 RID: 40145
	private int RoleSwitchPreviewHandEffectHandle;

	// Token: 0x04009CD2 RID: 40146
	private int RoleSwitchPreviewBackEffectHandle;

	// Token: 0x04009CD3 RID: 40147
	private bool IsPlayingChangeSuccessEffect;

	// Token: 0x04009CD4 RID: 40148
	private TsUiSceneRoleActor SceneRoleActor;

	// Token: 0x02008E17 RID: 36375
	[NullableContext(0)]
	public enum ERoleElementViewDefine
	{
		// Token: 0x0402E19F RID: 188831
		CloseButton,
		// Token: 0x0402E1A0 RID: 188832
		ScrollView,
		// Token: 0x0402E1A1 RID: 188833
		SwitchButton
	}
}
