using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C16 RID: 27670
	public class IOpenPhoneMessageBoardT
	{
		// Token: 0x1700CDD0 RID: 52688
		// (get) Token: 0x06030AA1 RID: 199329 RVA: 0x0069B4CB File Offset: 0x006996CB
		// (set) Token: 0x06030AA2 RID: 199330 RVA: 0x0069B4D3 File Offset: 0x006996D3
		public EPhoneSystemInteractType Type { get; set; }

		// Token: 0x1700CDD1 RID: 52689
		// (get) Token: 0x06030AA3 RID: 199331 RVA: 0x0069B4DC File Offset: 0x006996DC
		// (set) Token: 0x06030AA4 RID: 199332 RVA: 0x0069B4E4 File Offset: 0x006996E4
		public IMessageBoardT PhoneBoardType { get; set; }

		// Token: 0x06030AA5 RID: 199333 RVA: 0x0069B4ED File Offset: 0x006996ED
		public IOpenPhoneMessageBoardT()
		{
			this.Type = EPhoneSystemInteractType.SendPhoneMessage;
			this.PhoneBoardType = null;
		}
	}
}
