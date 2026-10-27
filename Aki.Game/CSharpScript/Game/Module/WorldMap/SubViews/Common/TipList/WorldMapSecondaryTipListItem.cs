using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList
{
	// Token: 0x0200483A RID: 18490
	public class WorldMapSecondaryTipListItem : UiPanelBase, IGridProxy<IWorldMapSecondaryTipItemParam>
	{
		// Token: 0x170078F8 RID: 30968
		// (get) Token: 0x0603062B RID: 198187 RVA: 0x00B3B5E0 File Offset: 0x00B397E0
		// (set) Token: 0x0603062C RID: 198188 RVA: 0x00B3B5E8 File Offset: 0x00B397E8
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<IWorldMapSecondaryTipItemParam>, IWorldMapSecondaryTipItemParam> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x170078F9 RID: 30969
		// (get) Token: 0x0603062D RID: 198189 RVA: 0x00B3B5F1 File Offset: 0x00B397F1
		// (set) Token: 0x0603062E RID: 198190 RVA: 0x00B3B5F9 File Offset: 0x00B397F9
		public int GridIndex { get; set; }

		// Token: 0x170078FA RID: 30970
		// (get) Token: 0x0603062F RID: 198191 RVA: 0x00B3B602 File Offset: 0x00B39802
		// (set) Token: 0x06030630 RID: 198192 RVA: 0x00B3B60A File Offset: 0x00B3980A
		public int DisplayIndex { get; set; }

		// Token: 0x06030631 RID: 198193 RVA: 0x00B3B614 File Offset: 0x00B39814
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030632 RID: 198194 RVA: 0x00B3B67D File Offset: 0x00B3987D
		[NullableContext(1)]
		public virtual void Refresh(IWorldMapSecondaryTipItemParam data, bool isSelected, int gridIndex)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(data.Name, true);
			}
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(data.Desc, true);
		}

		// Token: 0x06030633 RID: 198195 RVA: 0x00B3B6B0 File Offset: 0x00B398B0
		public void Clear()
		{
		}

		// Token: 0x06030634 RID: 198196 RVA: 0x00B3B6B2 File Offset: 0x00B398B2
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06030635 RID: 198197 RVA: 0x00B3B6B4 File Offset: 0x00B398B4
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06030636 RID: 198198 RVA: 0x00B3B6B6 File Offset: 0x00B398B6
		[NullableContext(1)]
		public object GetKey(IWorldMapSecondaryTipItemParam data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x06030637 RID: 198199 RVA: 0x00B3B6C3 File Offset: 0x00B398C3
		[NullableContext(2)]
		protected UUIText GetNameTxt()
		{
			return base.GetText(0);
		}

		// Token: 0x06030638 RID: 198200 RVA: 0x00B3B6CC File Offset: 0x00B398CC
		[NullableContext(2)]
		protected UUIText GetDescTxt()
		{
			return base.GetText(1);
		}

		// Token: 0x0200AB12 RID: 43794
		private static class EComponents
		{
			// Token: 0x04033FDF RID: 212959
			public const int TxtItemName = 0;

			// Token: 0x04033FE0 RID: 212960
			public const int TxtItemDesc = 1;
		}
	}
}
