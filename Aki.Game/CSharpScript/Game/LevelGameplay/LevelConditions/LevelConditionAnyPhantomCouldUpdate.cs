using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C46 RID: 27718
	public class LevelConditionAnyPhantomCouldUpdate : LevelConditionBase
	{
		// Token: 0x060444E6 RID: 279782 RVA: 0x010D3B20 File Offset: 0x010D1D20
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
