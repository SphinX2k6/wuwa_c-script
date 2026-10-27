using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Giant;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C9D RID: 27805
	public class LevelConditionCheckGiantCanChangeMood : LevelConditionBase
	{
		// Token: 0x060445CC RID: 280012 RVA: 0x010DB9D7 File Offset: 0x010D9BD7
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return GiantModel.Instance.CanChangeMood();
		}
	}
}
