using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02004333 RID: 17203
	[NullableContext(1)]
	[Nullable(0)]
	public class PriceData : IPriceData
	{
		// Token: 0x170056FF RID: 22271
		// (get) Token: 0x0602B6FC RID: 177916 RVA: 0x00C3572A File Offset: 0x00C3392A
		// (set) Token: 0x0602B6FD RID: 177917 RVA: 0x00C35732 File Offset: 0x00C33932
		public Func<int> OwnNumber { get; set; }

		// Token: 0x17005700 RID: 22272
		// (get) Token: 0x0602B6FE RID: 177918 RVA: 0x00C3573B File Offset: 0x00C3393B
		// (set) Token: 0x0602B6FF RID: 177919 RVA: 0x00C35743 File Offset: 0x00C33943
		public int NowPrice { get; set; }

		// Token: 0x17005701 RID: 22273
		// (get) Token: 0x0602B700 RID: 177920 RVA: 0x00C3574C File Offset: 0x00C3394C
		// (set) Token: 0x0602B701 RID: 177921 RVA: 0x00C35754 File Offset: 0x00C33954
		public int? OriginalPrice { get; set; }

		// Token: 0x17005702 RID: 22274
		// (get) Token: 0x0602B702 RID: 177922 RVA: 0x00C3575D File Offset: 0x00C3395D
		// (set) Token: 0x0602B703 RID: 177923 RVA: 0x00C35765 File Offset: 0x00C33965
		public int CurrencyId { get; set; }

		// Token: 0x17005703 RID: 22275
		// (get) Token: 0x0602B704 RID: 177924 RVA: 0x00C3576E File Offset: 0x00C3396E
		// (set) Token: 0x0602B705 RID: 177925 RVA: 0x00C35776 File Offset: 0x00C33976
		public bool Enough { get; set; }

		// Token: 0x17005704 RID: 22276
		// (get) Token: 0x0602B706 RID: 177926 RVA: 0x00C3577F File Offset: 0x00C3397F
		// (set) Token: 0x0602B707 RID: 177927 RVA: 0x00C35787 File Offset: 0x00C33987
		public bool InDiscountTime { get; set; }
	}
}
