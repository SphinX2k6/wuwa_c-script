using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DBC RID: 23996
	public class LevelConditionAccountSettingOpen : LevelConditionBase
	{
		// Token: 0x0603A638 RID: 239160 RVA: 0x0107D974 File Offset: 0x0107BB74
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("Id");
			if (limitParams == null)
			{
				return false;
			}
			int type = int.Parse(limitParams);
			return ChannelController.Instance.CheckAccountSettingOpen((EChannelAccountSetting)type);
		}
	}
}
