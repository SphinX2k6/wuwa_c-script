using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C65 RID: 27749
	public class LevelConditionCheckComboTeachingState : LevelConditionBase
	{
		// Token: 0x06044552 RID: 279890 RVA: 0x010D866B File Offset: 0x010D686B
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			return ComboTeachingModel.Instance.IsClose;
		}
	}
}
