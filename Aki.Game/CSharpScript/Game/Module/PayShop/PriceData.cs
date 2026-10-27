using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02005350 RID: 21328
	[NullableContext(1)]
	[Nullable(0)]
	public class PriceData : IPriceData
	{
		// Token: 0x17008333 RID: 33587
		// (get) Token: 0x060367BB RID: 223163 RVA: 0x00CE6A2A File Offset: 0x00CE4C2A
		// (set) Token: 0x060367BC RID: 223164 RVA: 0x00CE6A32 File Offset: 0x00CE4C32
		public Func<int> OwnNumber { get; set; }

		// Token: 0x17008334 RID: 33588
		// (get) Token: 0x060367BD RID: 223165 RVA: 0x00CE6A3B File Offset: 0x00CE4C3B
		// (set) Token: 0x060367BE RID: 223166 RVA: 0x00CE6A43 File Offset: 0x00CE4C43
		public int NowPrice { get; set; }

		// Token: 0x17008335 RID: 33589
		// (get) Token: 0x060367BF RID: 223167 RVA: 0x00CE6A4C File Offset: 0x00CE4C4C
		// (set) Token: 0x060367C0 RID: 223168 RVA: 0x00CE6A54 File Offset: 0x00CE4C54
		public int? OriginalPrice { get; set; }

		// Token: 0x17008336 RID: 33590
		// (get) Token: 0x060367C1 RID: 223169 RVA: 0x00CE6A5D File Offset: 0x00CE4C5D
		// (set) Token: 0x060367C2 RID: 223170 RVA: 0x00CE6A65 File Offset: 0x00CE4C65
		public int CurrencyId { get; set; }

		// Token: 0x17008337 RID: 33591
		// (get) Token: 0x060367C3 RID: 223171 RVA: 0x00CE6A6E File Offset: 0x00CE4C6E
		// (set) Token: 0x060367C4 RID: 223172 RVA: 0x00CE6A76 File Offset: 0x00CE4C76
		public bool Enough { get; set; }

		// Token: 0x17008338 RID: 33592
		// (get) Token: 0x060367C5 RID: 223173 RVA: 0x00CE6A7F File Offset: 0x00CE4C7F
		// (set) Token: 0x060367C6 RID: 223174 RVA: 0x00CE6A87 File Offset: 0x00CE4C87
		public bool InDiscountTime { get; set; }
	}
}
