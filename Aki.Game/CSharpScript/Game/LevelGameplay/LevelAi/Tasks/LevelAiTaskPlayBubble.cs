using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02005F3F RID: 24383
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiTaskPlayBubble : LevelAiTask
	{
		// Token: 0x0603AA26 RID: 240166 RVA: 0x01091AB8 File Offset: 0x0108FCB8
		protected override ELevelAiNodeResult ExecuteTask()
		{
			PlayBubble playBubble = this.Params as PlayBubble;
			if (playBubble == null)
			{
				return ELevelAiNodeResult.Failed;
			}
			CharacterDynamicFlowData characterDynamicFlowData = null;
			if (playBubble.EntityId != null)
			{
				characterDynamicFlowData = this.CreateCharacterFlowDataFromPbDataId(playBubble.EntityId.Value, playBubble);
			}
			else
			{
				BaseActorComponent component = base.CharacterPlanComponent.Entity.GetComponent<BaseActorComponent>();
				long? num = (component != null) ? new long?(component.CreatureData.GetCreatureDataId()) : null;
				if (num != null)
				{
					characterDynamicFlowData = this.CreateCharacterFlowDataFromCreatureId(num.Value, playBubble);
				}
			}
			if (characterDynamicFlowData == null)
			{
				return ELevelAiNodeResult.Failed;
			}
			DynamicFlowController.Instance.AddDynamicFlow(characterDynamicFlowData);
			return ELevelAiNodeResult.Succeeded;
		}

		// Token: 0x0603AA27 RID: 240167 RVA: 0x01091B5C File Offset: 0x0108FD5C
		private CharacterDynamicFlowData CreateCharacterFlowDataFromPbDataId(int pbDataId, PlayBubble @params)
		{
			CharacterDynamicFlowData characterDynamicFlowData = new CharacterDynamicFlowData();
			AddPlayBubble bubbleData = new AddPlayBubble
			{
				EntityIds = new List<int>
				{
					pbDataId
				},
				Flow = @params.Flow,
				WaitTime = new int?(0),
				RedDot = new bool?(false),
				IsRangeFollowEntity = @params.IsRangeFollowEntity,
				IsAudioOccludedByScene = @params.IsAudioOccludedByScene
			};
			DynamicFlowActorInfo masterInfo = new DynamicFlowActorInfo();
			masterInfo.PbDataId = pbDataId;
			characterDynamicFlowData.MasterInfo = masterInfo;
			characterDynamicFlowData.BubbleData = bubbleData;
			characterDynamicFlowData.Type = new EDynamicFlowType?(EDynamicFlowType.LevelAi);
			characterDynamicFlowData.Callback = delegate()
			{
				DynamicFlowController.Instance.RemoveDynamicFlow(masterInfo);
			};
			return characterDynamicFlowData;
		}

		// Token: 0x0603AA28 RID: 240168 RVA: 0x01091C10 File Offset: 0x0108FE10
		private CharacterDynamicFlowData CreateCharacterFlowDataFromCreatureId(long creatureId, PlayBubble @params)
		{
			CharacterDynamicFlowData characterDynamicFlowData = new CharacterDynamicFlowData();
			AddPlayBubble bubbleData = new AddPlayBubble
			{
				EntityIds = new List<int>(),
				Flow = @params.Flow,
				WaitTime = new int?(0),
				IsRangeFollowEntity = @params.IsRangeFollowEntity,
				IsAudioOccludedByScene = @params.IsAudioOccludedByScene
			};
			DynamicFlowActorInfo masterInfo = new DynamicFlowActorInfo();
			masterInfo.CreatureId = creatureId;
			characterDynamicFlowData.MasterInfo = masterInfo;
			characterDynamicFlowData.BubbleData = bubbleData;
			characterDynamicFlowData.Type = new EDynamicFlowType?(EDynamicFlowType.LevelEventClient);
			characterDynamicFlowData.Callback = delegate()
			{
				DynamicFlowController.Instance.RemoveDynamicFlow(masterInfo);
			};
			return characterDynamicFlowData;
		}
	}
}
