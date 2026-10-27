using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059E8 RID: 23016
	[NullableContext(1)]
	[Nullable(0)]
	public class WaitSceneReferenceEntityPlaySequenceNode : TickBehaviorNode
	{
		// Token: 0x0603A533 RID: 238899 RVA: 0x00DDF5B0 File Offset: 0x00DDD7B0
		public WaitSceneReferenceEntityPlaySequenceNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17008BA0 RID: 35744
		// (get) Token: 0x0603A534 RID: 238900 RVA: 0x00DDF5CF File Offset: 0x00DDD7CF
		protected override List<int> CorrelativeEntities
		{
			get
			{
				return this.InnerCorrelativeEntities;
			}
		}

		// Token: 0x0603A535 RID: 238901 RVA: 0x00DDF5D8 File Offset: 0x00DDD7D8
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
			WaitUntilLevelSequenceReachMark waitUntilLevelSequenceReachMark = childQuestBtNode.Condition as WaitUntilLevelSequenceReachMark;
			if (waitUntilLevelSequenceReachMark == null)
			{
				return false;
			}
			this.PbDataId = waitUntilLevelSequenceReachMark.EntityId;
			this.InnerCorrelativeEntities.Clear();
			this.InnerCorrelativeEntities.Add(this.PbDataId);
			this.Mark = waitUntilLevelSequenceReachMark.Mark;
			return true;
		}

		// Token: 0x0603A536 RID: 238902 RVA: 0x00DDF642 File Offset: 0x00DDD842
		protected override void OnStart(ENodeStatusUpdateReason reason)
		{
			base.OnStart(reason);
			this.SubmitSuccess = false;
		}

		// Token: 0x0603A537 RID: 238903 RVA: 0x00DDF654 File Offset: 0x00DDD854
		protected unsafe override void OnTick(float delta)
		{
			if (this.SubmitSuccess)
			{
				return;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.PbDataId);
			bool flag;
			if (entityByPbDataId == null)
			{
				flag = true;
			}
			else
			{
				WorldEntity entity = entityByPbDataId.Entity;
				flag = !((entity != null) ? new bool?(entity.Valid) : null).GetValueOrDefault();
			}
			if (flag || !entityByPbDataId.Entity.IsInit)
			{
				return;
			}
			SceneItemReferenceComponent component = entityByPbDataId.Entity.GetComponent<SceneItemReferenceComponent>();
			if (component == null)
			{
				base.RemoveTimer();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "WaitSceneReferenceEntityPlaySequenceNode.OnTick:找不到实体身上的SceneItemReferenceComponent组件";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("treeConfigId", base.TreeConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("nodeId", base.NodeId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("pbDataId", this.PbDataId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			if (!component.IsPlayToMarkFinished(this.Mark))
			{
				return;
			}
			this.SubmitNode(null);
		}

		// Token: 0x0603A538 RID: 238904 RVA: 0x00DDF776 File Offset: 0x00DDD976
		protected override void OnAfterSubmit(bool submitSuccess)
		{
			base.OnAfterSubmit(submitSuccess);
			this.SubmitSuccess = submitSuccess;
		}

		// Token: 0x0401E686 RID: 124550
		private int PbDataId;

		// Token: 0x0401E687 RID: 124551
		private string Mark = "";

		// Token: 0x0401E688 RID: 124552
		private bool SubmitSuccess;

		// Token: 0x0401E689 RID: 124553
		private readonly List<int> InnerCorrelativeEntities = new List<int>();
	}
}
