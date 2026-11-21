using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DE6 RID: 24038
	public class LevelConditionCheckDis : LevelConditionBase
	{
		// Token: 0x0603A6BB RID: 239291 RVA: 0x01082AD8 File Offset: 0x01080CD8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0 || inTrigger == null)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Distance");
			string limitParams2 = inConditionInfo.GetLimitParams("CheckWay");
			if (limitParams == null || limitParams2 == null)
			{
				return false;
			}
			float distanceTo = Global.BaseCharacter.GetDistanceTo(inTrigger);
			if (limitParams2 == "1")
			{
				return float.Parse(limitParams) >= distanceTo;
			}
			if (!(limitParams2 == "2"))
			{
				return limitParams2 == "3" && float.Parse(limitParams) != distanceTo;
			}
			return float.Parse(limitParams) <= distanceTo;
		}
	}
}
