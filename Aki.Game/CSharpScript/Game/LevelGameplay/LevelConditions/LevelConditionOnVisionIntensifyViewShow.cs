using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C49 RID: 27721
	public class LevelConditionOnVisionIntensifyViewShow : LevelConditionBase
	{
		// Token: 0x060444EC RID: 279788 RVA: 0x010D3CFF File Offset: 0x010D1EFF
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			return (bool)eventArgs[0];
		}
	}
}
