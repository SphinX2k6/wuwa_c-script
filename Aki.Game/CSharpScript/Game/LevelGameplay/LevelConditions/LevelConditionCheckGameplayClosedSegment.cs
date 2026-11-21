using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E15 RID: 24085
	public class LevelConditionCheckGameplayClosedSegment : LevelConditionBase
	{
		// Token: 0x0603A720 RID: 239392 RVA: 0x0108578E File Offset: 0x0108398E
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return this.IsInNormalDungeon(inConditionInfo) || this.FindRunningTimerTree() != null;
		}

		// Token: 0x0603A721 RID: 239393 RVA: 0x010857A8 File Offset: 0x010839A8
		private bool IsInNormalDungeon(Condition inConditionInfo)
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
			InstanceDungeon? instanceDungeon = (instance != null) ? instance.GetConfig(instanceId) : null;
			return instanceDungeon != null && instanceDungeon.Value.InstType == 2;
		}

		// Token: 0x0603A722 RID: 239394 RVA: 0x010857FC File Offset: 0x010839FC
		[NullableContext(2)]
		private unsafe BaseBehaviorTree FindRunningTimerTree()
		{
			foreach (BaseBehaviorTree baseBehaviorTree in GeneralLogicTreeModel.Instance.GetAllBehaviorTrees().Values)
			{
				BaseBehaviorTree baseBehaviorTree2 = baseBehaviorTree;
				List<string> includes = null;
				int num = 1;
				List<string> list = new List<string>(num);
				CollectionsMarshal.SetCount<string>(list, num);
				Span<string> span = CollectionsMarshal.AsSpan<string>(list);
				int index = 0;
				*span[index] = ETimerType.WaitTime.ToEnumString();
				if (baseBehaviorTree2.HasRunningTimers(includes, list))
				{
					return baseBehaviorTree;
				}
			}
			return null;
		}
	}
}
