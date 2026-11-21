using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027FF RID: 10239
	public class ITalkItemPhoneMessageAttachment : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600E335 RID: 58165 RVA: 0x00217D7F File Offset: 0x00215F7F
		public static ITalkItemPhoneMessageAttachment Create(ITalkItemPhoneMessageAttachment? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageAttachment
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FE5 RID: 16357
		// (get) Token: 0x0600E336 RID: 58166 RVA: 0x00217D9E File Offset: 0x00215F9E
		public override EPhoneMessageType Type
		{
			get
			{
				return (EPhoneMessageType)this.Instance.Type;
			}
		}

		// Token: 0x17003FE6 RID: 16358
		// (get) Token: 0x0600E337 RID: 58167 RVA: 0x00217DAB File Offset: 0x00215FAB
		public virtual int AttachmentId
		{
			get
			{
				return this.Instance.AttachmentId;
			}
		}

		// Token: 0x04007C21 RID: 31777
		private ITalkItemPhoneMessageAttachment Instance;
	}
}
