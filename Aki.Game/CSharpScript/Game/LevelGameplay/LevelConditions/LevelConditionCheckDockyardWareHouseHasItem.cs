using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C6D RID: 27757
	public class LevelConditionCheckDockyardWareHouseHasItem : LevelConditionBase
	{
		// Token: 0x06044563 RID: 279907 RVA: 0x010D8BD8 File Offset: 0x010D6DD8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			DockyardModel instance = DockyardModel.Instance;
			return ((instance != null) ? new int?(instance.BackpackUseSize) : null).GetValueOrDefault() > 0;
		}
	}
}
