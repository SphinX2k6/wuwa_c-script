using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C97 RID: 27799
	public class LevelConditionCheckFishingWareHouseItemListLength : LevelConditionBase
	{
		// Token: 0x060445BE RID: 279998 RVA: 0x010DB5CE File Offset: 0x010D97CE
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return DockyardModel.Instance.GetWareHouseDataList().Count > 0;
		}
	}
}
