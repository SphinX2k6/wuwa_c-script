using System;
using System.Collections.Generic;
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

// Token: 0x02001481 RID: 5249
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomManageSettingTitleItem : GridProxyAbstract<InventoryDefine.IManageConfigTitleItemData>, IStaticVariableResetter
{
	// Token: 0x0600D23C RID: 53820 RVA: 0x003E5DDD File Offset: 0x003E3FDD
	static PhantomManageSettingTitleItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomManageSettingTitleItem.CreateStaticDefaultValue), new Action(PhantomManageSettingTitleItem.ResetStaticDefaultValue));
	}

	// Token: 0x0600D23D RID: 53821 RVA: 0x003E5DFC File Offset: 0x003E3FFC
	public static void CreateStaticDefaultValue()
	{
		PhantomManageSettingTitleItem.ViewModel = null;
	}

	// Token: 0x0600D23E RID: 53822 RVA: 0x003E5E04 File Offset: 0x003E4004
	public static void ResetStaticDefaultValue()
	{
		PhantomManageSettingTitleItem.ViewModel = null;
	}

	// Token: 0x0600D23F RID: 53823 RVA: 0x003E5E0C File Offset: 0x003E400C
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

	// Token: 0x0600D240 RID: 53824 RVA: 0x003E5E75 File Offset: 0x003E4075
	protected override void OnStart()
	{
		PhantomManageSettingTitleItem.ViewModel.Bind(new Action<EPhantomManageConfigViewData>(this.OnViewModelUpdate));
	}

	// Token: 0x0600D241 RID: 53825 RVA: 0x003E5E8D File Offset: 0x003E408D
	protected override void OnBeforeDestroy()
	{
		PhantomManageSettingTitleItem.ViewModel.UnBind(new Action<EPhantomManageConfigViewData>(this.OnViewModelUpdate));
	}

	// Token: 0x0600D242 RID: 53826 RVA: 0x003E5EA5 File Offset: 0x003E40A5
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

	// Token: 0x0600D243 RID: 53827 RVA: 0x003E5ED8 File Offset: 0x003E40D8
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

	// Token: 0x0600D244 RID: 53828 RVA: 0x003E5F24 File Offset: 0x003E4124
	public UniTask RefreshByViewModelAsync()
	{
		PhantomManageSettingTitleItem.<RefreshByViewModelAsync>d__13 <RefreshByViewModelAsync>d__;
		<RefreshByViewModelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshByViewModelAsync>d__.<>4__this = this;
		<RefreshByViewModelAsync>d__.<>1__state = -1;
		<RefreshByViewModelAsync>d__.<>t__builder.Start<PhantomManageSettingTitleItem.<RefreshByViewModelAsync>d__13>(ref <RefreshByViewModelAsync>d__);
		return <RefreshByViewModelAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D245 RID: 53829 RVA: 0x003E5F68 File Offset: 0x003E4168
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

	// Token: 0x0600D246 RID: 53830 RVA: 0x003E5FBC File Offset: 0x003E41BC
	private void RrefreshTitle()
	{
		FilterRule? filterRuleConfig = FilterConfig.Instance.GetFilterRuleConfig(this.Data.FilterRuleId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), filterRuleConfig.Value.Title, Array.Empty<object>());
	}

	// Token: 0x0600D247 RID: 53831 RVA: 0x003E6004 File Offset: 0x003E4204
	public void RefreshByView()
	{
		this.RefreshByViewModelAsync().Forget();
	}

	// Token: 0x0600D248 RID: 53832 RVA: 0x003E6011 File Offset: 0x003E4211
	public override object GetKey(InventoryDefine.IManageConfigTitleItemData data, int displayIndex)
	{
		return data.FilterRuleId;
	}

	// Token: 0x0600D249 RID: 53833 RVA: 0x003E6020 File Offset: 0x003E4220
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

	// Token: 0x0600D24A RID: 53834 RVA: 0x003E606C File Offset: 0x003E426C
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

	// Token: 0x0600D24B RID: 53835 RVA: 0x003E60D0 File Offset: 0x003E42D0
	private void OnSelectViewConfirm(Dictionary<int, int[]> selection)
	{
		foreach (KeyValuePair<int, int[]> keyValuePair in selection)
		{
			PhantomManageSettingTitleItem.ViewModel.SetEditDataByIdList(keyValuePair.Key, keyValuePair.Value, false);
		}
	}

	// Token: 0x0600D24C RID: 53836 RVA: 0x003E6130 File Offset: 0x003E4330
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

	// Token: 0x0600D24D RID: 53837 RVA: 0x003E61C0 File Offset: 0x003E43C0
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
			array2 = selectConfig.GetValueListByRuleId(filterRuleId);
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

	// Token: 0x04007686 RID: 30342
	[Nullable(2)]
	private InventoryDefine.IManageConfigTitleItemData Data;

	// Token: 0x04007687 RID: 30343
	[Nullable(2)]
	public static PhantomManageConfigViewModel ViewModel;

	// Token: 0x04007688 RID: 30344
	private InventoryDefine.ESettingGridType GridType = InventoryDefine.ESettingGridType.Small;

	// Token: 0x04007689 RID: 30345
	[Nullable(2)]
	private SettingGridLayout ItemLayout;

	// Token: 0x0200774A RID: 30538
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04026BD8 RID: 158680
		TextName,
		// Token: 0x04026BD9 RID: 158681
		LayoutGrid
	}
}
