using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DD1 RID: 3537
[NullableContext(2)]
public interface IMediumItemPrice
{
	// Token: 0x17000FCD RID: 4045
	// (get) Token: 0x06009012 RID: 36882
	// (set) Token: 0x06009013 RID: 36883
	int CurPrice { get; set; }

	// Token: 0x17000FCE RID: 4046
	// (get) Token: 0x06009014 RID: 36884
	// (set) Token: 0x06009015 RID: 36885
	int? OriginalPrice { get; set; }

	// Token: 0x17000FCF RID: 4047
	// (get) Token: 0x06009016 RID: 36886
	// (set) Token: 0x06009017 RID: 36887
	string TexPath { get; set; }

	// Token: 0x17000FD0 RID: 4048
	// (get) Token: 0x06009018 RID: 36888
	// (set) Token: 0x06009019 RID: 36889
	bool? CurrencyNotEnough { get; set; }
}
