using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

// Token: 0x02001FBF RID: 8127
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomManageSettingTitleItem : GridProxyAbstract<InventoryDefine.IManageConfigTitleItemData>, IStaticVariableResetter
{
	// Token: 0x0600FE16 RID: 65046 RVA: 0x003DA401 File Offset: 0x003D8601
	static PhantomManageSettingTitleItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomManageSettingTitleItem.CreateStaticDefaultValue), new Action(PhantomManageSettingTitleItem.ResetStaticDefaultValue));
	}

	// Token: 0x0600FE17 RID: 65047 RVA: 0x003DA420 File Offset: 0x003D8620
	public static void CreateStaticDefaultValue()
	{
		PhantomManageSettingTitleItem.ViewModel = null;
	}

	// Token: 0x0600FE18 RID: 65048 RVA: 0x003DA428 File Offset: 0x003D8628
	public static void ResetStaticDefaultValue()
	{
		PhantomManageSettingTitleItem.ViewModel = null;
	}

	// Token: 0x0600FE19 RID: 65049 RVA: 0x003DA430 File Offset: 0x003D8630
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600FE1A RID: 65050 RVA: 0x003DA499 File Offset: 0x003D8699
	protected override void OnStart()
	{
		PhantomManageSettingTitleItem.ViewModel.Bind(new Action<EPhantomManageConfigViewData>(this.OnViewModelUpdate));
	}

	// Token: 0x0600FE1B RID: 65051 RVA: 0x003DA4B1 File Offset: 0x003D86B1
	protected override void OnBeforeDestroy()
	{
		PhantomManageSettingTitleItem.ViewModel.UnBind(new Action<EPhantomManageConfigViewData>(this.OnViewModelUpdate));
	}

	// Token: 0x0600FE1C RID: 65052 RVA: 0x003DA4C9 File Offset: 0x003D86C9
	private void OnViewModelUpdate(EPhantomManageConfigViewData data)
	{
		if (data == EPhantomManageConfigViewData.SelectConfig)
		{
			this.RefreshByViewModelAsync().Forget();
			return;
		}
		if (data == EPhantomManageConfigViewData.EditState)
		{
			this.RefreshByViewModelAsync().Forget();
			return;
		}
		if (data == EPhantomManageConfigViewData.EditData)
		{
			this.RefreshByViewModelAsync().Forget();
		}
	}

	// Token: 0x0600FE1D RID: 65053 RVA: 0x003DA4FC File Offset: 0x003D86FC
	public override UniTask RefreshAsync(InventoryDefine.IManageConfigTitleItemData data, bool isSelected, int gridIndex)
	{
		PhantomManageSettingTitleItem.<RefreshAsync>d__12 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<PhantomManageSettingTitleItem.<RefreshAsync>d__12>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FE1E RID: 65054 RVA: 0x003DA548 File Offset: 0x003D8748
	public UniTask RefreshByViewModelAsync()
	{
		PhantomManageSettingTitleItem.<RefreshByViewModelAsync>d__13 <RefreshByViewModelAsync>d__;
		<RefreshByViewModelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshByViewModelAsync>d__.<>4__this = this;
		<RefreshByViewModelAsync>d__.<>1__state = -1;
		<RefreshByViewModelAsync>d__.<>t__builder.Start<PhantomManageSettingTitleItem.<RefreshByViewModelAsync>d__13>(ref <RefreshByViewModelAsync>d__);
		return <RefreshByViewModelAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FE1F RID: 65055 RVA: 0x003DA58C File Offset: 0x003D878C
	public override void Refresh(InventoryDefine.IManageConfigTitleItemData data, bool isSelected, int gridIndex)
	{
		PhantomManageSettingTitleItem.<>c__DisplayClass14_0 CS$<>8__locals1 = new PhantomManageSettingTitleItem.<>c__DisplayClass14_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.data = data;
		CS$<>8__locals1.isSelected = isSelected;
		CS$<>8__locals1.gridIndex = gridIndex;
		UiAsyncTask task = new UiAsyncTask("RefreshAsync", delegate()
		{
			PhantomManageSettingTitleItem.<>c__DisplayClass14_0.<<Refresh>b__0>d <<Refresh>b__0>d;
			<<Refresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<Refresh>b__0>d.<>4__this = CS$<>8__locals1;
			<<Refresh>b__0>d.<>1__state = -1;
			<<Refresh>b__0>d.<>t__builder.Start<PhantomManageSettingTitleItem.<>c__DisplayClass14_0.<<Refresh>b__0>d>(ref <<Refresh>b__0>d);
			return <<Refresh>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task).Forget();
	}

	// Token: 0x0600FE20 RID: 65056 RVA: 0x003DA5E0 File Offset: 0x003D87E0
	private void RrefreshTitle()
	{
		FilterRule? filterRuleConfig = FilterConfig.Instance.GetFilterRuleConfig(this.Data.FilterRuleId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), filterRuleConfig.Value.Title, Array.Empty<object>());
	}

	// Token: 0x0600FE21 RID: 65057 RVA: 0x003DA628 File Offset: 0x003D8828
	public void RefreshByView()
	{
		this.RefreshByViewModelAsync().Forget();
	}

	// Token: 0x0600FE22 RID: 65058 RVA: 0x003DA635 File Offset: 0x003D8835
	public override object GetKey(InventoryDefine.IManageConfigTitleItemData data, int displayIndex)
	{
		return data.FilterRuleId;
	}

	// Token: 0x0600FE23 RID: 65059 RVA: 0x003DA644 File Offset: 0x003D8844
	private UniTask InitLayoutAsync(int ruleId)
	{
		PhantomManageSettingTitleItem.<InitLayoutAsync>d__18 <InitLayoutAsync>d__;
		<InitLayoutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitLayoutAsync>d__.<>4__this = this;
		<InitLayoutAsync>d__.ruleId = ruleId;
		<InitLayoutAsync>d__.<>1__state = -1;
		<InitLayoutAsync>d__.<>t__builder.Start<PhantomManageSettingTitleItem.<InitLayoutAsync>d__18>(ref <InitLayoutAsync>d__);
		return <InitLayoutAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FE24 RID: 65060 RVA: 0x003DA690 File Offset: 0x003D8890
	private void OnClickedGrid(InventoryDefine.IManageConfigSettingGridData data, bool isAdd)
	{
		if (this.GridType == InventoryDefine.ESettingGridType.Small)
		{
			PhantomManageSettingTitleItem.ViewModel.SetEditDataById(data.RuleId, data.Value, isAdd, false);
			return;
		}
		if (isAdd)
		{
			InventoryDefine.ISelectViewData selectViewData = this.GetSelectViewData(data);
			UiManager.Instance.OpenView(EUiViewName.PhantomManageConfigSelectView, selectViewData, null);
			return;
		}
		PhantomManageSettingTitleItem.ViewModel.SetEditDataById(data.RuleId, data.Value, false, false);
	}

	// Token: 0x0600FE25 RID: 65061 RVA: 0x003DA6F4 File Offset: 0x003D88F4
	private void OnSelectViewConfirm(Dictionary<int, int[]> selection)
	{
		foreach (KeyValuePair<int, int[]> keyValuePair in selection)
		{
			PhantomManageSettingTitleItem.ViewModel.SetEditDataByIdList(keyValuePair.Key, keyValuePair.Value, false);
		}
	}

	// Token: 0x0600FE26 RID: 65062 RVA: 0x003DA754 File Offset: 0x003D8954
	private InventoryDefine.ISelectViewData GetSelectViewData(InventoryDefine.IManageConfigSettingGridData data)
	{
		Dictionary<int, int[]> editDataByRuleId = PhantomManageSettingTitleItem.ViewModel.GetEditDataByRuleId(data.RuleId);
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(this.Data.FilterId);
		return new InventoryDefine.SelectViewData
		{
			GridType = filterConfig.Value.GridType,
			FilterId = this.Data.FilterId,
			RuleIdList = new int[]
			{
				data.RuleId
			},
			ValueMap = editDataByRuleId,
			CallbackConfirm = new Action<Dictionary<int, int[]>>(this.OnSelectViewConfirm)
		};
	}

	// Token: 0x0600FE27 RID: 65063 RVA: 0x003DA7E4 File Offset: 0x003D89E4
	private InventoryDefine.IManageConfigSettingGridData[] GetGridData()
	{
		int filterRuleId = this.Data.FilterRuleId;
		PhantomManageConfigData selectConfig = PhantomManageSettingTitleItem.ViewModel.GetSelectConfig();
		FilterRule? filterRuleConfig = FilterConfig.Instance.GetFilterRuleConfig(filterRuleId);
		int[] array = filterRuleConfig.Value.IdList();
		bool editState = PhantomManageSettingTitleItem.ViewModel.GetEditState();
		int[] array2 = Array.Empty<int>();
		Dictionary<int, int[]> editDataByRuleId = PhantomManageSettingTitleItem.ViewModel.GetEditDataByRuleId(filterRuleId);
		int[] array3;
		if (editDataByRuleId == null || !editState)
		{
			array2 = selectConfig.GetValueListByRuleId(filterRuleId).ToArray<int>();
		}
		else if (editDataByRuleId.TryGetValue(filterRuleId, out array3))
		{
			array2 = array3;
		}
		bool flag = array2.Length == 0;
		int filterType = filterRuleConfig.Value.FilterType;
		int num = (int)InventoryDefine.recFilterRuleToGirdType[(FilterDefine.EFilterType)filterType];
		List<InventoryDefine.IManageConfigSettingGridData> list = new List<InventoryDefine.IManageConfigSettingGridData>();
		bool isEmpty = !editState && flag;
		bool isAdd = num == 2 && editState;
		InventoryDefine.ManageConfigSettingGridData item = new InventoryDefine.ManageConfigSettingGridData
		{
			IsFirst = true,
			IsEmpty = isEmpty,
			IsAdd = isAdd,
			IsSelect = false,
			IsEditing = editState,
			RuleId = filterRuleId,
			Value = 0
		};
		list.Add(item);
		foreach (int value in array)
		{
			bool isSelect = Array.IndexOf<int>(array2, value) >= 0;
			InventoryDefine.ManageConfigSettingGridData item2 = new InventoryDefine.ManageConfigSettingGridData
			{
				IsFirst = false,
				IsEmpty = false,
				IsAdd = false,
				IsSelect = isSelect,
				IsEditing = editState,
				RuleId = filterRuleId,
				Value = value
			};
			list.Add(item2);
		}
		return list.ToArray();
	}

	// Token: 0x040075A4 RID: 30116
	[Nullable(2)]
	private InventoryDefine.IManageConfigTitleItemData Data;

	// Token: 0x040075A5 RID: 30117
	[Nullable(2)]
	public static PhantomManageConfigViewModel ViewModel;

	// Token: 0x040075A6 RID: 30118
	private InventoryDefine.ESettingGridType GridType = InventoryDefine.ESettingGridType.Small;

	// Token: 0x040075A7 RID: 30119
	[Nullable(2)]
	private SettingGridLayout ItemLayout;

	// Token: 0x020085C8 RID: 34248
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B8D0 RID: 178384
		TextName,
		// Token: 0x0402B8D1 RID: 178385
		LayoutGrid
	}
}
