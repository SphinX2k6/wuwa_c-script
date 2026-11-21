using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components.TearItem
{
	// Token: 0x0200522A RID: 21034
	[NullableContext(2)]
	[Nullable(0)]
	public class PrizeDrawingTearCoverItemBase : UiPanelBase
	{
		// Token: 0x06034559 RID: 214361 RVA: 0x00EA468C File Offset: 0x00EA288C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603455A RID: 214362 RVA: 0x00EA46F8 File Offset: 0x00EA28F8
		[NullableContext(1)]
		public void AttachTearItemToContent(PrizeDrawingTearItemBase tearItem)
		{
			if (this.TearItem != null)
			{
				this.TearItem.Destroy(null);
			}
			this.TearItem = tearItem;
			tearItem.GetRootItem().K2_AttachTo(base.GetItem(0), default(FName), EAttachLocation.KeepRelativeOffset, true);
		}

		// Token: 0x0603455B RID: 214363 RVA: 0x00EA473E File Offset: 0x00EA293E
		public PrizeDrawingTearItemBase GetTearItem()
		{
			return this.TearItem;
		}

		// Token: 0x0401BCC8 RID: 113864
		protected PrizeDrawingTearItemBase TearItem;
	}
}
