using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x020030D0 RID: 12496
[NullableContext(2)]
public interface ISkillTarget
{
	// Token: 0x170024BD RID: 9405
	// (get) Token: 0x0601AC1C RID: 109596
	// (set) Token: 0x0601AC1D RID: 109597
	int? LockOnConfigId { get; set; }

	// Token: 0x170024BE RID: 9406
	// (get) Token: 0x0601AC1E RID: 109598
	// (set) Token: 0x0601AC1F RID: 109599
	ESkillTargetPriority? SkillTargetPriority { get; set; }

	// Token: 0x170024BF RID: 9407
	// (get) Token: 0x0601AC20 RID: 109600
	// (set) Token: 0x0601AC21 RID: 109601
	bool? ShowTarget { get; set; }

	// Token: 0x170024C0 RID: 9408
	// (get) Token: 0x0601AC22 RID: 109602
	// (set) Token: 0x0601AC23 RID: 109603
	bool? GlobalTarget { get; set; }

	// Token: 0x170024C1 RID: 9409
	// (get) Token: 0x0601AC24 RID: 109604
	// (set) Token: 0x0601AC25 RID: 109605
	string BlackboardKey { get; set; }

	// Token: 0x170024C2 RID: 9410
	// (get) Token: 0x0601AC26 RID: 109606
	// (set) Token: 0x0601AC27 RID: 109607
	double? SkillTargetRemainTime { get; set; }
}
