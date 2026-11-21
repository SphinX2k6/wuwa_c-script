using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A0B RID: 23051
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct SolarSchoolShopSlotData
	{
		// Token: 0x17006C68 RID: 27752
		// (get) Token: 0x06038C1C RID: 232476 RVA: 0x00FE2FC3 File Offset: 0x00FE11C3
		public SolarSchoolShopGoodsData Goods { get; }

		// Token: 0x17006C69 RID: 27753
		// (get) Token: 0x06038C1D RID: 232477 RVA: 0x00FE2FCB File Offset: 0x00FE11CB
		public bool IsEmpty
		{
			get
			{
				return this.Goods == null;
			}
		}

		// Token: 0x06038C1E RID: 232478 RVA: 0x00FE2FD6 File Offset: 0x00FE11D6
		public SolarSchoolShopSlotData(SolarSchoolShopGoodsData goods)
		{
			this.Goods = goods;
		}

		// Token: 0x0401DE0A RID: 122378
		public static readonly SolarSchoolShopSlotData Empty = new SolarSchoolShopSlotData(null);
	}
}
