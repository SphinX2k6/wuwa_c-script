using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002454 RID: 9300
[NullableContext(1)]
[Nullable(0)]
public static class ExtraEffectIdSets
{
	// Token: 0x0400C4E4 RID: 50404
	[StaticVariableRuleIgnore]
	public static readonly HashSet<EExtraEffectId> initExecutionIds = new HashSet<EExtraEffectId>
	{
		EExtraEffectId.AddBuffToAdjacentRole,
		EExtraEffectId.QteExecution
	};

	// Token: 0x0400C4E5 RID: 50405
	[StaticVariableRuleIgnore]
	public static readonly HashSet<EExtraEffectId> periodExecutionIds = new HashSet<EExtraEffectId>
	{
		EExtraEffectId.AddBuffInstantByStackCount,
		EExtraEffectId.AddBulletInstantByStackCount,
		EExtraEffectId.AddEnergy,
		EExtraEffectId.ModifyFormationAttribute,
		EExtraEffectId.ExtendBuffDuration,
		EExtraEffectId.PeriodAddBuffToAdjacentEntity,
		EExtraEffectId.ModifyLife,
		EExtraEffectId.PeriodicExtraEffect,
		EExtraEffectId.PhantomAssist,
		EExtraEffectId.ReduceCd,
		EExtraEffectId.ReviveExecution,
		EExtraEffectId.ConvertBuffToAnother,
		EExtraEffectId.InvokePeriod,
		EExtraEffectId.ConvertAbnormalLight,
		EExtraEffectId.StartBattleQte,
		EExtraEffectId.RemoveBuffByFilter,
		EExtraEffectId.ModifyTeamMemberBuff,
		EExtraEffectId.BuffMapper,
		EExtraEffectId.AdjacentBuffStackToEffect
	};
}
