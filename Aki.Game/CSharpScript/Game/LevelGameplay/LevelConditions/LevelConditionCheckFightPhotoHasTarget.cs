using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D20 RID: 27936
	public class LevelConditionCheckFightPhotoHasTarget : LevelConditionBase
	{
		// Token: 0x060446E4 RID: 280292 RVA: 0x010E0CD8 File Offset: 0x010DEED8
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return PhotographController.Instance.CurrentBtNode != null;
		}
	}
}
