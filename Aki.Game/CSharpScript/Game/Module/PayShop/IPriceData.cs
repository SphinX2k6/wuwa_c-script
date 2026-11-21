using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02004332 RID: 17202
	[NullableContext(1)]
	public interface IPriceData
	{
		// Token: 0x170056F9 RID: 22265
		// (get) Token: 0x0602B6F0 RID: 177904
		// (set) Token: 0x0602B6F1 RID: 177905
		Func<int> OwnNumber { get; set; }

		// Token: 0x170056FA RID: 22266
		// (get) Token: 0x0602B6F2 RID: 177906
		// (set) Token: 0x0602B6F3 RID: 177907
		int NowPrice { get; set; }

		// Token: 0x170056FB RID: 22267
		// (get) Token: 0x0602B6F4 RID: 177908
		// (set) Token: 0x0602B6F5 RID: 177909
		int? OriginalPrice { get; set; }

		// Token: 0x170056FC RID: 22268
		// (get) Token: 0x0602B6F6 RID: 177910
		// (set) Token: 0x0602B6F7 RID: 177911
		int CurrencyId { get; set; }

		// Token: 0x170056FD RID: 22269
		// (get) Token: 0x0602B6F8 RID: 177912
		// (set) Token: 0x0602B6F9 RID: 177913
		bool Enough { get; set; }

		// Token: 0x170056FE RID: 22270
		// (get) Token: 0x0602B6FA RID: 177914
		// (set) Token: 0x0602B6FB RID: 177915
		bool InDiscountTime { get; set; }
	}
}
