using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FilterSort.Sort.AttributeSort
{
	// Token: 0x02004B1E RID: 19230
	[NullableContext(1)]
	[Nullable(0)]
	public class AttributeSortGroup : UiPanelBase
	{
		// Token: 0x060301A3 RID: 197027 RVA: 0x00D6ABA5 File Offset: 0x00D68DA5
		public AttributeSortGroup(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x060301A4 RID: 197028 RVA: 0x00D6ABCC File Offset: 0x00D68DCC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060301A5 RID: 197029 RVA: 0x00D6AC56 File Offset: 0x00D68E56
		protected override void OnStart()
		{
			this.Layout = new GenericLayoutNew<SortItem>(base.GetLayoutBase(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<SortItem>(this.InitSortItem), base.GetItem(2));
		}

		// Token: 0x060301A6 RID: 197030 RVA: 0x00D6AC80 File Offset: 0x00D68E80
		private ILayoutItem<SortItem> InitSortItem(object tempRuleId, UUIItem uiItem, int index)
		{
			int num = (int)tempRuleId;
			SortItem sortItem = new SortItem(uiItem);
			sortItem.SetToggleFunction(new TSortItemToggleEventWithState(this.SortItemToggleEvent));
			sortItem.SetCanExecuteChange(new TCanExecuteChangeSimple(this.CanExecuteChange));
			int num2 = this.FindSortIndex(num);
			sortItem.ShowSortItem(num, this.DataType, num2 + 1);
			return new LayoutItem<SortItem>
			{
				Key = num,
				Value = sortItem
			};
		}

		// Token: 0x060301A7 RID: 197031 RVA: 0x00D6ACEF File Offset: 0x00D68EEF
		private void SortItemToggleEvent(EToggleState state, int ruleId, string name)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.TempSelectMap.Add(ruleId, name);
			}
			else
			{
				this.TempSelectMap.Remove(ruleId);
				this.CancelSortIndex(ruleId);
			}
			this.RefreshSortIndex();
			this.SetTitle();
		}

		// Token: 0x060301A8 RID: 197032 RVA: 0x00D6AD24 File Offset: 0x00D68F24
		private bool CanExecuteChange()
		{
			return this.LimitNum == 0 || this.TempSelectMap.Count < this.LimitNum;
		}

		// Token: 0x060301A9 RID: 197033 RVA: 0x00D6AD43 File Offset: 0x00D68F43
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060301AA RID: 197034 RVA: 0x00D6AD48 File Offset: 0x00D68F48
		private int FindSortIndex(int ruleId)
		{
			int num = 0;
			using (Dictionary<int, string>.KeyCollection.Enumerator enumerator = this.TempSelectMap.Keys.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == ruleId)
					{
						return num;
					}
					num++;
				}
			}
			return -1;
		}

		// Token: 0x060301AB RID: 197035 RVA: 0x00D6ADA8 File Offset: 0x00D68FA8
		private void CancelSortIndex(int ruleId)
		{
			this.Layout.GetLayoutItemByKey(ruleId).RefreshIndex(0);
		}

		// Token: 0x060301AC RID: 197036 RVA: 0x00D6ADC4 File Offset: 0x00D68FC4
		private void RefreshSortIndex()
		{
			int num = 0;
			foreach (int num2 in this.TempSelectMap.Keys)
			{
				this.Layout.GetLayoutItemByKey(num2).RefreshIndex(num + 1);
				num++;
			}
		}

		// Token: 0x060301AD RID: 197037 RVA: 0x00D6AE34 File Offset: 0x00D69034
		private void InitConfigId()
		{
			SortResultData sortResultData = SortModel.Instance.GetSortResultData(this.UniqueId);
			this.ConfigId = sortResultData.ConfigId;
		}

		// Token: 0x060301AE RID: 197038 RVA: 0x00D6AE60 File Offset: 0x00D69060
		private void InitTempSelectList()
		{
			Dictionary<int, string> selectAttributeSort = SortModel.Instance.GetSortResultData(this.UniqueId).GetSelectAttributeSort();
			if (selectAttributeSort == null)
			{
				return;
			}
			foreach (KeyValuePair<int, string> keyValuePair in selectAttributeSort)
			{
				this.TempSelectMap.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x060301AF RID: 197039 RVA: 0x00D6AEDC File Offset: 0x00D690DC
		private void InitSort()
		{
			Sort value = SortConfig.Instance.GetSortConfig(this.ConfigId).Value;
			this.LimitNum = value.LimitNum;
			this.DataType = (ESortDataType)value.DataId;
			this.Layout.RebuildLayoutByDataNew<int>(value.AttributeSortList(), null);
		}

		// Token: 0x060301B0 RID: 197040 RVA: 0x00D6AF38 File Offset: 0x00D69138
		private void SetTitle()
		{
			UUIText text = base.GetText(0);
			if (this.LimitNum == 0)
			{
				LguiUtil.Instance.SetLocalText(text, "AttributeSortName", Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalText(text, "AttributeSortLimitName", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.TempSelectMap.Count,
				this.LimitNum
			}));
		}

		// Token: 0x060301B1 RID: 197041 RVA: 0x00D6AFA7 File Offset: 0x00D691A7
		public void Init(int uniqueId)
		{
			this.UniqueId = uniqueId;
			this.InitConfigId();
			this.InitTempSelectList();
			this.InitSort();
			this.SetTitle();
		}

		// Token: 0x060301B2 RID: 197042 RVA: 0x00D6AFC8 File Offset: 0x00D691C8
		public void Reset()
		{
			this.TempSelectMap.Clear();
			foreach (KeyValuePair<object, SortItem> keyValuePair in this.Layout.GetLayoutItemMap())
			{
				int ruleId = (int)keyValuePair.Key;
				keyValuePair.Value.ShowSortItem(ruleId, this.DataType, 0);
			}
			this.SetTitle();
		}

		// Token: 0x060301B3 RID: 197043 RVA: 0x00D6B04C File Offset: 0x00D6924C
		public Dictionary<int, string> GetTempSelectMap()
		{
			return this.TempSelectMap;
		}

		// Token: 0x040197EE RID: 104430
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<SortItem> Layout;

		// Token: 0x040197EF RID: 104431
		private readonly Dictionary<int, string> TempSelectMap = new Dictionary<int, string>();

		// Token: 0x040197F0 RID: 104432
		private int ConfigId;

		// Token: 0x040197F1 RID: 104433
		private int UniqueId;

		// Token: 0x040197F2 RID: 104434
		private ESortDataType DataType = ESortDataType.Role;

		// Token: 0x040197F3 RID: 104435
		private int LimitNum;

		// Token: 0x0200A77A RID: 42874
		[NullableContext(0)]
		private enum ECompDefine
		{
			// Token: 0x04033C16 RID: 211990
			Title,
			// Token: 0x04033C17 RID: 211991
			Layout,
			// Token: 0x04033C18 RID: 211992
			LayoutItem
		}
	}
}
