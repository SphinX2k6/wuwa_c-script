using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D62 RID: 28002
	public class LevelConditionOnPlayerUseSkill : LevelConditionBase
	{
		// Token: 0x0604476A RID: 280426 RVA: 0x010E291C File Offset: 0x010E0B1C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			long num;
			long.TryParse(inConditionInfo.GetLimitParams("SkillId"), out num);
			long? num2 = (eventArgs[1] != null) ? new long?(Convert.ToInt64(eventArgs[1])) : null;
			long num3 = num;
			long? num4 = num2;
			return num3 == num4.GetValueOrDefault() & num4 != null;
		}
	}
}
