using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A5B RID: 10843
[NullableContext(1)]
[Nullable(0)]
public class RoleOrnamentTabView : UiTabViewBase
{
	// Token: 0x0601697F RID: 92543 RVA: 0x005B9C58 File Offset: 0x005B7E58
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIDraggableComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickHideViewToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06016980 RID: 92544 RVA: 0x005B9E2C File Offset: 0x005B802C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleOrnamentTabView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleOrnamentTabView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016981 RID: 92545 RVA: 0x005B9E70 File Offset: 0x005B8070
	protected override void OnBeforeShow()
	{
		EModelStateInSkinView? modelState = this.RootViewModel.GetModelState();
		if (modelState.GetValueOrDefault() == EModelStateInSkinView.ShowGlider || modelState.GetValueOrDefault() == EModelStateInSkinView.ShowCalabash)
		{
			this.SkipCameraBlend = true;
		}
		ISkinViewData viewData = this.RootViewModel.ViewData;
		if (viewData.SkipOrnamentCameraBlend.GetValueOrDefault())
		{
			this.SkipCameraBlend = true;
			viewData.SkipOrnamentCameraBlend = new bool?(false);
		}
		this.RootViewModel.SetModelState(EModelStateInSkinView.ShowRole, false);
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
		this.RefreshDefaultSelect();
		this.RefreshContentLayout();
		this.RefreshUiSceneRoleActor();
	}

	// Token: 0x06016982 RID: 92546 RVA: 0x005B9F00 File Offset: 0x005B8100
	protected override void OnBeforeHide()
	{
		this.RootViewModel.EndCameraInput();
	}

	// Token: 0x06016983 RID: 92547 RVA: 0x005B9F0D File Offset: 0x005B810D
	protected override void OnBeforeDestroy()
	{
		this.RootViewModel.UnBind(new Action<ESkinRootViewData>(this.OnRootViewModelUpdate));
		this.ViewModel.UnBind(new Action<ERoleOrnamentTabViewData>(this.OnViewModelUpdate));
	}

	// Token: 0x06016984 RID: 92548 RVA: 0x005B9F40 File Offset: 0x005B8140
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnSkinRootViewDestroy, new Action(this.OnSkinRootViewDestroy));
		EventSystem.Instance.Add(EEventName.OnOrnamentChange, new Action(this.OnOrnamentChange));
		EventSystem.Instance.Add<int>(EEventName.OnOrnamentUnlock, new Action<int>(this.OnOrnamentUnlock));
	}

	// Token: 0x06016985 RID: 92549 RVA: 0x005B9FA4 File Offset: 0x005B81A4
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSkinRootViewDestroy, new Action(this.OnSkinRootViewDestroy));
		EventSystem.Instance.Remove(EEventName.OnOrnamentChange, new Action(this.OnOrnamentChange));
		EventSystem.Instance.Remove<int>(EEventName.OnOrnamentUnlock, new Action<int>(this.OnOrnamentUnlock));
	}

	// Token: 0x06016986 RID: 92550 RVA: 0x005BA008 File Offset: 0x005B8208
	private void RefreshDefaultSelect()
	{
		int? num = null;
		int? num2 = null;
		SkinTabViewParam tabViewParam = this.RootViewModel.GetTabViewParam();
		if (tabViewParam != null && tabViewParam.SkinId != null)
		{
			num = tabViewParam.SkinId;
			num2 = new int?(tabViewParam.OrnamentId ?? this.ViewModel.GetDefaultOrnamentId(num.Value));
		}
		if (num == null)
		{
			num = new int?(this.ViewModel.GetDefaultSkinId(this.RootViewModel.RoleId));
			if (num.Value != this.ViewModel.GetSelectedSkinId())
			{
				num2 = new int?(this.ViewModel.GetDefaultOrnamentId(num.Value));
			}
		}
		int value = num2.GetValueOrDefault();
		if (num2 == null)
		{
			value = this.ViewModel.GetDefaultOrnamentId(num.Value);
			num2 = new int?(value);
		}
		this.ViewModel.SetSelectedSkinId(num.Value, false);
		this.ViewModel.SetSelectedOrnamentId(num2.Value, false);
	}

	// Token: 0x06016987 RID: 92551 RVA: 0x005BA124 File Offset: 0x005B8324
	private void RefreshOrnamentView(bool playAnim = true)
	{
		RoleOrnamentModel instance = RoleOrnamentModel.Instance;
		int selectedOrnamentId = this.ViewModel.GetSelectedOrnamentId();
		RoleOrnamentData roleOrnamentData = instance.GetRoleOrnamentData(selectedOrnamentId);
		this.RefreshText(roleOrnamentData.GetName(), roleOrnamentData.GetBgDescription());
		int selectedSkinId = this.ViewModel.GetSelectedSkinId();
		bool flag = RoleSkinModel.Instance.GetRoleSkinData(selectedSkinId).IsLocked();
		bool flag2 = instance.IsOwnOrnament(selectedOrnamentId);
		bool flag3 = flag && flag2;
		if (flag3)
		{
			this.HintItem.SetShowText("OrnamentUiText_04");
		}
		bool flag4 = flag2 && !flag;
		bool flag5 = RoleOrnamentModel.Instance.IsSkinWearingOrnament(selectedOrnamentId, selectedSkinId, true);
		if (flag4)
		{
			this.ConfirmButton.SetShowText(flag5 ? "OrnamentUiText_02" : "OrnamentUiText_01");
		}
		bool flag6 = !flag2;
		this.ObtainLayout.SetActive(flag6);
		if (flag6)
		{
			this.RefreshObtainLayout(selectedOrnamentId);
		}
		List<int> conflictOrnamentsOnSkin = instance.GetConflictOrnamentsOnSkin(selectedOrnamentId, selectedSkinId, false);
		bool flag7 = !flag5 && conflictOrnamentsOnSkin.Count > 0;
		if (flag7)
		{
			Ornament value = RoleConfig.Instance.GetOrnamentConfig(conflictOrnamentsOnSkin[0]).Value;
			this.HintItem.SetLocalText("OrnamentUiText_03", new object[]
			{
				ConfigMultiTextLang.GetLocalTextNew(value.Name, null)
			});
			if (playAnim)
			{
				this.UiViewSequence.StopSequenceByKey("RedTips", false, false);
				this.UiViewSequence.PlaySequence("RedTips", true, null);
			}
		}
		this.HintItem.SetUiActive(flag3 || flag7);
		bool flag8 = flag2 && flag;
		if (flag8)
		{
			this.ConfirmButton.SetShowText("OrnamentUiText_07");
		}
		this.ConfirmButton.SetUiActive(flag4 || flag8);
		if (playAnim)
		{
			this.UiViewSequence.StopSequenceByKey("Switch", false, false);
			this.UiViewSequence.PlaySequence("Switch", true, null);
		}
	}

	// Token: 0x06016988 RID: 92552 RVA: 0x005BA2F4 File Offset: 0x005B84F4
	private void RefreshOrnamentModel()
	{
		int selectedOrnamentId = this.ViewModel.GetSelectedOrnamentId();
		int selectedSkinId = this.ViewModel.GetSelectedSkinId();
		List<int> wearPreviewOrnamentResult = RoleOrnamentModel.Instance.GetWearPreviewOrnamentResult(selectedOrnamentId, selectedSkinId);
		List<OrnamentModelContext> list = new List<OrnamentModelContext>();
		for (int i = 0; i < wearPreviewOrnamentResult.Count; i++)
		{
			int ornamentId = wearPreviewOrnamentResult[i];
			list.Add(UiModelUtil.BuildOrnamentModelContext(selectedSkinId, ornamentId));
		}
		UiModelUtil.RefreshRoleOrnaments(this.RootViewModel.TsUiSceneRoleActor.Model, list.ToArray(), false);
	}

	// Token: 0x06016989 RID: 92553 RVA: 0x005BA375 File Offset: 0x005B8575
	private void RefreshText(string name, string desc)
	{
		base.GetText(6).ShowTextNew(name);
		base.GetText(7).ShowTextNew(desc);
	}

	// Token: 0x0601698A RID: 92554 RVA: 0x005BA394 File Offset: 0x005B8594
	private void RefreshContentLayout()
	{
		int roleId = this.RootViewModel.RoleId;
		List<RoleSkinData> roleSkinDataList = RoleSkinModel.Instance.GetRoleSkinDataList(roleId);
		roleSkinDataList.Sort(delegate(RoleSkinData a, RoleSkinData b)
		{
			bool flag = a.IsWear();
			bool flag2 = b.IsWear();
			if (flag == flag2)
			{
				return 0;
			}
			if (!flag)
			{
				return 1;
			}
			return -1;
		});
		this.ContentLayout.RefreshByData(roleSkinDataList, null, false);
	}

	// Token: 0x0601698B RID: 92555 RVA: 0x005BA3EC File Offset: 0x005B85EC
	private void RefreshObtainLayout(int itemId)
	{
		List<IGetWayItemData> getWayDataList = InventoryModel.Instance.GetGetWayDataList(itemId);
		this.ObtainLayout.RefreshByData(getWayDataList, null, false);
	}

	// Token: 0x0601698C RID: 92556 RVA: 0x005BA413 File Offset: 0x005B8613
	private void RefreshUiSceneRoleActor()
	{
		RoleController.Instance.RefreshUiSceneRoleActor(this.RootViewModel.TsUiSceneRoleActor, this.RootViewModel.RoleId, this.ViewModel.GetSelectedSkinId(), null);
	}

	// Token: 0x0601698D RID: 92557 RVA: 0x005BA444 File Offset: 0x005B8644
	private void RefreshContentGridSelected()
	{
		List<RoleSkinOrnamentItem> layoutItemList = this.ContentLayout.GetLayoutItemList();
		for (int i = 0; i < layoutItemList.Count; i++)
		{
			RoleSkinOrnamentItem roleSkinOrnamentItem = layoutItemList[i];
			if (roleSkinOrnamentItem != null)
			{
				roleSkinOrnamentItem.RefreshGridSelected();
			}
		}
	}

	// Token: 0x0601698E RID: 92558 RVA: 0x005BA480 File Offset: 0x005B8680
	private void RefreshContentItems()
	{
		List<RoleSkinOrnamentItem> layoutItemList = this.ContentLayout.GetLayoutItemList();
		for (int i = 0; i < layoutItemList.Count; i++)
		{
			RoleSkinOrnamentItem roleSkinOrnamentItem = layoutItemList[i];
			if (roleSkinOrnamentItem != null)
			{
				roleSkinOrnamentItem.RefreshOrnamentItems();
			}
		}
	}

	// Token: 0x0601698F RID: 92559 RVA: 0x005BA4BC File Offset: 0x005B86BC
	private void RevertRoleSkin()
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RootViewModel.RoleId);
		if (roleInstanceById == null || this.RootViewModel.TsUiSceneRoleActor == null)
		{
			return;
		}
		RoleController.Instance.RefreshUiSceneRoleActor(this.RootViewModel.TsUiSceneRoleActor, this.RootViewModel.RoleId, roleInstanceById.GetRoleSkinId(), null);
	}

	// Token: 0x06016990 RID: 92560 RVA: 0x005BA518 File Offset: 0x005B8718
	private void RevertOrnamentModel(bool useSelectedSkinId = false)
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.RootViewModel.TsUiSceneRoleActor;
		if (((tsUiSceneRoleActor != null) ? tsUiSceneRoleActor.Model : null) == null)
		{
			return;
		}
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RootViewModel.RoleId);
		int num = useSelectedSkinId ? this.ViewModel.GetSelectedSkinId() : roleInstanceById.GetRoleSkinId();
		List<int> skinAllWearingOrnaments = RoleOrnamentModel.Instance.GetSkinAllWearingOrnaments(num, true);
		List<OrnamentModelContext> list = new List<OrnamentModelContext>();
		for (int i = 0; i < skinAllWearingOrnaments.Count; i++)
		{
			int ornamentId = skinAllWearingOrnaments[i];
			list.Add(UiModelUtil.BuildOrnamentModelContext(num, ornamentId));
		}
		UiModelUtil.RefreshRoleOrnaments(this.RootViewModel.TsUiSceneRoleActor.Model, list.ToArray(), false);
	}

	// Token: 0x06016991 RID: 92561 RVA: 0x005BA5C8 File Offset: 0x005B87C8
	private void TryPlayRoleMontage()
	{
		int selectedOrnamentId = this.ViewModel.GetSelectedOrnamentId();
		if (RoleConfig.Instance.GetOrnamentConfig(selectedOrnamentId).Value.UiRoleState == 0)
		{
			return;
		}
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Favor, false, false, false);
	}

	// Token: 0x06016992 RID: 92562 RVA: 0x005BA60E File Offset: 0x005B880E
	private RoleSkinOrnamentItem CreateSkinOrnamentItem()
	{
		RoleSkinOrnamentItem roleSkinOrnamentItem = new RoleSkinOrnamentItem();
		roleSkinOrnamentItem.SetClickOrnamentCallback(new Action<int, int>(this.OnClickOrnamentCallback));
		roleSkinOrnamentItem.SetGetPreviewSkinIdFunc(new Func<int>(this.GetPreviewSkinIdFunc));
		roleSkinOrnamentItem.SetGetPreviewOrnamentIdFunc(new Func<int>(this.GetPreviewOrnamentIdFunc));
		return roleSkinOrnamentItem;
	}

	// Token: 0x06016993 RID: 92563 RVA: 0x005BA64B File Offset: 0x005B884B
	private RoleOrnamentObtainItem CreateObtainItem()
	{
		return new RoleOrnamentObtainItem();
	}

	// Token: 0x06016994 RID: 92564 RVA: 0x005BA652 File Offset: 0x005B8852
	private void OnUiOutSequenceFinish()
	{
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x06016995 RID: 92565 RVA: 0x005BA661 File Offset: 0x005B8861
	private void OnRootViewModelUpdate(ESkinRootViewData data)
	{
		if (data == ESkinRootViewData.CurSelectTabViewName && base.IsShowOrShowing)
		{
			this.RevertRoleSkin();
			this.RevertOrnamentModel(false);
		}
	}

	// Token: 0x06016996 RID: 92566 RVA: 0x005BA67B File Offset: 0x005B887B
	private void OnViewModelUpdate(ERoleOrnamentTabViewData data)
	{
		if (data == ERoleOrnamentTabViewData.SelectedOrnamentId)
		{
			this.RefreshOrnamentView(true);
			this.RefreshContentGridSelected();
			this.RefreshOrnamentModel();
			this.UpdateCamera(new bool?(true));
			this.TryPlayRoleMontage();
			return;
		}
		if (data == ERoleOrnamentTabViewData.SelectedSkinId)
		{
			this.RefreshUiSceneRoleActor();
		}
	}

	// Token: 0x06016997 RID: 92567 RVA: 0x005BA6B0 File Offset: 0x005B88B0
	private void OnClickHideViewToggle(EToggleState state)
	{
		UUIItem item = base.GetItem(0);
		if (state == EToggleState.ETT_Checked)
		{
			this.RootViewModel.SetCaptionItemActive(true);
			item.SetUIActive(true);
			this.UiViewSequence.PlaySequence("UiIn", true, null);
		}
		else
		{
			this.RootViewModel.SetCaptionItemActive(false);
			this.UiViewSequence.PlaySequence("UiOut", true, null);
		}
		this.UpdateCamera(null);
		this.TryPlayRoleMontage();
	}

	// Token: 0x06016998 RID: 92568 RVA: 0x005BA734 File Offset: 0x005B8934
	private void OnClickConfirmButton()
	{
		int selectedSkinId = this.ViewModel.GetSelectedSkinId();
		if (RoleSkinModel.Instance.GetRoleSkinData(selectedSkinId).IsLocked())
		{
			this.RootViewModel.SetTabViewParam(new SkinTabViewParam
			{
				SkinId = new int?(selectedSkinId)
			});
			this.RootViewModel.SetSelectTabViewName(EUiTabViewName.RoleSkinTabView, false);
			return;
		}
		if (!RoleController.Instance.CheckCanWearOrnamentAndShowTip())
		{
			return;
		}
		int selectedOrnamentId = this.ViewModel.GetSelectedOrnamentId();
		if (!RoleOrnamentModel.Instance.IsOwnOrnament(selectedOrnamentId))
		{
			return;
		}
		bool flag = RoleOrnamentModel.Instance.IsSkinWearingOrnament(selectedOrnamentId, selectedSkinId, true);
		RoleController.Instance.RequestChangeOrnamentRequest(selectedSkinId, selectedOrnamentId, !flag);
	}

	// Token: 0x06016999 RID: 92569 RVA: 0x005BA7D4 File Offset: 0x005B89D4
	private void OnClickOrnamentCallback(int skinId, int ornamentId)
	{
		int selectedOrnamentId = this.ViewModel.GetSelectedOrnamentId();
		this.ViewModel.SetPreSelectedOrnamentId(selectedOrnamentId, false);
		this.ViewModel.SetSelectedSkinId(skinId, false);
		this.ViewModel.SetSelectedOrnamentId(ornamentId, false);
	}

	// Token: 0x0601699A RID: 92570 RVA: 0x005BA814 File Offset: 0x005B8A14
	private void OnSkinRootViewDestroy()
	{
		this.RevertRoleSkin();
		this.RevertOrnamentModel(false);
		this.RootViewModel.EndCameraInput();
	}

	// Token: 0x0601699B RID: 92571 RVA: 0x005BA82E File Offset: 0x005B8A2E
	private void OnOrnamentChange()
	{
		this.RevertOrnamentModel(true);
		this.RefreshOrnamentView(false);
		this.RefreshContentItems();
	}

	// Token: 0x0601699C RID: 92572 RVA: 0x005BA844 File Offset: 0x005B8A44
	private void OnOrnamentUnlock(int ornamentId)
	{
		this.RefreshDefaultSelect();
		this.RefreshContentLayout();
	}

	// Token: 0x0601699D RID: 92573 RVA: 0x005BA852 File Offset: 0x005B8A52
	private int GetPreviewSkinIdFunc()
	{
		return this.ViewModel.GetSelectedSkinId();
	}

	// Token: 0x0601699E RID: 92574 RVA: 0x005BA85F File Offset: 0x005B8A5F
	private int GetPreviewOrnamentIdFunc()
	{
		return this.ViewModel.GetSelectedOrnamentId();
	}

	// Token: 0x0601699F RID: 92575 RVA: 0x005BA86C File Offset: 0x005B8A6C
	private IUiCameraInputComponentData GetCameraInputData()
	{
		return this.ViewModel.GetOrnamentTabCameraInputData(this.RootViewModel.GetDragItem(), this.RootViewModel.TsUiSceneRoleActor, this.IsHidingUi());
	}

	// Token: 0x060169A0 RID: 92576 RVA: 0x005BA898 File Offset: 0x005B8A98
	private bool IsAllowCameraRotate()
	{
		int selectedOrnamentId = this.ViewModel.GetSelectedOrnamentId();
		Ornament value = RoleConfig.Instance.GetOrnamentConfig(selectedOrnamentId).Value;
		if (!this.IsHidingUi())
		{
			return value.AllowUiCameraRotate;
		}
		return value.AllowHideUiCameraRotate;
	}

	// Token: 0x060169A1 RID: 92577 RVA: 0x005BA8DC File Offset: 0x005B8ADC
	private bool IsHidingUi()
	{
		return base.GetExtendToggle(2).GetToggleState() == EToggleState.ETT_UnChecked;
	}

	// Token: 0x060169A2 RID: 92578 RVA: 0x005BA8ED File Offset: 0x005B8AED
	private void UpdateCamera(bool? isFromOrnament = null)
	{
		this.TryPushOrnamentCamera(isFromOrnament, null);
		this.RootViewModel.StartCameraInput(this.GetCameraInputData(), new bool?(this.IsAllowCameraRotate()), false);
	}

	// Token: 0x060169A3 RID: 92579 RVA: 0x005BA914 File Offset: 0x005B8B14
	[NullableContext(2)]
	private void TryPushOrnamentCamera(bool? isFromOrnament = null, Action callback = null)
	{
		int selectedOrnamentId = this.ViewModel.GetSelectedOrnamentId();
		int selectedSkinId = this.ViewModel.GetSelectedSkinId();
		bool flag = this.IsHidingUi();
		bool skipCameraBlend = this.SkipCameraBlend;
		if (this.SkipCameraBlend)
		{
			this.SkipCameraBlend = false;
		}
		string blendName = flag ? "1001" : this.GetOrnamentCameraBlendName(selectedOrnamentId, isFromOrnament);
		string ornamentCameraHandleName = this.GetOrnamentCameraHandleName(selectedOrnamentId, selectedSkinId, flag);
		UiCameraHandleData uiCameraHandleData = UiCameraHandleData.NewByHandleName(ornamentCameraHandleName, null);
		uiCameraHandleData.ViewName = ornamentCameraHandleName;
		uiCameraHandleData.OwnerViewName = base.GetViewName();
		UiCameraAnimationManager.Instance.PushCameraHandle(uiCameraHandleData, !skipCameraBlend, !skipCameraBlend, blendName, false, delegate(UiCameraAnimationDefine.IFinishData _)
		{
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		});
	}

	// Token: 0x060169A4 RID: 92580 RVA: 0x005BA9D4 File Offset: 0x005B8BD4
	private string GetOrnamentCameraBlendName(int targetOrnament, bool? isFromOrnament = null)
	{
		if (!isFromOrnament.GetValueOrDefault())
		{
			return "1001";
		}
		int preSelectedOrnamentId = this.ViewModel.GetPreSelectedOrnamentId();
		if (preSelectedOrnamentId == 0)
		{
			return "1001";
		}
		Ornament? ornamentConfig = RoleConfig.Instance.GetOrnamentConfig(preSelectedOrnamentId);
		if (ornamentConfig == null)
		{
			return "1001";
		}
		Ornament value = ornamentConfig.Value;
		for (int i = 0; i < value.UiCameraBlendLength; i++)
		{
			DicIntString? dicIntString = value.UiCameraBlend(i);
			if (dicIntString != null)
			{
				DicIntString value2 = dicIntString.Value;
				if (value2.Key == targetOrnament)
				{
					return value2.Value ?? "1001";
				}
			}
		}
		return "1001";
	}

	// Token: 0x060169A5 RID: 92581 RVA: 0x005BAA78 File Offset: 0x005B8C78
	private string GetOrnamentCameraHandleName(int ornamentId, int skinId, bool isHidingUi)
	{
		Ornament value = RoleConfig.Instance.GetOrnamentConfig(ornamentId).Value;
		RoleSkin value2 = SkinConfig.Instance.GetRoleSkinConfig(skinId).Value;
		if (isHidingUi)
		{
			if (value.HideUiCameraLength <= 0)
			{
				return string.Empty;
			}
			if (!RoleModel.Instance.IsMainRole(value2.RoleId))
			{
				return value.HideUiCamera(0) ?? string.Empty;
			}
			string result;
			if (RoleConfig.Instance.GetMainRoleById(value2.RoleId).Value.Gender != 1)
			{
				if ((result = value.HideUiCamera(1)) == null)
				{
					return string.Empty;
				}
			}
			else
			{
				result = (value.HideUiCamera(0) ?? string.Empty);
			}
			return result;
		}
		else
		{
			if (value.UiCameraLength <= 0)
			{
				return string.Empty;
			}
			if (!RoleModel.Instance.IsMainRole(value2.RoleId))
			{
				return value.UiCamera(0) ?? string.Empty;
			}
			string result2;
			if (RoleConfig.Instance.GetMainRoleById(value2.RoleId).Value.Gender != 1)
			{
				if ((result2 = value.UiCamera(1)) == null)
				{
					return string.Empty;
				}
			}
			else
			{
				result2 = (value.UiCamera(0) ?? string.Empty);
			}
			return result2;
		}
	}

	// Token: 0x0400A7A4 RID: 42916
	private SkinRootViewModel RootViewModel;

	// Token: 0x0400A7A5 RID: 42917
	private RoleOrnamentViewModel ViewModel;

	// Token: 0x0400A7A6 RID: 42918
	private GenericLayout<RoleSkinOrnamentItem, RoleSkinData> ContentLayout;

	// Token: 0x0400A7A7 RID: 42919
	private GenericLayout<RoleOrnamentObtainItem, IGetWayItemData> ObtainLayout;

	// Token: 0x0400A7A8 RID: 42920
	private RoleOrnamentTabView.RoleOrnamentHintItem HintItem;

	// Token: 0x0400A7A9 RID: 42921
	private ButtonItem ConfirmButton;

	// Token: 0x0400A7AA RID: 42922
	private bool SkipCameraBlend;

	// Token: 0x0200909D RID: 37021
	[NullableContext(0)]
	private enum EComponentType
	{
		// Token: 0x0402EDBF RID: 191935
		RootItem,
		// Token: 0x0402EDC0 RID: 191936
		ContentLayout,
		// Token: 0x0402EDC1 RID: 191937
		HideViewToggle,
		// Token: 0x0402EDC2 RID: 191938
		ConfirmButton,
		// Token: 0x0402EDC3 RID: 191939
		ObtainLayout,
		// Token: 0x0402EDC4 RID: 191940
		ObtainItem,
		// Token: 0x0402EDC5 RID: 191941
		TitleText,
		// Token: 0x0402EDC6 RID: 191942
		ContentText,
		// Token: 0x0402EDC7 RID: 191943
		Draggable,
		// Token: 0x0402EDC8 RID: 191944
		HintItem,
		// Token: 0x0402EDC9 RID: 191945
		SkinOrnamentItem
	}

	// Token: 0x0200909E RID: 37022
	[Nullable(0)]
	private class RoleOrnamentHintItem : UiPanelBase
	{
		// Token: 0x0604BB46 RID: 310086 RVA: 0x013ED650 File Offset: 0x013EB850
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604BB47 RID: 310087 RVA: 0x013ED6DA File Offset: 0x013EB8DA
		public void SetLocalText(string text, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), text, args);
		}

		// Token: 0x0604BB48 RID: 310088 RVA: 0x013ED6EF File Offset: 0x013EB8EF
		public void SetShowText(string text)
		{
			base.GetText(1).ShowTextNew(text);
		}

		// Token: 0x0604BB49 RID: 310089 RVA: 0x013ED700 File Offset: 0x013EB900
		public void SetSprite(string resourcePath, bool setSize = false)
		{
			this.SetSpriteByPath(resourcePath, base.GetSprite(0), setSize, null, null);
		}

		// Token: 0x0200D05E RID: 53342
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x0403E969 RID: 256361
			Sprite,
			// Token: 0x0403E96A RID: 256362
			Text,
			// Token: 0x0403E96B RID: 256363
			Button
		}
	}
}
