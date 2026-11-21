using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EA9 RID: 24233
	public class LevelConditionForMoonChasingCheckHasNotFinishedTask : LevelConditionBase
	{
		// Token: 0x0603A85C RID: 239708 RVA: 0x0108B118 File Offset: 0x01089318
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
