using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.FilterSort.Sort.SortEntrance
{
	// Token: 0x02004B16 RID: 19222
	[NullableContext(1)]
	[Nullable(0)]
	public class SortEntrance<[Nullable(2)] T> : UiPanelBase
	{
		// Token: 0x0603014C RID: 196940 RVA: 0x00D69868 File Offset: 0x00D67A68
		public SortEntrance(UUIItem uiItem, TUpdateDataListFunction<T> updateDataListFunction)
		{
			this.UpdateDataListFunction = updateDataListFunction;
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603014D RID: 196941 RVA: 0x00D698D0 File Offset: 0x00D67AD0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.HandleSortShow));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.SortData));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603014E RID: 196942 RVA: 0x00D699FC File Offset: 0x00D67BFC
		private void HandleSortShow(EToggleState toggleState)
		{
			if (this.IsMultipleSelect)
			{
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				SortViewData viewData = new SortViewData(this.ResultData.UniqueId, new Action(this.ConfirmFunction));
				FilterSortController.Instance.OpenSortView(viewData);
				return;
			}
			bool bIsUIActive = base.GetScrollViewWithScrollbar(3).RootUIComp.Get().bIsUIActive;
			this.ChangeScrollActive(!bIsUIActive);
		}

		// Token: 0x0603014F RID: 196943 RVA: 0x00D69A6F File Offset: 0x00D67C6F
		private void ConfirmFunction()
		{
			this.SetButtonName();
			this.UpdateDataList(false);
		}

		// Token: 0x06030150 RID: 196944 RVA: 0x00D69A7E File Offset: 0x00D67C7E
		private void SortData(EToggleState state)
		{
			this.ResultData.SetIsAscending(state == EToggleState.ETT_Checked);
			this.UpdateDataList(false);
		}

		// Token: 0x06030151 RID: 196945 RVA: 0x00D69A96 File Offset: 0x00D67C96
		private void HideScroll()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x06030152 RID: 196946 RVA: 0x00D69AAC File Offset: 0x00D67CAC
		protected override void OnStart()
		{
			this.Scroll = new GenericScrollViewNew<SortItem, ISortData>(base.GetScrollViewWithScrollbar(3), new Func<SortItem>(this.InitSortItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, null);
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06030153 RID: 196947 RVA: 0x00D69AFA File Offset: 0x00D67CFA
		private SortItem InitSortItem()
		{
			SortItem sortItem = new SortItem();
			sortItem.SetToggleFunction(new TSortItemToggleEvent(this.SortItemToggleEvent));
			sortItem.SetCanExecuteChange(new TCanExecuteChange(this.CanExecuteChange));
			return sortItem;
		}

		// Token: 0x06030154 RID: 196948 RVA: 0x00D69B25 File Offset: 0x00D67D25
		private void SortItemToggleEvent(int ruleId, string name)
		{
			this.ResetLastSelect();
			new KeyValuePair<int, string>(ruleId, name);
			this.ResultData.SetSelectBaseSort(new SortViewBaseSort(ruleId, name));
			this.SetButtonName();
			this.UpdateDataList(false);
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x06030155 RID: 196949 RVA: 0x00D69B65 File Offset: 0x00D67D65
		private bool CanExecuteChange(int ruleId)
		{
			SortViewBaseSort selectBaseSort = this.ResultData.GetSelectBaseSort();
			return selectBaseSort == null || selectBaseSort.RuleId != ruleId;
		}

		// Token: 0x06030156 RID: 196950 RVA: 0x00D69B84 File Offset: 0x00D67D84
		protected override void OnBeforeDestroy()
		{
			DynamicMaskButton maskButton = this.MaskButton;
			if (maskButton != null)
			{
				maskButton.Destroy(null);
			}
			this.SaveStorage();
			foreach (int uniqueId in this.UniqueIdMap.Values)
			{
				SortModel.Instance.DeleteSortResultData(uniqueId);
			}
			this.UniqueIdMap.Clear();
		}

		// Token: 0x06030157 RID: 196951 RVA: 0x00D69C04 File Offset: 0x00D67E04
		private void SaveStorage()
		{
			if (this.SaveConfigId != null && this.GroupId != EFilterSortGroupId.None)
			{
				SortStorageData data = this.ResultData.ConvertToStorageData();
				SortModel.Instance.SetSortConfigData(this.SaveConfigId.Value, (int)this.GroupId, data, this.SaveConfigExtraParam);
			}
		}

		// Token: 0x06030158 RID: 196952 RVA: 0x00D69C54 File Offset: 0x00D67E54
		[NullableContext(2)]
		private void InitConfigId(EFilterSortGroupId groupId, EFilterSortConfigId? saveConfigId = null, string saveConfigExtraParam = null)
		{
			this.GroupId = groupId;
			this.ConfigId = SortConfig.Instance.GetSortId(groupId);
			this.SaveConfigId = saveConfigId;
			this.SaveConfigExtraParam = (saveConfigExtraParam ?? "");
		}

		// Token: 0x06030159 RID: 196953 RVA: 0x00D69C88 File Offset: 0x00D67E88
		private void InitIsMultipleSelect()
		{
			this.IsMultipleSelect = (SortConfig.Instance.GetSortConfig(this.ConfigId).Value.AttributeSortListLength > 0);
		}

		// Token: 0x0603015A RID: 196954 RVA: 0x00D69CC0 File Offset: 0x00D67EC0
		private void InitDataType()
		{
			this.DataType = (ESortDataType)SortConfig.Instance.GetSortConfig(this.ConfigId).Value.DataId;
		}

		// Token: 0x0603015B RID: 196955 RVA: 0x00D69CF4 File Offset: 0x00D67EF4
		[NullableContext(2)]
		private void InitResultData(SortStorageData storageData = null)
		{
			int uniqueIdByGroupId = this.GetUniqueIdByGroupId(this.GroupId);
			this.ResultData = SortModel.Instance.GetSortResultData(uniqueIdByGroupId);
			if (this.ResultData != null && !this.IsResultDataDirty)
			{
				return;
			}
			if (this.ResultData == null)
			{
				Sort? sortConfig = SortConfig.Instance.GetSortConfig(this.ConfigId);
				int ruleId = ((storageData != null) ? storageData.SelectBaseSort : null) ?? sortConfig.Value.GetBaseSortListArray()[0];
				string sortRuleName = SortConfig.Instance.GetSortRuleName(ruleId, this.DataType);
				this.ResultData = new SortResultData();
				this.ResultData.SetConfigId(this.ConfigId);
				this.ResultData.SetSelectBaseSort(new SortViewBaseSort(ruleId, sortRuleName));
				UUIExtendToggle extendToggle = base.GetExtendToggle(2);
				if (storageData != null)
				{
					bool isAscending = storageData.IsAscending;
					this.ResultData.SetIsAscending(storageData.IsAscending);
				}
				else
				{
					this.ResultData.SetIsAscending(extendToggle.GetToggleState() == EToggleState.ETT_Checked);
				}
				if (((storageData != null) ? storageData.SelectAttributeSort : null) != null && storageData.SelectAttributeSort.Count > 0)
				{
					Dictionary<int, string> dictionary = new Dictionary<int, string>();
					foreach (int num in storageData.SelectAttributeSort)
					{
						string sortRuleName2 = SortConfig.Instance.GetSortRuleName(num, this.DataType);
						dictionary.Add(num, sortRuleName2);
					}
					this.ResultData.SetSelectAttributeSort(dictionary);
				}
				SortModel.Instance.SetSortResultData(this.ResultData);
				this.UniqueIdMap.Add((int)this.GroupId, this.ResultData.UniqueId);
			}
			if (this.IsResultDataDirty)
			{
				SortViewBaseSort selectBaseSort = this.ResultData.GetSelectBaseSort();
				if (selectBaseSort != null)
				{
					string sortRuleName3 = SortConfig.Instance.GetSortRuleName(selectBaseSort.RuleId, this.DataType);
					selectBaseSort.RuleName = sortRuleName3;
				}
				this.IsResultDataDirty = false;
			}
		}

		// Token: 0x0603015C RID: 196956 RVA: 0x00D69F04 File Offset: 0x00D68104
		private void ChangeScrollActive(bool value)
		{
			this.Scroll.SetActive(value);
			if (value)
			{
				this.ShowMaskButton().Forget();
				return;
			}
			this.HideMaskButton();
		}

		// Token: 0x0603015D RID: 196957 RVA: 0x00D69F28 File Offset: 0x00D68128
		private void InitSort()
		{
			this.ChangeScrollActive(false);
			if (this.IsMultipleSelect)
			{
				return;
			}
			Sort? sortConfig = SortConfig.Instance.GetSortConfig(this.ConfigId);
			List<ISortData> list = new List<ISortData>();
			int ruleId = this.ResultData.GetSelectBaseSort().RuleId;
			foreach (int ruleId2 in sortConfig.Value.GetBaseSortListArray())
			{
				list.Add(new SortData
				{
					RuleId = ruleId2,
					DataType = this.DataType,
					SelectedRule = ruleId
				});
			}
			this.Scroll.RefreshByData(list, null, false);
		}

		// Token: 0x0603015E RID: 196958 RVA: 0x00D69FCC File Offset: 0x00D681CC
		private void InitSortToggle()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			EToggleState state = this.ResultData.GetIsAscending() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleState(state, false, false, false);
		}

		// Token: 0x0603015F RID: 196959 RVA: 0x00D69FFC File Offset: 0x00D681FC
		private void ResetLastSelect()
		{
			SortViewBaseSort selectBaseSort = this.ResultData.GetSelectBaseSort();
			this.Scroll.GetScrollItemByKey(selectBaseSort.RuleId).SetToggleStateForce(false);
		}

		// Token: 0x06030160 RID: 196960 RVA: 0x00D6A034 File Offset: 0x00D68234
		private void SetButtonName()
		{
			string newText = this.ResultData.ShowAllSortContent();
			base.GetText(1).SetText(newText, true);
		}

		// Token: 0x06030161 RID: 196961 RVA: 0x00D6A05C File Offset: 0x00D6825C
		private void UpdateDataList(bool isOutSideChange)
		{
			List<T> dataList = this.DataList;
			FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.FilterUniqueId);
			if (filterResultData != null)
			{
				int filterId = FilterConfig.Instance.GetFilterId(this.GroupId);
				Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> selectRuleData = filterResultData.GetSelectRuleData();
				dataList = FilterModel.Instance.GetFilterList<T>(dataList, filterId, selectRuleData);
			}
			SortModel.Instance.SortDataList<T>(dataList, this.ConfigId, this.ResultData, this.ExtraParams.ToArray());
			TUpdateDataListFunction<T> updateDataListFunction = this.UpdateDataListFunction;
			if (updateDataListFunction == null)
			{
				return;
			}
			updateDataListFunction(dataList, isOutSideChange, EFilterSortType.Sort);
		}

		// Token: 0x06030162 RID: 196962 RVA: 0x00D6A0E0 File Offset: 0x00D682E0
		private UniTask ShowMaskButton()
		{
			SortEntrance<T>.<ShowMaskButton>d__38 <ShowMaskButton>d__;
			<ShowMaskButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowMaskButton>d__.<>4__this = this;
			<ShowMaskButton>d__.<>1__state = -1;
			<ShowMaskButton>d__.<>t__builder.Start<SortEntrance<T>.<ShowMaskButton>d__38>(ref <ShowMaskButton>d__);
			return <ShowMaskButton>d__.<>t__builder.Task;
		}

		// Token: 0x06030163 RID: 196963 RVA: 0x00D6A123 File Offset: 0x00D68323
		private void HideMaskButton()
		{
			if (this.MaskButton == null)
			{
				return;
			}
			this.MaskButton.ResetItemParent();
			this.MaskButton.SetActive(false);
		}

		// Token: 0x06030164 RID: 196964 RVA: 0x00D6A145 File Offset: 0x00D68345
		private void HandleSortActive()
		{
			this.SetActive(this.ConfigId > 0);
		}

		// Token: 0x06030165 RID: 196965 RVA: 0x00D6A158 File Offset: 0x00D68358
		public void UpdateData(EFilterSortGroupId groupId, List<T> dataList, params object[] parameters)
		{
			this.InitConfigId(groupId, null, null);
			this.HandleSortActive();
			if (this.ConfigId <= 0)
			{
				return;
			}
			this.DataList = dataList;
			this.ExtraParams = new List<object>(parameters);
			this.InitIsMultipleSelect();
			this.InitDataType();
			this.InitResultData(null);
			this.InitSort();
			this.InitSortToggle();
			this.SetButtonName();
			this.UpdateDataList(true);
		}

		// Token: 0x06030166 RID: 196966 RVA: 0x00D6A1C8 File Offset: 0x00D683C8
		public void UpdateDataWithConfig(EFilterSortGroupId groupId, EFilterSortConfigId saveConfigId, List<T> dataList, string saveConfigExtraParam = "", params object[] parameters)
		{
			FilterSortConfig sortFilterConfig = SortConfig.Instance.GetSortFilterConfig(saveConfigId);
			if (sortFilterConfig.SaveMode == 2 || sortFilterConfig.SaveMode == 3)
			{
				this.UpdateData(groupId, dataList, parameters);
				return;
			}
			this.SaveStorage();
			this.InitConfigId(groupId, new EFilterSortConfigId?(saveConfigId), saveConfigExtraParam);
			this.HandleSortActive();
			if (this.ConfigId <= 0)
			{
				return;
			}
			this.DataList = dataList;
			this.ExtraParams = new List<object>(parameters);
			this.InitIsMultipleSelect();
			this.InitDataType();
			SortStorageData sortConfigData = SortModel.Instance.GetSortConfigData(saveConfigId, (int)this.GroupId, saveConfigExtraParam);
			this.InitResultData(sortConfigData);
			this.InitSort();
			this.InitSortToggle();
			this.SetButtonName();
			this.UpdateDataList(true);
		}

		// Token: 0x06030167 RID: 196967 RVA: 0x00D6A279 File Offset: 0x00D68479
		public void SetResultDataDirty()
		{
			this.IsResultDataDirty = true;
		}

		// Token: 0x06030168 RID: 196968 RVA: 0x00D6A284 File Offset: 0x00D68484
		public void SetSortToggleState(bool isAscending)
		{
			EToggleState state = isAscending ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(2).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x06030169 RID: 196969 RVA: 0x00D6A2AC File Offset: 0x00D684AC
		public int GetUniqueIdByGroupId(EFilterSortGroupId groupId)
		{
			int result;
			if (this.UniqueIdMap.TryGetValue((int)groupId, out result))
			{
				return result;
			}
			return -1;
		}

		// Token: 0x0603016A RID: 196970 RVA: 0x00D6A2CC File Offset: 0x00D684CC
		public void DeleteUniqueIdByGroupId(EFilterSortGroupId groupId)
		{
			int uniqueId;
			if (this.UniqueIdMap.TryGetValue((int)groupId, out uniqueId))
			{
				SortModel.Instance.DeleteSortResultData(uniqueId);
				this.UniqueIdMap.Remove((int)groupId);
			}
		}

		// Token: 0x0603016B RID: 196971 RVA: 0x00D6A301 File Offset: 0x00D68501
		public void SetFilterUniqueId(int uniqueId)
		{
			this.FilterUniqueId = uniqueId;
		}

		// Token: 0x040197D0 RID: 104400
		private readonly Dictionary<int, int> UniqueIdMap = new Dictionary<int, int>();

		// Token: 0x040197D1 RID: 104401
		private int FilterUniqueId = -1;

		// Token: 0x040197D2 RID: 104402
		[Nullable(2)]
		private SortResultData ResultData;

		// Token: 0x040197D3 RID: 104403
		private bool IsResultDataDirty;

		// Token: 0x040197D4 RID: 104404
		private EFilterSortGroupId GroupId = EFilterSortGroupId.Role;

		// Token: 0x040197D5 RID: 104405
		private int ConfigId;

		// Token: 0x040197D6 RID: 104406
		private EFilterSortConfigId? SaveConfigId;

		// Token: 0x040197D7 RID: 104407
		private string SaveConfigExtraParam = "";

		// Token: 0x040197D8 RID: 104408
		private ESortDataType DataType = ESortDataType.Role;

		// Token: 0x040197D9 RID: 104409
		private List<T> DataList = new List<T>();

		// Token: 0x040197DA RID: 104410
		private List<object> ExtraParams = new List<object>();

		// Token: 0x040197DB RID: 104411
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SortItem, ISortData> Scroll;

		// Token: 0x040197DC RID: 104412
		private bool IsMultipleSelect;

		// Token: 0x040197DD RID: 104413
		[Nullable(2)]
		private DynamicMaskButton MaskButton;

		// Token: 0x040197DE RID: 104414
		protected TUpdateDataListFunction<T> UpdateDataListFunction;

		// Token: 0x0200A775 RID: 42869
		[NullableContext(0)]
		private enum ECompDefine
		{
			// Token: 0x04033C00 RID: 211968
			Toggle,
			// Token: 0x04033C01 RID: 211969
			Name,
			// Token: 0x04033C02 RID: 211970
			SortToggle,
			// Token: 0x04033C03 RID: 211971
			SortScroll,
			// Token: 0x04033C04 RID: 211972
			SortItem
		}
	}
}
