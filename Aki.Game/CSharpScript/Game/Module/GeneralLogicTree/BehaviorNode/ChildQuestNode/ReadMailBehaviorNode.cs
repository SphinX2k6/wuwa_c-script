using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049B6 RID: 18870
	[NullableContext(1)]
	[Nullable(0)]
	public class ReadMailBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F411 RID: 193553 RVA: 0x00D2DE3C File Offset: 0x00D2C03C
		public ReadMailBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F412 RID: 193554 RVA: 0x00D2DE48 File Offset: 0x00D2C048
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

		// Token: 0x0602F413 RID: 193555 RVA: 0x00D2DE8A File Offset: 0x00D2C08A
		protected void OnStart()
		{
			this.SubmitFinished = false;
		}

		// Token: 0x0602F414 RID: 193556 RVA: 0x00D2DE93 File Offset: 0x00D2C093
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.MailId = 0;
		}

		// Token: 0x0602F415 RID: 193557 RVA: 0x00D2DEA2 File Offset: 0x00D2C0A2
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add<string, int>(EEventName.SelectedMail, new Action<string, int>(this.OnReadMail));
		}

		// Token: 0x0602F416 RID: 193558 RVA: 0x00D2DEC6 File Offset: 0x00D2C0C6
		protected override void RemoveEventsOnChildQuestEnd()
		{
			EventSystem.Instance.Remove<string, int>(EEventName.SelectedMail, new Action<string, int>(this.OnReadMail));
			base.RemoveEventsOnChildQuestEnd();
		}

		// Token: 0x0602F417 RID: 193559 RVA: 0x00D2DEEA File Offset: 0x00D2C0EA
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

		// Token: 0x0602F418 RID: 193560 RVA: 0x00D2DF0D File Offset: 0x00D2C10D
		protected override void OnAfterSubmit(bool submitSuccess)
		{
			base.OnAfterSubmit(submitSuccess);
			if (submitSuccess)
			{
				this.SubmitFinished = true;
			}
		}

		// Token: 0x0401910C RID: 102668
		private bool SubmitFinished;

		// Token: 0x0401910D RID: 102669
		private int MailId;
	}
}
