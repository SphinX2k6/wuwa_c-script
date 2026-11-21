using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DC5 RID: 15813
	public class RogueInfoViewTokenElement : MediumItemGridComponent
	{
		// Token: 0x060286AF RID: 165551 RVA: 0x00B53145 File Offset: 0x00B51345
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemRogueElement";
		}

		// Token: 0x060286B0 RID: 165552 RVA: 0x00B5314C File Offset: 0x00B5134C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060286B1 RID: 165553 RVA: 0x00B53194 File Offset: 0x00B51394
		protected override void OnActivate()
		{
			this.GenericLayout = new GenericLayout<CommonElementItem, int>(base.GetVerticalLayout(0), new Func<CommonElementItem>(this.CreateElement), null, false, true);
		}

		// Token: 0x060286B2 RID: 165554 RVA: 0x00B531B7 File Offset: 0x00B513B7
		[NullableContext(1)]
		private CommonElementItem CreateElement()
		{
			return new CommonElementItem();
		}

		// Token: 0x060286B3 RID: 165555 RVA: 0x00B531C0 File Offset: 0x00B513C0
		[NullableContext(2)]
		protected override void OnRefresh(object param = null)
		{
			RogueGainEntry rogueGainEntry = param as RogueGainEntry;
			if (rogueGainEntry == null)
			{
				return;
			}
			List<ElementInfo> sortElementInfoArrayByCount = rogueGainEntry.GetSortElementInfoArrayByCount(false);
			if (sortElementInfoArrayByCount.Count <= 0)
			{
				return;
			}
			ElementInfo elementInfo = sortElementInfoArrayByCount[0];
			List<int> list = new List<int>();
			for (int i = 0; i < elementInfo.Count; i++)
			{
				list.Add(elementInfo.ElementId);
			}
			GenericLayout<CommonElementItem, int> genericLayout = this.GenericLayout;
			if (genericLayout == null)
			{
				return;
			}
			genericLayout.RefreshByData(list, null, false);
		}

		// Token: 0x04015F2D RID: 89901
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonElementItem, int> GenericLayout;

		// Token: 0x020099BE RID: 39358
		private class ERogueInfoViewTokenElement
		{
			// Token: 0x0402FEF8 RID: 196344
			public const int Layout = 0;
		}
	}
}
