using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E71 RID: 24177
	public class LevelConditionCheckTeleportTypeUnlock : LevelConditionBase
	{
		// Token: 0x0603A7EB RID: 239595 RVA: 0x01089A2C File Offset: 0x01087C2C
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				return false;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				int? id = PlayerInfoModel.Instance.GetId();
				int worldOwner = CreatureModel.Instance.GetWorldOwner();
				if (!(id.GetValueOrDefault() == worldOwner & id != null))
				{
					return false;
				}
			}
			string limitParams = inConditionInfo.GetLimitParams("TeleportType");
			Teleporter? config = ConfigTeleporterById.GetConfig((int)eventArgs[0], true);
			int num;
			return config != null && int.TryParse(limitParams, out num) && config.Value.Type == num;
		}
	}
}
