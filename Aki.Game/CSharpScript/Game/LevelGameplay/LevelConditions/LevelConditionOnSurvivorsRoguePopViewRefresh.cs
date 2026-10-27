using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D86 RID: 28038
	public class LevelConditionOnSurvivorsRoguePopViewRefresh : LevelConditionBase
	{
		// Token: 0x060447C8 RID: 280520 RVA: 0x010E4044 File Offset: 0x010E2244
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num = (int)eventArgs[0];
			int num2 = int.Parse(inConditionInfo.GetLimitParams("Type"));
			int num3 = int.Parse(inConditionInfo.GetLimitParams("LevelId"));
			int curLevelId = SurvivorsRogueModel.Instance.CurLevelId;
			return num == num2 && (num3 == 0 || num3 == curLevelId);
		}
	}
}
