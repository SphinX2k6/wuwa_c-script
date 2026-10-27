using System;
using System.Runtime.CompilerServices;

// Token: 0x020014A8 RID: 5288
[NullableContext(1)]
[Nullable(0)]
public struct ITaskSubViewTabData
{
	// Token: 0x17000CFC RID: 3324
	// (get) Token: 0x060095BB RID: 38331 RVA: 0x00204B9F File Offset: 0x00202D9F
	// (set) Token: 0x060095BC RID: 38332 RVA: 0x00204BA7 File Offset: 0x00202DA7
	public string TitleKey { readonly get; set; }

	// Token: 0x17000CFD RID: 3325
	// (get) Token: 0x060095BD RID: 38333 RVA: 0x00204BB0 File Offset: 0x00202DB0
	// (set) Token: 0x060095BE RID: 38334 RVA: 0x00204BB8 File Offset: 0x00202DB8
	public string IconName { readonly get; set; }

	// Token: 0x17000CFE RID: 3326
	// (get) Token: 0x060095BF RID: 38335 RVA: 0x00204BC1 File Offset: 0x00202DC1
	// (set) Token: 0x060095C0 RID: 38336 RVA: 0x00204BC9 File Offset: 0x00202DC9
	public EActivityRegressTaskSubViewType Type { readonly get; set; }

	// Token: 0x17000CFF RID: 3327
	// (get) Token: 0x060095C1 RID: 38337 RVA: 0x00204BD2 File Offset: 0x00202DD2
	// (set) Token: 0x060095C2 RID: 38338 RVA: 0x00204BDA File Offset: 0x00202DDA
	public ERedDotName? RedDotName { readonly get; set; }
}
