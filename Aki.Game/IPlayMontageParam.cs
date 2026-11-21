using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002568 RID: 9576
[NullableContext(2)]
[Nullable(0)]
public class IPlayMontageParam : IActionParamMap
{
	// Token: 0x1700249B RID: 9371
	// (get) Token: 0x06017A45 RID: 96837 RVA: 0x006FCDFB File Offset: 0x006FAFFB
	// (set) Token: 0x06017A46 RID: 96838 RVA: 0x006FCE03 File Offset: 0x006FB003
	public string MontagePath { get; set; }

	// Token: 0x1700249C RID: 9372
	// (get) Token: 0x06017A47 RID: 96839 RVA: 0x006FCE0C File Offset: 0x006FB00C
	// (set) Token: 0x06017A48 RID: 96840 RVA: 0x006FCE14 File Offset: 0x006FB014
	public UAnimMontage MontageAsset { get; set; }

	// Token: 0x1700249D RID: 9373
	// (get) Token: 0x06017A49 RID: 96841 RVA: 0x006FCE1D File Offset: 0x006FB01D
	// (set) Token: 0x06017A4A RID: 96842 RVA: 0x006FCE25 File Offset: 0x006FB025
	public bool? IsLoop { get; set; }

	// Token: 0x1700249E RID: 9374
	// (get) Token: 0x06017A4B RID: 96843 RVA: 0x006FCE2E File Offset: 0x006FB02E
	// (set) Token: 0x06017A4C RID: 96844 RVA: 0x006FCE36 File Offset: 0x006FB036
	public Action<int, EPerformGroup> OnStartCallback { get; set; }

	// Token: 0x1700249F RID: 9375
	// (get) Token: 0x06017A4D RID: 96845 RVA: 0x006FCE3F File Offset: 0x006FB03F
	// (set) Token: 0x06017A4E RID: 96846 RVA: 0x006FCE47 File Offset: 0x006FB047
	public Action<UAnimMontage, bool> OnEndCallback { get; set; }

	// Token: 0x170024A0 RID: 9376
	// (get) Token: 0x06017A4F RID: 96847 RVA: 0x006FCE50 File Offset: 0x006FB050
	// (set) Token: 0x06017A50 RID: 96848 RVA: 0x006FCE58 File Offset: 0x006FB058
	public Action<UAnimMontage> OnPlayCallback { get; set; }

	// Token: 0x170024A1 RID: 9377
	// (get) Token: 0x06017A51 RID: 96849 RVA: 0x006FCE61 File Offset: 0x006FB061
	// (set) Token: 0x06017A52 RID: 96850 RVA: 0x006FCE69 File Offset: 0x006FB069
	public FName? InSectionToStartMontageAt { get; set; }

	// Token: 0x170024A2 RID: 9378
	// (get) Token: 0x06017A53 RID: 96851 RVA: 0x006FCE72 File Offset: 0x006FB072
	// (set) Token: 0x06017A54 RID: 96852 RVA: 0x006FCE7A File Offset: 0x006FB07A
	public float? Duration { get; set; }

	// Token: 0x170024A3 RID: 9379
	// (get) Token: 0x06017A55 RID: 96853 RVA: 0x006FCE83 File Offset: 0x006FB083
	// (set) Token: 0x06017A56 RID: 96854 RVA: 0x006FCE8B File Offset: 0x006FB08B
	public bool? KeepOtherMontage { get; set; }

	// Token: 0x170024A4 RID: 9380
	// (get) Token: 0x06017A57 RID: 96855 RVA: 0x006FCE94 File Offset: 0x006FB094
	// (set) Token: 0x06017A58 RID: 96856 RVA: 0x006FCE9C File Offset: 0x006FB09C
	public IAnimStateParam AnimStateParam { get; set; }

	// Token: 0x170024A5 RID: 9381
	// (get) Token: 0x06017A59 RID: 96857 RVA: 0x006FCEA5 File Offset: 0x006FB0A5
	// (set) Token: 0x06017A5A RID: 96858 RVA: 0x006FCEAD File Offset: 0x006FB0AD
	public bool? DisableBlinkCurve { get; set; }

	// Token: 0x170024A6 RID: 9382
	// (get) Token: 0x06017A5B RID: 96859 RVA: 0x006FCEB6 File Offset: 0x006FB0B6
	// (set) Token: 0x06017A5C RID: 96860 RVA: 0x006FCEBE File Offset: 0x006FB0BE
	public Action<UAnimMontage, bool> OnBlendOutCallback { get; set; }

	// Token: 0x170024A7 RID: 9383
	// (get) Token: 0x06017A5D RID: 96861 RVA: 0x006FCEC7 File Offset: 0x006FB0C7
	// (set) Token: 0x06017A5E RID: 96862 RVA: 0x006FCECF File Offset: 0x006FB0CF
	public bool? EndActionOnBlendOut { get; set; }
}
