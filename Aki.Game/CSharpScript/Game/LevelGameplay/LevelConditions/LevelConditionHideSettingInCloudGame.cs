using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EB2 RID: 24242
	public class LevelConditionHideSettingInCloudGame : LevelConditionBase
	{
		// Token: 0x0603A86F RID: 239727 RVA: 0x0108B6CC File Offset: 0x010898CC
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return !CloudGameManager.Instance.IsCloudGame;
		}
	}
}
