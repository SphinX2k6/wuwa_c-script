using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002556 RID: 9558
	public class ITalkItemPhoneMessageAttachment : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600D5CB RID: 54731 RVA: 0x001FC183 File Offset: 0x001FA383
		[NullableContext(1)]
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

		// Token: 0x17003CE1 RID: 15585
		// (get) Token: 0x0600D5CC RID: 54732 RVA: 0x001FC1A2 File Offset: 0x001FA3A2
		public override EPhoneMessageType Type
		{
			get
			{
				return (EPhoneMessageType)this.Instance.Type;
			}
		}

		// Token: 0x17003CE2 RID: 15586
		// (get) Token: 0x0600D5CD RID: 54733 RVA: 0x001FC1AF File Offset: 0x001FA3AF
		public virtual int AttachmentId
		{
			get
			{
				return this.Instance.AttachmentId;
			}
		}

		// Token: 0x040075C4 RID: 30148
		private ITalkItemPhoneMessageAttachment Instance;
	}
}
