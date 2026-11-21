using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x02002473 RID: 9331
[NullableContext(2)]
[Nullable(0)]
public class Partial_RequirementPayload
{
	// Token: 0x0400C53A RID: 50490
	public const int DEFAULT_WEAPON_TYPE_NOT_PASS = -2;

	// Token: 0x0400C53B RID: 50491
	public int? SkillId;

	// Token: 0x0400C53C RID: 50492
	public IReadOnlyList<ESkillGenre> SkillGenres;

	// Token: 0x0400C53D RID: 50493
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<string> BattleFlags;

	// Token: 0x0400C53E RID: 50494
	public int? CalculateType;

	// Token: 0x0400C53F RID: 50495
	public int? DamageType;

	// Token: 0x0400C540 RID: 50496
	public IReadOnlyList<int> DamageSubTypes;

	// Token: 0x0400C541 RID: 50497
	public int? SmashType;

	// Token: 0x0400C542 RID: 50498
	public long? BulletId;

	// Token: 0x0400C543 RID: 50499
	public long? DamageId;

	// Token: 0x0400C544 RID: 50500
	public long? BuffId;

	// Token: 0x0400C545 RID: 50501
	public bool? IsCritical;

	// Token: 0x0400C546 RID: 50502
	public bool? IsImmune;

	// Token: 0x0400C547 RID: 50503
	public bool? IsTargetKilled;

	// Token: 0x0400C548 RID: 50504
	public EElementType? ElementType;

	// Token: 0x0400C549 RID: 50505
	public int? WeaponType;

	// Token: 0x0400C54A RID: 50506
	public int? PartId;

	// Token: 0x0400C54B RID: 50507
	public int? PartTag;

	// Token: 0x0400C54C RID: 50508
	public IReadOnlyList<int> BulletTags;

	// Token: 0x0400C54D RID: 50509
	public int? SkillDamageCount;

	// Token: 0x0400C54E RID: 50510
	public int? SkillDamageCountByVictim;

	// Token: 0x0400C54F RID: 50511
	public int? BulletDamageCount;

	// Token: 0x0400C550 RID: 50512
	public long? BulletMessageId;

	// Token: 0x0400C551 RID: 50513
	public long? SkillMessageId;

	// Token: 0x0400C552 RID: 50514
	public ECounterAttackType? CounterType;

	// Token: 0x0400C553 RID: 50515
	public DamageSourceType? SourceType;

	// Token: 0x0400C554 RID: 50516
	public EChangeWeaknessType? ChangeWeaknessType;
}
