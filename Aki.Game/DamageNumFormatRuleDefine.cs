using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x02000EBF RID: 3775
public static class DamageNumFormatRuleDefine
{
	// Token: 0x04005AB5 RID: 23221
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EDungeonSubType, IDamageNumFormatRule> DamageNumFormatRuleMap = new Dictionary<EDungeonSubType, IDamageNumFormatRule>
	{
		{
			EDungeonSubType.PinballBattle,
			new PinballBattleDamageNumFormatRule()
		},
		{
			EDungeonSubType.BossPiling,
			new BossPillingBattleDamageNumFormatRule()
		}
	};
}
