using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200220E RID: 8718
[NullableContext(1)]
[Nullable(0)]
public class ActiveMaterialEntry : IActiveMaterialEntry
{
	// Token: 0x1700208E RID: 8334
	// (get) Token: 0x06015705 RID: 87813 RVA: 0x00639A10 File Offset: 0x00637C10
	// (set) Token: 0x06015706 RID: 87814 RVA: 0x00639A18 File Offset: 0x00637C18
	public UObject Data { get; set; }

	// Token: 0x1700208F RID: 8335
	// (get) Token: 0x06015707 RID: 87815 RVA: 0x00639A21 File Offset: 0x00637C21
	// (set) Token: 0x06015708 RID: 87816 RVA: 0x00639A29 File Offset: 0x00637C29
	public bool IsGroup { get; set; }

	// Token: 0x17002090 RID: 8336
	// (get) Token: 0x06015709 RID: 87817 RVA: 0x00639A32 File Offset: 0x00637C32
	// (set) Token: 0x0601570A RID: 87818 RVA: 0x00639A3A File Offset: 0x00637C3A
	public bool WithAnimObject { get; set; }
}
