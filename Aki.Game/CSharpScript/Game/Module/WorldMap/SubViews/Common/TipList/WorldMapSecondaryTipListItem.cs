using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList
{
	// Token: 0x0200376B RID: 14187
	public class WorldMapSecondaryTipListItem : UiPanelBase, IGridProxy<IWorldMapSecondaryTipItemParam>
	{
		// Token: 0x17004BB5 RID: 19381
		// (get) Token: 0x06024DFB RID: 151035 RVA: 0x00A6B6AC File Offset: 0x00A698AC
		// (set) Token: 0x06024DFC RID: 151036 RVA: 0x00A6B6B4 File Offset: 0x00A698B4
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

		// Token: 0x17004BB6 RID: 19382
		// (get) Token: 0x06024DFD RID: 151037 RVA: 0x00A6B6BD File Offset: 0x00A698BD
		// (set) Token: 0x06024DFE RID: 151038 RVA: 0x00A6B6C5 File Offset: 0x00A698C5
		public int GridIndex { get; set; }

		// Token: 0x17004BB7 RID: 19383
		// (get) Token: 0x06024DFF RID: 151039 RVA: 0x00A6B6CE File Offset: 0x00A698CE
		// (set) Token: 0x06024E00 RID: 151040 RVA: 0x00A6B6D6 File Offset: 0x00A698D6
		public int DisplayIndex { get; set; }

		// Token: 0x06024E01 RID: 151041 RVA: 0x00A6B6E0 File Offset: 0x00A698E0
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

		// Token: 0x06024E02 RID: 151042 RVA: 0x00A6B749 File Offset: 0x00A69949
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

		// Token: 0x06024E03 RID: 151043 RVA: 0x00A6B77C File Offset: 0x00A6997C
		public void Clear()
		{
		}

		// Token: 0x06024E04 RID: 151044 RVA: 0x00A6B77E File Offset: 0x00A6997E
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06024E05 RID: 151045 RVA: 0x00A6B780 File Offset: 0x00A69980
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06024E06 RID: 151046 RVA: 0x00A6B782 File Offset: 0x00A69982
		[NullableContext(1)]
		public object GetKey(IWorldMapSecondaryTipItemParam data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x06024E07 RID: 151047 RVA: 0x00A6B78F File Offset: 0x00A6998F
		[NullableContext(2)]
		protected UUIText GetNameTxt()
		{
			return base.GetText(0);
		}

		// Token: 0x06024E08 RID: 151048 RVA: 0x00A6B798 File Offset: 0x00A69998
		[NullableContext(2)]
		protected UUIText GetDescTxt()
		{
			return base.GetText(1);
		}

		// Token: 0x020094C1 RID: 38081
		private static class EComponents
		{
			// Token: 0x0402E75F RID: 190303
			public const int TxtItemName = 0;

			// Token: 0x0402E760 RID: 190304
			public const int TxtItemDesc = 1;
		}
	}
}
