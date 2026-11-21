using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DE7 RID: 24039
	public class LevelConditionCheckDockyardWareHouseHasItem : LevelConditionBase
	{
		// Token: 0x0603A6BD RID: 239293 RVA: 0x01082B7C File Offset: 0x01080D7C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			DockyardModel instance = DockyardModel.Instance;
			return ((instance != null) ? new int?(instance.BackpackUseSize) : null).GetValueOrDefault() > 0;
		}
	}
}
