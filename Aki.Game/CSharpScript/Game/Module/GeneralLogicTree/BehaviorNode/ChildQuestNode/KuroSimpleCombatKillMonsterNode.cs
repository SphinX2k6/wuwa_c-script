using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049B0 RID: 18864
	[NullableContext(1)]
	[Nullable(0)]
	public class KuroSimpleCombatKillMonsterNode : ChildQuestNodeBase
	{
		// Token: 0x0602F3EB RID: 193515 RVA: 0x00D2C8DB File Offset: 0x00D2AADB
		public KuroSimpleCombatKillMonsterNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F3EC RID: 193516 RVA: 0x00D2C8E4 File Offset: 0x00D2AAE4
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

		// Token: 0x0602F3ED RID: 193517 RVA: 0x00D2C928 File Offset: 0x00D2AB28
		protected override bool OnUpdateProgress(ChildQuestNodeProgress progress)
		{
			if (progress.GpuMonster == null)
			{
				return false;
			}
			this.CurrentKillNum = progress.GpuMonster.CurKillNum;
			return true;
		}

		// Token: 0x0602F3EE RID: 193518 RVA: 0x00D2C946 File Offset: 0x00D2AB46
		public override string GetProgress()
		{
			return this.CurrentKillNum.ToString();
		}

		// Token: 0x0602F3EF RID: 193519 RVA: 0x00D2C953 File Offset: 0x00D2AB53
		public override string GetProgressMax()
		{
			return "";
		}

		// Token: 0x040190E4 RID: 102628
		private int CurrentKillNum;
	}
}
