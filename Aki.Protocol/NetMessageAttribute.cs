using System;

namespace Aki.Protocol
{
	// Token: 0x02001535 RID: 5429
	public class NetMessageAttribute : Attribute
	{
		// Token: 0x170060AA RID: 24746
		// (get) Token: 0x0601CAE2 RID: 117474 RVA: 0x00423CC1 File Offset: 0x00421EC1
		public EMessageId MessageId
		{
			get
			{
				return this.MessageIdInternal;
			}
		}

		// Token: 0x0601CAE3 RID: 117475 RVA: 0x00423CC9 File Offset: 0x00421EC9
		public NetMessageAttribute(EMessageId messageId)
		{
			this.MessageIdInternal = messageId;
		}

		// Token: 0x0400A3DC RID: 41948
		private EMessageId MessageIdInternal;
	}
}
