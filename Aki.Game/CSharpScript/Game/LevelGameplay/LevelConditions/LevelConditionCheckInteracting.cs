using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E29 RID: 24105
	public class LevelConditionCheckInteracting : LevelConditionBase
	{
		// Token: 0x0603A749 RID: 239433 RVA: 0x010863C0 File Offset: 0x010845C0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			bool flag = (InteractionModel.Instance.CurrentInteractEntityId ?? 0) == 0;
			return !flag || InteractionModel.Instance.InteractingEntity != null || (TsInteractionUtils.IsInteractHintViewOpened() && InputDistributeModel.Instance.IsActionInPress("通用交互"));
		}
	}
}
