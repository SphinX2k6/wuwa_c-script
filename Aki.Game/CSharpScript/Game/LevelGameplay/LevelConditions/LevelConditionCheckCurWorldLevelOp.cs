using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C68 RID: 27752
	public class LevelConditionCheckCurWorldLevelOp : LevelConditionBase
	{
		// Token: 0x06044558 RID: 279896 RVA: 0x010D8760 File Offset: 0x010D6960
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Level");
			if (limitParams == null)
			{
				return false;
			}
			int num = int.Parse(limitParams);
			int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
			if (curWorldLevel == 0)
			{
				return false;
			}
			string limitParams2 = inConditionInfo.GetLimitParams("Op");
			if (limitParams2 == "Eq")
			{
				return curWorldLevel == num;
			}
			if (limitParams2 == "Ne")
			{
				return curWorldLevel != num;
			}
			if (limitParams2 == "Ge")
			{
				return curWorldLevel >= num;
			}
			if (limitParams2 == "Gt")
			{
				return curWorldLevel > num;
			}
			if (limitParams2 == "Le")
			{
				return curWorldLevel <= num;
			}
			if (!(limitParams2 == "Lt"))
			{
				return curWorldLevel >= num;
			}
			return curWorldLevel < num;
		}
	}
}
