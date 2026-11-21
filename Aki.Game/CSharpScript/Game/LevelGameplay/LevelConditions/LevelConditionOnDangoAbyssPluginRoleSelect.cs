using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E8A RID: 24202
	public class LevelConditionOnDangoAbyssPluginRoleSelect : LevelConditionBase
	{
		// Token: 0x0603A81E RID: 239646 RVA: 0x0108A9B0 File Offset: 0x01088BB0
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			int num = (int)eventArgs[0];
			string limitParams = inConditionInfo.GetLimitParams("Index");
			int slotIndex;
			return limitParams != null && int.TryParse(limitParams, out slotIndex) && num != 0 && !DangoAbyssModel.Instance.GetSlotLockState(num, slotIndex);
		}
	}
}
