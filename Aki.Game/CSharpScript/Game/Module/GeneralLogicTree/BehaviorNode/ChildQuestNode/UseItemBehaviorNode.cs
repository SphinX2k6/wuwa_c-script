using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049C0 RID: 18880
	[NullableContext(1)]
	[Nullable(0)]
	public class UseItemBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F456 RID: 193622 RVA: 0x00D2ED89 File Offset: 0x00D2CF89
		public UseItemBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F457 RID: 193623 RVA: 0x00D2ED94 File Offset: 0x00D2CF94
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
			if (childQuestBtNode.Condition.Type != EChildQuest.UseItem)
			{
				return false;
			}
			this.TrackTextRuleInner = ENodeTrackTextRule.Progress;
			return true;
		}

		// Token: 0x0602F458 RID: 193624 RVA: 0x00D2EDD1 File Offset: 0x00D2CFD1
		protected override bool OnUpdateProgress(ChildQuestNodeProgress progress)
		{
			if (progress.UseItem == null)
			{
				return false;
			}
			this.Progress = progress.UseItem;
			return true;
		}

		// Token: 0x0602F459 RID: 193625 RVA: 0x00D2EDEC File Offset: 0x00D2CFEC
		public override string GetProgress()
		{
			UseItemProgress progress = this.Progress;
			return ((progress != null) ? progress.Count.ToString() : null) ?? "0";
		}

		// Token: 0x04019124 RID: 102692
		[Nullable(2)]
		private UseItemProgress Progress;
	}
}
