using System;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x020023BB RID: 9147
public class DamageResult
{
	// Token: 0x0400C024 RID: 49188
	public Damage DamageData;

	// Token: 0x0400C025 RID: 49189
	public float Damage;

	// Token: 0x0400C026 RID: 49190
	public float ChangeLife;

	// Token: 0x0400C027 RID: 49191
	public float ShieldCoverDamage;

	// Token: 0x0400C028 RID: 49192
	public bool IsCounterAttack;

	// Token: 0x0400C029 RID: 49193
	public bool IsCritical;

	// Token: 0x0400C02A RID: 49194
	public bool IsTargetKilled;

	// Token: 0x0400C02B RID: 49195
	public long KillerEntityId;

	// Token: 0x0400C02C RID: 49196
	public bool IsBlocked;

	// Token: 0x0400C02D RID: 49197
	public DamageSourceType SourceType;

	// Token: 0x0400C02E RID: 49198
	public bool IsImmune;

	// Token: 0x0400C02F RID: 49199
	public EElementType Element;
}
