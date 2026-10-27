using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02003030 RID: 12336
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class HitContext
{
	// Token: 0x0601A23F RID: 107071 RVA: 0x006DDCB6 File Offset: 0x006DBEB6
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public HitContext()
	{
	}

	// Token: 0x0400C670 RID: 50800
	public bool HasBeHitAnim;

	// Token: 0x0400C671 RID: 50801
	public EHitAnim BeHitAnim;

	// Token: 0x0400C672 RID: 50802
	public int VisionCounterAttackId;

	// Token: 0x0400C673 RID: 50803
	public ECounterAttackType CounterAttackType;

	// Token: 0x0400C674 RID: 50804
	public int SkillId;

	// Token: 0x0400C675 RID: 50805
	public int? SkillHitCount;

	// Token: 0x0400C676 RID: 50806
	public int? SkillHitCountByVictim;

	// Token: 0x0400C677 RID: 50807
	public int? BulletHitCount;

	// Token: 0x0400C678 RID: 50808
	public int? BulletHitCountByVictim;

	// Token: 0x0400C679 RID: 50809
	public IReadOnlyList<ESkillGenre> SkillGenres = Array.Empty<ESkillGenre>();

	// Token: 0x0400C67A RID: 50810
	public string[] BattleFlags = Array.Empty<string>();

	// Token: 0x0400C67B RID: 50811
	[Nullable(2)]
	public Entity Attacker;

	// Token: 0x0400C67C RID: 50812
	[RequiredMember]
	public Entity Target;

	// Token: 0x0400C67D RID: 50813
	public long BulletId;
}
