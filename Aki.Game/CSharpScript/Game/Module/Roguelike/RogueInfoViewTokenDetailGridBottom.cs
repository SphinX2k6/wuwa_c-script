using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DC8 RID: 15816
	public class RogueInfoViewTokenDetailGridBottom : MediumItemGridComponent
	{
		// Token: 0x060286BD RID: 165565 RVA: 0x00B53421 File Offset: 0x00B51621
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemRogue";
		}

		// Token: 0x060286BE RID: 165566 RVA: 0x00B53428 File Offset: 0x00B51628
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060286BF RID: 165567 RVA: 0x00B53491 File Offset: 0x00B51691
		protected override void OnActivate()
		{
			this.CommonElementItem = new CommonElementItem();
			this.CommonElementItem.CreateThenShowByActorAsync(base.GetItem(0).GetOwner());
		}

		// Token: 0x060286C0 RID: 165568 RVA: 0x00B534B8 File Offset: 0x00B516B8
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
			this.CommonElementItem.Update(sortElementInfoArrayByCount[0].ElementId);
			this.CommonElementItem.RefreshPanel();
			base.GetText(1).SetText(sortElementInfoArrayByCount[0].Count.ToString(), true);
		}

		// Token: 0x04015F2E RID: 89902
		[Nullable(2)]
		private CommonElementItem CommonElementItem;

		// Token: 0x020099C1 RID: 39361
		private class ERogueInfoViewTokenDetailGridBottomDefine
		{
			// Token: 0x0402FEFC RID: 196348
			public const int ElementItem = 0;

			// Token: 0x0402FEFD RID: 196349
			public const int ElementNumText = 1;
		}
	}
}
