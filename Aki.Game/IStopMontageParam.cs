using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002569 RID: 9577
[NullableContext(2)]
[Nullable(0)]
public class IStopMontageParam : IActionParamMap
{
	// Token: 0x170024A8 RID: 9384
	// (get) Token: 0x06017A60 RID: 96864 RVA: 0x006FCEE0 File Offset: 0x006FB0E0
	// (set) Token: 0x06017A61 RID: 96865 RVA: 0x006FCEE8 File Offset: 0x006FB0E8
	public EStopMethod? Method { get; set; }

	// Token: 0x170024A9 RID: 9385
	// (get) Token: 0x06017A62 RID: 96866 RVA: 0x006FCEF1 File Offset: 0x006FB0F1
	// (set) Token: 0x06017A63 RID: 96867 RVA: 0x006FCEF9 File Offset: 0x006FB0F9
	public UAnimMontage Montage { get; set; }

	// Token: 0x170024AA RID: 9386
	// (get) Token: 0x06017A64 RID: 96868 RVA: 0x006FCF02 File Offset: 0x006FB102
	// (set) Token: 0x06017A65 RID: 96869 RVA: 0x006FCF0A File Offset: 0x006FB10A
	public int? HandleId { get; set; }

	// Token: 0x170024AB RID: 9387
	// (get) Token: 0x06017A66 RID: 96870 RVA: 0x006FCF13 File Offset: 0x006FB113
	// (set) Token: 0x06017A67 RID: 96871 RVA: 0x006FCF1B File Offset: 0x006FB11B
	public float? BlendOutTime { get; set; }

	// Token: 0x170024AC RID: 9388
	// (get) Token: 0x06017A68 RID: 96872 RVA: 0x006FCF24 File Offset: 0x006FB124
	// (set) Token: 0x06017A69 RID: 96873 RVA: 0x006FCF2C File Offset: 0x006FB12C
	public float? Delay { get; set; }

	// Token: 0x170024AD RID: 9389
	// (get) Token: 0x06017A6A RID: 96874 RVA: 0x006FCF35 File Offset: 0x006FB135
	// (set) Token: 0x06017A6B RID: 96875 RVA: 0x006FCF3D File Offset: 0x006FB13D
	public bool? ImmediatelyCallback { get; set; }
}
