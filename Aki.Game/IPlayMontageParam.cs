using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003012 RID: 12306
[NullableContext(2)]
[Nullable(0)]
public class IPlayMontageParam : IActionParamMap
{
	// Token: 0x170023CD RID: 9165
	// (get) Token: 0x0601A0FD RID: 106749 RVA: 0x006D4EF3 File Offset: 0x006D30F3
	// (set) Token: 0x0601A0FE RID: 106750 RVA: 0x006D4EFB File Offset: 0x006D30FB
	public string MontagePath { get; set; }

	// Token: 0x170023CE RID: 9166
	// (get) Token: 0x0601A0FF RID: 106751 RVA: 0x006D4F04 File Offset: 0x006D3104
	// (set) Token: 0x0601A100 RID: 106752 RVA: 0x006D4F0C File Offset: 0x006D310C
	public UAnimMontage MontageAsset { get; set; }

	// Token: 0x170023CF RID: 9167
	// (get) Token: 0x0601A101 RID: 106753 RVA: 0x006D4F15 File Offset: 0x006D3115
	// (set) Token: 0x0601A102 RID: 106754 RVA: 0x006D4F1D File Offset: 0x006D311D
	public bool? IsLoop { get; set; }

	// Token: 0x170023D0 RID: 9168
	// (get) Token: 0x0601A103 RID: 106755 RVA: 0x006D4F26 File Offset: 0x006D3126
	// (set) Token: 0x0601A104 RID: 106756 RVA: 0x006D4F2E File Offset: 0x006D312E
	public Action<int, EPerformGroup> OnStartCallback { get; set; }

	// Token: 0x170023D1 RID: 9169
	// (get) Token: 0x0601A105 RID: 106757 RVA: 0x006D4F37 File Offset: 0x006D3137
	// (set) Token: 0x0601A106 RID: 106758 RVA: 0x006D4F3F File Offset: 0x006D313F
	public Action<UAnimMontage, bool> OnEndCallback { get; set; }

	// Token: 0x170023D2 RID: 9170
	// (get) Token: 0x0601A107 RID: 106759 RVA: 0x006D4F48 File Offset: 0x006D3148
	// (set) Token: 0x0601A108 RID: 106760 RVA: 0x006D4F50 File Offset: 0x006D3150
	public Action<UAnimMontage> OnPlayCallback { get; set; }

	// Token: 0x170023D3 RID: 9171
	// (get) Token: 0x0601A109 RID: 106761 RVA: 0x006D4F59 File Offset: 0x006D3159
	// (set) Token: 0x0601A10A RID: 106762 RVA: 0x006D4F61 File Offset: 0x006D3161
	public FName? InSectionToStartMontageAt { get; set; }

	// Token: 0x170023D4 RID: 9172
	// (get) Token: 0x0601A10B RID: 106763 RVA: 0x006D4F6A File Offset: 0x006D316A
	// (set) Token: 0x0601A10C RID: 106764 RVA: 0x006D4F72 File Offset: 0x006D3172
	public float? Duration { get; set; }

	// Token: 0x170023D5 RID: 9173
	// (get) Token: 0x0601A10D RID: 106765 RVA: 0x006D4F7B File Offset: 0x006D317B
	// (set) Token: 0x0601A10E RID: 106766 RVA: 0x006D4F83 File Offset: 0x006D3183
	public bool? KeepOtherMontage { get; set; }

	// Token: 0x170023D6 RID: 9174
	// (get) Token: 0x0601A10F RID: 106767 RVA: 0x006D4F8C File Offset: 0x006D318C
	// (set) Token: 0x0601A110 RID: 106768 RVA: 0x006D4F94 File Offset: 0x006D3194
	public IAnimStateParam AnimStateParam { get; set; }

	// Token: 0x170023D7 RID: 9175
	// (get) Token: 0x0601A111 RID: 106769 RVA: 0x006D4F9D File Offset: 0x006D319D
	// (set) Token: 0x0601A112 RID: 106770 RVA: 0x006D4FA5 File Offset: 0x006D31A5
	public bool? DisableBlinkCurve { get; set; }

	// Token: 0x170023D8 RID: 9176
	// (get) Token: 0x0601A113 RID: 106771 RVA: 0x006D4FAE File Offset: 0x006D31AE
	// (set) Token: 0x0601A114 RID: 106772 RVA: 0x006D4FB6 File Offset: 0x006D31B6
	public Action<UAnimMontage, bool> OnBlendOutCallback { get; set; }

	// Token: 0x170023D9 RID: 9177
	// (get) Token: 0x0601A115 RID: 106773 RVA: 0x006D4FBF File Offset: 0x006D31BF
	// (set) Token: 0x0601A116 RID: 106774 RVA: 0x006D4FC7 File Offset: 0x006D31C7
	public bool? EndActionOnBlendOut { get; set; }
}
