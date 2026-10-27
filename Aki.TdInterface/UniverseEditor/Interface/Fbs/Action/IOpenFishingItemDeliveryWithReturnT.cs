using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BFB RID: 27643
	public class IOpenFishingItemDeliveryWithReturnT
	{
		// Token: 0x1700CD8E RID: 52622
		// (get) Token: 0x06030983 RID: 199043 RVA: 0x00698B79 File Offset: 0x00696D79
		// (set) Token: 0x06030984 RID: 199044 RVA: 0x00698B81 File Offset: 0x00696D81
		public ESystemType Type { get; set; }

		// Token: 0x1700CD8F RID: 52623
		// (get) Token: 0x06030985 RID: 199045 RVA: 0x00698B8A File Offset: 0x00696D8A
		// (set) Token: 0x06030986 RID: 199046 RVA: 0x00698B92 File Offset: 0x00696D92
		public int PresetId { get; set; }

		// Token: 0x1700CD90 RID: 52624
		// (get) Token: 0x06030987 RID: 199047 RVA: 0x00698B9B File Offset: 0x00696D9B
		// (set) Token: 0x06030988 RID: 199048 RVA: 0x00698BA3 File Offset: 0x00696DA3
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06030989 RID: 199049 RVA: 0x00698BAC File Offset: 0x00696DAC
		public IOpenFishingItemDeliveryWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.PresetId = 0;
			this.ReturnVar = null;
		}
	}
}
