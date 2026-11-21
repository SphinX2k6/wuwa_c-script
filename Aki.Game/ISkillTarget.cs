using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002628 RID: 9768
[NullableContext(2)]
public interface ISkillTarget
{
	// Token: 0x17002640 RID: 9792
	// (get) Token: 0x06018631 RID: 99889
	// (set) Token: 0x06018632 RID: 99890
	int? LockOnConfigId { get; set; }

	// Token: 0x17002641 RID: 9793
	// (get) Token: 0x06018633 RID: 99891
	// (set) Token: 0x06018634 RID: 99892
	ESkillTargetPriority? SkillTargetPriority { get; set; }

	// Token: 0x17002642 RID: 9794
	// (get) Token: 0x06018635 RID: 99893
	// (set) Token: 0x06018636 RID: 99894
	bool? ShowTarget { get; set; }

	// Token: 0x17002643 RID: 9795
	// (get) Token: 0x06018637 RID: 99895
	// (set) Token: 0x06018638 RID: 99896
	bool? GlobalTarget { get; set; }

	// Token: 0x17002644 RID: 9796
	// (get) Token: 0x06018639 RID: 99897
	// (set) Token: 0x0601863A RID: 99898
	string BlackboardKey { get; set; }

	// Token: 0x17002645 RID: 9797
	// (get) Token: 0x0601863B RID: 99899
	// (set) Token: 0x0601863C RID: 99900
	double? SkillTargetRemainTime { get; set; }
}
