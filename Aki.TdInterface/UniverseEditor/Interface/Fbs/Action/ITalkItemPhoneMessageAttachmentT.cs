using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ABF RID: 31423
	public class ITalkItemPhoneMessageAttachmentT
	{
		// Token: 0x1700E957 RID: 59735
		// (get) Token: 0x06038171 RID: 229745 RVA: 0x0078BACC File Offset: 0x00789CCC
		// (set) Token: 0x06038172 RID: 229746 RVA: 0x0078BAD4 File Offset: 0x00789CD4
		public EPhoneMessageType Type { get; set; }

		// Token: 0x1700E958 RID: 59736
		// (get) Token: 0x06038173 RID: 229747 RVA: 0x0078BADD File Offset: 0x00789CDD
		// (set) Token: 0x06038174 RID: 229748 RVA: 0x0078BAE5 File Offset: 0x00789CE5
		public int AttachmentId { get; set; }

		// Token: 0x06038175 RID: 229749 RVA: 0x0078BAEE File Offset: 0x00789CEE
		public ITalkItemPhoneMessageAttachmentT()
		{
			this.Type = EPhoneMessageType.Voice;
			this.AttachmentId = 0;
		}
	}
}
