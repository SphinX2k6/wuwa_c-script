using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FD6 RID: 8150
[NullableContext(1)]
[Nullable(0)]
public class RoleOrnamentTabView : UiTabViewBase
{
	// Token: 0x060143A0 RID: 82848 RVA: 0x005E5DF0 File Offset: 0x005E3FF0
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

	// Token: 0x060143A1 RID: 82849 RVA: 0x005E5FC4 File Offset: 0x005E41C4
	protected override UniTask OnBeforeStartAsync()
	{
		RoleOrnamentTabView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleOrnamentTabView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060143A2 RID: 82850 RVA: 0x005E6008 File Offset: 0x005E4208
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

	// Token: 0x060143A3 RID: 82851 RVA: 0x005E6098 File Offset: 0x005E4298
	protected override void OnBeforeHide()
	{
		this.RootViewModel.UnbindCameraInput();
	}

	// Token: 0x060143A4 RID: 82852 RVA: 0x005E60A5 File Offset: 0x005E42A5
	protected override void OnBeforeDestroy()
	{
		this.RootViewModel.UnBind(new Action<ESkinRootViewData>(this.OnRootViewModelUpdate));
		this.ViewModel.UnBind(new Action<ERoleOrnamentTabViewData>(this.OnViewModelUpdate));
	}

	// Token: 0x060143A5 RID: 82853 RVA: 0x005E60D8 File Offset: 0x005E42D8
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnSkinRootViewDestroy, new Action(this.OnSkinRootViewDestroy));
		EventSystem.Instance.Add(EEventName.OnOrnamentChange, new Action(this.OnOrnamentChange));
		EventSystem.Instance.Add<int>(EEventName.OnOrnamentUnlock, new Action<int>(this.OnOrnamentUnlock));
	}

	// Token: 0x060143A6 RID: 82854 RVA: 0x005E613C File Offset: 0x005E433C
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSkinRootViewDestroy, new Action(this.OnSkinRootViewDestroy));
		EventSystem.Instance.Remove(EEventName.OnOrnamentChange, new Action(this.OnOrnamentChange));
		EventSystem.Instance.Remove<int>(EEventName.OnOrnamentUnlock, new Action<int>(this.OnOrnamentUnlock));
	}

	// Token: 0x060143A7 RID: 82855 RVA: 0x005E61A0 File Offset: 0x005E43A0
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

	// Token: 0x060143A8 RID: 82856 RVA: 0x005E62BC File Offset: 0x005E44BC
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

	// Token: 0x060143A9 RID: 82857 RVA: 0x005E648C File Offset: 0x005E468C
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

	// Token: 0x060143AA RID: 82858 RVA: 0x005E650D File Offset: 0x005E470D
	private void RefreshText(string name, string desc)
	{
		base.GetText(6).ShowTextNew(name);
		base.GetText(7).ShowTextNew(desc);
	}

	// Token: 0x060143AB RID: 82859 RVA: 0x005E652C File Offset: 0x005E472C
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

	// Token: 0x060143AC RID: 82860 RVA: 0x005E6584 File Offset: 0x005E4784
	private void RefreshObtainLayout(int itemId)
	{
		List<IGetWayItemData> getWayDataList = InventoryModel.Instance.GetGetWayDataList(itemId);
		this.ObtainLayout.RefreshByData(getWayDataList, null, false);
	}

	// Token: 0x060143AD RID: 82861 RVA: 0x005E65AB File Offset: 0x005E47AB
	private void RefreshUiSceneRoleActor()
	{
		RoleController.Instance.RefreshUiSceneRoleActor(this.RootViewModel.TsUiSceneRoleActor, this.RootViewModel.RoleId, this.ViewModel.GetSelectedSkinId(), null);
	}

	// Token: 0x060143AE RID: 82862 RVA: 0x005E65DC File Offset: 0x005E47DC
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

	// Token: 0x060143AF RID: 82863 RVA: 0x005E6618 File Offset: 0x005E4818
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

	// Token: 0x060143B0 RID: 82864 RVA: 0x005E6654 File Offset: 0x005E4854
	private void RevertRoleSkin()
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RootViewModel.RoleId);
		if (roleInstanceById == null || this.RootViewModel.TsUiSceneRoleActor == null)
		{
			return;
		}
		RoleController.Instance.RefreshUiSceneRoleActor(this.RootViewModel.TsUiSceneRoleActor, this.RootViewModel.RoleId, roleInstanceById.GetRoleSkinId(), null);
	}

	// Token: 0x060143B1 RID: 82865 RVA: 0x005E66B0 File Offset: 0x005E48B0
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

	// Token: 0x060143B2 RID: 82866 RVA: 0x005E6760 File Offset: 0x005E4960
	private void TryPlayRoleMontage()
	{
		int selectedOrnamentId = this.ViewModel.GetSelectedOrnamentId();
		if (RoleConfig.Instance.GetOrnamentConfig(selectedOrnamentId).Value.UiRoleState == 0)
		{
			return;
		}
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Favor, false, false, false);
	}

	// Token: 0x060143B3 RID: 82867 RVA: 0x005E67A6 File Offset: 0x005E49A6
	private RoleSkinOrnamentItem CreateSkinOrnamentItem()
	{
		RoleSkinOrnamentItem roleSkinOrnamentItem = new RoleSkinOrnamentItem();
		roleSkinOrnamentItem.SetClickOrnamentCallback(new Action<int, int>(this.OnClickOrnamentCallback));
		roleSkinOrnamentItem.SetGetPreviewSkinIdFunc(new Func<int>(this.GetPreviewSkinIdFunc));
		roleSkinOrnamentItem.SetGetPreviewOrnamentIdFunc(new Func<int>(this.GetPreviewOrnamentIdFunc));
		return roleSkinOrnamentItem;
	}

	// Token: 0x060143B4 RID: 82868 RVA: 0x005E67E3 File Offset: 0x005E49E3
	private RoleOrnamentObtainItem CreateObtainItem()
	{
		return new RoleOrnamentObtainItem();
	}

	// Token: 0x060143B5 RID: 82869 RVA: 0x005E67EA File Offset: 0x005E49EA
	private void OnUiOutSequenceFinish()
	{
		base.GetItem(0).SetUIActive(false);
	}

	// Token: 0x060143B6 RID: 82870 RVA: 0x005E67F9 File Offset: 0x005E49F9
	private void OnRootViewModelUpdate(ESkinRootViewData data)
	{
		if (data == ESkinRootViewData.CurSelectTabViewName && base.IsShowOrShowing)
		{
			this.RevertRoleSkin();
			this.RevertOrnamentModel(false);
		}
	}

	// Token: 0x060143B7 RID: 82871 RVA: 0x005E6813 File Offset: 0x005E4A13
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

	// Token: 0x060143B8 RID: 82872 RVA: 0x005E6848 File Offset: 0x005E4A48
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

	// Token: 0x060143B9 RID: 82873 RVA: 0x005E68CC File Offset: 0x005E4ACC
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

	// Token: 0x060143BA RID: 82874 RVA: 0x005E696C File Offset: 0x005E4B6C
	private void OnClickOrnamentCallback(int skinId, int ornamentId)
	{
		int selectedOrnamentId = this.ViewModel.GetSelectedOrnamentId();
		this.ViewModel.SetPreSelectedOrnamentId(selectedOrnamentId, false);
		this.ViewModel.SetSelectedSkinId(skinId, false);
		this.ViewModel.SetSelectedOrnamentId(ornamentId, false);
	}

	// Token: 0x060143BB RID: 82875 RVA: 0x005E69AC File Offset: 0x005E4BAC
	private void OnSkinRootViewDestroy()
	{
		this.RevertRoleSkin();
		this.RevertOrnamentModel(false);
		this.RootViewModel.UnbindCameraInput();
	}

	// Token: 0x060143BC RID: 82876 RVA: 0x005E69C6 File Offset: 0x005E4BC6
	private void OnOrnamentChange()
	{
		this.RevertOrnamentModel(true);
		this.RefreshOrnamentView(false);
		this.RefreshContentItems();
	}

	// Token: 0x060143BD RID: 82877 RVA: 0x005E69DC File Offset: 0x005E4BDC
	private void OnOrnamentUnlock(int ornamentId)
	{
		this.RefreshDefaultSelect();
		this.RefreshContentLayout();
	}

	// Token: 0x060143BE RID: 82878 RVA: 0x005E69EA File Offset: 0x005E4BEA
	private int GetPreviewSkinIdFunc()
	{
		return this.ViewModel.GetSelectedSkinId();
	}

	// Token: 0x060143BF RID: 82879 RVA: 0x005E69F7 File Offset: 0x005E4BF7
	private int GetPreviewOrnamentIdFunc()
	{
		return this.ViewModel.GetSelectedOrnamentId();
	}

	// Token: 0x060143C0 RID: 82880 RVA: 0x005E6A04 File Offset: 0x005E4C04
	private UiCameraInputBindingData GetCameraInputData()
	{
		return this.ViewModel.GetOrnamentTabCameraInputData(this.RootViewModel.GetDragItem(), this.RootViewModel.TsUiSceneRoleActor, this.IsHidingUi());
	}

	// Token: 0x060143C1 RID: 82881 RVA: 0x005E6A30 File Offset: 0x005E4C30
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

	// Token: 0x060143C2 RID: 82882 RVA: 0x005E6A74 File Offset: 0x005E4C74
	private bool IsHidingUi()
	{
		return base.GetExtendToggle(2).GetToggleState() == EToggleState.ETT_UnChecked;
	}

	// Token: 0x060143C3 RID: 82883 RVA: 0x005E6A85 File Offset: 0x005E4C85
	private void UpdateCamera(bool? isFromOrnament = null)
	{
		this.TryPushOrnamentCamera(isFromOrnament, null);
		this.RootViewModel.ConfigureCameraInput(this.GetCameraInputData());
		if (this.IsAllowCameraRotate())
		{
			this.RootViewModel.BindCameraInput();
			return;
		}
		this.RootViewModel.UnbindCameraInput();
	}

	// Token: 0x060143C4 RID: 82884 RVA: 0x005E6AC0 File Offset: 0x005E4CC0
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
		UiCameraHandleData handleData = UiCameraUtil.CreateHandleData(ornamentCameraHandleName, ornamentCameraHandleName);
		UiCameraModel.Instance.PushCameraHandle(handleData, !skipCameraBlend, !skipCameraBlend, blendName, false, delegate(UiCameraDefine.IFinishData _)
		{
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		});
	}

	// Token: 0x060143C5 RID: 82885 RVA: 0x005E6B5C File Offset: 0x005E4D5C
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

	// Token: 0x060143C6 RID: 82886 RVA: 0x005E6C00 File Offset: 0x005E4E00
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

	// Token: 0x0400ABA8 RID: 43944
	private SkinRootViewModel RootViewModel;

	// Token: 0x0400ABA9 RID: 43945
	private RoleOrnamentViewModel ViewModel;

	// Token: 0x0400ABAA RID: 43946
	private GenericLayout<RoleSkinOrnamentItem, RoleSkinData> ContentLayout;

	// Token: 0x0400ABAB RID: 43947
	private GenericLayout<RoleOrnamentObtainItem, IGetWayItemData> ObtainLayout;

	// Token: 0x0400ABAC RID: 43948
	private RoleOrnamentTabView.RoleOrnamentHintItem HintItem;

	// Token: 0x0400ABAD RID: 43949
	private ButtonItem ConfirmButton;

	// Token: 0x0400ABAE RID: 43950
	private bool SkipCameraBlend;

	// Token: 0x020082E4 RID: 33508
	[NullableContext(0)]
	private enum EComponentType
	{
		// Token: 0x0402A4B9 RID: 173241
		RootItem,
		// Token: 0x0402A4BA RID: 173242
		ContentLayout,
		// Token: 0x0402A4BB RID: 173243
		HideViewToggle,
		// Token: 0x0402A4BC RID: 173244
		ConfirmButton,
		// Token: 0x0402A4BD RID: 173245
		ObtainLayout,
		// Token: 0x0402A4BE RID: 173246
		ObtainItem,
		// Token: 0x0402A4BF RID: 173247
		TitleText,
		// Token: 0x0402A4C0 RID: 173248
		ContentText,
		// Token: 0x0402A4C1 RID: 173249
		Draggable,
		// Token: 0x0402A4C2 RID: 173250
		HintItem,
		// Token: 0x0402A4C3 RID: 173251
		SkinOrnamentItem
	}

	// Token: 0x020082E5 RID: 33509
	[Nullable(0)]
	private class RoleOrnamentHintItem : UiPanelBase
	{
		// Token: 0x0604203D RID: 270397 RVA: 0x01398C30 File Offset: 0x01396E30
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

		// Token: 0x0604203E RID: 270398 RVA: 0x01398CBA File Offset: 0x01396EBA
		public void SetLocalText(string text, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), text, args);
		}

		// Token: 0x0604203F RID: 270399 RVA: 0x01398CCF File Offset: 0x01396ECF
		public void SetShowText(string text)
		{
			base.GetText(1).ShowTextNew(text);
		}

		// Token: 0x06042040 RID: 270400 RVA: 0x01398CE0 File Offset: 0x01396EE0
		public void SetSprite(string resourcePath, bool setSize = false)
		{
			this.SetSpriteByPath(resourcePath, base.GetSprite(0), setSize, null, null);
		}

		// Token: 0x0200BC3C RID: 48188
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04039DB1 RID: 236977
			Sprite,
			// Token: 0x04039DB2 RID: 236978
			Text,
			// Token: 0x04039DB3 RID: 236979
			Button
		}
	}
}
