using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D0D RID: 27917
	public class LevelConditionOnDangoAbyssPluginRoleSelect : LevelConditionBase
	{
		// Token: 0x060446BE RID: 280254 RVA: 0x010E0824 File Offset: 0x010DEA24
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
