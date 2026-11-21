using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E34 RID: 24116
	public class LevelConditionCheckKurotatoLevelFinished : LevelConditionBase
	{
		// Token: 0x0603A766 RID: 239462 RVA: 0x01086E1C File Offset: 0x0108501C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("LevelId");
			if (limitParams == null)
			{
				return false;
			}
			KurotatoActivityController instance = KurotatoActivityController.Instance;
			KurotatoActivityData kurotatoActivityData = (instance != null) ? instance.GetActivityData() : null;
			return kurotatoActivityData != null && kurotatoActivityData.IsLevelFinished(int.Parse(limitParams));
		}
	}
}
