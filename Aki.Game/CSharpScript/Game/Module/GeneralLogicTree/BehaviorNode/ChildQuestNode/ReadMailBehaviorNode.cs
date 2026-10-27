using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059DD RID: 23005
	[NullableContext(1)]
	[Nullable(0)]
	public class ReadMailBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A4E9 RID: 238825 RVA: 0x00DDE61C File Offset: 0x00DDC81C
		public ReadMailBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A4EA RID: 238826 RVA: 0x00DDE628 File Offset: 0x00DDC828
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
			IReadMailCondition readMailCondition = childQuestBtNode.Condition as IReadMailCondition;
			if (readMailCondition == null)
			{
				return false;
			}
			this.MailId = readMailCondition.MailId;
			return true;
		}

		// Token: 0x0603A4EB RID: 238827 RVA: 0x00DDE66A File Offset: 0x00DDC86A
		protected void OnStart()
		{
			this.SubmitFinished = false;
		}

		// Token: 0x0603A4EC RID: 238828 RVA: 0x00DDE673 File Offset: 0x00DDC873
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.MailId = 0;
		}

		// Token: 0x0603A4ED RID: 238829 RVA: 0x00DDE682 File Offset: 0x00DDC882
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add<string, int>(EEventName.SelectedMail, new Action<string, int>(this.OnReadMail));
		}

		// Token: 0x0603A4EE RID: 238830 RVA: 0x00DDE6A6 File Offset: 0x00DDC8A6
		protected override void RemoveEventsOnChildQuestEnd()
		{
			EventSystem.Instance.Remove<string, int>(EEventName.SelectedMail, new Action<string, int>(this.OnReadMail));
			base.RemoveEventsOnChildQuestEnd();
		}

		// Token: 0x0603A4EF RID: 238831 RVA: 0x00DDE6CA File Offset: 0x00DDC8CA
		private void OnReadMail(string mailId, int configId)
		{
			if (this.Submitting || this.SubmitFinished)
			{
				return;
			}
			if (configId == this.MailId)
			{
				this.SubmitNode(null);
			}
		}

		// Token: 0x0603A4F0 RID: 238832 RVA: 0x00DDE6ED File Offset: 0x00DDC8ED
		protected override void OnAfterSubmit(bool submitSuccess)
		{
			base.OnAfterSubmit(submitSuccess);
			if (submitSuccess)
			{
				this.SubmitFinished = true;
			}
		}

		// Token: 0x0401E66D RID: 124525
		private bool SubmitFinished;

		// Token: 0x0401E66E RID: 124526
		private int MailId;
	}
}
