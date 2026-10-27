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
	// Token: 0x02005B39 RID: 23353
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseSortGroup : UiPanelBase
	{
		// Token: 0x0603B20E RID: 242190 RVA: 0x00E1987C File Offset: 0x00E17A7C
		public BaseSortGroup(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B20F RID: 242191 RVA: 0x00E19898 File Offset: 0x00E17A98
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

		// Token: 0x0603B210 RID: 242192 RVA: 0x00E19901 File Offset: 0x00E17B01
		protected override void OnStart()
		{
			this.Layout = new GenericLayoutNew<SortItem>(base.GetLayoutBase(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<SortItem>(this.InitSortItem), base.GetItem(1));
		}

		// Token: 0x0603B211 RID: 242193 RVA: 0x00E19928 File Offset: 0x00E17B28
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

		// Token: 0x0603B212 RID: 242194 RVA: 0x00E1999F File Offset: 0x00E17B9F
		private void SortItemToggleEvent(int ruleId, string name)
		{
			this.ResetLastSelect();
			this.TempSelect = new ValueTuple<int, string>?(new ValueTuple<int, string>(ruleId, name));
		}

		// Token: 0x0603B213 RID: 242195 RVA: 0x00E199B9 File Offset: 0x00E17BB9
		private bool CanExecuteChange(int ruleId)
		{
			return this.TempSelect.Value.Item1 != ruleId;
		}

		// Token: 0x0603B214 RID: 242196 RVA: 0x00E199D1 File Offset: 0x00E17BD1
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603B215 RID: 242197 RVA: 0x00E199D3 File Offset: 0x00E17BD3
		private void ResetLastSelect()
		{
			this.Layout.GetLayoutItemByKey(this.TempSelect.Value.Item1).SetToggleStateForce(false);
		}

		// Token: 0x0603B216 RID: 242198 RVA: 0x00E199FC File Offset: 0x00E17BFC
		private void InitConfigId()
		{
			SortResultData sortResultData = SortModel.Instance.GetSortResultData(this.UniqueId);
			this.ConfigId = sortResultData.ConfigId;
		}

		// Token: 0x0603B217 RID: 242199 RVA: 0x00E19A28 File Offset: 0x00E17C28
		private void InitTempSelect()
		{
			SortViewBaseSort selectBaseSort = SortModel.Instance.GetSortResultData(this.UniqueId).GetSelectBaseSort();
			this.TempSelect = new ValueTuple<int, string>?(new ValueTuple<int, string>(selectBaseSort.RuleId, selectBaseSort.RuleName));
		}

		// Token: 0x0603B218 RID: 242200 RVA: 0x00E19A68 File Offset: 0x00E17C68
		private void InitSort()
		{
			Sort value = SortConfig.Instance.GetSortConfig(this.ConfigId).Value;
			this.DataType = (ESortDataType)value.DataId;
			this.Layout.RebuildLayoutByDataNew<int>(value.BaseSortList(), null);
		}

		// Token: 0x0603B219 RID: 242201 RVA: 0x00E19AB6 File Offset: 0x00E17CB6
		public void Init(int uniqueId)
		{
			this.UniqueId = uniqueId;
			this.InitConfigId();
			this.InitTempSelect();
			this.InitSort();
		}

		// Token: 0x0603B21A RID: 242202 RVA: 0x00E19AD4 File Offset: 0x00E17CD4
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

		// Token: 0x0603B21B RID: 242203 RVA: 0x00E19B98 File Offset: 0x00E17D98
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTuple<int, string>? GetTempSelect()
		{
			return this.TempSelect;
		}

		// Token: 0x0401ED28 RID: 126248
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<SortItem> Layout;

		// Token: 0x0401ED29 RID: 126249
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private ValueTuple<int, string>? TempSelect;

		// Token: 0x0401ED2A RID: 126250
		private int ConfigId;

		// Token: 0x0401ED2B RID: 126251
		private int UniqueId;

		// Token: 0x0401ED2C RID: 126252
		private ESortDataType DataType = ESortDataType.Role;

		// Token: 0x0200BD6F RID: 48495
		[NullableContext(0)]
		private enum ECompDefine
		{
			// Token: 0x04039242 RID: 234050
			Layout,
			// Token: 0x04039243 RID: 234051
			LayoutItem
		}
	}
}
