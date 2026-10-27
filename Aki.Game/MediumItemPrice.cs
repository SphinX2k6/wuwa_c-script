using System;
using System.Runtime.CompilerServices;

// Token: 0x02001919 RID: 6425
[NullableContext(2)]
[Nullable(0)]
public class MediumItemPrice : IMediumItemPrice
{
	// Token: 0x17000FAE RID: 4014
	// (get) Token: 0x0600BC30 RID: 48176 RVA: 0x002AA2FD File Offset: 0x002A84FD
	// (set) Token: 0x0600BC31 RID: 48177 RVA: 0x002AA305 File Offset: 0x002A8505
	public int CurPrice { get; set; }

	// Token: 0x17000FAF RID: 4015
	// (get) Token: 0x0600BC32 RID: 48178 RVA: 0x002AA30E File Offset: 0x002A850E
	// (set) Token: 0x0600BC33 RID: 48179 RVA: 0x002AA316 File Offset: 0x002A8516
	public int? OriginalPrice { get; set; }

	// Token: 0x17000FB0 RID: 4016
	// (get) Token: 0x0600BC34 RID: 48180 RVA: 0x002AA31F File Offset: 0x002A851F
	// (set) Token: 0x0600BC35 RID: 48181 RVA: 0x002AA327 File Offset: 0x002A8527
	public string TexPath { get; set; }

	// Token: 0x17000FB1 RID: 4017
	// (get) Token: 0x0600BC36 RID: 48182 RVA: 0x002AA330 File Offset: 0x002A8530
	// (set) Token: 0x0600BC37 RID: 48183 RVA: 0x002AA338 File Offset: 0x002A8538
	public bool? CurrencyNotEnough { get; set; }
}
