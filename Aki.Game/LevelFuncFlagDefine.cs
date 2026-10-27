using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C4B RID: 7243
public class LevelFuncFlagDefine : IStaticVariableResetter
{
	// Token: 0x0600DA7B RID: 55931 RVA: 0x0032C122 File Offset: 0x0032A322
	static LevelFuncFlagDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelFuncFlagDefine.CreateStaticDefaultValue), new Action(LevelFuncFlagDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600DA7C RID: 55932 RVA: 0x0032C141 File Offset: 0x0032A341
	public static void CreateStaticDefaultValue()
	{
		LevelFuncFlagDefine.levelFuncFlagDefaultVal = new Dictionary<ELevelFuncFlagId, bool>
		{
			{
				ELevelFuncFlagId.TempTeleporterPlacement,
				true
			},
			{
				ELevelFuncFlagId.ExploreSkillRoulette,
				true
			}
		};
	}

	// Token: 0x0600DA7D RID: 55933 RVA: 0x0032C15D File Offset: 0x0032A35D
	public static void ResetStaticDefaultValue()
	{
		LevelFuncFlagDefine.levelFuncFlagDefaultVal = null;
	}

	// Token: 0x040063FB RID: 25595
	[Nullable(2)]
	public static Dictionary<ELevelFuncFlagId, bool> levelFuncFlagDefaultVal;
}
