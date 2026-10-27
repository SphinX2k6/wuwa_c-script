using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059D3 RID: 22995
	[NullableContext(1)]
	[Nullable(0)]
	public class GetItemBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A4A7 RID: 238759 RVA: 0x00DDC9C8 File Offset: 0x00DDABC8
		public GetItemBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A4A8 RID: 238760 RVA: 0x00DDC9D4 File Offset: 0x00DDABD4
		protected bool OnCreate(IChildQuestBtNode config)
		{
			if (!base.OnCreate(config))
			{
				return false;
			}
			IGetItemQuestCondition getItemQuestCondition = config.Condition as IGetItemQuestCondition;
			if (getItemQuestCondition == null)
			{
				return false;
			}
			this.ItemMaxCount = getItemQuestCondition.Items.Count;
			this.TrackTextRuleInner = ENodeTrackTextRule.Progress;
			return true;
		}

		// Token: 0x0603A4A9 RID: 238761 RVA: 0x00DDCA16 File Offset: 0x00DDAC16
		protected override bool OnUpdateProgress(ChildQuestNodeProgress progress)
		{
			this.Progress = progress.GetItem;
			return true;
		}

		// Token: 0x0603A4AA RID: 238762 RVA: 0x00DDCA25 File Offset: 0x00DDAC25
		public override string GetProgress()
		{
			return this.ItemMaxCount.ToString();
		}

		// Token: 0x0603A4AB RID: 238763 RVA: 0x00DDCA34 File Offset: 0x00DDAC34
		public override string GetProgressMax()
		{
			GetItemProgress progress = this.Progress;
			string text;
			if (progress == null)
			{
				text = null;
			}
			else
			{
				RepeatedField<GetItemCount> info = progress.Info;
				text = ((info != null) ? info.Count.ToString() : null);
			}
			return text ?? "0";
		}

		// Token: 0x0401E63B RID: 124475
		[Nullable(2)]
		private GetItemProgress Progress;

		// Token: 0x0401E63C RID: 124476
		private int ItemMaxCount;
	}
}
