using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059C7 RID: 22983
	public class AwakeAndLoadEntityNode : TickBehaviorNode
	{
		// Token: 0x0603A438 RID: 238648 RVA: 0x00DDAB27 File Offset: 0x00DD8D27
		public AwakeAndLoadEntityNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A439 RID: 238649 RVA: 0x00DDAB30 File Offset: 0x00DD8D30
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

		// Token: 0x0603A43A RID: 238650 RVA: 0x00DDAB94 File Offset: 0x00DD8D94
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

		// Token: 0x0603A43B RID: 238651 RVA: 0x00DDAD50 File Offset: 0x00DD8F50
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

		// Token: 0x0603A43C RID: 238652 RVA: 0x00DDAD9C File Offset: 0x00DD8F9C
		private void OnBeforeSubmitNode()
		{
			this.SubmitState = 1;
		}

		// Token: 0x0603A43D RID: 238653 RVA: 0x00DDADA5 File Offset: 0x00DD8FA5
		private void OnAfterSubmitNode(bool submitSuccess)
		{
			this.SubmitState = (submitSuccess ? 2 : 0);
		}

		// Token: 0x0401E60F RID: 124431
		[Nullable(2)]
		private List<int> EntityIds;

		// Token: 0x0401E610 RID: 124432
		private int SubmitState;

		// Token: 0x0401E611 RID: 124433
		private bool NeedCheckVisible;

		// Token: 0x0200BC3A RID: 48186
		private class ESubmitState
		{
			// Token: 0x04038CB3 RID: 232627
			public const int BeforeSubmit = 0;

			// Token: 0x04038CB4 RID: 232628
			public const int Submitting = 1;

			// Token: 0x04038CB5 RID: 232629
			public const int Submitted = 2;
		}
	}
}
