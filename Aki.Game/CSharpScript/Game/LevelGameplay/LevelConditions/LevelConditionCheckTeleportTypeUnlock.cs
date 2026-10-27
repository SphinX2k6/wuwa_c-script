using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006CF4 RID: 27892
	public class LevelConditionCheckTeleportTypeUnlock : LevelConditionBase
	{
		// Token: 0x0604468B RID: 280203 RVA: 0x010DF84C File Offset: 0x010DDA4C
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
