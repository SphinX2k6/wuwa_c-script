using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059D7 RID: 22999
	[NullableContext(1)]
	[Nullable(0)]
	public class KuroSimpleCombatKillMonsterNode : ChildQuestNodeBase
	{
		// Token: 0x0603A4C3 RID: 238787 RVA: 0x00DDD0B8 File Offset: 0x00DDB2B8
		public KuroSimpleCombatKillMonsterNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A4C4 RID: 238788 RVA: 0x00DDD0C4 File Offset: 0x00DDB2C4
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
			if (childQuestBtNode.Condition.Type != EChildQuest.FinishKuroSimpleCombatKillMonster)
			{
				return false;
			}
			this.CurrentKillNum = 0;
			this.TrackTextRuleInner = ENodeTrackTextRule.Progress;
			return true;
		}

		// Token: 0x0603A4C5 RID: 238789 RVA: 0x00DDD108 File Offset: 0x00DDB308
		protected override bool OnUpdateProgress(ChildQuestNodeProgress progress)
		{
			if (progress.GpuMonster == null)
			{
				return false;
			}
			this.CurrentKillNum = progress.GpuMonster.CurKillNum;
			return true;
		}

		// Token: 0x0603A4C6 RID: 238790 RVA: 0x00DDD126 File Offset: 0x00DDB326
		public override string GetProgress()
		{
			return this.CurrentKillNum.ToString();
		}

		// Token: 0x0603A4C7 RID: 238791 RVA: 0x00DDD133 File Offset: 0x00DDB333
		public override string GetProgressMax()
		{
			return "";
		}

		// Token: 0x0401E645 RID: 124485
		private int CurrentKillNum;
	}
}
