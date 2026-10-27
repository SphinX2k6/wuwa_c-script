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
	// Token: 0x02005B35 RID: 23349
	[NullableContext(1)]
	[Nullable(0)]
	public class SortEntrance<[Nullable(2)] T> : UiPanelBase
	{
		// Token: 0x0603B1DA RID: 242138 RVA: 0x00E18B50 File Offset: 0x00E16D50
		public SortEntrance(UUIItem uiItem, TUpdateDataListFunction<T> updateDataListFunction)
		{
			this.UpdateDataListFunction = updateDataListFunction;
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B1DB RID: 242139 RVA: 0x00E18BB8 File Offset: 0x00E16DB8
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

		// Token: 0x0603B1DC RID: 242140 RVA: 0x00E18CE4 File Offset: 0x00E16EE4
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

		// Token: 0x0603B1DD RID: 242141 RVA: 0x00E18D57 File Offset: 0x00E16F57
		private void ConfirmFunction()
		{
			this.SetButtonName();
			this.UpdateDataList(false);
		}

		// Token: 0x0603B1DE RID: 242142 RVA: 0x00E18D66 File Offset: 0x00E16F66
		private void SortData(EToggleState state)
		{
			this.ResultData.SetIsAscending(state == EToggleState.ETT_Checked);
			this.UpdateDataList(false);
		}

		// Token: 0x0603B1DF RID: 242143 RVA: 0x00E18D7E File Offset: 0x00E16F7E
		private void HideScroll()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x0603B1E0 RID: 242144 RVA: 0x00E18D94 File Offset: 0x00E16F94
		protected override void OnStart()
		{
			this.Scroll = new GenericScrollViewNew<SortItem, ISortData>(base.GetScrollViewWithScrollbar(3), new Func<SortItem>(this.InitSortItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, null);
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603B1E1 RID: 242145 RVA: 0x00E18DE2 File Offset: 0x00E16FE2
		private SortItem InitSortItem()
		{
			SortItem sortItem = new SortItem();
			sortItem.SetToggleFunction(new TSortItemToggleEvent(this.SortItemToggleEvent));
			sortItem.SetCanExecuteChange(new TCanExecuteChange(this.CanExecuteChange));
			return sortItem;
		}

		// Token: 0x0603B1E2 RID: 242146 RVA: 0x00E18E0D File Offset: 0x00E1700D
		private void SortItemToggleEvent(int ruleId, string name)
		{
			this.ResetLastSelect();
			new KeyValuePair<int, string>(ruleId, name);
			this.ResultData.SetSelectBaseSort(new SortViewBaseSort(ruleId, name));
			this.SetButtonName();
			this.UpdateDataList(false);
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x0603B1E3 RID: 242147 RVA: 0x00E18E4D File Offset: 0x00E1704D
		private bool CanExecuteChange(int ruleId)
		{
			SortViewBaseSort selectBaseSort = this.ResultData.GetSelectBaseSort();
			return selectBaseSort == null || selectBaseSort.RuleId != ruleId;
		}

		// Token: 0x0603B1E4 RID: 242148 RVA: 0x00E18E6C File Offset: 0x00E1706C
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

		// Token: 0x0603B1E5 RID: 242149 RVA: 0x00E18EEC File Offset: 0x00E170EC
		private void SaveStorage()
		{
			if (this.SaveConfigId != null && this.GroupId != EFilterSortGroupId.None)
			{
				SortStorageData data = this.ResultData.ConvertToStorageData();
				SortModel.Instance.SetSortConfigData(this.SaveConfigId.Value, (int)this.GroupId, data, this.SaveConfigExtraParam);
			}
		}

		// Token: 0x0603B1E6 RID: 242150 RVA: 0x00E18F3C File Offset: 0x00E1713C
		[NullableContext(2)]
		private void InitConfigId(EFilterSortGroupId groupId, EFilterSortConfigId? saveConfigId = null, string saveConfigExtraParam = null)
		{
			this.GroupId = groupId;
			this.ConfigId = SortConfig.Instance.GetSortId(groupId);
			this.SaveConfigId = saveConfigId;
			this.SaveConfigExtraParam = (saveConfigExtraParam ?? "");
		}

		// Token: 0x0603B1E7 RID: 242151 RVA: 0x00E18F70 File Offset: 0x00E17170
		private void InitIsMultipleSelect()
		{
			this.IsMultipleSelect = (SortConfig.Instance.GetSortConfig(this.ConfigId).Value.AttributeSortListLength > 0);
		}

		// Token: 0x0603B1E8 RID: 242152 RVA: 0x00E18FA8 File Offset: 0x00E171A8
		private void InitDataType()
		{
			this.DataType = (ESortDataType)SortConfig.Instance.GetSortConfig(this.ConfigId).Value.DataId;
		}

		// Token: 0x0603B1E9 RID: 242153 RVA: 0x00E18FDC File Offset: 0x00E171DC
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

		// Token: 0x0603B1EA RID: 242154 RVA: 0x00E191EC File Offset: 0x00E173EC
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

		// Token: 0x0603B1EB RID: 242155 RVA: 0x00E19210 File Offset: 0x00E17410
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

		// Token: 0x0603B1EC RID: 242156 RVA: 0x00E192B4 File Offset: 0x00E174B4
		private void InitSortToggle()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			EToggleState state = this.ResultData.GetIsAscending() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleState(state, false, false, false);
		}

		// Token: 0x0603B1ED RID: 242157 RVA: 0x00E192E4 File Offset: 0x00E174E4
		private void ResetLastSelect()
		{
			SortViewBaseSort selectBaseSort = this.ResultData.GetSelectBaseSort();
			this.Scroll.GetScrollItemByKey(selectBaseSort.RuleId).SetToggleStateForce(false);
		}

		// Token: 0x0603B1EE RID: 242158 RVA: 0x00E1931C File Offset: 0x00E1751C
		private void SetButtonName()
		{
			string newText = this.ResultData.ShowAllSortContent();
			base.GetText(1).SetText(newText, true);
		}

		// Token: 0x0603B1EF RID: 242159 RVA: 0x00E19344 File Offset: 0x00E17544
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

		// Token: 0x0603B1F0 RID: 242160 RVA: 0x00E193C8 File Offset: 0x00E175C8
		private UniTask ShowMaskButton()
		{
			SortEntrance<T>.<ShowMaskButton>d__38 <ShowMaskButton>d__;
			<ShowMaskButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowMaskButton>d__.<>4__this = this;
			<ShowMaskButton>d__.<>1__state = -1;
			<ShowMaskButton>d__.<>t__builder.Start<SortEntrance<T>.<ShowMaskButton>d__38>(ref <ShowMaskButton>d__);
			return <ShowMaskButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603B1F1 RID: 242161 RVA: 0x00E1940B File Offset: 0x00E1760B
		private void HideMaskButton()
		{
			if (this.MaskButton == null)
			{
				return;
			}
			this.MaskButton.ResetItemParent();
			this.MaskButton.SetActive(false);
		}

		// Token: 0x0603B1F2 RID: 242162 RVA: 0x00E1942D File Offset: 0x00E1762D
		private void HandleSortActive()
		{
			this.SetActive(this.ConfigId > 0);
		}

		// Token: 0x0603B1F3 RID: 242163 RVA: 0x00E19440 File Offset: 0x00E17640
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

		// Token: 0x0603B1F4 RID: 242164 RVA: 0x00E194B0 File Offset: 0x00E176B0
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

		// Token: 0x0603B1F5 RID: 242165 RVA: 0x00E19561 File Offset: 0x00E17761
		public void SetResultDataDirty()
		{
			this.IsResultDataDirty = true;
		}

		// Token: 0x0603B1F6 RID: 242166 RVA: 0x00E1956C File Offset: 0x00E1776C
		public void SetSortToggleState(bool isAscending)
		{
			EToggleState state = isAscending ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(2).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0603B1F7 RID: 242167 RVA: 0x00E19594 File Offset: 0x00E17794
		public int GetUniqueIdByGroupId(EFilterSortGroupId groupId)
		{
			int result;
			if (this.UniqueIdMap.TryGetValue((int)groupId, out result))
			{
				return result;
			}
			return -1;
		}

		// Token: 0x0603B1F8 RID: 242168 RVA: 0x00E195B4 File Offset: 0x00E177B4
		public void DeleteUniqueIdByGroupId(EFilterSortGroupId groupId)
		{
			int uniqueId;
			if (this.UniqueIdMap.TryGetValue((int)groupId, out uniqueId))
			{
				SortModel.Instance.DeleteSortResultData(uniqueId);
				this.UniqueIdMap.Remove((int)groupId);
			}
		}

		// Token: 0x0603B1F9 RID: 242169 RVA: 0x00E195E9 File Offset: 0x00E177E9
		public void SetFilterUniqueId(int uniqueId)
		{
			this.FilterUniqueId = uniqueId;
		}

		// Token: 0x0401ED14 RID: 126228
		private readonly Dictionary<int, int> UniqueIdMap = new Dictionary<int, int>();

		// Token: 0x0401ED15 RID: 126229
		private int FilterUniqueId = -1;

		// Token: 0x0401ED16 RID: 126230
		[Nullable(2)]
		private SortResultData ResultData;

		// Token: 0x0401ED17 RID: 126231
		private bool IsResultDataDirty;

		// Token: 0x0401ED18 RID: 126232
		private EFilterSortGroupId GroupId = EFilterSortGroupId.Role;

		// Token: 0x0401ED19 RID: 126233
		private int ConfigId;

		// Token: 0x0401ED1A RID: 126234
		private EFilterSortConfigId? SaveConfigId;

		// Token: 0x0401ED1B RID: 126235
		private string SaveConfigExtraParam = "";

		// Token: 0x0401ED1C RID: 126236
		private ESortDataType DataType = ESortDataType.Role;

		// Token: 0x0401ED1D RID: 126237
		private List<T> DataList = new List<T>();

		// Token: 0x0401ED1E RID: 126238
		private List<object> ExtraParams = new List<object>();

		// Token: 0x0401ED1F RID: 126239
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SortItem, ISortData> Scroll;

		// Token: 0x0401ED20 RID: 126240
		private bool IsMultipleSelect;

		// Token: 0x0401ED21 RID: 126241
		[Nullable(2)]
		private DynamicMaskButton MaskButton;

		// Token: 0x0401ED22 RID: 126242
		protected TUpdateDataListFunction<T> UpdateDataListFunction;

		// Token: 0x0200BD6C RID: 48492
		[NullableContext(0)]
		private enum ECompDefine
		{
			// Token: 0x04039234 RID: 234036
			Toggle,
			// Token: 0x04039235 RID: 234037
			Name,
			// Token: 0x04039236 RID: 234038
			SortToggle,
			// Token: 0x04039237 RID: 234039
			SortScroll,
			// Token: 0x04039238 RID: 234040
			SortItem
		}
	}
}
