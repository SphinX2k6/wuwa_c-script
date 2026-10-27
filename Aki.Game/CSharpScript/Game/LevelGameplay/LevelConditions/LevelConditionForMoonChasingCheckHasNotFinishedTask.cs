using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D2C RID: 27948
	public class LevelConditionForMoonChasingCheckHasNotFinishedTask : LevelConditionBase
	{
		// Token: 0x060446FC RID: 280316 RVA: 0x010E0F8C File Offset: 0x010DF18C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			using (List<EditTeamData>.Enumerator enumerator = MoonChasingBusinessModel.Instance.GetHelpEditTeamDataList(false).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetTeamDataUnLockState() == EEditTeamDataUnLockState.TaskUnFinish)
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
