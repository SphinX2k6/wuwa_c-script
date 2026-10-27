using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C9B RID: 27803
	public class LevelConditionCheckGameplayClosedSegment : LevelConditionBase
	{
		// Token: 0x060445C6 RID: 280006 RVA: 0x010DB7E2 File Offset: 0x010D99E2
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			return this.IsInNormalDungeon(inConditionInfo) || this.FindRunningTimerTree() != null;
		}

		// Token: 0x060445C7 RID: 280007 RVA: 0x010DB7FC File Offset: 0x010D99FC
		private bool IsInNormalDungeon(Condition inConditionInfo)
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
			InstanceDungeon? instanceDungeon = (instance != null) ? instance.GetConfig(instanceId) : null;
			return instanceDungeon != null && instanceDungeon.Value.InstType == 2;
		}

		// Token: 0x060445C8 RID: 280008 RVA: 0x010DB850 File Offset: 0x010D9A50
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
