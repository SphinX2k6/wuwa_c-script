using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DC0 RID: 28096
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiTaskPlayBubble : LevelAiTask
	{
		// Token: 0x060448C2 RID: 280770 RVA: 0x010E7890 File Offset: 0x010E5A90
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

		// Token: 0x060448C3 RID: 280771 RVA: 0x010E7934 File Offset: 0x010E5B34
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

		// Token: 0x060448C4 RID: 280772 RVA: 0x010E79DC File Offset: 0x010E5BDC
		private CharacterDynamicFlowData CreateCharacterFlowDataFromCreatureId(long creatureId, PlayBubble @params)
		{
			CharacterDynamicFlowData characterDynamicFlowData = new CharacterDynamicFlowData();
			AddPlayBubble bubbleData = new AddPlayBubble
			{
				EntityIds = new List<int>(),
				Flow = @params.Flow,
				WaitTime = new int?(0),
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
