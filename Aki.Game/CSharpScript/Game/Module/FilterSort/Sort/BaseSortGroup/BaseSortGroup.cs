using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FilterSort.Sort.BaseSortGroup
{
	// Token: 0x02004B1A RID: 19226
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseSortGroup : UiPanelBase
	{
		// Token: 0x06030180 RID: 196992 RVA: 0x00D6A594 File Offset: 0x00D68794
		public BaseSortGroup(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06030181 RID: 196993 RVA: 0x00D6A5B0 File Offset: 0x00D687B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030182 RID: 196994 RVA: 0x00D6A619 File Offset: 0x00D68819
		protected override void OnStart()
		{
			this.Layout = new GenericLayoutNew<SortItem>(base.GetLayoutBase(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<SortItem>(this.InitSortItem), base.GetItem(1));
		}

		// Token: 0x06030183 RID: 196995 RVA: 0x00D6A640 File Offset: 0x00D68840
		private ILayoutItem<SortItem> InitSortItem(object tempRuleId, UUIItem uiItem, int index)
		{
			int num = (int)tempRuleId;
			SortItem sortItem = new SortItem(uiItem);
			sortItem.SetToggleFunction(new TSortItemToggleEvent(this.SortItemToggleEvent));
			sortItem.SetCanExecuteChange(new TCanExecuteChange(this.CanExecuteChange));
			sortItem.ShowSortItem(num, this.DataType, this.TempSelect.Value.Item1 == num);
			return new LayoutItem<SortItem>
			{
				Key = num,
				Value = sortItem
			};
		}

		// Token: 0x06030184 RID: 196996 RVA: 0x00D6A6B7 File Offset: 0x00D688B7
		private void SortItemToggleEvent(int ruleId, string name)
		{
			this.ResetLastSelect();
			this.TempSelect = new ValueTuple<int, string>?(new ValueTuple<int, string>(ruleId, name));
		}

		// Token: 0x06030185 RID: 196997 RVA: 0x00D6A6D1 File Offset: 0x00D688D1
		private bool CanExecuteChange(int ruleId)
		{
			return this.TempSelect.Value.Item1 != ruleId;
		}

		// Token: 0x06030186 RID: 196998 RVA: 0x00D6A6E9 File Offset: 0x00D688E9
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06030187 RID: 196999 RVA: 0x00D6A6EB File Offset: 0x00D688EB
		private void ResetLastSelect()
		{
			this.Layout.GetLayoutItemByKey(this.TempSelect.Value.Item1).SetToggleStateForce(false);
		}

		// Token: 0x06030188 RID: 197000 RVA: 0x00D6A714 File Offset: 0x00D68914
		private void InitConfigId()
		{
			SortResultData sortResultData = SortModel.Instance.GetSortResultData(this.UniqueId);
			this.ConfigId = sortResultData.ConfigId;
		}

		// Token: 0x06030189 RID: 197001 RVA: 0x00D6A740 File Offset: 0x00D68940
		private void InitTempSelect()
		{
			SortViewBaseSort selectBaseSort = SortModel.Instance.GetSortResultData(this.UniqueId).GetSelectBaseSort();
			this.TempSelect = new ValueTuple<int, string>?(new ValueTuple<int, string>(selectBaseSort.RuleId, selectBaseSort.RuleName));
		}

		// Token: 0x0603018A RID: 197002 RVA: 0x00D6A780 File Offset: 0x00D68980
		private void InitSort()
		{
			Sort value = SortConfig.Instance.GetSortConfig(this.ConfigId).Value;
			this.DataType = (ESortDataType)value.DataId;
			this.Layout.RebuildLayoutByDataNew<int>(value.BaseSortList(), null);
		}

		// Token: 0x0603018B RID: 197003 RVA: 0x00D6A7CE File Offset: 0x00D689CE
		public void Init(int uniqueId)
		{
			this.UniqueId = uniqueId;
			this.InitConfigId();
			this.InitTempSelect();
			this.InitSort();
		}

		// Token: 0x0603018C RID: 197004 RVA: 0x00D6A7EC File Offset: 0x00D689EC
		public void Reset()
		{
			int num = SortConfig.Instance.GetSortConfig(this.ConfigId).Value.BaseSortList()[0];
			string sortRuleName = SortConfig.Instance.GetSortRuleName(num, this.DataType);
			this.TempSelect = new ValueTuple<int, string>?(new ValueTuple<int, string>(num, sortRuleName));
			foreach (KeyValuePair<object, SortItem> keyValuePair in this.Layout.GetLayoutItemMap())
			{
				int num2 = (int)keyValuePair.Key;
				keyValuePair.Value.ShowSortItem(num2, this.DataType, num == num2);
			}
		}

		// Token: 0x0603018D RID: 197005 RVA: 0x00D6A8B0 File Offset: 0x00D68AB0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTuple<int, string>? GetTempSelect()
		{
			return this.TempSelect;
		}

		// Token: 0x040197E4 RID: 104420
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<SortItem> Layout;

		// Token: 0x040197E5 RID: 104421
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private ValueTuple<int, string>? TempSelect;

		// Token: 0x040197E6 RID: 104422
		private int ConfigId;

		// Token: 0x040197E7 RID: 104423
		private int UniqueId;

		// Token: 0x040197E8 RID: 104424
		private ESortDataType DataType = ESortDataType.Role;

		// Token: 0x0200A778 RID: 42872
		[NullableContext(0)]
		private enum ECompDefine
		{
			// Token: 0x04033C0E RID: 211982
			Layout,
			// Token: 0x04033C0F RID: 211983
			LayoutItem
		}
	}
}
