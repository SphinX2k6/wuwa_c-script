using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02004336 RID: 17206
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemData : IItemData
	{
		// Token: 0x17005709 RID: 22281
		// (get) Token: 0x0602B711 RID: 177937 RVA: 0x00C35798 File Offset: 0x00C33998
		// (set) Token: 0x0602B712 RID: 177938 RVA: 0x00C357A0 File Offset: 0x00C339A0
		public int Quality { get; set; }

		// Token: 0x1700570A RID: 22282
		// (get) Token: 0x0602B713 RID: 177939 RVA: 0x00C357A9 File Offset: 0x00C339A9
		// (set) Token: 0x0602B714 RID: 177940 RVA: 0x00C357B1 File Offset: 0x00C339B1
		public int ItemId { get; set; }

		// Token: 0x1700570B RID: 22283
		// (get) Token: 0x0602B715 RID: 177941 RVA: 0x00C357BA File Offset: 0x00C339BA
		// (set) Token: 0x0602B716 RID: 177942 RVA: 0x00C357C2 File Offset: 0x00C339C2
		public string Name { get; set; }

		// Token: 0x1700570C RID: 22284
		// (get) Token: 0x0602B717 RID: 177943 RVA: 0x00C357CB File Offset: 0x00C339CB
		// (set) Token: 0x0602B718 RID: 177944 RVA: 0x00C357D3 File Offset: 0x00C339D3
		public EItemQualityType QualityType { get; set; }
	}
}
