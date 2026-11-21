using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000929 RID: 2345
[NullableContext(1)]
[Nullable(0)]
public struct IRegressGradeSignContext
{
	// Token: 0x17000D0A RID: 3338
	// (get) Token: 0x060067B9 RID: 26553 RVA: 0x00207B82 File Offset: 0x00205D82
	// (set) Token: 0x060067BA RID: 26554 RVA: 0x00207B8A File Offset: 0x00205D8A
	public UUIButtonComponent Btn { readonly get; set; }

	// Token: 0x17000D0B RID: 3339
	// (get) Token: 0x060067BB RID: 26555 RVA: 0x00207B93 File Offset: 0x00205D93
	// (set) Token: 0x060067BC RID: 26556 RVA: 0x00207B9B File Offset: 0x00205D9B
	public UUIItem RedDotItem { readonly get; set; }

	// Token: 0x17000D0C RID: 3340
	// (get) Token: 0x060067BD RID: 26557 RVA: 0x00207BA4 File Offset: 0x00205DA4
	// (set) Token: 0x060067BE RID: 26558 RVA: 0x00207BAC File Offset: 0x00205DAC
	public UUITexture CurrencyTexNode { readonly get; set; }

	// Token: 0x17000D0D RID: 3341
	// (get) Token: 0x060067BF RID: 26559 RVA: 0x00207BB5 File Offset: 0x00205DB5
	// (set) Token: 0x060067C0 RID: 26560 RVA: 0x00207BBD File Offset: 0x00205DBD
	public UUIText CurrencyText { readonly get; set; }

	// Token: 0x17000D0E RID: 3342
	// (get) Token: 0x060067C1 RID: 26561 RVA: 0x00207BC6 File Offset: 0x00205DC6
	// (set) Token: 0x060067C2 RID: 26562 RVA: 0x00207BCE File Offset: 0x00205DCE
	public UUIItem BubbleNode { readonly get; set; }
}
