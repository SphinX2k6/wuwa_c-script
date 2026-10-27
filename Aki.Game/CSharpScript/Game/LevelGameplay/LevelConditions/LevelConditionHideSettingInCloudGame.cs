using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D35 RID: 27957
	public class LevelConditionHideSettingInCloudGame : LevelConditionBase
	{
		// Token: 0x0604470F RID: 280335 RVA: 0x010E1540 File Offset: 0x010DF740
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return !CloudGameManager.Instance.IsCloudGame;
		}
	}
}
