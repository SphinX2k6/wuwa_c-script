using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059DE RID: 23006
	public class ReadPhoneMessageBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A4F1 RID: 238833 RVA: 0x00DDE700 File Offset: 0x00DDC900
		public ReadPhoneMessageBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A4F2 RID: 238834 RVA: 0x00DDE70C File Offset: 0x00DDC90C
		[NullableContext(1)]
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
			IReadPhoneMessageQuestCondition readPhoneMessageQuestCondition = childQuestBtNode.Condition as IReadPhoneMessageQuestCondition;
			if (readPhoneMessageQuestCondition == null)
			{
				return false;
			}
			int valueOrDefault = readPhoneMessageQuestCondition.PhoneMessageId.GetValueOrDefault();
			if (valueOrDefault == 0)
			{
				return false;
			}
			this.ShortMessageId = valueOrDefault;
			return true;
		}

		// Token: 0x0603A4F3 RID: 238835 RVA: 0x00DDE75D File Offset: 0x00DDC95D
		protected void OnStart()
		{
			this.SubmitFinished = false;
			if (PhoneMsgModel.Instance.IsShortMsgRead(this.ShortMessageId))
			{
				this.SubmitNode(null);
			}
		}

		// Token: 0x0603A4F4 RID: 238836 RVA: 0x00DDE77F File Offset: 0x00DDC97F
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add<int, int, bool>(EEventName.OnPhoneMsgReadProgressUpdate, new Action<int, int, bool>(this.OnPhoneMsgReadProgressUpdate));
		}

		// Token: 0x0603A4F5 RID: 238837 RVA: 0x00DDE7A3 File Offset: 0x00DDC9A3
		protected override void RemoveEventsOnChildQuestEnd()
		{
			base.RemoveEventsOnChildQuestEnd();
			EventSystem.Instance.Remove<int, int, bool>(EEventName.OnPhoneMsgReadProgressUpdate, new Action<int, int, bool>(this.OnPhoneMsgReadProgressUpdate));
		}

		// Token: 0x0603A4F6 RID: 238838 RVA: 0x00DDE7C7 File Offset: 0x00DDC9C7
		private void OnPhoneMsgReadProgressUpdate(int shortMsgId, int newProgress, bool isFinish)
		{
			if (shortMsgId != this.ShortMessageId)
			{
				return;
			}
			if (this.Submitting || this.SubmitFinished)
			{
				return;
			}
			if (!isFinish)
			{
				return;
			}
			this.SubmitNode(null);
		}

		// Token: 0x0603A4F7 RID: 238839 RVA: 0x00DDE7EF File Offset: 0x00DDC9EF
		protected override void OnAfterSubmit(bool submitSuccess)
		{
			base.OnAfterSubmit(submitSuccess);
			if (submitSuccess)
			{
				this.SubmitFinished = true;
			}
		}

		// Token: 0x0401E66F RID: 124527
		private bool SubmitFinished;

		// Token: 0x0401E670 RID: 124528
		private int ShortMessageId;
	}
}
