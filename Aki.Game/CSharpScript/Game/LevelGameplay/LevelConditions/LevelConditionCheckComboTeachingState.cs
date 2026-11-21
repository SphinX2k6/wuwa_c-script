using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DDF RID: 24031
	public class LevelConditionCheckComboTeachingState : LevelConditionBase
	{
		// Token: 0x0603A6AC RID: 239276 RVA: 0x01082603 File Offset: 0x01080803
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			return ComboTeachingModel.Instance.IsClose;
		}
	}
}
