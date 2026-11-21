using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D1E RID: 7454
[NullableContext(2)]
[Nullable(0)]
public class RoleElementView : UiViewBase
{
	// Token: 0x0601274A RID: 75594 RVA: 0x0057389B File Offset: 0x00571A9B
	[NullableContext(1)]
	public RoleElementView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601274B RID: 75595 RVA: 0x005738D8 File Offset: 0x00571AD8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUINiagara))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickSwitch))
		};
	}

	// Token: 0x0601274C RID: 75596 RVA: 0x00573A64 File Offset: 0x00571C64
	protected override UniTask OnBeforeStartAsync()
	{
		RoleElementView.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleElementView.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601274D RID: 75597 RVA: 0x00573AA7 File Offset: 0x00571CA7
	protected override void OnAfterPlayStartSequence()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlaySequencePurely("StartZ", false, false);
		}
		UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
		if (uiViewSequence2 == null)
		{
			return;
		}
		uiViewSequence2.PauseSequence();
	}

	// Token: 0x0601274E RID: 75598 RVA: 0x00573AD4 File Offset: 0x00571CD4
	private void AttachDefaultRole()
	{
		if (this.DataList == null || this.DataList.Count == 0)
		{
			return;
		}
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		int index = 0;
		for (int i = 0; i < this.DataList.Count; i++)
		{
			if (this.DataList[i].Id == curSelectRoleId)
			{
				index = i;
				break;
			}
		}
		RoleElementDragger dragger = this.Dragger;
		if (dragger == null)
		{
			return;
		}
		dragger.AttachByIndex(index, false);
	}

	// Token: 0x0601274F RID: 75599 RVA: 0x00573B48 File Offset: 0x00571D48
	private void InitCaptionItem()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetTitleLocalText("FunctionCondition_10052_Title");
		this.CaptionItem.SetHelpBtnActive(false);
		this.CaptionItem.SetCloseCallBack(delegate
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x06012750 RID: 75600 RVA: 0x00573B9A File Offset: 0x00571D9A
	private int GetElementItemDefine(int index)
	{
		return 6 + index;
	}

	// Token: 0x06012751 RID: 75601 RVA: 0x00573BA0 File Offset: 0x00571DA0
	private void InitDragger()
	{
		UUIItem item = base.GetItem(12);
		UUIDraggableComponent draggable = base.GetDraggable(4);
		if (item == null || draggable == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LJS;
			string message = "拖拽组件或吸附点为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("界面名称", "RoleElementView");
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Role;
			ELogAuthor author2 = ELogAuthor.LJS;
			string message2 = "内容容器UUIItem为空";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("界面名称", "RoleElementView");
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		List<UUIItem> list = new List<UUIItem>();
		int val = 6;
		List<MainRoleConfig> dataList = this.DataList;
		int num = Math.Min(val, (dataList != null) ? dataList.Count : 0);
		for (int i = 0; i < num; i++)
		{
			UUIItem item3 = base.GetItem(this.GetElementItemDefine(i));
			if (item3 != null)
			{
				list.Add(item3);
			}
		}
		this.Dragger = new RoleElementDragger(draggable, item2, item, list);
		float? floatConfig = ConfigCommonParamById.GetFloatConfig("MainRoleElementChangeEaseDuration");
		if (floatConfig != null)
		{
			this.Dragger.SetEaseDuration(floatConfig.Value);
		}
		float? floatConfig2 = ConfigCommonParamById.GetFloatConfig("MainRoleElementChangeAttachThreshold");
		if (floatConfig2 != null)
		{
			this.Dragger.SetAttachThreshold(floatConfig2.Value);
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("MainRoleElementItemChangeSpeed");
		if (intConfig != null)
		{
			this.Dragger.SetChangeSpeed(intConfig.Value);
		}
		string stringConfig = ConfigCommonParamById.GetStringConfig("MainRoleElementItemCurvePath");
		if (!string.IsNullOrEmpty(stringConfig))
		{
			this.Dragger.SetTrajectoryCurve(stringConfig);
		}
		string stringConfig2 = ConfigCommonParamById.GetStringConfig("MainRoleElementItemAlphaCurvePath");
		if (!string.IsNullOrEmpty(stringConfig2))
		{
			this.Dragger.SetAlphaCurve(stringConfig2);
		}
		string stringConfig3 = ConfigCommonParamById.GetStringConfig("MainRoleElementItemScaleCurvePath");
		if (!string.IsNullOrEmpty(stringConfig3))
		{
			this.Dragger.SetScaleCurve(stringConfig3);
		}
		this.Dragger.OnCurrentItemUndock = new Action<int>(this.OnCurrentItemUndock);
		this.Dragger.OnCandidateEnter = new Action<int>(this.OnCandidateEnter);
		this.Dragger.OnCandidateExit = new Action<int>(this.OnCandidateExit);
		this.Dragger.OnSnapped = new Action<int>(this.OnSnapped);
		this.Dragger.OnItemAlphaChange = new Action<int, float>(this.OnItemAlphaChange);
		this.Dragger.CanNavigate = (() => !this.IsPlayingChangeSuccessEffect);
	}

	// Token: 0x06012752 RID: 75602 RVA: 0x00573DE8 File Offset: 0x00571FE8
	private void SetAttachPointVisible(bool visible)
	{
		base.PlaySequence(visible ? "PointIn" : "PointOut", null, false);
	}

	// Token: 0x06012753 RID: 75603 RVA: 0x00573E01 File Offset: 0x00572001
	private RoleElementItem GetElementItem(int index)
	{
		if (index < 0 || index >= this.ElementItems.Count)
		{
			return null;
		}
		return this.ElementItems[index];
	}

	// Token: 0x06012754 RID: 75604 RVA: 0x00573E24 File Offset: 0x00572024
	private void SetElementItemVisible(int index, bool visible)
	{
		if (index >= 0)
		{
			List<MainRoleConfig> dataList = this.DataList;
			int? num = (dataList != null) ? new int?(dataList.Count) : null;
			if (!(index >= num.GetValueOrDefault() & num != null))
			{
				if (visible)
				{
					RoleElementItem elementItem = this.GetElementItem(index);
					if (elementItem == null)
					{
						return;
					}
					elementItem.PlayShow();
					return;
				}
				else
				{
					RoleElementItem elementItem2 = this.GetElementItem(index);
					if (elementItem2 == null)
					{
						return;
					}
					elementItem2.PlayClose();
					return;
				}
			}
		}
	}

	// Token: 0x06012755 RID: 75605 RVA: 0x00573E94 File Offset: 0x00572094
	protected UniTask RefreshAsync()
	{
		RoleElementView.<RefreshAsync>d__35 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RoleElementView.<RefreshAsync>d__35>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012756 RID: 75606 RVA: 0x00573ED8 File Offset: 0x005720D8
	private UniTask RefreshElementItemsAsync()
	{
		RoleElementView.<RefreshElementItemsAsync>d__36 <RefreshElementItemsAsync>d__;
		<RefreshElementItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshElementItemsAsync>d__.<>4__this = this;
		<RefreshElementItemsAsync>d__.<>1__state = -1;
		<RefreshElementItemsAsync>d__.<>t__builder.Start<RoleElementView.<RefreshElementItemsAsync>d__36>(ref <RefreshElementItemsAsync>d__);
		return <RefreshElementItemsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012757 RID: 75607 RVA: 0x00573F1B File Offset: 0x0057211B
	private void OnCurrentItemUndock(int index)
	{
		this.SetElementItemVisible(index, true);
		this.SetElementItemHighlight(index, false);
		this.DeactivateElementItem(index);
		this.SetAttachPointVisible(true);
		UUIButtonComponent button = base.GetButton(1);
		if (button != null)
		{
			button.SetSelfInteractive(false);
		}
		this.PlaySceneExitEffect();
	}

	// Token: 0x06012758 RID: 75608 RVA: 0x00573F54 File Offset: 0x00572154
	private void OnCandidateEnter(int index)
	{
		this.SetElementItemHighlight(index, true);
		this.ActivateElementItem(index);
		this.RefreshElementInfo(index);
	}

	// Token: 0x06012759 RID: 75609 RVA: 0x00573F6C File Offset: 0x0057216C
	private void OnCandidateExit(int index)
	{
		this.SetElementItemHighlight(index, false);
		this.DeactivateElementItem(index);
	}

	// Token: 0x0601275A RID: 75610 RVA: 0x00573F7D File Offset: 0x0057217D
	private void OnItemAlphaChange(int index, float alpha)
	{
		RoleElementItem elementItem = this.GetElementItem(index);
		if (elementItem == null)
		{
			return;
		}
		elementItem.SetIconBgAlpha(alpha);
	}

	// Token: 0x0601275B RID: 75611 RVA: 0x00573F94 File Offset: 0x00572194
	private void OnSnapped(int index)
	{
		if (this.DataList == null || index < 0 || index >= this.DataList.Count)
		{
			return;
		}
		this.CurSelectRoleId = this.DataList[index].Id;
		this.SetElementItemVisible(index, false);
		this.SetAttachPointVisible(false);
		this.RefreshElementInfo(index);
		if (this.IsFirstSnap)
		{
			this.IsFirstSnap = false;
			this.LastPreviewRoleId = this.CurSelectRoleId;
		}
		else if (this.CurSelectRoleId != this.LastPreviewRoleId)
		{
			this.LastPreviewRoleId = this.CurSelectRoleId;
			this.ShowElementPreviewEffect();
			base.PlaySequence("Switch", null, false);
		}
		else
		{
			this.ShowPreviewEffectVisual();
		}
		this.RefreshButtonState();
	}

	// Token: 0x0601275C RID: 75612 RVA: 0x00574044 File Offset: 0x00572244
	private void RefreshElementInfo(int index)
	{
		if (this.DataList == null || index < 0 || index >= this.DataList.Count)
		{
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.DataList[index].Id);
		if (roleConfig == null)
		{
			return;
		}
		int elementId = roleConfig.Value.ElementId;
		ElementInfo? elementInfo = ElementInfoConfig.Instance.GetElementInfo(elementId);
		if (elementInfo == null)
		{
			return;
		}
		ElementInfo value = elementInfo.Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.Name, Array.Empty<object>());
		base.SetTextureByPath(value.Icon, base.GetTexture(2), null, null);
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetColor(FColor.FromHex(value.ElementChangeMainLineColor));
		}
		UUINiagara uiNiagara = base.GetUiNiagara(14);
		if (uiNiagara == null)
		{
			return;
		}
		uiNiagara.SetColor(FColor.FromHex(value.ElementChangeLineColor));
	}

	// Token: 0x0601275D RID: 75613 RVA: 0x0057413E File Offset: 0x0057233E
	private void PlaySceneExitEffect()
	{
		this.HidePreviewEffectVisual();
		this.PlayDissipateHandEffect();
	}

	// Token: 0x0601275E RID: 75614 RVA: 0x0057414C File Offset: 0x0057234C
	private void SetElementItemHighlight(int index, bool isHighlight)
	{
		for (int i = 0; i < this.ElementItems.Count; i++)
		{
			this.ElementItems[i].SetHighlight(i == index && isHighlight);
		}
	}

	// Token: 0x0601275F RID: 75615 RVA: 0x00574186 File Offset: 0x00572386
	private void ActivateElementItem(int index)
	{
		RoleElementItem elementItem = this.GetElementItem(index);
		if (elementItem == null)
		{
			return;
		}
		elementItem.PlayActivate();
	}

	// Token: 0x06012760 RID: 75616 RVA: 0x00574199 File Offset: 0x00572399
	private void DeactivateElementItem(int index)
	{
		RoleElementItem elementItem = this.GetElementItem(index);
		if (elementItem == null)
		{
			return;
		}
		elementItem.PlayActivateOut();
	}

	// Token: 0x06012761 RID: 75617 RVA: 0x005741AC File Offset: 0x005723AC
	public void AttachElementByIndex(int index)
	{
		RoleElementDragger dragger = this.Dragger;
		if (dragger == null)
		{
			return;
		}
		dragger.AttachByIndex(index, true);
	}

	// Token: 0x06012762 RID: 75618 RVA: 0x005741C0 File Offset: 0x005723C0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.ShowRoleElementChangePreviewEffect, new Action<bool>(this.OnShowRoleElementChangePreviewEffect));
	}

	// Token: 0x06012763 RID: 75619 RVA: 0x005741DE File Offset: 0x005723DE
	protected override void OnAfterShow()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSystemChangeRole));
	}

	// Token: 0x06012764 RID: 75620 RVA: 0x005741FC File Offset: 0x005723FC
	private void RefreshButtonState()
	{
		bool flag = this.RoleViewAgent.GetCurSelectRoleId() == this.CurSelectRoleId || this.CurSelectRoleId == 0;
		UUIButtonComponent button = base.GetButton(1);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(!flag);
	}

	// Token: 0x06012765 RID: 75621 RVA: 0x0057423E File Offset: 0x0057243E
	protected override void OnBeforeHide()
	{
		RoleController.Instance.SetTriggerElementEnd(false);
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSystemChangeRole));
	}

	// Token: 0x06012766 RID: 75622 RVA: 0x00574267 File Offset: 0x00572467
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ShowRoleElementChangePreviewEffect, new Action<bool>(this.OnShowRoleElementChangePreviewEffect));
	}

	// Token: 0x06012767 RID: 75623 RVA: 0x00574285 File Offset: 0x00572485
	protected override void OnBeforeDestroy()
	{
		RoleElementDragger dragger = this.Dragger;
		if (dragger != null)
		{
			dragger.Dispose();
		}
		this.Dragger = null;
		this.HideElementPreviewEffect();
		this.IsEffectAssetReady = false;
		this.PreloadedEffectAssets.Clear();
	}

	// Token: 0x06012768 RID: 75624 RVA: 0x005742B8 File Offset: 0x005724B8
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

	// Token: 0x06012769 RID: 75625 RVA: 0x00574374 File Offset: 0x00572574
	private void OnRoleSystemChangeRole(int roleId)
	{
		MainRoleModel.Instance.MarkElementChanged();
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
		this.RefreshButtonState();
	}

	// Token: 0x0601276A RID: 75626 RVA: 0x00574404 File Offset: 0x00572604
	private void OnShowRoleElementChangePreviewEffect(bool isShow)
	{
		if (isShow)
		{
			this.ShowElementPreviewEffect();
			if (this.IsFirstPreviewShow)
			{
				this.IsFirstPreviewShow = false;
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.StopSequenceByKey("StartZ", false, false);
				}
				base.PlaySequence("StartZ", null, false);
				return;
			}
		}
		else
		{
			this.HidePreviewEffectVisual();
		}
	}

	// Token: 0x0601276B RID: 75627 RVA: 0x00574455 File Offset: 0x00572655
	private void RoleChangeShowSuccess()
	{
		UiLayer.Instance.SetShowMaskLayer("RoleElementView", false);
		this.IsPlayingChangeSuccessEffect = false;
		ScrollingTipsController.Instance.ShowTipsById("ElementTransferSuccess", Array.Empty<object>());
	}

	// Token: 0x0601276C RID: 75628 RVA: 0x00574484 File Offset: 0x00572684
	private void ShowElementPreviewEffect()
	{
		if (this.IsPlayingChangeSuccessEffect)
		{
			return;
		}
		this.ShowElementPreviewEffectById(RoleConfig.Instance.GetRoleConfig(this.CurSelectRoleId).Value.ElementId);
	}

	// Token: 0x0601276D RID: 75629 RVA: 0x005744C0 File Offset: 0x005726C0
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
		RoleController.Instance.SetTriggerElementEnd(true);
		base.PlaySequence("CloseZ", null, false);
		int? roleElementSwitchDelayTime = RoleConfig.Instance.GetRoleElementSwitchDelayTime();
		this.ShowElementSuccessEffectById(value.ElementId);
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.RoleChangeShowSuccess();
			base.PlaySequence("StartZ", null, false);
			RoleController.Instance.SetTriggerElementEnd(false);
		}, (float)roleElementSwitchDelayTime.Value, null, null, true, 1f);
	}

	// Token: 0x0601276E RID: 75630 RVA: 0x00574580 File Offset: 0x00572780
	[return: Nullable(0)]
	private UniTask<int> CreateRoleElementEffect([Nullable(1)] string effectPathKey, USceneComponent parentComponent, FName? socketName, FTransformDouble? relativeTransform, string colorHex = null, string iconPath = null)
	{
		RoleElementView.<CreateRoleElementEffect>d__60 <CreateRoleElementEffect>d__;
		<CreateRoleElementEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
		<CreateRoleElementEffect>d__.<>4__this = this;
		<CreateRoleElementEffect>d__.effectPathKey = effectPathKey;
		<CreateRoleElementEffect>d__.parentComponent = parentComponent;
		<CreateRoleElementEffect>d__.socketName = socketName;
		<CreateRoleElementEffect>d__.relativeTransform = relativeTransform;
		<CreateRoleElementEffect>d__.colorHex = colorHex;
		<CreateRoleElementEffect>d__.iconPath = iconPath;
		<CreateRoleElementEffect>d__.<>1__state = -1;
		<CreateRoleElementEffect>d__.<>t__builder.Start<RoleElementView.<CreateRoleElementEffect>d__60>(ref <CreateRoleElementEffect>d__);
		return <CreateRoleElementEffect>d__.<>t__builder.Task;
	}

	// Token: 0x0601276F RID: 75631 RVA: 0x005745F8 File Offset: 0x005727F8
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

	// Token: 0x06012770 RID: 75632 RVA: 0x00574664 File Offset: 0x00572864
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

	// Token: 0x06012771 RID: 75633 RVA: 0x00574739 File Offset: 0x00572939
	private void CreateRoleElementEffectFail()
	{
	}

	// Token: 0x06012772 RID: 75634 RVA: 0x0057473C File Offset: 0x0057293C
	private UniTask PreloadEffectsAsync()
	{
		RoleElementView.<PreloadEffectsAsync>d__64 <PreloadEffectsAsync>d__;
		<PreloadEffectsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadEffectsAsync>d__.<>4__this = this;
		<PreloadEffectsAsync>d__.<>1__state = -1;
		<PreloadEffectsAsync>d__.<>t__builder.Start<RoleElementView.<PreloadEffectsAsync>d__64>(ref <PreloadEffectsAsync>d__);
		return <PreloadEffectsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012773 RID: 75635 RVA: 0x00574780 File Offset: 0x00572980
	private UniTask EnsurePreviewEffectsAsync()
	{
		RoleElementView.<EnsurePreviewEffectsAsync>d__65 <EnsurePreviewEffectsAsync>d__;
		<EnsurePreviewEffectsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnsurePreviewEffectsAsync>d__.<>4__this = this;
		<EnsurePreviewEffectsAsync>d__.<>1__state = -1;
		<EnsurePreviewEffectsAsync>d__.<>t__builder.Start<RoleElementView.<EnsurePreviewEffectsAsync>d__65>(ref <EnsurePreviewEffectsAsync>d__);
		return <EnsurePreviewEffectsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012774 RID: 75636 RVA: 0x005747C4 File Offset: 0x005729C4
	private UniTask EnsureDissipateEffectAsync()
	{
		RoleElementView.<EnsureDissipateEffectAsync>d__66 <EnsureDissipateEffectAsync>d__;
		<EnsureDissipateEffectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnsureDissipateEffectAsync>d__.<>4__this = this;
		<EnsureDissipateEffectAsync>d__.<>1__state = -1;
		<EnsureDissipateEffectAsync>d__.<>t__builder.Start<RoleElementView.<EnsureDissipateEffectAsync>d__66>(ref <EnsureDissipateEffectAsync>d__);
		return <EnsureDissipateEffectAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012775 RID: 75637 RVA: 0x00574808 File Offset: 0x00572A08
	private int GetCurRoleElementId()
	{
		if (RoleConfig.Instance.GetRoleConfig(this.CurSelectRoleId) == null)
		{
			return 0;
		}
		RoleInfo? roleInfo;
		return roleInfo.GetValueOrDefault().ElementId;
	}

	// Token: 0x06012776 RID: 75638 RVA: 0x00574840 File Offset: 0x00572A40
	private FTransformDouble GetPreviewEffectTransform()
	{
		FRotator frotator = new FRotator(0f, 0f, 0f);
		FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, 0.0);
		FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
		FVector fvector = fvectorDouble2;
		return new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
	}

	// Token: 0x06012777 RID: 75639 RVA: 0x005748B8 File Offset: 0x00572AB8
	private void ApplyElementColorAndIcon(int handle, int elementId)
	{
		RoleElementView.<>c__DisplayClass69_0 CS$<>8__locals1 = new RoleElementView.<>c__DisplayClass69_0();
		CS$<>8__locals1.handle = handle;
		CS$<>8__locals1.<>4__this = this;
		if (CS$<>8__locals1.handle == 0)
		{
			return;
		}
		ElementInfo? elementInfo = ElementInfoConfig.Instance.GetElementInfo(elementId);
		if (elementInfo == null)
		{
			return;
		}
		RoleElementView.<>c__DisplayClass69_0 CS$<>8__locals2 = CS$<>8__locals1;
		FColor fcolor = FColor.FromHex(elementInfo.Value.ElementEffectColor);
		CS$<>8__locals2.lColor = FLinearColor.FromSRGBColor(fcolor);
		ResourceSystem.Instance.LoadAsync<UTexture>(elementInfo.Value.Icon3, delegate([Nullable(2)] UTexture textureObject, string _)
		{
			if (EffectSystem.Instance.IsValid(CS$<>8__locals1.handle))
			{
				CS$<>8__locals1.<>4__this.UpdetaColorAndIcon(CS$<>8__locals1.handle, CS$<>8__locals1.lColor, true, textureObject);
			}
		}, 100, this.MemoryTag);
	}

	// Token: 0x06012778 RID: 75640 RVA: 0x00574948 File Offset: 0x00572B48
	private void StopEffectHandle(int handle)
	{
		if (handle != 0 && EffectSystem.Instance.IsValid(handle))
		{
			EffectSystem.Instance.StopEffectById(handle, "HideElementPreviewEffect", true, new bool?(true));
		}
	}

	// Token: 0x06012779 RID: 75641 RVA: 0x00574974 File Offset: 0x00572B74
	private void SetPreviewEffectHidden(bool hidden)
	{
		bool flag = this.IsPreviewEffectHidden && !hidden;
		this.IsPreviewEffectHidden = hidden;
		if (!hidden)
		{
			this.EnsurePreviewEffectsAsync().Forget();
		}
		if (this.RoleSwitchPreviewHandEffectHandle != 0)
		{
			EffectSystem.Instance.SetEffectHidden(this.RoleSwitchPreviewHandEffectHandle, hidden, "RoleElementPreview", false);
		}
		if (flag)
		{
			AudioSystem.Instance.PostEvent("play_ui_switchelement_buttorn_click");
		}
	}

	// Token: 0x0601277A RID: 75642 RVA: 0x005749D6 File Offset: 0x00572BD6
	public void ShowElementPreviewEffectById(int elementId)
	{
		if (!this.IsEffectAssetReady || this.IsPlayingChangeSuccessEffect)
		{
			return;
		}
		this.PreviewElementId = elementId;
		this.ApplyElementColorAndIcon(this.RoleSwitchPreviewHandEffectHandle, elementId);
		this.SetPreviewEffectHidden(false);
	}

	// Token: 0x0601277B RID: 75643 RVA: 0x00574A04 File Offset: 0x00572C04
	private void HidePreviewEffectVisual()
	{
		this.SetPreviewEffectHidden(true);
	}

	// Token: 0x0601277C RID: 75644 RVA: 0x00574A0D File Offset: 0x00572C0D
	private void ShowPreviewEffectVisual()
	{
		if (!this.IsEffectAssetReady || this.IsPlayingChangeSuccessEffect)
		{
			return;
		}
		this.SetPreviewEffectHidden(false);
	}

	// Token: 0x0601277D RID: 75645 RVA: 0x00574A27 File Offset: 0x00572C27
	private void SetDissipateEffectHidden(bool hidden)
	{
		this.IsDissipateEffectHidden = hidden;
		if (!hidden)
		{
			this.EnsureDissipateEffectAsync().Forget();
		}
		if (this.RoleSwitchDissipateHandEffectHandle != 0)
		{
			EffectSystem.Instance.SetEffectHidden(this.RoleSwitchDissipateHandEffectHandle, hidden, "RoleElementPreview", false);
		}
	}

	// Token: 0x0601277E RID: 75646 RVA: 0x00574A60 File Offset: 0x00572C60
	private void PlayDissipateHandEffect()
	{
		if (!this.IsEffectAssetReady)
		{
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.CurSelectRoleId);
		if (roleConfig == null)
		{
			return;
		}
		this.DissipateElementId = roleConfig.Value.ElementId;
		this.ApplyElementColorAndIcon(this.RoleSwitchDissipateHandEffectHandle, this.DissipateElementId);
		int roleSwitchDissipateHandEffectHandle = this.RoleSwitchDissipateHandEffectHandle;
		this.SetDissipateEffectHidden(false);
		if (roleSwitchDissipateHandEffectHandle != 0 && EffectSystem.Instance.IsValid(roleSwitchDissipateHandEffectHandle))
		{
			EffectSystem instance = EffectSystem.Instance;
			int id = roleSwitchDissipateHandEffectHandle;
			string reason = "RoleElementDissipateReplay";
			FTransformDouble? ftransformDouble = null;
			instance.ReplayEffect(id, reason, ftransformDouble);
		}
	}

	// Token: 0x0601277F RID: 75647 RVA: 0x00574AF0 File Offset: 0x00572CF0
	private void HideElementPreviewEffect()
	{
		this.IsPreviewEffectHidden = true;
		this.IsDissipateEffectHidden = true;
		this.StopEffectHandle(this.RoleSwitchPreviewHandEffectHandle);
		this.RoleSwitchPreviewHandEffectHandle = 0;
		this.StopEffectHandle(this.RoleSwitchPreviewBackEffectHandle);
		this.RoleSwitchPreviewBackEffectHandle = 0;
		this.StopEffectHandle(this.RoleSwitchDissipateHandEffectHandle);
		this.RoleSwitchDissipateHandEffectHandle = 0;
	}

	// Token: 0x0400A0A1 RID: 41121
	private const int ELEMENT_ITEM_COUNT = 6;

	// Token: 0x0400A0A2 RID: 41122
	private List<MainRoleConfig> DataList;

	// Token: 0x0400A0A3 RID: 41123
	[Nullable(1)]
	private readonly List<RoleElementItem> ElementItems = new List<RoleElementItem>();

	// Token: 0x0400A0A4 RID: 41124
	private RoleElementDragger Dragger;

	// Token: 0x0400A0A5 RID: 41125
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A0A6 RID: 41126
	private int CurSelectRoleId;

	// Token: 0x0400A0A7 RID: 41127
	private int LastPreviewRoleId;

	// Token: 0x0400A0A8 RID: 41128
	private bool IsFirstSnap = true;

	// Token: 0x0400A0A9 RID: 41129
	private RoleViewAgent RoleViewAgent;

	// Token: 0x0400A0AA RID: 41130
	private int RoleSwitchPreviewHandEffectHandle;

	// Token: 0x0400A0AB RID: 41131
	private int RoleSwitchPreviewBackEffectHandle;

	// Token: 0x0400A0AC RID: 41132
	private int RoleSwitchDissipateHandEffectHandle;

	// Token: 0x0400A0AD RID: 41133
	[Nullable(1)]
	private readonly List<UEffectModelBase> PreloadedEffectAssets = new List<UEffectModelBase>();

	// Token: 0x0400A0AE RID: 41134
	private bool IsEffectAssetReady;

	// Token: 0x0400A0AF RID: 41135
	private bool IsPreviewEffectSpawning;

	// Token: 0x0400A0B0 RID: 41136
	private bool IsDissipateEffectSpawning;

	// Token: 0x0400A0B1 RID: 41137
	private bool IsPreviewEffectHidden = true;

	// Token: 0x0400A0B2 RID: 41138
	private bool IsDissipateEffectHidden = true;

	// Token: 0x0400A0B3 RID: 41139
	private int PreviewElementId;

	// Token: 0x0400A0B4 RID: 41140
	private int DissipateElementId;

	// Token: 0x0400A0B5 RID: 41141
	private bool IsFirstPreviewShow = true;

	// Token: 0x0400A0B6 RID: 41142
	private bool IsPlayingChangeSuccessEffect;

	// Token: 0x0400A0B7 RID: 41143
	private TsUiSceneRoleActor SceneRoleActor;

	// Token: 0x0200805D RID: 32861
	[NullableContext(0)]
	public enum ERoleElementViewDefine
	{
		// Token: 0x0402987D RID: 170109
		CaptionItem,
		// Token: 0x0402987E RID: 170110
		SwitchButton,
		// Token: 0x0402987F RID: 170111
		ElementIconTexture,
		// Token: 0x04029880 RID: 170112
		ElementNameText,
		// Token: 0x04029881 RID: 170113
		DraggablePanel,
		// Token: 0x04029882 RID: 170114
		ElementItemContainer,
		// Token: 0x04029883 RID: 170115
		ElementItem1,
		// Token: 0x04029884 RID: 170116
		ElementItem2,
		// Token: 0x04029885 RID: 170117
		ElementItem3,
		// Token: 0x04029886 RID: 170118
		ElementItem4,
		// Token: 0x04029887 RID: 170119
		ElementItem5,
		// Token: 0x04029888 RID: 170120
		ElementItem6,
		// Token: 0x04029889 RID: 170121
		AttachItem,
		// Token: 0x0402988A RID: 170122
		MainLineItem,
		// Token: 0x0402988B RID: 170123
		LineNiagara
	}
}
