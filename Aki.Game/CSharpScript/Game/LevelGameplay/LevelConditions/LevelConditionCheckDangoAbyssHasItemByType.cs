using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E8C RID: 24204
	public class LevelConditionCheckDangoAbyssHasItemByType : LevelConditionBase
	{
		// Token: 0x0603A822 RID: 239650 RVA: 0x0108AA10 File Offset: 0x01088C10
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			string limitParams = inConditionInfo.GetLimitParams("Type");
			int slotType;
			return limitParams != null && int.TryParse(limitParams, out slotType) && DangoAbyssModel.Instance.GetPluginItemListByType((DangoAbyssDefine.ESlotType)slotType).Length != 0;
		}
	}
}
