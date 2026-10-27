using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x02002F20 RID: 12064
[NullableContext(2)]
[Nullable(0)]
public class Partial_RequirementPayload
{
	// Token: 0x0400C198 RID: 49560
	public const int DEFAULT_WEAPON_TYPE_NOT_PASS = -2;

	// Token: 0x0400C199 RID: 49561
	public int? SkillId;

	// Token: 0x0400C19A RID: 49562
	public IReadOnlyList<ESkillGenre> SkillGenres;

	// Token: 0x0400C19B RID: 49563
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<string> BattleFlags;

	// Token: 0x0400C19C RID: 49564
	public int? CalculateType;

	// Token: 0x0400C19D RID: 49565
	public int? DamageType;

	// Token: 0x0400C19E RID: 49566
	public IReadOnlyList<int> DamageSubTypes;

	// Token: 0x0400C19F RID: 49567
	public int? SmashType;

	// Token: 0x0400C1A0 RID: 49568
	public long? BulletId;

	// Token: 0x0400C1A1 RID: 49569
	public long? DamageId;

	// Token: 0x0400C1A2 RID: 49570
	public long? BuffId;

	// Token: 0x0400C1A3 RID: 49571
	public bool? IsCritical;

	// Token: 0x0400C1A4 RID: 49572
	public bool? IsImmune;

	// Token: 0x0400C1A5 RID: 49573
	public bool? IsTargetKilled;

	// Token: 0x0400C1A6 RID: 49574
	public EElementType? ElementType;

	// Token: 0x0400C1A7 RID: 49575
	public int? WeaponType;

	// Token: 0x0400C1A8 RID: 49576
	public int? PartId;

	// Token: 0x0400C1A9 RID: 49577
	public int? PartTag;

	// Token: 0x0400C1AA RID: 49578
	public IReadOnlyList<int> BulletTags;

	// Token: 0x0400C1AB RID: 49579
	public int? SkillDamageCount;

	// Token: 0x0400C1AC RID: 49580
	public int? SkillDamageCountByVictim;

	// Token: 0x0400C1AD RID: 49581
	public int? BulletDamageCount;

	// Token: 0x0400C1AE RID: 49582
	public long? BulletMessageId;

	// Token: 0x0400C1AF RID: 49583
	public long? SkillMessageId;

	// Token: 0x0400C1B0 RID: 49584
	public ECounterAttackType? CounterType;

	// Token: 0x0400C1B1 RID: 49585
	public DamageSourceType? SourceType;

	// Token: 0x0400C1B2 RID: 49586
	public EChangeWeaknessType? ChangeWeaknessType;
}
