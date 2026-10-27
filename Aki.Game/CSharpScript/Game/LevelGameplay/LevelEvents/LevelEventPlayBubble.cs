using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B4B RID: 27467
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventPlayBubble : LevelEventBase
	{
		// Token: 0x060441A0 RID: 278944 RVA: 0x010C19B2 File Offset: 0x010BFBB2
		public LevelEventPlayBubble(int id) : base(id)
		{
		}

		// Token: 0x060441A1 RID: 278945 RVA: 0x010C19BC File Offset: 0x010BFBBC
		public unsafe override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			PlayBubble playBubble = inParams as PlayBubble;
			if (playBubble == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			CharacterDynamicFlowData characterDynamicFlowData = null;
			int? entityId = playBubble.EntityId;
			if (entityId != null && entityId.GetValueOrDefault() != 0)
			{
				GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
				if (generalLogicTreeContext != null)
				{
					BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(generalLogicTreeContext.TreeIncId), false);
					if (behaviorTree != null)
					{
						behaviorTree.AddDynamicFlowNpc(playBubble.EntityId.Value);
					}
				}
				characterDynamicFlowData = this.CreateCharacterFlowDataFromPbDataId(playBubble.EntityId.Value, playBubble);
			}
			else
			{
				int id = 0;
				EntityContext entityContext = context as EntityContext;
				if (entityContext != null)
				{
					id = entityContext.EntityId.GetValueOrDefault();
				}
				else
				{
					TriggerContext triggerContext = context as TriggerContext;
					if (triggerContext != null)
					{
						id = triggerContext.TriggerEntityId.GetValueOrDefault();
					}
				}
				Entity entity = EntitySystem.Instance.Get(id);
				BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
				long? num = (baseActorComponent != null) ? new long?(baseActorComponent.CreatureData.GetCreatureDataId()) : null;
				if (num != null)
				{
					characterDynamicFlowData = this.CreateCharacterFlowDataFromCreatureId(num.Value, playBubble);
				}
			}
			if (characterDynamicFlowData == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "添加动态冒泡失败,无法创建动态冒泡数据";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", playBubble.EntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowId", playBubble.Flow.FlowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FlowName", playBubble.Flow.FlowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("State", playBubble.Flow.StateId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("ContextType", context.Type);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				base.FinishExecute(false, false, true);
				return;
			}
			DynamicFlowController.Instance.AddDynamicFlow(characterDynamicFlowData);
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060441A2 RID: 278946 RVA: 0x010C1BD8 File Offset: 0x010BFDD8
		private unsafe CharacterDynamicFlowData CreateCharacterFlowDataFromPbDataId(int pbDataId, PlayBubble param)
		{
			CharacterDynamicFlowData characterDynamicFlowData = new CharacterDynamicFlowData();
			AddPlayBubble addPlayBubble = new AddPlayBubble();
			int num = 1;
			List<int> list = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list, num);
			Span<int> span = CollectionsMarshal.AsSpan<int>(list);
			int index = 0;
			*span[index] = pbDataId;
			addPlayBubble.EntityIds = list;
			addPlayBubble.Flow = param.Flow;
			addPlayBubble.WaitTime = new int?(0);
			addPlayBubble.IsAudioOccludedByScene = param.IsAudioOccludedByScene;
			AddPlayBubble bubbleData = addPlayBubble;
			DynamicFlowActorInfo masterInfo = new DynamicFlowActorInfo();
			masterInfo.PbDataId = pbDataId;
			characterDynamicFlowData.MasterInfo = masterInfo;
			characterDynamicFlowData.BubbleData = bubbleData;
			characterDynamicFlowData.Type = new EDynamicFlowType?(EDynamicFlowType.LevelEventClient);
			characterDynamicFlowData.Callback = delegate()
			{
				DynamicFlowController.Instance.RemoveDynamicFlow(masterInfo);
			};
			return characterDynamicFlowData;
		}

		// Token: 0x060441A3 RID: 278947 RVA: 0x010C1C8C File Offset: 0x010BFE8C
		private CharacterDynamicFlowData CreateCharacterFlowDataFromCreatureId(long creatureId, PlayBubble param)
		{
			CharacterDynamicFlowData characterDynamicFlowData = new CharacterDynamicFlowData();
			AddPlayBubble bubbleData = new AddPlayBubble
			{
				EntityIds = new List<int>(),
				Flow = param.Flow,
				WaitTime = new int?(0),
				IsAudioOccludedByScene = param.IsAudioOccludedByScene
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
