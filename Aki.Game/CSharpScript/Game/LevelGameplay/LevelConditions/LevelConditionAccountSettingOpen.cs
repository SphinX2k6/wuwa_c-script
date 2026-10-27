using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C43 RID: 27715
	public class LevelConditionAccountSettingOpen : LevelConditionBase
	{
		// Token: 0x060444E0 RID: 279776 RVA: 0x010D3AC4 File Offset: 0x010D1CC4
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
