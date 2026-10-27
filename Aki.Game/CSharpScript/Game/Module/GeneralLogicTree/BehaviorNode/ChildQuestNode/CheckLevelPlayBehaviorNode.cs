using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059CA RID: 22986
	[NullableContext(1)]
	[Nullable(0)]
	public class CheckLevelPlayBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A448 RID: 238664 RVA: 0x00DDB098 File Offset: 0x00DD9298
		public CheckLevelPlayBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A449 RID: 238665 RVA: 0x00DDB0A4 File Offset: 0x00DD92A4
		protected override bool OnCreate(IBtNode config)
		{
			IChildQuestBtNode childQuestBtNode = config as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			if (!base.OnCreate(config))
			{
				return false;
			}
			if (childQuestBtNode.Condition.Type != EChildQuest.CheckLevelPlay)
			{
				return false;
			}
			this.Progress = 0;
			this.TrackTextRuleInner = ENodeTrackTextRule.Progress;
			return true;
		}

		// Token: 0x0603A44A RID: 238666 RVA: 0x00DDB0E8 File Offset: 0x00DD92E8
		protected override bool OnUpdateProgress(ChildQuestNodeProgress progress)
		{
			this.Progress = progress.LevelPlayCount;
			return true;
		}

		// Token: 0x0603A44B RID: 238667 RVA: 0x00DDB0F7 File Offset: 0x00DD92F7
		public override string GetProgress()
		{
			return this.Progress.ToString();
		}

		// Token: 0x0401E618 RID: 124440
		private int Progress;
	}
}
