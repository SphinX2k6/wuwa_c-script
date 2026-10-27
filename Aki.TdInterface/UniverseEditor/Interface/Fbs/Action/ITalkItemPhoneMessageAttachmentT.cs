using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072EA RID: 29418
	public class ITalkItemPhoneMessageAttachmentT
	{
		// Token: 0x1700DD5E RID: 56670
		// (get) Token: 0x06034E6B RID: 216683 RVA: 0x0072A668 File Offset: 0x00728868
		// (set) Token: 0x06034E6C RID: 216684 RVA: 0x0072A670 File Offset: 0x00728870
		public EPhoneMessageType Type { get; set; }

		// Token: 0x1700DD5F RID: 56671
		// (get) Token: 0x06034E6D RID: 216685 RVA: 0x0072A679 File Offset: 0x00728879
		// (set) Token: 0x06034E6E RID: 216686 RVA: 0x0072A681 File Offset: 0x00728881
		public int AttachmentId { get; set; }

		// Token: 0x06034E6F RID: 216687 RVA: 0x0072A68A File Offset: 0x0072888A
		public ITalkItemPhoneMessageAttachmentT()
		{
			this.Type = EPhoneMessageType.Voice;
			this.AttachmentId = 0;
		}
	}
}
