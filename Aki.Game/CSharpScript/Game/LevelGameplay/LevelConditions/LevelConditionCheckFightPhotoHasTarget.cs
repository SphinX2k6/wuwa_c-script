using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E9D RID: 24221
	public class LevelConditionCheckFightPhotoHasTarget : LevelConditionBase
	{
		// Token: 0x0603A844 RID: 239684 RVA: 0x0108AE64 File Offset: 0x01089064
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return PhotographController.Instance.CurrentBtNode != null;
		}
	}
}
