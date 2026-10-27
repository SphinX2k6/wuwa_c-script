using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x02001A00 RID: 6656
public static class DamageNumFormatRuleDefine
{
	// Token: 0x040059E6 RID: 23014
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
