using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049C1 RID: 18881
	[NullableContext(1)]
	[Nullable(0)]
	public class WaitSceneReferenceEntityPlaySequenceNode : TickBehaviorNode
	{
		// Token: 0x0602F45A RID: 193626 RVA: 0x00D2EE1C File Offset: 0x00D2D01C
		public WaitSceneReferenceEntityPlaySequenceNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17005F6D RID: 24429
		// (get) Token: 0x0602F45B RID: 193627 RVA: 0x00D2EE3B File Offset: 0x00D2D03B
		protected override List<int> CorrelativeEntities
		{
			get
			{
				return this.InnerCorrelativeEntities;
			}
		}

		// Token: 0x0602F45C RID: 193628 RVA: 0x00D2EE44 File Offset: 0x00D2D044
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

		// Token: 0x0602F45D RID: 193629 RVA: 0x00D2EEAE File Offset: 0x00D2D0AE
		protected override void OnStart(ENodeStatusUpdateReason reason)
		{
			base.OnStart(reason);
			this.SubmitSuccess = false;
		}

		// Token: 0x0602F45E RID: 193630 RVA: 0x00D2EEC0 File Offset: 0x00D2D0C0
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

		// Token: 0x0602F45F RID: 193631 RVA: 0x00D2EFE2 File Offset: 0x00D2D1E2
		protected override void OnAfterSubmit(bool submitSuccess)
		{
			base.OnAfterSubmit(submitSuccess);
			this.SubmitSuccess = submitSuccess;
		}

		// Token: 0x04019125 RID: 102693
		private int PbDataId;

		// Token: 0x04019126 RID: 102694
		private string Mark = "";

		// Token: 0x04019127 RID: 102695
		private bool SubmitSuccess;

		// Token: 0x04019128 RID: 102696
		private readonly List<int> InnerCorrelativeEntities = new List<int>();
	}
}
