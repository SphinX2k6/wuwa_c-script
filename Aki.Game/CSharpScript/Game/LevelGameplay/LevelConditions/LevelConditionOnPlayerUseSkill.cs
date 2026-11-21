using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EE0 RID: 24288
	public class LevelConditionOnPlayerUseSkill : LevelConditionBase
	{
		// Token: 0x0603A8CC RID: 239820 RVA: 0x0108CAD4 File Offset: 0x0108ACD4
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
