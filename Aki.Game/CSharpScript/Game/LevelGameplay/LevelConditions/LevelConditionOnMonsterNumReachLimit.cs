using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D6F RID: 28015
	public class LevelConditionOnMonsterNumReachLimit : LevelConditionBase
	{
		// Token: 0x06044784 RID: 280452 RVA: 0x010E2C78 File Offset: 0x010E0E78
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			PhantomArenaOwnData ownData = PhantomArenaBattleModel.Instance.OwnData;
			int? num;
			if (ownData == null)
			{
				num = null;
			}
			else
			{
				List<PhantomCardData> battleCardDataList = ownData.GetBattleCardDataList();
				num = ((battleCardDataList != null) ? new int?(battleCardDataList.Count) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault() >= 4;
		}

		// Token: 0x040239DC RID: 145884
		private const int BATTLE_CARD_NUM_LIMIT = 4;
	}
}
