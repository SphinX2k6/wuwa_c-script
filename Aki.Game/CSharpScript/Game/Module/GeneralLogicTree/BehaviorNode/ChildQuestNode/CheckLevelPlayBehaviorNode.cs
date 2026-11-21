using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049A3 RID: 18851
	[NullableContext(1)]
	[Nullable(0)]
	public class CheckLevelPlayBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F36F RID: 193391 RVA: 0x00D2A920 File Offset: 0x00D28B20
		public CheckLevelPlayBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F370 RID: 193392 RVA: 0x00D2A92C File Offset: 0x00D28B2C
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

		// Token: 0x0602F371 RID: 193393 RVA: 0x00D2A970 File Offset: 0x00D28B70
		protected override bool OnUpdateProgress(ChildQuestNodeProgress progress)
		{
			this.Progress = progress.LevelPlayCount;
			return true;
		}

		// Token: 0x0602F372 RID: 193394 RVA: 0x00D2A97F File Offset: 0x00D28B7F
		public override string GetProgress()
		{
			return this.Progress.ToString();
		}

		// Token: 0x040190B7 RID: 102583
		private int Progress;
	}
}
