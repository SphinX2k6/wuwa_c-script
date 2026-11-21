using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E11 RID: 24081
	public class LevelConditionCheckFishingWareHouseItemListLength : LevelConditionBase
	{
		// Token: 0x0603A718 RID: 239384 RVA: 0x0108557A File Offset: 0x0108377A
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return DockyardModel.Instance.GetWareHouseDataList().Count > 0;
		}
	}
}
