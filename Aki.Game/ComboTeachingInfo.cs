using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020017C9 RID: 6089
[NullableContext(1)]
[Nullable(0)]
public class ComboTeachingInfo : IComboTeachingInfo
{
	// Token: 0x17000EDC RID: 3804
	// (get) Token: 0x0600B1F6 RID: 45558 RVA: 0x0028415D File Offset: 0x0028235D
	// (set) Token: 0x0600B1F7 RID: 45559 RVA: 0x00284165 File Offset: 0x00282365
	public int Index { get; set; }

	// Token: 0x17000EDD RID: 3805
	// (get) Token: 0x0600B1F8 RID: 45560 RVA: 0x0028416E File Offset: 0x0028236E
	// (set) Token: 0x0600B1F9 RID: 45561 RVA: 0x00284176 File Offset: 0x00282376
	public ComboTeaching Config { get; set; }

	// Token: 0x17000EDE RID: 3806
	// (get) Token: 0x0600B1FA RID: 45562 RVA: 0x0028417F File Offset: 0x0028237F
	// (set) Token: 0x0600B1FB RID: 45563 RVA: 0x00284187 File Offset: 0x00282387
	public float HoldTotalTime { get; set; }

	// Token: 0x17000EDF RID: 3807
	// (get) Token: 0x0600B1FC RID: 45564 RVA: 0x00284190 File Offset: 0x00282390
	// (set) Token: 0x0600B1FD RID: 45565 RVA: 0x00284198 File Offset: 0x00282398
	public float SuccessDelay { get; set; }

	// Token: 0x17000EE0 RID: 3808
	// (get) Token: 0x0600B1FE RID: 45566 RVA: 0x002841A1 File Offset: 0x002823A1
	// (set) Token: 0x0600B1FF RID: 45567 RVA: 0x002841A9 File Offset: 0x002823A9
	[Nullable(2)]
	public TimerHandle SuccessHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000EE1 RID: 3809
	// (get) Token: 0x0600B200 RID: 45568 RVA: 0x002841B2 File Offset: 0x002823B2
	// (set) Token: 0x0600B201 RID: 45569 RVA: 0x002841BA File Offset: 0x002823BA
	public BaseCheckCondition SuccessCondition { get; set; }

	// Token: 0x17000EE2 RID: 3810
	// (get) Token: 0x0600B202 RID: 45570 RVA: 0x002841C3 File Offset: 0x002823C3
	// (set) Token: 0x0600B203 RID: 45571 RVA: 0x002841CB File Offset: 0x002823CB
	public List<BaseCheckCondition> FailUpdateCondition { get; set; } = new List<BaseCheckCondition>();

	// Token: 0x17000EE3 RID: 3811
	// (get) Token: 0x0600B204 RID: 45572 RVA: 0x002841D4 File Offset: 0x002823D4
	// (set) Token: 0x0600B205 RID: 45573 RVA: 0x002841DC File Offset: 0x002823DC
	public float FailDelay { get; set; }

	// Token: 0x17000EE4 RID: 3812
	// (get) Token: 0x0600B206 RID: 45574 RVA: 0x002841E5 File Offset: 0x002823E5
	// (set) Token: 0x0600B207 RID: 45575 RVA: 0x002841ED File Offset: 0x002823ED
	[Nullable(2)]
	public TimerHandle FailHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000EE5 RID: 3813
	// (get) Token: 0x0600B208 RID: 45576 RVA: 0x002841F6 File Offset: 0x002823F6
	// (set) Token: 0x0600B209 RID: 45577 RVA: 0x002841FE File Offset: 0x002823FE
	public List<BaseCheckCondition> FailEventCondition { get; set; } = new List<BaseCheckCondition>();

	// Token: 0x17000EE6 RID: 3814
	// (get) Token: 0x0600B20A RID: 45578 RVA: 0x00284207 File Offset: 0x00282407
	// (set) Token: 0x0600B20B RID: 45579 RVA: 0x0028420F File Offset: 0x0028240F
	public bool IsEmit { get; set; }

	// Token: 0x17000EE7 RID: 3815
	// (get) Token: 0x0600B20C RID: 45580 RVA: 0x00284218 File Offset: 0x00282418
	// (set) Token: 0x0600B20D RID: 45581 RVA: 0x00284220 File Offset: 0x00282420
	public bool IsHoldAction { get; set; }

	// Token: 0x17000EE8 RID: 3816
	// (get) Token: 0x0600B20E RID: 45582 RVA: 0x00284229 File Offset: 0x00282429
	// (set) Token: 0x0600B20F RID: 45583 RVA: 0x00284231 File Offset: 0x00282431
	public bool IsShowTag { get; set; }

	// Token: 0x17000EE9 RID: 3817
	// (get) Token: 0x0600B210 RID: 45584 RVA: 0x0028423A File Offset: 0x0028243A
	// (set) Token: 0x0600B211 RID: 45585 RVA: 0x00284242 File Offset: 0x00282442
	public string ActionInfo { get; set; } = "";

	// Token: 0x17000EEA RID: 3818
	// (get) Token: 0x0600B212 RID: 45586 RVA: 0x0028424B File Offset: 0x0028244B
	// (set) Token: 0x0600B213 RID: 45587 RVA: 0x00284253 File Offset: 0x00282453
	public bool NeedTickSummon { get; set; }
}
