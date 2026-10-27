using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C97 RID: 7319
[NullableContext(2)]
[Nullable(0)]
public class GachaTagInfo
{
	// Token: 0x0600DCF3 RID: 56563 RVA: 0x00338FE8 File Offset: 0x003371E8
	public GachaTagInfo(EGachaTagKind kind, string text = null, int? discountPct = null)
	{
		this.Kind = kind;
		this.Text = text;
		this.DiscountPct = discountPct;
	}

	// Token: 0x04006553 RID: 25939
	public EGachaTagKind Kind;

	// Token: 0x04006554 RID: 25940
	public string Text;

	// Token: 0x04006555 RID: 25941
	public int? DiscountPct;
}
