using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200114D RID: 4429
public class BabelTowerDefine : IStaticVariableResetter
{
	// Token: 0x0600743E RID: 29758 RVA: 0x0017BD98 File Offset: 0x00179F98
	static BabelTowerDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BabelTowerDefine.CreateStaticDefaultValue), new Action(BabelTowerDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600743F RID: 29759 RVA: 0x0017BDF8 File Offset: 0x00179FF8
	public static void CreateStaticDefaultValue()
	{
		BabelTowerDefine.BABEL_TOWER_SETTLEMENT_DETERM_LINE_COUNT = new int?(4);
		BabelTowerDefine.BABEL_TOWER_TEAM_ROLE_SLOT_COUNT = new int?(3);
	}

	// Token: 0x06007440 RID: 29760 RVA: 0x0017BE10 File Offset: 0x0017A010
	public static void ResetStaticDefaultValue()
	{
		BabelTowerDefine.BABEL_TOWER_SETTLEMENT_DETERM_LINE_COUNT = null;
		BabelTowerDefine.BABEL_TOWER_TEAM_ROLE_SLOT_COUNT = null;
	}

	// Token: 0x04003588 RID: 13704
	public static int? BABEL_TOWER_SETTLEMENT_DETERM_LINE_COUNT;

	// Token: 0x04003589 RID: 13705
	public static int? BABEL_TOWER_TEAM_ROLE_SLOT_COUNT;

	// Token: 0x0400358A RID: 13706
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly IReadOnlyList<string> babelTowerRankDecoPath = new List<string>
	{
		"",
		"T_RankDeco1",
		"T_RankDeco2",
		"T_RankDeco3"
	};
}
