using System;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x02002E69 RID: 11881
public class DamageResult
{
	// Token: 0x0400BC8F RID: 48271
	public Damage DamageData;

	// Token: 0x0400BC90 RID: 48272
	public float Damage;

	// Token: 0x0400BC91 RID: 48273
	public float ChangeLife;

	// Token: 0x0400BC92 RID: 48274
	public float ShieldCoverDamage;

	// Token: 0x0400BC93 RID: 48275
	public bool IsCounterAttack;

	// Token: 0x0400BC94 RID: 48276
	public bool IsCritical;

	// Token: 0x0400BC95 RID: 48277
	public bool IsTargetKilled;

	// Token: 0x0400BC96 RID: 48278
	public long KillerEntityId;

	// Token: 0x0400BC97 RID: 48279
	public bool IsBlocked;

	// Token: 0x0400BC98 RID: 48280
	public DamageSourceType SourceType;

	// Token: 0x0400BC99 RID: 48281
	public bool IsImmune;

	// Token: 0x0400BC9A RID: 48282
	public EElementType Element;
}
