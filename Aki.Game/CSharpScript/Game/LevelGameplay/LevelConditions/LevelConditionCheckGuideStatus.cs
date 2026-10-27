using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Guide.GroupInfo;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CA2 RID: 27810
	public class LevelConditionCheckGuideStatus : LevelConditionBase
	{
		// Token: 0x060445D6 RID: 280022 RVA: 0x010DBC28 File Offset: 0x010D9E28
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("GuideGroupId");
			string limitParams2 = inConditionInfo.GetLimitParams("Status");
			string text = inConditionInfo.GetLimitParamsOpe("Status");
			if (limitParams == null || limitParams2 == null)
			{
				return false;
			}
			if (text == null)
			{
				text = "";
			}
			return GuideModel.Instance.CheckGroupStatus(int.Parse(limitParams), (EGuideGroupState)int.Parse(limitParams2), text);
		}
	}
}
