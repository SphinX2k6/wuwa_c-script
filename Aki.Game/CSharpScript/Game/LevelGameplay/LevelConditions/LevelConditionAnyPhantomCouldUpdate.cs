using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DBF RID: 23999
	public class LevelConditionAnyPhantomCouldUpdate : LevelConditionBase
	{
		// Token: 0x0603A63E RID: 239166 RVA: 0x0107D9D0 File Offset: 0x0107BBD0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			foreach (KeyValuePair<int, PhantomBattleData> keyValuePair in PhantomBattleModel.Instance.GetPhantomBattleDataMap())
			{
				if (!keyValuePair.Value.IsMax() && PhantomBattleModel.Instance.GetExpMaterialList(keyValuePair.Value.GetIncrId(), 0, false, false).Length != 0)
				{
					return true;
				}
			}
			return false;
		}
	}
}
