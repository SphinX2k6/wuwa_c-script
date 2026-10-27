using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002CB5 RID: 11445
[NullableContext(1)]
[Nullable(0)]
public class ActiveMaterialEntry : IActiveMaterialEntry
{
	// Token: 0x1700203D RID: 8253
	// (get) Token: 0x06017E91 RID: 97937 RVA: 0x00613E84 File Offset: 0x00612084
	// (set) Token: 0x06017E92 RID: 97938 RVA: 0x00613E8C File Offset: 0x0061208C
	public UObject Data { get; set; }

	// Token: 0x1700203E RID: 8254
	// (get) Token: 0x06017E93 RID: 97939 RVA: 0x00613E95 File Offset: 0x00612095
	// (set) Token: 0x06017E94 RID: 97940 RVA: 0x00613E9D File Offset: 0x0061209D
	public bool IsGroup { get; set; }

	// Token: 0x1700203F RID: 8255
	// (get) Token: 0x06017E95 RID: 97941 RVA: 0x00613EA6 File Offset: 0x006120A6
	// (set) Token: 0x06017E96 RID: 97942 RVA: 0x00613EAE File Offset: 0x006120AE
	public bool WithAnimObject { get; set; }
}
