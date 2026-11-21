using System;

namespace Aki.Protocol
{
	// Token: 0x020015AB RID: 5547
	public class NetMessageAttribute : Attribute
	{
		// Token: 0x1700634D RID: 25421
		// (get) Token: 0x0601D5AD RID: 120237 RVA: 0x0043F8E1 File Offset: 0x0043DAE1
		public EMessageId MessageId
		{
			get
			{
				return this.MessageIdInternal;
			}
		}

		// Token: 0x0601D5AE RID: 120238 RVA: 0x0043F8E9 File Offset: 0x0043DAE9
		public NetMessageAttribute(EMessageId messageId)
		{
			this.MessageIdInternal = messageId;
		}

		// Token: 0x0400A839 RID: 43065
		private EMessageId MessageIdInternal;
	}
}
