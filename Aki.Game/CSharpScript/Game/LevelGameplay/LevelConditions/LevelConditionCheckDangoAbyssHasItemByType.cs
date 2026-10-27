using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D0F RID: 27919
	public class LevelConditionCheckDangoAbyssHasItemByType : LevelConditionBase
	{
		// Token: 0x060446C2 RID: 280258 RVA: 0x010E0884 File Offset: 0x010DEA84
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("Type");
			int slotType;
			return limitParams != null && int.TryParse(limitParams, out slotType) && DangoAbyssModel.Instance.GetPluginItemListByType((DangoAbyssDefine.ESlotType)slotType).Length != 0;
		}
	}
}
