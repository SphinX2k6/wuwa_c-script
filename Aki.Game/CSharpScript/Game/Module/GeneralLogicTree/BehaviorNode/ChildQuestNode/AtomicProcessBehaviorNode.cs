using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelFlow;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059C6 RID: 22982
	public class AtomicProcessBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A432 RID: 238642 RVA: 0x00DDAA20 File Offset: 0x00DD8C20
		public AtomicProcessBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A433 RID: 238643 RVA: 0x00DDAA2C File Offset: 0x00DD8C2C
		[NullableContext(1)]
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			return childQuestBtNode != null && base.OnCreate(nodeConfig) && childQuestBtNode.Condition.Type == EChildQuest.AtomicProcess;
		}

		// Token: 0x0603A434 RID: 238644 RVA: 0x00DDAA62 File Offset: 0x00DD8C62
		protected override void OnStart(ENodeStatusUpdateReason reason)
		{
			EventSystem.Instance.Add(EEventName.OnLevelFlowFinished, new Action(this.OnLevelFlowFinished));
			LevelFlowController.Instance.InitTaskTreeInfo(base.TreeIncId, base.NodeId);
			LevelFlowController.Instance.StartLevelFlow(0);
		}

		// Token: 0x0603A435 RID: 238645 RVA: 0x00DDAAA1 File Offset: 0x00DD8CA1
		protected override void OnEnd(bool bFinished)
		{
			if (!bFinished)
			{
				this.PrepareRollback();
				return;
			}
			EventSystem.Instance.Remove(EEventName.OnLevelFlowFinished, new Action(this.OnLevelFlowFinished));
		}

		// Token: 0x0603A436 RID: 238646 RVA: 0x00DDAACC File Offset: 0x00DD8CCC
		private void PrepareRollback()
		{
			if (LevelFlowModel.Instance.IsEnd)
			{
				return;
			}
			AsyncTask task = new AsyncTask("LevelFlowPrepareRollback", delegate()
			{
				AtomicProcessBehaviorNode.<>c.<<PrepareRollback>b__4_0>d <<PrepareRollback>b__4_0>d;
				<<PrepareRollback>b__4_0>d.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
				<<PrepareRollback>b__4_0>d.<>1__state = -1;
				<<PrepareRollback>b__4_0>d.<>t__builder.Start<AtomicProcessBehaviorNode.<>c.<<PrepareRollback>b__4_0>d>(ref <<PrepareRollback>b__4_0>d);
				return <<PrepareRollback>b__4_0>d.<>t__builder.Task;
			}, null, null, null);
			TaskSystem.Instance.AddTask(task);
		}

		// Token: 0x0603A437 RID: 238647 RVA: 0x00DDAB1E File Offset: 0x00DD8D1E
		private void OnLevelFlowFinished()
		{
			this.SubmitNode(null);
		}
	}
}
