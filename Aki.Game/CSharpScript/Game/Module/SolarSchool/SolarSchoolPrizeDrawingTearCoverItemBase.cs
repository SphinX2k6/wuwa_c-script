using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005921 RID: 22817
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolPrizeDrawingTearCoverItemBase : UiPanelBase
	{
		// Token: 0x060383C5 RID: 230341 RVA: 0x00FB8FE4 File Offset: 0x00FB71E4
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

		// Token: 0x060383C6 RID: 230342 RVA: 0x00FB9050 File Offset: 0x00FB7250
		[NullableContext(1)]
		public void AttachTearItemToContent(SolarSchoolPrizeDrawingTearItemBase tearItem)
		{
			if (this.TearItem != null)
			{
				this.TearItem.Destroy(null);
			}
			this.TearItem = tearItem;
			tearItem.GetRootItem().K2_AttachTo(base.GetItem(0), default(FName), EAttachLocation.KeepRelativeOffset, true);
		}

		// Token: 0x060383C7 RID: 230343 RVA: 0x00FB9096 File Offset: 0x00FB7296
		public SolarSchoolPrizeDrawingTearItemBase GetTearItem()
		{
			return this.TearItem;
		}

		// Token: 0x0401D9D4 RID: 121300
		protected SolarSchoolPrizeDrawingTearItemBase TearItem;
	}
}
