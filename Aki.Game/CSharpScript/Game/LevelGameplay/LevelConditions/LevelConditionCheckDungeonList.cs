using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C76 RID: 27766
	public class LevelConditionCheckDungeonList : LevelConditionBase
	{
		// Token: 0x06044576 RID: 279926 RVA: 0x010D9220 File Offset: 0x010D7420
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.ByteBuffer.Length == 0)
			{
				return false;
			}
			int num = int.Parse(inConditionInfo.GetLimitParams("DungeonListLength") ?? "0");
			for (int i = 0; i <= num; i++)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Dungeon");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				int num2 = int.Parse(inConditionInfo.GetLimitParams(defaultInterpolatedStringHandler.ToStringAndClear()) ?? "0");
				int instanceId = CreatureModel.Instance.GetInstanceId();
				if (instanceId == 0 || num2 == 0)
				{
					return false;
				}
				if (instanceId == num2)
				{
					return true;
				}
			}
			return false;
		}
	}
}
