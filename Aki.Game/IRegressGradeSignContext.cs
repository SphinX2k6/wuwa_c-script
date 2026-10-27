using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001475 RID: 5237
[NullableContext(1)]
[Nullable(0)]
public struct IRegressGradeSignContext
{
	// Token: 0x17000CEA RID: 3306
	// (get) Token: 0x06009424 RID: 37924 RVA: 0x001FEC1E File Offset: 0x001FCE1E
	// (set) Token: 0x06009425 RID: 37925 RVA: 0x001FEC26 File Offset: 0x001FCE26
	public UUIButtonComponent Btn { readonly get; set; }

	// Token: 0x17000CEB RID: 3307
	// (get) Token: 0x06009426 RID: 37926 RVA: 0x001FEC2F File Offset: 0x001FCE2F
	// (set) Token: 0x06009427 RID: 37927 RVA: 0x001FEC37 File Offset: 0x001FCE37
	public UUIItem RedDotItem { readonly get; set; }

	// Token: 0x17000CEC RID: 3308
	// (get) Token: 0x06009428 RID: 37928 RVA: 0x001FEC40 File Offset: 0x001FCE40
	// (set) Token: 0x06009429 RID: 37929 RVA: 0x001FEC48 File Offset: 0x001FCE48
	public UUITexture CurrencyTexNode { readonly get; set; }

	// Token: 0x17000CED RID: 3309
	// (get) Token: 0x0600942A RID: 37930 RVA: 0x001FEC51 File Offset: 0x001FCE51
	// (set) Token: 0x0600942B RID: 37931 RVA: 0x001FEC59 File Offset: 0x001FCE59
	public UUIText CurrencyText { readonly get; set; }

	// Token: 0x17000CEE RID: 3310
	// (get) Token: 0x0600942C RID: 37932 RVA: 0x001FEC62 File Offset: 0x001FCE62
	// (set) Token: 0x0600942D RID: 37933 RVA: 0x001FEC6A File Offset: 0x001FCE6A
	public UUIItem BubbleNode { readonly get; set; }
}
