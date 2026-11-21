using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000601 RID: 1537
public class BabelTowerDefine : IStaticVariableResetter
{
	// Token: 0x060047D5 RID: 18389 RVA: 0x001848E4 File Offset: 0x00182AE4
	static BabelTowerDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BabelTowerDefine.CreateStaticDefaultValue), new Action(BabelTowerDefine.ResetStaticDefaultValue));
	}

	// Token: 0x060047D6 RID: 18390 RVA: 0x00184944 File Offset: 0x00182B44
	public static void CreateStaticDefaultValue()
	{
		BabelTowerDefine.BABEL_TOWER_SETTLEMENT_DETERM_LINE_COUNT = new int?(4);
		BabelTowerDefine.BABEL_TOWER_TEAM_ROLE_SLOT_COUNT = new int?(3);
	}

	// Token: 0x060047D7 RID: 18391 RVA: 0x0018495C File Offset: 0x00182B5C
	public static void ResetStaticDefaultValue()
	{
		BabelTowerDefine.BABEL_TOWER_SETTLEMENT_DETERM_LINE_COUNT = null;
		BabelTowerDefine.BABEL_TOWER_TEAM_ROLE_SLOT_COUNT = null;
	}

	// Token: 0x04003621 RID: 13857
	public static int? BABEL_TOWER_SETTLEMENT_DETERM_LINE_COUNT;

	// Token: 0x04003622 RID: 13858
	public static int? BABEL_TOWER_TEAM_ROLE_SLOT_COUNT;

	// Token: 0x04003623 RID: 13859
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
