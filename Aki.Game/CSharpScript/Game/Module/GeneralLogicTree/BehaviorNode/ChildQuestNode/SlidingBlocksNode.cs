using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.SlidingBlocks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059E2 RID: 23010
	public class SlidingBlocksNode : ChildQuestNodeBase
	{
		// Token: 0x0603A509 RID: 238857 RVA: 0x00DDEC40 File Offset: 0x00DDCE40
		public SlidingBlocksNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A50A RID: 238858 RVA: 0x00DDEC4C File Offset: 0x00DDCE4C
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

		// Token: 0x0603A50B RID: 238859 RVA: 0x00DDEC89 File Offset: 0x00DDCE89
		protected override void OnNodeActive()
		{
			base.OnNodeActive();
			LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.SlidingBlocks, ELoadingPerform.CameraFade, null, null, Array.Empty<object>());
		}

		// Token: 0x0603A50C RID: 238860 RVA: 0x00DDECA5 File Offset: 0x00DDCEA5
		protected override void OnStart(ENodeStatusUpdateReason reason)
		{
			base.OnStart(reason);
			this.StartGameAsync().Forget();
		}

		// Token: 0x0603A50D RID: 238861 RVA: 0x00DDECB9 File Offset: 0x00DDCEB9
		protected override void OnEnd(bool bFinished)
		{
			SlidingBlocksController.Instance.OnGameEnd(bFinished);
		}

		// Token: 0x0603A50E RID: 238862 RVA: 0x00DDECC6 File Offset: 0x00DDCEC6
		protected override void OnDestroy()
		{
			SlidingBlocksController.Instance.DestroyGameplay();
		}

		// Token: 0x0603A50F RID: 238863 RVA: 0x00DDECD4 File Offset: 0x00DDCED4
		private UniTask StartGameAsync()
		{
			SlidingBlocksNode.<StartGameAsync>d__7 <StartGameAsync>d__;
			<StartGameAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartGameAsync>d__.<>4__this = this;
			<StartGameAsync>d__.<>1__state = -1;
			<StartGameAsync>d__.<>t__builder.Start<SlidingBlocksNode.<StartGameAsync>d__7>(ref <StartGameAsync>d__);
			return <StartGameAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401E674 RID: 124532
		[Nullable(2)]
		private IFinishTetris Config;
	}
}
