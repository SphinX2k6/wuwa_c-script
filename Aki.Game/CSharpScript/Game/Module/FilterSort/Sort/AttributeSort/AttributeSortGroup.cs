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
	// Token: 0x02005B3D RID: 23357
	[NullableContext(1)]
	[Nullable(0)]
	public class AttributeSortGroup : UiPanelBase
	{
		// Token: 0x0603B231 RID: 242225 RVA: 0x00E19E8D File Offset: 0x00E1808D
		public AttributeSortGroup(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B232 RID: 242226 RVA: 0x00E19EB4 File Offset: 0x00E180B4
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

		// Token: 0x0603B233 RID: 242227 RVA: 0x00E19F3E File Offset: 0x00E1813E
		protected override void OnStart()
		{
			this.Layout = new GenericLayoutNew<SortItem>(base.GetLayoutBase(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<SortItem>(this.InitSortItem), base.GetItem(2));
		}

		// Token: 0x0603B234 RID: 242228 RVA: 0x00E19F68 File Offset: 0x00E18168
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

		// Token: 0x0603B235 RID: 242229 RVA: 0x00E19FD7 File Offset: 0x00E181D7
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

		// Token: 0x0603B236 RID: 242230 RVA: 0x00E1A00C File Offset: 0x00E1820C
		private bool CanExecuteChange()
		{
			return this.LimitNum == 0 || this.TempSelectMap.Count < this.LimitNum;
		}

		// Token: 0x0603B237 RID: 242231 RVA: 0x00E1A02B File Offset: 0x00E1822B
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603B238 RID: 242232 RVA: 0x00E1A030 File Offset: 0x00E18230
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

		// Token: 0x0603B239 RID: 242233 RVA: 0x00E1A090 File Offset: 0x00E18290
		private void CancelSortIndex(int ruleId)
		{
			this.Layout.GetLayoutItemByKey(ruleId).RefreshIndex(0);
		}

		// Token: 0x0603B23A RID: 242234 RVA: 0x00E1A0AC File Offset: 0x00E182AC
		private void RefreshSortIndex()
		{
			int num = 0;
			foreach (int num2 in this.TempSelectMap.Keys)
			{
				this.Layout.GetLayoutItemByKey(num2).RefreshIndex(num + 1);
				num++;
			}
		}

		// Token: 0x0603B23B RID: 242235 RVA: 0x00E1A11C File Offset: 0x00E1831C
		private void InitConfigId()
		{
			SortResultData sortResultData = SortModel.Instance.GetSortResultData(this.UniqueId);
			this.ConfigId = sortResultData.ConfigId;
		}

		// Token: 0x0603B23C RID: 242236 RVA: 0x00E1A148 File Offset: 0x00E18348
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

		// Token: 0x0603B23D RID: 242237 RVA: 0x00E1A1C4 File Offset: 0x00E183C4
		private void InitSort()
		{
			Sort value = SortConfig.Instance.GetSortConfig(this.ConfigId).Value;
			this.LimitNum = value.LimitNum;
			this.DataType = (ESortDataType)value.DataId;
			this.Layout.RebuildLayoutByDataNew<int>(value.AttributeSortList(), null);
		}

		// Token: 0x0603B23E RID: 242238 RVA: 0x00E1A220 File Offset: 0x00E18420
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

		// Token: 0x0603B23F RID: 242239 RVA: 0x00E1A28F File Offset: 0x00E1848F
		public void Init(int uniqueId)
		{
			this.UniqueId = uniqueId;
			this.InitConfigId();
			this.InitTempSelectList();
			this.InitSort();
			this.SetTitle();
		}

		// Token: 0x0603B240 RID: 242240 RVA: 0x00E1A2B0 File Offset: 0x00E184B0
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

		// Token: 0x0603B241 RID: 242241 RVA: 0x00E1A334 File Offset: 0x00E18534
		public Dictionary<int, string> GetTempSelectMap()
		{
			return this.TempSelectMap;
		}

		// Token: 0x0401ED32 RID: 126258
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<SortItem> Layout;

		// Token: 0x0401ED33 RID: 126259
		private readonly Dictionary<int, string> TempSelectMap = new Dictionary<int, string>();

		// Token: 0x0401ED34 RID: 126260
		private int ConfigId;

		// Token: 0x0401ED35 RID: 126261
		private int UniqueId;

		// Token: 0x0401ED36 RID: 126262
		private ESortDataType DataType = ESortDataType.Role;

		// Token: 0x0401ED37 RID: 126263
		private int LimitNum;

		// Token: 0x0200BD71 RID: 48497
		[NullableContext(0)]
		private enum ECompDefine
		{
			// Token: 0x0403924A RID: 234058
			Title,
			// Token: 0x0403924B RID: 234059
			Layout,
			// Token: 0x0403924C RID: 234060
			LayoutItem
		}
	}
}
