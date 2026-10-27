using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002823 RID: 10275
[NullableContext(1)]
[Nullable(0)]
public class RoleDevRootView : UiViewBase
{
	// Token: 0x06015243 RID: 86595 RVA: 0x00559836 File Offset: 0x00557A36
	public RoleDevRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015244 RID: 86596 RVA: 0x0055985C File Offset: 0x00557A5C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 23;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(22, new Action<EToggleState>(this.OnClickToggleRoleMark));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06015245 RID: 86597 RVA: 0x00559BC8 File Offset: 0x00557DC8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSelect));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
	}

	// Token: 0x06015246 RID: 86598 RVA: 0x00559C2C File Offset: 0x00557E2C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSelect));
		EventSystem.Instance.Remove(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
		EventSystem.Instance.Remove(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
	}

	// Token: 0x06015247 RID: 86599 RVA: 0x00559C90 File Offset: 0x00557E90
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevRootView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevRootView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015248 RID: 86600 RVA: 0x00559CD3 File Offset: 0x00557ED3
	protected override void OnStart()
	{
		this.HideRoleUiModel();
	}

	// Token: 0x06015249 RID: 86601 RVA: 0x00559CDC File Offset: 0x00557EDC
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		RoleDevRootView.<OnBeforeShowAsyncImplementImplement>d__27 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<RoleDevRootView.<OnBeforeShowAsyncImplementImplement>d__27>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0601524A RID: 86602 RVA: 0x00559D20 File Offset: 0x00557F20
	private void ShowRoleUiModel()
	{
		TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		if (roleSystemRoleActor == null)
		{
			return;
		}
		UiModelUtil.Instance.SetVisible(roleSystemRoleActor.Model, true);
		UiModelUtil.Instance.ModelFadeOut(roleSystemRoleActor.Model, new ERoleFadeCurveDefine?(ERoleFadeCurveDefine.TerminalSkinRoleFadeOutCurve), null);
	}

	// Token: 0x0601524B RID: 86603 RVA: 0x00559D6C File Offset: 0x00557F6C
	private void HideRoleUiModel()
	{
		TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		if (roleSystemRoleActor == null)
		{
			return;
		}
		UiModelUtil.Instance.SetDitherEffect(roleSystemRoleActor.Model, 0f);
		UiModelUtil.Instance.SetVisible(roleSystemRoleActor.Model, false);
	}

	// Token: 0x0601524C RID: 86604 RVA: 0x00559DB0 File Offset: 0x00557FB0
	private UniTask InitializeDevelopTagItem()
	{
		RoleDevRootView.<InitializeDevelopTagItem>d__30 <InitializeDevelopTagItem>d__;
		<InitializeDevelopTagItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeDevelopTagItem>d__.<>4__this = this;
		<InitializeDevelopTagItem>d__.<>1__state = -1;
		<InitializeDevelopTagItem>d__.<>t__builder.Start<RoleDevRootView.<InitializeDevelopTagItem>d__30>(ref <InitializeDevelopTagItem>d__);
		return <InitializeDevelopTagItem>d__.<>t__builder.Task;
	}

	// Token: 0x0601524D RID: 86605 RVA: 0x00559DF4 File Offset: 0x00557FF4
	private UniTask InitializeElementSuitItem()
	{
		RoleDevRootView.<InitializeElementSuitItem>d__31 <InitializeElementSuitItem>d__;
		<InitializeElementSuitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeElementSuitItem>d__.<>4__this = this;
		<InitializeElementSuitItem>d__.<>1__state = -1;
		<InitializeElementSuitItem>d__.<>t__builder.Start<RoleDevRootView.<InitializeElementSuitItem>d__31>(ref <InitializeElementSuitItem>d__);
		return <InitializeElementSuitItem>d__.<>t__builder.Task;
	}

	// Token: 0x0601524E RID: 86606 RVA: 0x00559E38 File Offset: 0x00558038
	private void OnRoleDevTargetRoleIdChange()
	{
		int devTargetRoleId = RoleDevModel.Instance.DevTargetRoleId;
		int tempRoleMarkRoleId = this.TempRoleMarkRoleId;
		if (devTargetRoleId != 0 && tempRoleMarkRoleId != devTargetRoleId)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RoleProject_Tips11", Array.Empty<object>());
		}
		else if (devTargetRoleId == 0 && tempRoleMarkRoleId != 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RoleProject_Tips13", Array.Empty<object>());
		}
		this.SetTempRoleMarkRoleId(devTargetRoleId);
		this.RefreshRoleMarkToggle(this.CurSelectRoleId);
		this.ConfigRoleLayout.RefreshWithoutDataSync();
	}

	// Token: 0x0601524F RID: 86607 RVA: 0x00559EAC File Offset: 0x005580AC
	protected void OnRoleSelect(int i)
	{
		this.RefreshCurrentTabView();
	}

	// Token: 0x06015250 RID: 86608 RVA: 0x00559EB4 File Offset: 0x005580B4
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> _)
	{
		this.UpdateTabList();
		this.RefreshCurrentTabView();
	}

	// Token: 0x06015251 RID: 86609 RVA: 0x00559EC2 File Offset: 0x005580C2
	private RoleDevMediumItemGrid OnGridProxyCreate()
	{
		RoleDevMediumItemGrid roleDevMediumItemGrid = new RoleDevMediumItemGrid();
		roleDevMediumItemGrid.BindOnExtendToggleStateChanged(delegate(MediumItemGridExtendCallback callbackParameter)
		{
			EToggleState state = callbackParameter.State;
			RoleDataBase data = callbackParameter.Data as RoleDataBase;
			this.OnRoleItemToggleChanged(state, data);
		});
		roleDevMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunctionForOwn));
		return roleDevMediumItemGrid;
	}

	// Token: 0x06015252 RID: 86610 RVA: 0x00559EF0 File Offset: 0x005580F0
	private UniTask InitializeCaption()
	{
		RoleDevRootView.<InitializeCaption>d__36 <InitializeCaption>d__;
		<InitializeCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeCaption>d__.<>4__this = this;
		<InitializeCaption>d__.<>1__state = -1;
		<InitializeCaption>d__.<>t__builder.Start<RoleDevRootView.<InitializeCaption>d__36>(ref <InitializeCaption>d__);
		return <InitializeCaption>d__.<>t__builder.Task;
	}

	// Token: 0x06015253 RID: 86611 RVA: 0x00559F33 File Offset: 0x00558133
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015254 RID: 86612 RVA: 0x00559F3C File Offset: 0x0055813C
	private UniTask InitializeLayouts()
	{
		RoleDevRootView.<InitializeLayouts>d__38 <InitializeLayouts>d__;
		<InitializeLayouts>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeLayouts>d__.<>4__this = this;
		<InitializeLayouts>d__.<>1__state = -1;
		<InitializeLayouts>d__.<>t__builder.Start<RoleDevRootView.<InitializeLayouts>d__38>(ref <InitializeLayouts>d__);
		return <InitializeLayouts>d__.<>t__builder.Task;
	}

	// Token: 0x06015255 RID: 86613 RVA: 0x00559F7F File Offset: 0x0055817F
	private void OnChangeFetterGroupSuccessCallBack(int roleId, int fetterGroupId)
	{
		RoleDevPhantomViewItemDataBase roleDevPhantomViewItemData = this.RoleDevViewModelInstance.RoleDevPhantomViewItemData;
		if (roleDevPhantomViewItemData != null)
		{
			roleDevPhantomViewItemData.RefreshSuitDataList();
		}
		this.RefreshCurrentTabView();
	}

	// Token: 0x06015256 RID: 86614 RVA: 0x00559FA0 File Offset: 0x005581A0
	private UniTask InitTabListAsync()
	{
		RoleDevRootView.<InitTabListAsync>d__40 <InitTabListAsync>d__;
		<InitTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTabListAsync>d__.<>4__this = this;
		<InitTabListAsync>d__.<>1__state = -1;
		<InitTabListAsync>d__.<>t__builder.Start<RoleDevRootView.<InitTabListAsync>d__40>(ref <InitTabListAsync>d__);
		return <InitTabListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015257 RID: 86615 RVA: 0x00559FE4 File Offset: 0x005581E4
	private void UpdateTabList()
	{
		RoleDevRoleViewItemDataBase roleDevRoleViewItemData = this.RoleDevViewModelInstance.RoleDevRoleViewItemData;
		RoleDevWeaponViewItemDataBase roleDevWeaponViewItemData = this.RoleDevViewModelInstance.RoleDevWeaponViewItemData;
		RoleDevSkillViewItemDataBase roleDevSkillViewItemData = this.RoleDevViewModelInstance.RoleDevSkillViewItemData;
		bool flag = RoleDevUtils.GetRoleTypeTagByRoleId(this.CurSelectRoleId) == global::ERoleTypeTag.Forecast;
		bool flag2 = RoleModel.Instance.IsRoleOwned(this.CurSelectRoleId);
		bool flag3 = flag || !flag2;
		foreach (global::IRoleDevRootTabData roleDevRootTabData in this.TabDataList)
		{
			switch (roleDevRootTabData.TabIndex)
			{
			case global::ERoleDevTabType.Role:
				roleDevRootTabData.TabIsUpgrade = (!flag3 && roleDevRoleViewItemData.IsAllMaterialEnough);
				roleDevRootTabData.TabIsFinish = (!flag3 && roleDevRoleViewItemData.IsFinish);
				break;
			case global::ERoleDevTabType.Weapon:
				roleDevRootTabData.TabIsUpgrade = (!flag3 && roleDevWeaponViewItemData.DevItemData.IsAllMaterialEnough && roleDevWeaponViewItemData.IsWeaponHighQuality);
				roleDevRootTabData.TabIsFinish = (!flag3 && roleDevWeaponViewItemData.DevItemData.IsFinish);
				break;
			case global::ERoleDevTabType.Phantom:
				roleDevRootTabData.TabIsUpgrade = false;
				roleDevRootTabData.TabIsFinish = false;
				break;
			case global::ERoleDevTabType.Skill:
				roleDevRootTabData.TabIsUpgrade = (!flag3 && roleDevSkillViewItemData.IsCurrentPlanAllMaterialEnough);
				roleDevRootTabData.TabIsFinish = (!flag3 && roleDevSkillViewItemData.IsPerfectPlanFinished);
				break;
			}
		}
		this.TabItemLayout.RefreshWithoutDataSync();
	}

	// Token: 0x06015258 RID: 86616 RVA: 0x0055A158 File Offset: 0x00558358
	private RoleDevSelectionMediumItemGrid InitNewRoleItem()
	{
		RoleDevSelectionMediumItemGrid roleDevSelectionMediumItemGrid = new RoleDevSelectionMediumItemGrid();
		roleDevSelectionMediumItemGrid.BindOnExtendToggleStateChanged(delegate(MediumItemGridExtendCallback callbackParameter)
		{
			EToggleState state = callbackParameter.State;
			RoleDisplayModelBase data = callbackParameter.Data as RoleDisplayModelBase;
			this.OnNewRoleItemToggleChanged(state, data);
		});
		roleDevSelectionMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunctionForNew));
		return roleDevSelectionMediumItemGrid;
	}

	// Token: 0x06015259 RID: 86617 RVA: 0x0055A183 File Offset: 0x00558383
	private void OnPlanChangeCallback(RoleDevSkillViewItemDataBase data)
	{
		this.UpdateTabList();
	}

	// Token: 0x0601525A RID: 86618 RVA: 0x0055A18C File Offset: 0x0055838C
	private void UpdateList(List<RoleDataBase> list, bool isOutSideChange, EFilterSortType operationType)
	{
		List<RoleDataBase> list2 = this.SortPinnedRolesToFront(list);
		this.RoleDevViewModelInstance.SetRoleDataList(list2);
		this.RestoreOwnListSelection(list2, isOutSideChange, operationType);
	}

	// Token: 0x0601525B RID: 86619 RVA: 0x0055A1B8 File Offset: 0x005583B8
	private List<RoleDataBase> SortPinnedRolesToFront(List<RoleDataBase> roleList)
	{
		int devTargetRoleId = RoleDevModel.Instance.DevTargetRoleId;
		if (devTargetRoleId == 0)
		{
			return roleList;
		}
		List<RoleDataBase> list = new List<RoleDataBase>();
		List<RoleDataBase> list2 = new List<RoleDataBase>();
		foreach (RoleDataBase roleDataBase in roleList)
		{
			if (roleDataBase.GetRoleId() == devTargetRoleId)
			{
				list.Add(roleDataBase);
			}
			else
			{
				list2.Add(roleDataBase);
			}
		}
		List<RoleDataBase> list3 = new List<RoleDataBase>();
		list3.AddRange(list);
		list3.AddRange(list2);
		return list3;
	}

	// Token: 0x0601525C RID: 86620 RVA: 0x0055A250 File Offset: 0x00558450
	private void RestoreOwnListSelection(List<RoleDataBase> roleList, bool isOutSideChange, EFilterSortType operationType)
	{
		if (this.FilterSortEntranceRefreshLock)
		{
			return;
		}
		this.ConfigRoleLayout.RefreshByData(roleList, delegate
		{
			if (this.CurSelectRoleListType == global::ERoleListType.OwnList)
			{
				this.ConfigRoleLayout.SelectGridProxyByKey(this.CurSelectRoleId, false);
			}
		}, true);
	}

	// Token: 0x0601525D RID: 86621 RVA: 0x0055A274 File Offset: 0x00558474
	private global::ERoleDevTabType GetTargetTabType()
	{
		if (!RoleModel.Instance.IsRoleOwned(this.CurSelectRoleId))
		{
			return global::ERoleDevTabType.Role;
		}
		if (this.RoleDevViewModelInstance.RoleDevRoleViewItemData == null || !this.RoleDevViewModelInstance.RoleDevRoleViewItemData.RoleLevelIsMax)
		{
			return global::ERoleDevTabType.Role;
		}
		if (this.RoleDevViewModelInstance.RoleDevWeaponViewItemData == null || !this.RoleDevViewModelInstance.RoleDevWeaponViewItemData.DevItemData.WeaponIsMaxLevel)
		{
			return global::ERoleDevTabType.Weapon;
		}
		return global::ERoleDevTabType.Phantom;
	}

	// Token: 0x0601525E RID: 86622 RVA: 0x0055A2E0 File Offset: 0x005584E0
	private void UpdatePropertyText(int roleId)
	{
		UUIText text = base.GetText(9);
		if (RoleDevUtils.GetRoleTypeTagByRoleId(roleId) == global::ERoleTypeTag.Forecast)
		{
			if (text != null)
			{
				text.SetUIActive(false);
			}
			return;
		}
		RoleDevProject? roleDevProjectConfig = RoleDevConfig.Instance.GetRoleDevProjectConfig(roleId);
		if (roleDevProjectConfig == null || roleDevProjectConfig.Value.KeyProperty == 0)
		{
			if (text != null)
			{
				text.SetUIActive(false);
			}
			return;
		}
		PropertyIndex? propertyIndexConfigByIndex = RoleDevConfig.Instance.GetPropertyIndexConfigByIndex(roleDevProjectConfig.Value.KeyProperty);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		string text2;
		if (roleDevProjectConfig.Value.PropertyValue(0) != 1)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<double>((double)roleDevProjectConfig.Value.PropertyValue(1) / 100.0, "F1");
			defaultInterpolatedStringHandler.AppendLiteral("%");
			text2 = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			text2 = roleDevProjectConfig.Value.PropertyValue(1).ToString();
		}
		string str = text2;
		string text3 = ConfigMultiTextLang.GetLocalTextNew(propertyIndexConfigByIndex.Value.Name, null) + " " + str;
		string newText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("RoleProject_TargetProperty", null), new string[]
		{
			text3
		});
		if (text != null)
		{
			text.SetText(newText, true);
		}
	}

	// Token: 0x0601525F RID: 86623 RVA: 0x0055A424 File Offset: 0x00558624
	private void SelectRoleByRoleDataBase(RoleDataBase roleData)
	{
		this.SelectRole(roleData.GetRoleConfig().Id, global::ERoleListType.OwnList);
	}

	// Token: 0x06015260 RID: 86624 RVA: 0x0055A446 File Offset: 0x00558646
	private void SelectRoleByDisplayModelData(RoleDisplayModelBase roleData)
	{
		this.SelectRole(roleData.Id, global::ERoleListType.NewList);
	}

	// Token: 0x06015261 RID: 86625 RVA: 0x0055A458 File Offset: 0x00558658
	private void SelectRole(int roleId, global::ERoleListType listType)
	{
		if (listType == global::ERoleListType.OwnList)
		{
			this.ConfigRoleLayout.SelectGridProxyByKey(roleId, false);
		}
		else if (this.RoleDevViewModelInstance.HotRoleDataList.FindIndex((RoleDisplayModelBase data) => data.Id == roleId) != -1)
		{
			this.NewRoleLayout.SelectGridProxyByKey(roleId, false);
		}
		this.UpdateRoleViewAfterSelect(roleId, listType);
		this.UpdateTabList();
		this.UpdateTabStates(this.CurSelectTab);
		this.SelectTabByTabType(this.CurSelectTab);
	}

	// Token: 0x06015262 RID: 86626 RVA: 0x0055A4F0 File Offset: 0x005586F0
	private void SetDevelopTag(int roleId, global::ERoleListType listType)
	{
		if (this.DevelopTagItem == null)
		{
			return;
		}
		global::ERoleTypeTag data;
		if (listType == global::ERoleListType.OwnList)
		{
			data = RoleDevUtils.GetRoleTypeTagByRoleId(roleId);
		}
		else
		{
			RoleDisplayModelBase roleDisplayModelBase = this.RoleDevViewModelInstance.HotRoleDataList.Find((RoleDisplayModelBase model) => model.Id == roleId);
			data = ((roleDisplayModelBase != null) ? roleDisplayModelBase.TypeTag : global::ERoleTypeTag.None);
		}
		this.DevelopTagItem.SetData(data);
	}

	// Token: 0x06015263 RID: 86627 RVA: 0x0055A55B File Offset: 0x0055875B
	private void UpdateRoleViewAfterSelect(int roleId, global::ERoleListType listType)
	{
		this.SetRoleData(roleId, listType);
		this.RefreshRoleName(roleId);
		this.RefreshRoleTexture(roleId);
		this.RefreshElementIcon(roleId);
		this.SetDevelopTag(roleId, listType);
		this.UpdatePropertyText(roleId);
		this.RefreshRoleMarkToggle(roleId);
		this.RefreshCurrentTabView();
	}

	// Token: 0x06015264 RID: 86628 RVA: 0x0055A598 File Offset: 0x00558798
	private void RefreshRoleMarkToggle(int roleId)
	{
		this.RefreshRoleMarkToggleActive(roleId);
		this.RefreshRoleMarkToggleByTempData(null);
	}

	// Token: 0x06015265 RID: 86629 RVA: 0x0055A5BC File Offset: 0x005587BC
	private void RefreshCurrentTabView()
	{
		switch (this.CurSelectTab)
		{
		case global::ERoleDevTabType.Role:
		{
			RoleDevRoleViewItemDataBase roleDevRoleViewItemData = this.RoleDevViewModelInstance.RoleDevRoleViewItemData;
			if (roleDevRoleViewItemData != null)
			{
				RoleDevRoleViewItem roleViewItem = this.RoleViewItem;
				if (roleViewItem == null)
				{
					return;
				}
				roleViewItem.Refresh(roleDevRoleViewItemData);
				return;
			}
			break;
		}
		case global::ERoleDevTabType.Weapon:
		{
			RoleDevWeaponViewItemDataBase roleDevWeaponViewItemData = this.RoleDevViewModelInstance.RoleDevWeaponViewItemData;
			if (roleDevWeaponViewItemData != null)
			{
				RoleDevWeaponViewItem weaponViewItem = this.WeaponViewItem;
				if (weaponViewItem == null)
				{
					return;
				}
				weaponViewItem.RefreshByData(roleDevWeaponViewItemData);
				return;
			}
			break;
		}
		case global::ERoleDevTabType.Phantom:
		{
			RoleDevPhantomViewItemDataBase roleDevPhantomViewItemData = this.RoleDevViewModelInstance.RoleDevPhantomViewItemData;
			if (roleDevPhantomViewItemData != null)
			{
				RoleDevPhantomViewItem phantomViewItem = this.PhantomViewItem;
				if (phantomViewItem == null)
				{
					return;
				}
				phantomViewItem.Refresh(roleDevPhantomViewItemData);
				return;
			}
			break;
		}
		case global::ERoleDevTabType.Skill:
		{
			RoleDevSkillViewItemDataBase roleDevSkillViewItemData = this.RoleDevViewModelInstance.RoleDevSkillViewItemData;
			if (roleDevSkillViewItemData != null)
			{
				RoleDevSkillViewItem skillViewItem = this.SkillViewItem;
				if (skillViewItem == null)
				{
					return;
				}
				skillViewItem.Refresh(roleDevSkillViewItemData);
			}
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06015266 RID: 86630 RVA: 0x0055A66D File Offset: 0x0055886D
	private void SetRoleData(int roleId, global::ERoleListType type)
	{
		this.SetCurSelectRoleId(roleId);
		this.RoleDevViewModelInstance.InitAllDevItemDataByRoleId(roleId);
	}

	// Token: 0x06015267 RID: 86631 RVA: 0x0055A684 File Offset: 0x00558884
	private void OnRoleItemToggleChanged(EToggleState state, RoleDataBase data)
	{
		if (state == EToggleState.ETT_Checked)
		{
			int id = data.GetRoleConfig().Id;
			GenericLayout<RoleDevSelectionMediumItemGrid, RoleDisplayModelBase> newRoleLayout = this.NewRoleLayout;
			if (newRoleLayout != null)
			{
				newRoleLayout.DeselectCurrentGridProxy();
			}
			GenericLayout<RoleDevMediumItemGrid, RoleDataBase> configRoleLayout = this.ConfigRoleLayout;
			if (configRoleLayout != null)
			{
				configRoleLayout.DeselectCurrentGridProxy();
			}
			this.SelectRoleInLayout(id, global::ERoleListType.OwnList);
			this.PlayTabItemAnimation(this.CurSelectTab);
			this.UiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}
	}

	// Token: 0x06015268 RID: 86632 RVA: 0x0055A6F4 File Offset: 0x005588F4
	private void OnNewRoleItemToggleChanged(EToggleState state, RoleDisplayModelBase data)
	{
		if (state == EToggleState.ETT_Checked)
		{
			int id = data.Id;
			GenericLayout<RoleDevSelectionMediumItemGrid, RoleDisplayModelBase> newRoleLayout = this.NewRoleLayout;
			if (newRoleLayout != null)
			{
				newRoleLayout.DeselectCurrentGridProxy();
			}
			GenericLayout<RoleDevMediumItemGrid, RoleDataBase> configRoleLayout = this.ConfigRoleLayout;
			if (configRoleLayout != null)
			{
				configRoleLayout.DeselectCurrentGridProxy();
			}
			this.SelectRoleInLayout(id, global::ERoleListType.NewList);
			this.PlayTabItemAnimation(this.CurSelectTab);
			this.UiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}
	}

	// Token: 0x06015269 RID: 86633 RVA: 0x0055A75C File Offset: 0x0055895C
	private void SelectRoleInLayout(int roleId, global::ERoleListType fromListType)
	{
		this.SetCurSelectRoleId(roleId);
		this.SetCurSelectRoleListType(fromListType);
		if (fromListType == global::ERoleListType.OwnList)
		{
			RoleDataBase roleDataBase = this.RoleDevViewModelInstance.RoleDataList.Find((RoleDataBase data) => data.GetRoleConfig().Id == roleId);
			if (roleDataBase != null)
			{
				this.SelectRoleByRoleDataBase(roleDataBase);
				return;
			}
		}
		else
		{
			RoleDisplayModelBase roleDisplayModelBase = this.RoleDevViewModelInstance.HotRoleDataList.Find((RoleDisplayModelBase model) => model.Id == roleId);
			if (roleDisplayModelBase != null)
			{
				this.SelectRoleByDisplayModelData(roleDisplayModelBase);
			}
		}
	}

	// Token: 0x0601526A RID: 86634 RVA: 0x0055A7DC File Offset: 0x005589DC
	private bool CanExecuteChangeFunctionForOwn(object data, bool isForceSelected, EToggleState state)
	{
		int id = (data as RoleDataBase).GetRoleConfig().Id;
		return state != EToggleState.ETT_Checked || this.CurSelectRoleListType != global::ERoleListType.OwnList || this.CurSelectRoleId != id;
	}

	// Token: 0x0601526B RID: 86635 RVA: 0x0055A818 File Offset: 0x00558A18
	private bool CanExecuteChangeFunctionForNew(object data, bool isForceSelected, EToggleState state)
	{
		int id = (data as RoleDisplayModelBase).Id;
		return state != EToggleState.ETT_Checked || this.CurSelectRoleListType != global::ERoleListType.NewList || this.CurSelectRoleId != id;
	}

	// Token: 0x0601526C RID: 86636 RVA: 0x0055A84C File Offset: 0x00558A4C
	private RoleDevRootTabItem InitTabItem()
	{
		RoleDevRootTabItem roleDevRootTabItem = new RoleDevRootTabItem();
		roleDevRootTabItem.OnClickToggleCallBack = new Action<int>(this.OnClickTabItem);
		roleDevRootTabItem.CanClickCallBack = new Func<int, EToggleState, bool>(this.CanClickTabItem);
		this.TabItems.Add(roleDevRootTabItem);
		return roleDevRootTabItem;
	}

	// Token: 0x0601526D RID: 86637 RVA: 0x0055A890 File Offset: 0x00558A90
	private void OnClickTabItem(int tabType)
	{
		this.SelectTabByTabType((global::ERoleDevTabType)tabType);
		this.PlayTabItemAnimation((global::ERoleDevTabType)tabType);
	}

	// Token: 0x0601526E RID: 86638 RVA: 0x0055A8A0 File Offset: 0x00558AA0
	private bool CanClickTabItem(int tabType, EToggleState toggleState)
	{
		return this.CurSelectTabInternal == null || tabType != (int)this.CurSelectTabInternal.Value || toggleState != EToggleState.ETT_Checked;
	}

	// Token: 0x0601526F RID: 86639 RVA: 0x0055A8C8 File Offset: 0x00558AC8
	private void SelectTabByTabType(global::ERoleDevTabType tabType)
	{
		this.SetCurSelectTab((int)tabType);
		this.RefreshTabPanel(tabType);
		ERoleDevMainPage mainPage = RoleDevDefine.tabTypeToMainPageMap[(CSharpScript.Game.Module.RoleDev.ERoleDevTabType)tabType];
		RoleDevController.Instance.LogRoleDevPageClick(this.CurSelectRoleId, mainPage);
	}

	// Token: 0x06015270 RID: 86640 RVA: 0x0055A900 File Offset: 0x00558B00
	private void PlayTabItemAnimation(global::ERoleDevTabType tabType)
	{
		switch (tabType)
		{
		case global::ERoleDevTabType.Role:
			this.PlayRoleViewAnimation();
			return;
		case global::ERoleDevTabType.Weapon:
			this.PlayWeaponViewAnimation();
			return;
		case global::ERoleDevTabType.Phantom:
			this.PlayPhantomViewAnimation();
			return;
		case global::ERoleDevTabType.Skill:
			this.PlaySkillViewAnimation();
			return;
		default:
			return;
		}
	}

	// Token: 0x06015271 RID: 86641 RVA: 0x0055A934 File Offset: 0x00558B34
	private void PlayRoleViewAnimation()
	{
		RoleDevRoleViewItem roleViewItem = this.RoleViewItem;
		if (roleViewItem == null)
		{
			return;
		}
		UiBehaviorLevelSequence uiViewSequence = roleViewItem.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x06015272 RID: 86642 RVA: 0x0055A96C File Offset: 0x00558B6C
	private void PlayWeaponViewAnimation()
	{
		RoleDevWeaponViewItem weaponViewItem = this.WeaponViewItem;
		if (weaponViewItem == null)
		{
			return;
		}
		UiBehaviorLevelSequence uiViewSequence = weaponViewItem.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x06015273 RID: 86643 RVA: 0x0055A9A4 File Offset: 0x00558BA4
	private void PlayPhantomViewAnimation()
	{
		RoleDevPhantomViewItem phantomViewItem = this.PhantomViewItem;
		if (phantomViewItem == null)
		{
			return;
		}
		UiBehaviorLevelSequence uiViewSequence = phantomViewItem.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x06015274 RID: 86644 RVA: 0x0055A9DC File Offset: 0x00558BDC
	private void PlaySkillViewAnimation()
	{
		RoleDevSkillViewItem skillViewItem = this.SkillViewItem;
		if (skillViewItem == null)
		{
			return;
		}
		UiBehaviorLevelSequence uiViewSequence = skillViewItem.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x06015275 RID: 86645 RVA: 0x0055AA12 File Offset: 0x00558C12
	private void RefreshTabPanel(global::ERoleDevTabType index)
	{
		this.UpdateTabStates(index);
		this.RefreshContentByTab();
	}

	// Token: 0x06015276 RID: 86646 RVA: 0x0055AA21 File Offset: 0x00558C21
	private void UpdateTabStates(global::ERoleDevTabType activeIndex)
	{
		GenericLayout<RoleDevRootTabItem, global::IRoleDevRootTabData> tabItemLayout = this.TabItemLayout;
		if (tabItemLayout == null)
		{
			return;
		}
		tabItemLayout.SelectGridProxy((int)activeIndex, false);
	}

	// Token: 0x06015277 RID: 86647 RVA: 0x0055AA38 File Offset: 0x00558C38
	private void RefreshContentByTab()
	{
		bool flag = RoleDevUtils.GetRoleTypeTagByRoleId(this.CurSelectRoleId) == global::ERoleTypeTag.Forecast;
		base.GetItem(21).SetUIActive(!flag);
		global::ERoleDevTabType curSelectTab = this.CurSelectTab;
		bool flag2 = curSelectTab == global::ERoleDevTabType.Role;
		base.GetItem(13).SetUIActive(flag2);
		base.GetItem(14).SetUIActive(flag2);
		RoleDevRoleViewItem roleViewItem = this.RoleViewItem;
		if (roleViewItem != null)
		{
			roleViewItem.SetUiActive(flag2);
		}
		bool flag3 = curSelectTab == global::ERoleDevTabType.Weapon;
		base.GetItem(17).SetUIActive(flag3);
		base.GetItem(18).SetUIActive(flag3);
		RoleDevWeaponViewItem weaponViewItem = this.WeaponViewItem;
		if (weaponViewItem != null)
		{
			weaponViewItem.SetUiActive(flag3);
		}
		bool flag4 = curSelectTab == global::ERoleDevTabType.Phantom;
		if (flag && flag4)
		{
			base.GetItem(19).SetUIActive(false);
			base.GetItem(20).SetUIActive(false);
			RoleDevPhantomViewItem phantomViewItem = this.PhantomViewItem;
			if (phantomViewItem != null)
			{
				phantomViewItem.SetUiActive(false);
			}
			base.GetItem(21).SetUIActive(true);
		}
		else
		{
			base.GetItem(19).SetUIActive(flag4);
			base.GetItem(20).SetUIActive(flag4);
			RoleDevPhantomViewItem phantomViewItem2 = this.PhantomViewItem;
			if (phantomViewItem2 != null)
			{
				phantomViewItem2.SetUiActive(flag4);
			}
			base.GetItem(21).SetUIActive(false);
		}
		bool flag5 = curSelectTab == global::ERoleDevTabType.Skill;
		base.GetItem(15).SetUIActive(flag5);
		base.GetItem(16).SetUIActive(flag5);
		RoleDevSkillViewItem skillViewItem = this.SkillViewItem;
		if (skillViewItem != null)
		{
			skillViewItem.SetUiActive(flag5);
		}
		this.RefreshCurrentTabView();
	}

	// Token: 0x06015278 RID: 86648 RVA: 0x0055AB94 File Offset: 0x00558D94
	private void RefreshRoleName(int roleId)
	{
		if (RoleDevUtils.GetRoleTypeTagByRoleId(roleId) == global::ERoleTypeTag.Forecast)
		{
			IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(roleId);
			base.GetText(6).SetText(roleDevProsProjectConfig.RoleName, true);
			return;
		}
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(roleId).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), value.Name, Array.Empty<object>());
	}

	// Token: 0x06015279 RID: 86649 RVA: 0x0055AC00 File Offset: 0x00558E00
	private void RefreshRoleTexture(int roleId)
	{
		UUITexture texture = base.GetTexture(5);
		if (RoleDevUtils.GetRoleTypeTagByRoleId(roleId) == global::ERoleTypeTag.Forecast)
		{
			string roleHeadIconSmall = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(roleId).RoleHeadIconSmall;
			base.SetTextureByPath(roleHeadIconSmall, texture, null, null);
			return;
		}
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(roleId).Value;
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleId);
		int value2 = (roleInstanceById != null) ? roleInstanceById.GetRoleSkinId() : 0;
		base.SetRoleIconByRoleIdOrSkinId(value.RoleHeadIcon, texture, roleId, new int?(value2), null, null);
	}

	// Token: 0x0601527A RID: 86650 RVA: 0x0055AC94 File Offset: 0x00558E94
	private void RefreshRoleMarkToggleActive(int roleId)
	{
		bool uiactive = RoleModel.Instance.IsRoleOwned(roleId);
		base.GetExtendToggle(22).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x0601527B RID: 86651 RVA: 0x0055ACC8 File Offset: 0x00558EC8
	private void OnClickToggleRoleMark(EToggleState toggleState)
	{
		int curSelectRoleId = this.CurSelectRoleId;
		if (RoleModel.Instance.IsRoleOwned(curSelectRoleId))
		{
			int num;
			if (this.TempRoleMarkRoleId == curSelectRoleId)
			{
				num = 0;
			}
			else
			{
				num = curSelectRoleId;
			}
			RoleDevController.Instance.RequestRecordRoleMarkOperation(num);
			this.RefreshRoleMarkToggleByTempData(new int?(num));
		}
	}

	// Token: 0x0601527C RID: 86652 RVA: 0x0055AD11 File Offset: 0x00558F11
	private void SetTempRoleMarkRoleId(int roleId)
	{
		this.TempRoleMarkRoleIdInternal = roleId;
	}

	// Token: 0x0601527D RID: 86653 RVA: 0x0055AD1C File Offset: 0x00558F1C
	private void RefreshRoleMarkToggleByTempData(int? expectedMarkRoleId = null)
	{
		int curSelectRoleId = this.CurSelectRoleId;
		this.SetRoleMarkToggleState(((expectedMarkRoleId ?? this.TempRoleMarkRoleId) == curSelectRoleId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
	}

	// Token: 0x0601527E RID: 86654 RVA: 0x0055AD5B File Offset: 0x00558F5B
	private void SetRoleMarkToggleState(EToggleState state)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(22);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x0601527F RID: 86655 RVA: 0x0055AD74 File Offset: 0x00558F74
	private void RefreshElementIcon(int roleId)
	{
		if (RoleDevUtils.GetRoleTypeTagByRoleId(roleId) != global::ERoleTypeTag.Forecast)
		{
			int elementId = RoleConfig.Instance.GetRoleConfig(roleId).Value.ElementId;
			CommonElementItem elementSuitItem = this.ElementSuitItem;
			if (elementSuitItem == null)
			{
				return;
			}
			elementSuitItem.Refresh(elementId, false, 0);
			return;
		}
		else
		{
			int elementId2 = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(roleId).ElementId;
			CommonElementItem elementSuitItem2 = this.ElementSuitItem;
			if (elementSuitItem2 == null)
			{
				return;
			}
			elementSuitItem2.Refresh(elementId2, false, 0);
			return;
		}
	}

	// Token: 0x06015280 RID: 86656 RVA: 0x0055ADE0 File Offset: 0x00558FE0
	public void SetCurSelectRoleId(int roleId)
	{
		this.CurSelectRoleIdInternal = roleId;
	}

	// Token: 0x06015281 RID: 86657 RVA: 0x0055ADE9 File Offset: 0x00558FE9
	public void SetCurSelectTab(int value)
	{
		this.CurSelectTabInternal = new global::ERoleDevTabType?((global::ERoleDevTabType)value);
	}

	// Token: 0x06015282 RID: 86658 RVA: 0x0055ADF7 File Offset: 0x00558FF7
	public void SetCurSelectRoleListType(global::ERoleListType value)
	{
		this.CurSelectRoleListTypeInternal = value;
	}

	// Token: 0x06015283 RID: 86659 RVA: 0x0055AE00 File Offset: 0x00559000
	public void SetIsFirstEnter(bool value)
	{
		this.IsFirstEnterInternal = value;
	}

	// Token: 0x17001C05 RID: 7173
	// (get) Token: 0x06015284 RID: 86660 RVA: 0x0055AE09 File Offset: 0x00559009
	public global::ERoleDevTabType CurSelectTab
	{
		get
		{
			return this.CurSelectTabInternal.Value;
		}
	}

	// Token: 0x17001C06 RID: 7174
	// (get) Token: 0x06015285 RID: 86661 RVA: 0x0055AE16 File Offset: 0x00559016
	public int CurSelectRoleId
	{
		get
		{
			return this.CurSelectRoleIdInternal;
		}
	}

	// Token: 0x17001C07 RID: 7175
	// (get) Token: 0x06015286 RID: 86662 RVA: 0x0055AE1E File Offset: 0x0055901E
	public global::ERoleListType CurSelectRoleListType
	{
		get
		{
			return this.CurSelectRoleListTypeInternal;
		}
	}

	// Token: 0x17001C08 RID: 7176
	// (get) Token: 0x06015287 RID: 86663 RVA: 0x0055AE26 File Offset: 0x00559026
	public bool IsFirstEnter
	{
		get
		{
			return this.IsFirstEnterInternal;
		}
	}

	// Token: 0x17001C09 RID: 7177
	// (get) Token: 0x06015288 RID: 86664 RVA: 0x0055AE2E File Offset: 0x0055902E
	public int TempRoleMarkRoleId
	{
		get
		{
			return this.TempRoleMarkRoleIdInternal;
		}
	}

	// Token: 0x06015289 RID: 86665 RVA: 0x0055AE36 File Offset: 0x00559036
	public void ClearCache()
	{
		this.CurSelectRoleIdInternal = 0;
		this.CurSelectTabInternal = null;
		this.TempRoleMarkRoleIdInternal = 0;
	}

	// Token: 0x0601528A RID: 86666 RVA: 0x0055AE52 File Offset: 0x00559052
	protected override void OnBeforeDestroy()
	{
		this.ShowRoleUiModel();
		this.ClearCache();
	}

	// Token: 0x04009E6B RID: 40555
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevMediumItemGrid, RoleDataBase> ConfigRoleLayout;

	// Token: 0x04009E6C RID: 40556
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevSelectionMediumItemGrid, RoleDisplayModelBase> NewRoleLayout;

	// Token: 0x04009E6D RID: 40557
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevRootTabItem, global::IRoleDevRootTabData> TabItemLayout;

	// Token: 0x04009E6E RID: 40558
	[Nullable(2)]
	private RoleDevRoleViewItem RoleViewItem;

	// Token: 0x04009E6F RID: 40559
	[Nullable(2)]
	private RoleDevWeaponViewItem WeaponViewItem;

	// Token: 0x04009E70 RID: 40560
	[Nullable(2)]
	private RoleDevPhantomViewItem PhantomViewItem;

	// Token: 0x04009E71 RID: 40561
	[Nullable(2)]
	private RoleDevSkillViewItem SkillViewItem;

	// Token: 0x04009E72 RID: 40562
	[Nullable(2)]
	private PopupCaptionItem ItemCaption;

	// Token: 0x04009E73 RID: 40563
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntranceInstance;

	// Token: 0x04009E74 RID: 40564
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::IRoleDevRootTabData> TabDataList;

	// Token: 0x04009E75 RID: 40565
	private readonly List<RoleDevRootTabItem> TabItems = new List<RoleDevRootTabItem>();

	// Token: 0x04009E76 RID: 40566
	private readonly RoleDevViewModel RoleDevViewModelInstance = new RoleDevViewModel();

	// Token: 0x04009E77 RID: 40567
	[Nullable(2)]
	private RoleDevTagItem DevelopTagItem;

	// Token: 0x04009E78 RID: 40568
	[Nullable(2)]
	private CommonElementItem ElementSuitItem;

	// Token: 0x04009E79 RID: 40569
	private int CurSelectRoleIdInternal;

	// Token: 0x04009E7A RID: 40570
	private global::ERoleDevTabType? CurSelectTabInternal;

	// Token: 0x04009E7B RID: 40571
	private global::ERoleListType CurSelectRoleListTypeInternal;

	// Token: 0x04009E7C RID: 40572
	private bool IsFirstEnterInternal = true;

	// Token: 0x04009E7D RID: 40573
	private int TempRoleMarkRoleIdInternal;

	// Token: 0x04009E7E RID: 40574
	private bool FilterSortEntranceRefreshLock;

	// Token: 0x02008E6A RID: 36458
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E312 RID: 189202
		Caption,
		// Token: 0x0402E313 RID: 189203
		GridNewRole,
		// Token: 0x0402E314 RID: 189204
		GridOwnRole,
		// Token: 0x0402E315 RID: 189205
		RoleItem,
		// Token: 0x0402E316 RID: 189206
		FilterSortItem,
		// Token: 0x0402E317 RID: 189207
		TextureRole,
		// Token: 0x0402E318 RID: 189208
		TxtRoleName,
		// Token: 0x0402E319 RID: 189209
		Tag,
		// Token: 0x0402E31A RID: 189210
		DevelopTag,
		// Token: 0x0402E31B RID: 189211
		TxtProperty,
		// Token: 0x0402E31C RID: 189212
		ElementIcon,
		// Token: 0x0402E31D RID: 189213
		ToggleLayout,
		// Token: 0x0402E31E RID: 189214
		DevelopToggle,
		// Token: 0x0402E31F RID: 189215
		SubRoleViewLayout,
		// Token: 0x0402E320 RID: 189216
		SubRoleViewScrollView,
		// Token: 0x0402E321 RID: 189217
		SubSkillViewLayout,
		// Token: 0x0402E322 RID: 189218
		SubSkillViewScrollView,
		// Token: 0x0402E323 RID: 189219
		SubWeaponViewLayout,
		// Token: 0x0402E324 RID: 189220
		SubWeaponViewScrollView,
		// Token: 0x0402E325 RID: 189221
		SubPhantomViewLayout,
		// Token: 0x0402E326 RID: 189222
		SubPhantomViewScrollView,
		// Token: 0x0402E327 RID: 189223
		EmptyPanel,
		// Token: 0x0402E328 RID: 189224
		ToggleRoleMark
	}
}
