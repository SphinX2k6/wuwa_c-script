using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x0200534F RID: 21327
	[NullableContext(1)]
	public interface IPriceData
	{
		// Token: 0x1700832D RID: 33581
		// (get) Token: 0x060367AF RID: 223151
		// (set) Token: 0x060367B0 RID: 223152
		Func<int> OwnNumber { get; set; }

		// Token: 0x1700832E RID: 33582
		// (get) Token: 0x060367B1 RID: 223153
		// (set) Token: 0x060367B2 RID: 223154
		int NowPrice { get; set; }

		// Token: 0x1700832F RID: 33583
		// (get) Token: 0x060367B3 RID: 223155
		// (set) Token: 0x060367B4 RID: 223156
		int? OriginalPrice { get; set; }

		// Token: 0x17008330 RID: 33584
		// (get) Token: 0x060367B5 RID: 223157
		// (set) Token: 0x060367B6 RID: 223158
		int CurrencyId { get; set; }

		// Token: 0x17008331 RID: 33585
		// (get) Token: 0x060367B7 RID: 223159
		// (set) Token: 0x060367B8 RID: 223160
		bool Enough { get; set; }

		// Token: 0x17008332 RID: 33586
		// (get) Token: 0x060367B9 RID: 223161
		// (set) Token: 0x060367BA RID: 223162
		bool InDiscountTime { get; set; }
	}
}
