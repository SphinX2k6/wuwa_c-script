using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x020030D1 RID: 12497
[NullableContext(2)]
[Nullable(0)]
public class SkillTargetImpl : ISkillTarget
{
	// Token: 0x170024C3 RID: 9411
	// (get) Token: 0x0601AC28 RID: 109608 RVA: 0x0073640C File Offset: 0x0073460C
	// (set) Token: 0x0601AC29 RID: 109609 RVA: 0x00736414 File Offset: 0x00734614
	public int? LockOnConfigId { get; set; }

	// Token: 0x170024C4 RID: 9412
	// (get) Token: 0x0601AC2A RID: 109610 RVA: 0x0073641D File Offset: 0x0073461D
	// (set) Token: 0x0601AC2B RID: 109611 RVA: 0x00736425 File Offset: 0x00734625
	public ESkillTargetPriority? SkillTargetPriority { get; set; }

	// Token: 0x170024C5 RID: 9413
	// (get) Token: 0x0601AC2C RID: 109612 RVA: 0x0073642E File Offset: 0x0073462E
	// (set) Token: 0x0601AC2D RID: 109613 RVA: 0x00736436 File Offset: 0x00734636
	public bool? ShowTarget { get; set; }

	// Token: 0x170024C6 RID: 9414
	// (get) Token: 0x0601AC2E RID: 109614 RVA: 0x0073643F File Offset: 0x0073463F
	// (set) Token: 0x0601AC2F RID: 109615 RVA: 0x00736447 File Offset: 0x00734647
	public bool? GlobalTarget { get; set; }

	// Token: 0x170024C7 RID: 9415
	// (get) Token: 0x0601AC30 RID: 109616 RVA: 0x00736450 File Offset: 0x00734650
	// (set) Token: 0x0601AC31 RID: 109617 RVA: 0x00736458 File Offset: 0x00734658
	public string BlackboardKey { get; set; }

	// Token: 0x170024C8 RID: 9416
	// (get) Token: 0x0601AC32 RID: 109618 RVA: 0x00736461 File Offset: 0x00734661
	// (set) Token: 0x0601AC33 RID: 109619 RVA: 0x00736469 File Offset: 0x00734669
	public double? SkillTargetRemainTime { get; set; }
}
