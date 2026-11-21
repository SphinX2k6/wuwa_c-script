using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049B7 RID: 18871
	public class ReadPhoneMessageBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F419 RID: 193561 RVA: 0x00D2DF20 File Offset: 0x00D2C120
		public ReadPhoneMessageBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F41A RID: 193562 RVA: 0x00D2DF2C File Offset: 0x00D2C12C
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

		// Token: 0x0602F41B RID: 193563 RVA: 0x00D2DF7D File Offset: 0x00D2C17D
		protected void OnStart()
		{
			this.SubmitFinished = false;
			if (PhoneMsgModel.Instance.IsShortMsgRead(this.ShortMessageId))
			{
				this.SubmitNode(null);
			}
		}

		// Token: 0x0602F41C RID: 193564 RVA: 0x00D2DF9F File Offset: 0x00D2C19F
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add<int, int, bool>(EEventName.OnPhoneMsgReadProgressUpdate, new Action<int, int, bool>(this.OnPhoneMsgReadProgressUpdate));
		}

		// Token: 0x0602F41D RID: 193565 RVA: 0x00D2DFC3 File Offset: 0x00D2C1C3
		protected override void RemoveEventsOnChildQuestEnd()
		{
			base.RemoveEventsOnChildQuestEnd();
			EventSystem.Instance.Remove<int, int, bool>(EEventName.OnPhoneMsgReadProgressUpdate, new Action<int, int, bool>(this.OnPhoneMsgReadProgressUpdate));
		}

		// Token: 0x0602F41E RID: 193566 RVA: 0x00D2DFE7 File Offset: 0x00D2C1E7
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

		// Token: 0x0602F41F RID: 193567 RVA: 0x00D2E00F File Offset: 0x00D2C20F
		protected override void OnAfterSubmit(bool submitSuccess)
		{
			base.OnAfterSubmit(submitSuccess);
			if (submitSuccess)
			{
				this.SubmitFinished = true;
			}
		}

		// Token: 0x0401910E RID: 102670
		private bool SubmitFinished;

		// Token: 0x0401910F RID: 102671
		private int ShortMessageId;
	}
}
