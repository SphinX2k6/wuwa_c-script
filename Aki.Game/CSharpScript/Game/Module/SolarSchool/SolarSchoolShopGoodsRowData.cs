using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A0C RID: 23052
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolShopGoodsRowData
	{
		// Token: 0x17006C6A RID: 27754
		// (get) Token: 0x06038C20 RID: 232480 RVA: 0x00FE2FEC File Offset: 0x00FE11EC
		public IReadOnlyList<SolarSchoolShopSlotData> Slots { get; }

		// Token: 0x06038C21 RID: 232481 RVA: 0x00FE2FF4 File Offset: 0x00FE11F4
		public SolarSchoolShopGoodsRowData(IReadOnlyList<SolarSchoolShopSlotData> slots)
		{
			this.Slots = slots;
		}
	}
}
