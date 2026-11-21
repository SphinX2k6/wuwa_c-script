using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049A0 RID: 18848
	public class AwakeAndLoadEntityNode : TickBehaviorNode
	{
		// Token: 0x0602F35F RID: 193375 RVA: 0x00D2A3AF File Offset: 0x00D285AF
		public AwakeAndLoadEntityNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F360 RID: 193376 RVA: 0x00D2A3B8 File Offset: 0x00D285B8
		[NullableContext(1)]
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			if (!base.OnCreate(nodeConfig))
			{
				return false;
			}
			IAwakeAndLoadEntityCondition awakeAndLoadEntityCondition = childQuestBtNode.Condition as IAwakeAndLoadEntityCondition;
			if (awakeAndLoadEntityCondition == null)
			{
				return false;
			}
			this.EntityIds = awakeAndLoadEntityCondition.EntityIds;
			this.IntervalTime = 1000f;
			this.NeedCheckVisible = awakeAndLoadEntityCondition.IsWaitForShow.GetValueOrDefault();
			return true;
		}

		// Token: 0x0602F361 RID: 193377 RVA: 0x00D2A41C File Offset: 0x00D2861C
		protected unsafe override void OnTick(float _)
		{
			if (this.SubmitState != 0)
			{
				return;
			}
			if (this.EntityIds == null || this.EntityIds.Count == 0)
			{
				this.Submit();
				return;
			}
			foreach (int num in this.EntityIds)
			{
				if (CreatureModel.Instance.GetEntityData(new int?(num), null) == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Entity;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "GeneralLogicTree.AwakeAndLoadEntityNode 找不到实体配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num);
					if (entityByPbDataId == null)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Entity;
						ELogAuthor author2 = ELogAuthor.YSQ;
						string message2 = "GeneralLogicTree.AwakeAndLoadEntityNode AOI范围外的实体";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TreeConfigId", base.TreeConfigId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NodeId", base.NodeId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("pbDataId", num);
						instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					}
					else
					{
						if (!entityByPbDataId.IsInit)
						{
							return;
						}
						SceneItemManipulatableComponent component = entityByPbDataId.Entity.GetComponent<SceneItemManipulatableComponent>();
						if (component != null && !component.LoadingBaseConfigFinish)
						{
							return;
						}
						SceneItemActorComponent component2 = entityByPbDataId.Entity.GetComponent<SceneItemActorComponent>();
						if (this.NeedCheckVisible && component2 != null && !component2.GetIsSceneInteractionLoadCompleted())
						{
							return;
						}
					}
				}
			}
			this.Submit();
		}

		// Token: 0x0602F362 RID: 193378 RVA: 0x00D2A5D8 File Offset: 0x00D287D8
		private void Submit()
		{
			if (this.Blackboard.ContainTag(EBehaviorTreeTag.RollbackWaiting))
			{
				return;
			}
			if (this.Blackboard.IsSuspend())
			{
				return;
			}
			this.OnBeforeSubmitNode();
			GeneralLogicTreeController.Instance.RequestSubmitAwakeAndLoadEntityNode(this.Context, new Action<bool>(this.OnAfterSubmitNode));
		}

		// Token: 0x0602F363 RID: 193379 RVA: 0x00D2A624 File Offset: 0x00D28824
		private void OnBeforeSubmitNode()
		{
			this.SubmitState = 1;
		}

		// Token: 0x0602F364 RID: 193380 RVA: 0x00D2A62D File Offset: 0x00D2882D
		private void OnAfterSubmitNode(bool submitSuccess)
		{
			this.SubmitState = (submitSuccess ? 2 : 0);
		}

		// Token: 0x040190AE RID: 102574
		[Nullable(2)]
		private List<int> EntityIds;

		// Token: 0x040190AF RID: 102575
		private int SubmitState;

		// Token: 0x040190B0 RID: 102576
		private bool NeedCheckVisible;

		// Token: 0x0200A645 RID: 42565
		private class ESubmitState
		{
			// Token: 0x04033682 RID: 210562
			public const int BeforeSubmit = 0;

			// Token: 0x04033683 RID: 210563
			public const int Submitting = 1;

			// Token: 0x04033684 RID: 210564
			public const int Submitted = 2;
		}
	}
}
