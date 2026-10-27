using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059E7 RID: 23015
	[NullableContext(1)]
	[Nullable(0)]
	public class UseItemBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A52F RID: 238895 RVA: 0x00DDF51D File Offset: 0x00DDD71D
		public UseItemBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A530 RID: 238896 RVA: 0x00DDF528 File Offset: 0x00DDD728
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

		// Token: 0x0603A531 RID: 238897 RVA: 0x00DDF565 File Offset: 0x00DDD765
		protected override bool OnUpdateProgress(ChildQuestNodeProgress progress)
		{
			if (progress.UseItem == null)
			{
				return false;
			}
			this.Progress = progress.UseItem;
			return true;
		}

		// Token: 0x0603A532 RID: 238898 RVA: 0x00DDF580 File Offset: 0x00DDD780
		public override string GetProgress()
		{
			UseItemProgress progress = this.Progress;
			return ((progress != null) ? progress.Count.ToString() : null) ?? "0";
		}

		// Token: 0x0401E685 RID: 124549
		[Nullable(2)]
		private UseItemProgress Progress;
	}
}
