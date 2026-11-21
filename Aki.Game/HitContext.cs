using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002586 RID: 9606
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class HitContext
{
	// Token: 0x06017B9E RID: 97182 RVA: 0x007059C0 File Offset: 0x00703BC0
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public HitContext()
	{
	}

	// Token: 0x0400CA3F RID: 51775
	public bool HasBeHitAnim;

	// Token: 0x0400CA40 RID: 51776
	public EHitAnim BeHitAnim;

	// Token: 0x0400CA41 RID: 51777
	public int VisionCounterAttackId;

	// Token: 0x0400CA42 RID: 51778
	public ECounterAttackType CounterAttackType;

	// Token: 0x0400CA43 RID: 51779
	public int SkillId;

	// Token: 0x0400CA44 RID: 51780
	public int? SkillHitCount;

	// Token: 0x0400CA45 RID: 51781
	public int? SkillHitCountByVictim;

	// Token: 0x0400CA46 RID: 51782
	public int? BulletHitCount;

	// Token: 0x0400CA47 RID: 51783
	public int? BulletHitCountByVictim;

	// Token: 0x0400CA48 RID: 51784
	public IReadOnlyList<ESkillGenre> SkillGenres = Array.Empty<ESkillGenre>();

	// Token: 0x0400CA49 RID: 51785
	public string[] BattleFlags = Array.Empty<string>();

	// Token: 0x0400CA4A RID: 51786
	[Nullable(2)]
	public Entity Attacker;

	// Token: 0x0400CA4B RID: 51787
	[RequiredMember]
	public Entity Target;

	// Token: 0x0400CA4C RID: 51788
	public long BulletId;
}
