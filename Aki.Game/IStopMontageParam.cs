using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003013 RID: 12307
[NullableContext(2)]
[Nullable(0)]
public class IStopMontageParam : IActionParamMap
{
	// Token: 0x170023DA RID: 9178
	// (get) Token: 0x0601A118 RID: 106776 RVA: 0x006D4FD8 File Offset: 0x006D31D8
	// (set) Token: 0x0601A119 RID: 106777 RVA: 0x006D4FE0 File Offset: 0x006D31E0
	public EStopMethod? Method { get; set; }

	// Token: 0x170023DB RID: 9179
	// (get) Token: 0x0601A11A RID: 106778 RVA: 0x006D4FE9 File Offset: 0x006D31E9
	// (set) Token: 0x0601A11B RID: 106779 RVA: 0x006D4FF1 File Offset: 0x006D31F1
	public UAnimMontage Montage { get; set; }

	// Token: 0x170023DC RID: 9180
	// (get) Token: 0x0601A11C RID: 106780 RVA: 0x006D4FFA File Offset: 0x006D31FA
	// (set) Token: 0x0601A11D RID: 106781 RVA: 0x006D5002 File Offset: 0x006D3202
	public int? HandleId { get; set; }

	// Token: 0x170023DD RID: 9181
	// (get) Token: 0x0601A11E RID: 106782 RVA: 0x006D500B File Offset: 0x006D320B
	// (set) Token: 0x0601A11F RID: 106783 RVA: 0x006D5013 File Offset: 0x006D3213
	public float? BlendOutTime { get; set; }

	// Token: 0x170023DE RID: 9182
	// (get) Token: 0x0601A120 RID: 106784 RVA: 0x006D501C File Offset: 0x006D321C
	// (set) Token: 0x0601A121 RID: 106785 RVA: 0x006D5024 File Offset: 0x006D3224
	public float? Delay { get; set; }

	// Token: 0x170023DF RID: 9183
	// (get) Token: 0x0601A122 RID: 106786 RVA: 0x006D502D File Offset: 0x006D322D
	// (set) Token: 0x0601A123 RID: 106787 RVA: 0x006D5035 File Offset: 0x006D3235
	public bool? ImmediatelyCallback { get; set; }
}
