using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049AC RID: 18860
	[NullableContext(1)]
	[Nullable(0)]
	public class GetItemBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F3CE RID: 193486 RVA: 0x00D2C1A8 File Offset: 0x00D2A3A8
		public GetItemBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F3CF RID: 193487 RVA: 0x00D2C1B4 File Offset: 0x00D2A3B4
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

		// Token: 0x0602F3D0 RID: 193488 RVA: 0x00D2C1F6 File Offset: 0x00D2A3F6
		protected override bool OnUpdateProgress(ChildQuestNodeProgress progress)
		{
			this.Progress = progress.GetItem;
			return true;
		}

		// Token: 0x0602F3D1 RID: 193489 RVA: 0x00D2C205 File Offset: 0x00D2A405
		public override string GetProgress()
		{
			return this.ItemMaxCount.ToString();
		}

		// Token: 0x0602F3D2 RID: 193490 RVA: 0x00D2C214 File Offset: 0x00D2A414
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

		// Token: 0x040190DA RID: 102618
		[Nullable(2)]
		private GetItemProgress Progress;

		// Token: 0x040190DB RID: 102619
		private int ItemMaxCount;
	}
}
