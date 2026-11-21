using System;
using System.Runtime.CompilerServices;

// Token: 0x02001156 RID: 4438
[NullableContext(2)]
[Nullable(0)]
public class GachaTagInfo
{
	// Token: 0x0600B109 RID: 45321 RVA: 0x00344530 File Offset: 0x00342730
	public GachaTagInfo(EGachaTagKind kind, string text = null, int? discountPct = null)
	{
		this.Kind = kind;
		this.Text = text;
		this.DiscountPct = discountPct;
	}

	// Token: 0x04006625 RID: 26149
	public EGachaTagKind Kind;

	// Token: 0x04006626 RID: 26150
	public string Text;

	// Token: 0x04006627 RID: 26151
	public int? DiscountPct;
}
