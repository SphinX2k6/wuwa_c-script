using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.SlidingBlocks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049BB RID: 18875
	public class SlidingBlocksNode : ChildQuestNodeBase
	{
		// Token: 0x0602F430 RID: 193584 RVA: 0x00D2E4AC File Offset: 0x00D2C6AC
		public SlidingBlocksNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F431 RID: 193585 RVA: 0x00D2E4B8 File Offset: 0x00D2C6B8
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
			IFinishTetris finishTetris = childQuestBtNode.Condition as IFinishTetris;
			if (finishTetris == null)
			{
				return false;
			}
			this.Config = finishTetris;
			return true;
		}

		// Token: 0x0602F432 RID: 193586 RVA: 0x00D2E4F5 File Offset: 0x00D2C6F5
		protected override void OnNodeActive()
		{
			base.OnNodeActive();
			LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.SlidingBlocks, ELoadingPerform.CameraFade, null, null, Array.Empty<object>());
		}

		// Token: 0x0602F433 RID: 193587 RVA: 0x00D2E511 File Offset: 0x00D2C711
		protected override void OnStart(ENodeStatusUpdateReason reason)
		{
			base.OnStart(reason);
			this.StartGameAsync().Forget();
		}

		// Token: 0x0602F434 RID: 193588 RVA: 0x00D2E525 File Offset: 0x00D2C725
		protected override void OnEnd(bool bFinished)
		{
			SlidingBlocksController.Instance.OnGameEnd(bFinished);
		}

		// Token: 0x0602F435 RID: 193589 RVA: 0x00D2E532 File Offset: 0x00D2C732
		protected override void OnDestroy()
		{
			SlidingBlocksController.Instance.DestroyGameplay();
		}

		// Token: 0x0602F436 RID: 193590 RVA: 0x00D2E540 File Offset: 0x00D2C740
		private UniTask StartGameAsync()
		{
			SlidingBlocksNode.<StartGameAsync>d__7 <StartGameAsync>d__;
			<StartGameAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartGameAsync>d__.<>4__this = this;
			<StartGameAsync>d__.<>1__state = -1;
			<StartGameAsync>d__.<>t__builder.Start<SlidingBlocksNode.<StartGameAsync>d__7>(ref <StartGameAsync>d__);
			return <StartGameAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04019113 RID: 102675
		[Nullable(2)]
		private IFinishTetris Config;
	}
}
