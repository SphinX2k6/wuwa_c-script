using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E99 RID: 24217
	public class LevelConditionDistanceLess : LevelConditionBase
	{
		// Token: 0x0603A83C RID: 239676 RVA: 0x0108AC38 File Offset: 0x01088E38
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("StartTarget");
			string limitParams2 = inConditionInfo.GetLimitParams("EndTargetTag");
			string limitParams3 = inConditionInfo.GetLimitParams("Distance");
			if (limitParams == null || limitParams2 == null)
			{
				return false;
			}
			AActor aactor = inTrigger;
			if (limitParams != "Trigger")
			{
				aactor = LevelGeneralCommons.FindTargetWithTag(limitParams);
			}
			if (aactor == null)
			{
				return false;
			}
			AActor aactor2 = LevelGeneralCommons.FindTargetWithTag(limitParams2);
			return aactor2 != null && aactor.GetDistanceTo(aactor2) < float.Parse(limitParams3);
		}
	}
}
