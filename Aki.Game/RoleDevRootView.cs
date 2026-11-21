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

// Token: 0x02001D9E RID: 7582
[NullableContext(1)]
[Nullable(0)]
public class RoleDevRootView : UiViewBase
{
	// Token: 0x06012C41 RID: 76865 RVA: 0x0058454A File Offset: 0x0058274A
	public RoleDevRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012C42 RID: 76866 RVA: 0x00584570 File Offset: 0x00582770
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

	// Token: 0x06012C43 RID: 76867 RVA: 0x005848DC File Offset: 0x00582ADC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSelect));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
	}

	// Token: 0x06012C44 RID: 76868 RVA: 0x00584940 File Offset: 0x00582B40
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSelect));
		EventSystem.Instance.Remove(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
		EventSystem.Instance.Remove(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
	}

	// Token: 0x06012C45 RID: 76869 RVA: 0x005849A4 File Offset: 0x00582BA4
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevRootView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevRootView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012C46 RID: 76870 RVA: 0x005849E7 File Offset: 0x00582BE7
	protected override void OnStart()
	{
		this.HideRoleUiModel();
	}

	// Token: 0x06012C47 RID: 76871 RVA: 0x005849F0 File Offset: 0x00582BF0
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		RoleDevRootView.<OnBeforeShowAsyncImplementImplement>d__27 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<RoleDevRootView.<OnBeforeShowAsyncImplementImplement>d__27>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06012C48 RID: 76872 RVA: 0x00584A34 File Offset: 0x00582C34
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

	// Token: 0x06012C49 RID: 76873 RVA: 0x00584A80 File Offset: 0x00582C80
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

	// Token: 0x06012C4A RID: 76874 RVA: 0x00584AC4 File Offset: 0x00582CC4
	private UniTask InitializeDevelopTagItem()
	{
		RoleDevRootView.<InitializeDevelopTagItem>d__30 <InitializeDevelopTagItem>d__;
		<InitializeDevelopTagItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeDevelopTagItem>d__.<>4__this = this;
		<InitializeDevelopTagItem>d__.<>1__state = -1;
		<InitializeDevelopTagItem>d__.<>t__builder.Start<RoleDevRootView.<InitializeDevelopTagItem>d__30>(ref <InitializeDevelopTagItem>d__);
		return <InitializeDevelopTagItem>d__.<>t__builder.Task;
	}

	// Token: 0x06012C4B RID: 76875 RVA: 0x00584B08 File Offset: 0x00582D08
	private UniTask InitializeElementSuitItem()
	{
		RoleDevRootView.<InitializeElementSuitItem>d__31 <InitializeElementSuitItem>d__;
		<InitializeElementSuitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeElementSuitItem>d__.<>4__this = this;
		<InitializeElementSuitItem>d__.<>1__state = -1;
		<InitializeElementSuitItem>d__.<>t__builder.Start<RoleDevRootView.<InitializeElementSuitItem>d__31>(ref <InitializeElementSuitItem>d__);
		return <InitializeElementSuitItem>d__.<>t__builder.Task;
	}

	// Token: 0x06012C4C RID: 76876 RVA: 0x00584B4C File Offset: 0x00582D4C
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

	// Token: 0x06012C4D RID: 76877 RVA: 0x00584BC0 File Offset: 0x00582DC0
	protected void OnRoleSelect(int i)
	{
		this.RefreshCurrentTabView();
	}

	// Token: 0x06012C4E RID: 76878 RVA: 0x00584BC8 File Offset: 0x00582DC8
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> _)
	{
		this.UpdateTabList();
		this.RefreshCurrentTabView();
	}

	// Token: 0x06012C4F RID: 76879 RVA: 0x00584BD6 File Offset: 0x00582DD6
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

	// Token: 0x06012C50 RID: 76880 RVA: 0x00584C04 File Offset: 0x00582E04
	private UniTask InitializeCaption()
	{
		RoleDevRootView.<InitializeCaption>d__36 <InitializeCaption>d__;
		<InitializeCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeCaption>d__.<>4__this = this;
		<InitializeCaption>d__.<>1__state = -1;
		<InitializeCaption>d__.<>t__builder.Start<RoleDevRootView.<InitializeCaption>d__36>(ref <InitializeCaption>d__);
		return <InitializeCaption>d__.<>t__builder.Task;
	}

	// Token: 0x06012C51 RID: 76881 RVA: 0x00584C47 File Offset: 0x00582E47
	private void OnBackButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06012C52 RID: 76882 RVA: 0x00584C50 File Offset: 0x00582E50
	private UniTask InitializeLayouts()
	{
		RoleDevRootView.<InitializeLayouts>d__38 <InitializeLayouts>d__;
		<InitializeLayouts>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeLayouts>d__.<>4__this = this;
		<InitializeLayouts>d__.<>1__state = -1;
		<InitializeLayouts>d__.<>t__builder.Start<RoleDevRootView.<InitializeLayouts>d__38>(ref <InitializeLayouts>d__);
		return <InitializeLayouts>d__.<>t__builder.Task;
	}

	// Token: 0x06012C53 RID: 76883 RVA: 0x00584C93 File Offset: 0x00582E93
	private void OnChangeFetterGroupSuccessCallBack(int roleId, int fetterGroupId)
	{
		RoleDevPhantomViewItemDataBase roleDevPhantomViewItemData = this.RoleDevViewModelInstance.RoleDevPhantomViewItemData;
		if (roleDevPhantomViewItemData != null)
		{
			roleDevPhantomViewItemData.RefreshSuitDataList();
		}
		this.RefreshCurrentTabView();
	}

	// Token: 0x06012C54 RID: 76884 RVA: 0x00584CB4 File Offset: 0x00582EB4
	private UniTask InitTabListAsync()
	{
		RoleDevRootView.<InitTabListAsync>d__40 <InitTabListAsync>d__;
		<InitTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTabListAsync>d__.<>4__this = this;
		<InitTabListAsync>d__.<>1__state = -1;
		<InitTabListAsync>d__.<>t__builder.Start<RoleDevRootView.<InitTabListAsync>d__40>(ref <InitTabListAsync>d__);
		return <InitTabListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012C55 RID: 76885 RVA: 0x00584CF8 File Offset: 0x00582EF8
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

	// Token: 0x06012C56 RID: 76886 RVA: 0x00584E6C File Offset: 0x0058306C
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

	// Token: 0x06012C57 RID: 76887 RVA: 0x00584E97 File Offset: 0x00583097
	private void OnPlanChangeCallback(RoleDevSkillViewItemDataBase data)
	{
		this.UpdateTabList();
	}

	// Token: 0x06012C58 RID: 76888 RVA: 0x00584EA0 File Offset: 0x005830A0
	private void UpdateList(List<RoleDataBase> list, bool isOutSideChange, EFilterSortType operationType)
	{
		List<RoleDataBase> list2 = this.SortPinnedRolesToFront(list);
		this.RoleDevViewModelInstance.SetRoleDataList(list2);
		this.RestoreOwnListSelection(list2, isOutSideChange, operationType);
	}

	// Token: 0x06012C59 RID: 76889 RVA: 0x00584ECC File Offset: 0x005830CC
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

	// Token: 0x06012C5A RID: 76890 RVA: 0x00584F64 File Offset: 0x00583164
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

	// Token: 0x06012C5B RID: 76891 RVA: 0x00584F88 File Offset: 0x00583188
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

	// Token: 0x06012C5C RID: 76892 RVA: 0x00584FF4 File Offset: 0x005831F4
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

	// Token: 0x06012C5D RID: 76893 RVA: 0x00585138 File Offset: 0x00583338
	private void SelectRoleByRoleDataBase(RoleDataBase roleData)
	{
		this.SelectRole(roleData.GetRoleConfig().Id, global::ERoleListType.OwnList);
	}

	// Token: 0x06012C5E RID: 76894 RVA: 0x0058515A File Offset: 0x0058335A
	private void SelectRoleByDisplayModelData(RoleDisplayModelBase roleData)
	{
		this.SelectRole(roleData.Id, global::ERoleListType.NewList);
	}

	// Token: 0x06012C5F RID: 76895 RVA: 0x0058516C File Offset: 0x0058336C
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

	// Token: 0x06012C60 RID: 76896 RVA: 0x00585204 File Offset: 0x00583404
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

	// Token: 0x06012C61 RID: 76897 RVA: 0x0058526F File Offset: 0x0058346F
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

	// Token: 0x06012C62 RID: 76898 RVA: 0x005852AC File Offset: 0x005834AC
	private void RefreshRoleMarkToggle(int roleId)
	{
		this.RefreshRoleMarkToggleActive(roleId);
		this.RefreshRoleMarkToggleByTempData(null);
	}

	// Token: 0x06012C63 RID: 76899 RVA: 0x005852D0 File Offset: 0x005834D0
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

	// Token: 0x06012C64 RID: 76900 RVA: 0x00585381 File Offset: 0x00583581
	private void SetRoleData(int roleId, global::ERoleListType type)
	{
		this.SetCurSelectRoleId(roleId);
		this.RoleDevViewModelInstance.InitAllDevItemDataByRoleId(roleId);
	}

	// Token: 0x06012C65 RID: 76901 RVA: 0x00585398 File Offset: 0x00583598
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

	// Token: 0x06012C66 RID: 76902 RVA: 0x00585408 File Offset: 0x00583608
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

	// Token: 0x06012C67 RID: 76903 RVA: 0x00585470 File Offset: 0x00583670
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

	// Token: 0x06012C68 RID: 76904 RVA: 0x005854F0 File Offset: 0x005836F0
	private bool CanExecuteChangeFunctionForOwn(object data, bool isForceSelected, EToggleState state)
	{
		int id = (data as RoleDataBase).GetRoleConfig().Id;
		return state != EToggleState.ETT_Checked || this.CurSelectRoleListType != global::ERoleListType.OwnList || this.CurSelectRoleId != id;
	}

	// Token: 0x06012C69 RID: 76905 RVA: 0x0058552C File Offset: 0x0058372C
	private bool CanExecuteChangeFunctionForNew(object data, bool isForceSelected, EToggleState state)
	{
		int id = (data as RoleDisplayModelBase).Id;
		return state != EToggleState.ETT_Checked || this.CurSelectRoleListType != global::ERoleListType.NewList || this.CurSelectRoleId != id;
	}

	// Token: 0x06012C6A RID: 76906 RVA: 0x00585560 File Offset: 0x00583760
	private RoleDevRootTabItem InitTabItem()
	{
		RoleDevRootTabItem roleDevRootTabItem = new RoleDevRootTabItem();
		roleDevRootTabItem.OnClickToggleCallBack = new Action<int>(this.OnClickTabItem);
		roleDevRootTabItem.CanClickCallBack = new Func<int, EToggleState, bool>(this.CanClickTabItem);
		this.TabItems.Add(roleDevRootTabItem);
		return roleDevRootTabItem;
	}

	// Token: 0x06012C6B RID: 76907 RVA: 0x005855A4 File Offset: 0x005837A4
	private void OnClickTabItem(int tabType)
	{
		this.SelectTabByTabType((global::ERoleDevTabType)tabType);
		this.PlayTabItemAnimation((global::ERoleDevTabType)tabType);
	}

	// Token: 0x06012C6C RID: 76908 RVA: 0x005855B4 File Offset: 0x005837B4
	private bool CanClickTabItem(int tabType, EToggleState toggleState)
	{
		return this.CurSelectTabInternal == null || tabType != (int)this.CurSelectTabInternal.Value || toggleState != EToggleState.ETT_Checked;
	}

	// Token: 0x06012C6D RID: 76909 RVA: 0x005855DC File Offset: 0x005837DC
	private void SelectTabByTabType(global::ERoleDevTabType tabType)
	{
		this.SetCurSelectTab((int)tabType);
		this.RefreshTabPanel(tabType);
		ERoleDevMainPage mainPage = RoleDevDefine.tabTypeToMainPageMap[(CSharpScript.Game.Module.RoleDev.ERoleDevTabType)tabType];
		RoleDevController.Instance.LogRoleDevPageClick(this.CurSelectRoleId, mainPage);
	}

	// Token: 0x06012C6E RID: 76910 RVA: 0x00585614 File Offset: 0x00583814
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

	// Token: 0x06012C6F RID: 76911 RVA: 0x00585648 File Offset: 0x00583848
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

	// Token: 0x06012C70 RID: 76912 RVA: 0x00585680 File Offset: 0x00583880
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

	// Token: 0x06012C71 RID: 76913 RVA: 0x005856B8 File Offset: 0x005838B8
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

	// Token: 0x06012C72 RID: 76914 RVA: 0x005856F0 File Offset: 0x005838F0
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

	// Token: 0x06012C73 RID: 76915 RVA: 0x00585726 File Offset: 0x00583926
	private void RefreshTabPanel(global::ERoleDevTabType index)
	{
		this.UpdateTabStates(index);
		this.RefreshContentByTab();
	}

	// Token: 0x06012C74 RID: 76916 RVA: 0x00585735 File Offset: 0x00583935
	private void UpdateTabStates(global::ERoleDevTabType activeIndex)
	{
		GenericLayout<RoleDevRootTabItem, global::IRoleDevRootTabData> tabItemLayout = this.TabItemLayout;
		if (tabItemLayout == null)
		{
			return;
		}
		tabItemLayout.SelectGridProxy((int)activeIndex, false);
	}

	// Token: 0x06012C75 RID: 76917 RVA: 0x0058574C File Offset: 0x0058394C
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

	// Token: 0x06012C76 RID: 76918 RVA: 0x005858A8 File Offset: 0x00583AA8
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

	// Token: 0x06012C77 RID: 76919 RVA: 0x00585914 File Offset: 0x00583B14
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

	// Token: 0x06012C78 RID: 76920 RVA: 0x005859A8 File Offset: 0x00583BA8
	private void RefreshRoleMarkToggleActive(int roleId)
	{
		bool uiactive = RoleModel.Instance.IsRoleOwned(roleId);
		base.GetExtendToggle(22).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06012C79 RID: 76921 RVA: 0x005859DC File Offset: 0x00583BDC
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

	// Token: 0x06012C7A RID: 76922 RVA: 0x00585A25 File Offset: 0x00583C25
	private void SetTempRoleMarkRoleId(int roleId)
	{
		this.TempRoleMarkRoleIdInternal = roleId;
	}

	// Token: 0x06012C7B RID: 76923 RVA: 0x00585A30 File Offset: 0x00583C30
	private void RefreshRoleMarkToggleByTempData(int? expectedMarkRoleId = null)
	{
		int curSelectRoleId = this.CurSelectRoleId;
		this.SetRoleMarkToggleState(((expectedMarkRoleId ?? this.TempRoleMarkRoleId) == curSelectRoleId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
	}

	// Token: 0x06012C7C RID: 76924 RVA: 0x00585A6F File Offset: 0x00583C6F
	private void SetRoleMarkToggleState(EToggleState state)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(22);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x06012C7D RID: 76925 RVA: 0x00585A88 File Offset: 0x00583C88
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

	// Token: 0x06012C7E RID: 76926 RVA: 0x00585AF4 File Offset: 0x00583CF4
	public void SetCurSelectRoleId(int roleId)
	{
		this.CurSelectRoleIdInternal = roleId;
	}

	// Token: 0x06012C7F RID: 76927 RVA: 0x00585AFD File Offset: 0x00583CFD
	public void SetCurSelectTab(int value)
	{
		this.CurSelectTabInternal = new global::ERoleDevTabType?((global::ERoleDevTabType)value);
	}

	// Token: 0x06012C80 RID: 76928 RVA: 0x00585B0B File Offset: 0x00583D0B
	public void SetCurSelectRoleListType(global::ERoleListType value)
	{
		this.CurSelectRoleListTypeInternal = value;
	}

	// Token: 0x06012C81 RID: 76929 RVA: 0x00585B14 File Offset: 0x00583D14
	public void SetIsFirstEnter(bool value)
	{
		this.IsFirstEnterInternal = value;
	}

	// Token: 0x17001C5D RID: 7261
	// (get) Token: 0x06012C82 RID: 76930 RVA: 0x00585B1D File Offset: 0x00583D1D
	public global::ERoleDevTabType CurSelectTab
	{
		get
		{
			return this.CurSelectTabInternal.Value;
		}
	}

	// Token: 0x17001C5E RID: 7262
	// (get) Token: 0x06012C83 RID: 76931 RVA: 0x00585B2A File Offset: 0x00583D2A
	public int CurSelectRoleId
	{
		get
		{
			return this.CurSelectRoleIdInternal;
		}
	}

	// Token: 0x17001C5F RID: 7263
	// (get) Token: 0x06012C84 RID: 76932 RVA: 0x00585B32 File Offset: 0x00583D32
	public global::ERoleListType CurSelectRoleListType
	{
		get
		{
			return this.CurSelectRoleListTypeInternal;
		}
	}

	// Token: 0x17001C60 RID: 7264
	// (get) Token: 0x06012C85 RID: 76933 RVA: 0x00585B3A File Offset: 0x00583D3A
	public bool IsFirstEnter
	{
		get
		{
			return this.IsFirstEnterInternal;
		}
	}

	// Token: 0x17001C61 RID: 7265
	// (get) Token: 0x06012C86 RID: 76934 RVA: 0x00585B42 File Offset: 0x00583D42
	public int TempRoleMarkRoleId
	{
		get
		{
			return this.TempRoleMarkRoleIdInternal;
		}
	}

	// Token: 0x06012C87 RID: 76935 RVA: 0x00585B4A File Offset: 0x00583D4A
	public void ClearCache()
	{
		this.CurSelectRoleIdInternal = 0;
		this.CurSelectTabInternal = null;
		this.TempRoleMarkRoleIdInternal = 0;
	}

	// Token: 0x06012C88 RID: 76936 RVA: 0x00585B66 File Offset: 0x00583D66
	protected override void OnBeforeDestroy()
	{
		this.ShowRoleUiModel();
		this.ClearCache();
	}

	// Token: 0x0400A254 RID: 41556
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevMediumItemGrid, RoleDataBase> ConfigRoleLayout;

	// Token: 0x0400A255 RID: 41557
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevSelectionMediumItemGrid, RoleDisplayModelBase> NewRoleLayout;

	// Token: 0x0400A256 RID: 41558
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevRootTabItem, global::IRoleDevRootTabData> TabItemLayout;

	// Token: 0x0400A257 RID: 41559
	[Nullable(2)]
	private RoleDevRoleViewItem RoleViewItem;

	// Token: 0x0400A258 RID: 41560
	[Nullable(2)]
	private RoleDevWeaponViewItem WeaponViewItem;

	// Token: 0x0400A259 RID: 41561
	[Nullable(2)]
	private RoleDevPhantomViewItem PhantomViewItem;

	// Token: 0x0400A25A RID: 41562
	[Nullable(2)]
	private RoleDevSkillViewItem SkillViewItem;

	// Token: 0x0400A25B RID: 41563
	[Nullable(2)]
	private PopupCaptionItem ItemCaption;

	// Token: 0x0400A25C RID: 41564
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntranceInstance;

	// Token: 0x0400A25D RID: 41565
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::IRoleDevRootTabData> TabDataList;

	// Token: 0x0400A25E RID: 41566
	private readonly List<RoleDevRootTabItem> TabItems = new List<RoleDevRootTabItem>();

	// Token: 0x0400A25F RID: 41567
	private readonly RoleDevViewModel RoleDevViewModelInstance = new RoleDevViewModel();

	// Token: 0x0400A260 RID: 41568
	[Nullable(2)]
	private RoleDevTagItem DevelopTagItem;

	// Token: 0x0400A261 RID: 41569
	[Nullable(2)]
	private CommonElementItem ElementSuitItem;

	// Token: 0x0400A262 RID: 41570
	private int CurSelectRoleIdInternal;

	// Token: 0x0400A263 RID: 41571
	private global::ERoleDevTabType? CurSelectTabInternal;

	// Token: 0x0400A264 RID: 41572
	private global::ERoleListType CurSelectRoleListTypeInternal;

	// Token: 0x0400A265 RID: 41573
	private bool IsFirstEnterInternal = true;

	// Token: 0x0400A266 RID: 41574
	private int TempRoleMarkRoleIdInternal;

	// Token: 0x0400A267 RID: 41575
	private bool FilterSortEntranceRefreshLock;

	// Token: 0x020080B2 RID: 32946
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029A0E RID: 170510
		Caption,
		// Token: 0x04029A0F RID: 170511
		GridNewRole,
		// Token: 0x04029A10 RID: 170512
		GridOwnRole,
		// Token: 0x04029A11 RID: 170513
		RoleItem,
		// Token: 0x04029A12 RID: 170514
		FilterSortItem,
		// Token: 0x04029A13 RID: 170515
		TextureRole,
		// Token: 0x04029A14 RID: 170516
		TxtRoleName,
		// Token: 0x04029A15 RID: 170517
		Tag,
		// Token: 0x04029A16 RID: 170518
		DevelopTag,
		// Token: 0x04029A17 RID: 170519
		TxtProperty,
		// Token: 0x04029A18 RID: 170520
		ElementIcon,
		// Token: 0x04029A19 RID: 170521
		ToggleLayout,
		// Token: 0x04029A1A RID: 170522
		DevelopToggle,
		// Token: 0x04029A1B RID: 170523
		SubRoleViewLayout,
		// Token: 0x04029A1C RID: 170524
		SubRoleViewScrollView,
		// Token: 0x04029A1D RID: 170525
		SubSkillViewLayout,
		// Token: 0x04029A1E RID: 170526
		SubSkillViewScrollView,
		// Token: 0x04029A1F RID: 170527
		SubWeaponViewLayout,
		// Token: 0x04029A20 RID: 170528
		SubWeaponViewScrollView,
		// Token: 0x04029A21 RID: 170529
		SubPhantomViewLayout,
		// Token: 0x04029A22 RID: 170530
		SubPhantomViewScrollView,
		// Token: 0x04029A23 RID: 170531
		EmptyPanel,
		// Token: 0x04029A24 RID: 170532
		ToggleRoleMark
	}
}
