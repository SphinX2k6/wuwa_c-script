using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EEE RID: 24302
	public class LevelConditionOnMonsterNumReachLimit : LevelConditionBase
	{
		// Token: 0x0603A8E8 RID: 239848 RVA: 0x0108CE5C File Offset: 0x0108B05C
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

		// Token: 0x0401EC7E RID: 126078
		private const int BATTLE_CARD_NUM_LIMIT = 4;
	}
}
