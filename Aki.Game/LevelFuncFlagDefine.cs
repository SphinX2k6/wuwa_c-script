using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200110A RID: 4362
public class LevelFuncFlagDefine : IStaticVariableResetter
{
	// Token: 0x0600AE91 RID: 44689 RVA: 0x0033752A File Offset: 0x0033572A
	static LevelFuncFlagDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelFuncFlagDefine.CreateStaticDefaultValue), new Action(LevelFuncFlagDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600AE92 RID: 44690 RVA: 0x00337549 File Offset: 0x00335749
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

	// Token: 0x0600AE93 RID: 44691 RVA: 0x00337565 File Offset: 0x00335765
	public static void ResetStaticDefaultValue()
	{
		LevelFuncFlagDefine.levelFuncFlagDefaultVal = null;
	}

	// Token: 0x040064CD RID: 25805
	[Nullable(2)]
	public static Dictionary<ELevelFuncFlagId, bool> levelFuncFlagDefaultVal;
}
