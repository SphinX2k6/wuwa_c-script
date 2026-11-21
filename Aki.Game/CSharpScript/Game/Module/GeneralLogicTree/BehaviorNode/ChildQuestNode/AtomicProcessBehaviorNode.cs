using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelFlow;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x0200499F RID: 18847
	public class AtomicProcessBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F359 RID: 193369 RVA: 0x00D2A2A8 File Offset: 0x00D284A8
		public AtomicProcessBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F35A RID: 193370 RVA: 0x00D2A2B4 File Offset: 0x00D284B4
		[NullableContext(1)]
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			return childQuestBtNode != null && base.OnCreate(nodeConfig) && childQuestBtNode.Condition.Type == EChildQuest.AtomicProcess;
		}

		// Token: 0x0602F35B RID: 193371 RVA: 0x00D2A2EA File Offset: 0x00D284EA
		protected override void OnStart(ENodeStatusUpdateReason reason)
		{
			EventSystem.Instance.Add(EEventName.OnLevelFlowFinished, new Action(this.OnLevelFlowFinished));
			LevelFlowController.Instance.InitTaskTreeInfo(base.TreeIncId, base.NodeId);
			LevelFlowController.Instance.StartLevelFlow(0);
		}

		// Token: 0x0602F35C RID: 193372 RVA: 0x00D2A329 File Offset: 0x00D28529
		protected override void OnEnd(bool bFinished)
		{
			if (!bFinished)
			{
				this.PrepareRollback();
				return;
			}
			EventSystem.Instance.Remove(EEventName.OnLevelFlowFinished, new Action(this.OnLevelFlowFinished));
		}

		// Token: 0x0602F35D RID: 193373 RVA: 0x00D2A354 File Offset: 0x00D28554
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

		// Token: 0x0602F35E RID: 193374 RVA: 0x00D2A3A6 File Offset: 0x00D285A6
		private void OnLevelFlowFinished()
		{
			this.SubmitNode(null);
		}
	}
}
