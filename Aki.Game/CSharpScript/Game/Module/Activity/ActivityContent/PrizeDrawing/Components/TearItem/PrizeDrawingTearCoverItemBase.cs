using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components.TearItem
{
	// Token: 0x020062AC RID: 25260
	[NullableContext(2)]
	[Nullable(0)]
	public class PrizeDrawingTearCoverItemBase : UiPanelBase
	{
		// Token: 0x0603F898 RID: 260248 RVA: 0x00F5D730 File Offset: 0x00F5B930
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

		// Token: 0x0603F899 RID: 260249 RVA: 0x00F5D79C File Offset: 0x00F5B99C
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

		// Token: 0x0603F89A RID: 260250 RVA: 0x00F5D7E2 File Offset: 0x00F5B9E2
		public PrizeDrawingTearItemBase GetTearItem()
		{
			return this.TearItem;
		}

		// Token: 0x04021399 RID: 136089
		protected PrizeDrawingTearItemBase TearItem;
	}
}
