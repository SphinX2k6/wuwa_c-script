using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EEF RID: 24303
	public class LevelConditionOnGetSpCard : LevelConditionBase
	{
		// Token: 0x0603A8EA RID: 239850 RVA: 0x0108CEB8 File Offset: 0x0108B0B8
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
