using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F05 RID: 24325
	public class LevelConditionOnSurvivorsRoguePopViewRefresh : LevelConditionBase
	{
		// Token: 0x0603A92C RID: 239916 RVA: 0x0108E26C File Offset: 0x0108C46C
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
