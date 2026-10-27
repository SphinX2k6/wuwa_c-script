using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02005353 RID: 21331
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemData : IItemData
	{
		// Token: 0x1700833D RID: 33597
		// (get) Token: 0x060367D0 RID: 223184 RVA: 0x00CE6A98 File Offset: 0x00CE4C98
		// (set) Token: 0x060367D1 RID: 223185 RVA: 0x00CE6AA0 File Offset: 0x00CE4CA0
		public int Quality { get; set; }

		// Token: 0x1700833E RID: 33598
		// (get) Token: 0x060367D2 RID: 223186 RVA: 0x00CE6AA9 File Offset: 0x00CE4CA9
		// (set) Token: 0x060367D3 RID: 223187 RVA: 0x00CE6AB1 File Offset: 0x00CE4CB1
		public int ItemId { get; set; }

		// Token: 0x1700833F RID: 33599
		// (get) Token: 0x060367D4 RID: 223188 RVA: 0x00CE6ABA File Offset: 0x00CE4CBA
		// (set) Token: 0x060367D5 RID: 223189 RVA: 0x00CE6AC2 File Offset: 0x00CE4CC2
		public string Name { get; set; }

		// Token: 0x17008340 RID: 33600
		// (get) Token: 0x060367D6 RID: 223190 RVA: 0x00CE6ACB File Offset: 0x00CE4CCB
		// (set) Token: 0x060367D7 RID: 223191 RVA: 0x00CE6AD3 File Offset: 0x00CE4CD3
		public EItemQualityType QualityType { get; set; }
	}
}
