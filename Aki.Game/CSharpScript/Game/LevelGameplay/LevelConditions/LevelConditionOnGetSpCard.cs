using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D70 RID: 28016
	public class LevelConditionOnGetSpCard : LevelConditionBase
	{
		// Token: 0x06044786 RID: 280454 RVA: 0x010E2CD4 File Offset: 0x010E0ED4
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (eventArgs.Length != 0)
			{
				IReadOnlyList<int> readOnlyList = eventArgs[0] as IReadOnlyList<int>;
				if (readOnlyList != null)
				{
					for (int i = 0; i < readOnlyList.Count; i++)
					{
						int cardId = readOnlyList[i];
						PhantomArenaOwnData ownData = PhantomArenaBattleModel.Instance.OwnData;
						PhantomCardData phantomCardData = (ownData != null) ? ownData.GetHandCardDataByCardId(cardId) : null;
						if (phantomCardData != null && phantomCardData.IsFourCost)
						{
							return true;
						}
					}
					return false;
				}
			}
			return false;
		}
	}
}
