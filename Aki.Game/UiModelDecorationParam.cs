using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020021CB RID: 8651
[NullableContext(1)]
[Nullable(0)]
public class UiModelDecorationParam : IUiModelDecorationParam
{
	// Token: 0x17002039 RID: 8249
	// (get) Token: 0x060154B0 RID: 87216 RVA: 0x006313FB File Offset: 0x0062F5FB
	// (set) Token: 0x060154B1 RID: 87217 RVA: 0x00631403 File Offset: 0x0062F603
	public string SocketName { get; set; }

	// Token: 0x1700203A RID: 8250
	// (get) Token: 0x060154B2 RID: 87218 RVA: 0x0063140C File Offset: 0x0062F60C
	// (set) Token: 0x060154B3 RID: 87219 RVA: 0x00631414 File Offset: 0x0062F614
	public USkeletalMesh SkeletalMesh { get; set; }

	// Token: 0x1700203B RID: 8251
	// (get) Token: 0x060154B4 RID: 87220 RVA: 0x0063141D File Offset: 0x0062F61D
	// (set) Token: 0x060154B5 RID: 87221 RVA: 0x00631425 File Offset: 0x0062F625
	public FTransform Transform { get; set; }
}
