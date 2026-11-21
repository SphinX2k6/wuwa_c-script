using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E9D RID: 28317
	public class IFlowOpenPhoneMessageT
	{
		// Token: 0x1700CFB5 RID: 53173
		// (get) Token: 0x06030FBC RID: 200636 RVA: 0x006A50C7 File Offset: 0x006A32C7
		// (set) Token: 0x06030FBD RID: 200637 RVA: 0x006A50CF File Offset: 0x006A32CF
		public EPhoneSystemInteractType Type { get; set; }

		// Token: 0x1700CFB6 RID: 53174
		// (get) Token: 0x06030FBE RID: 200638 RVA: 0x006A50D8 File Offset: 0x006A32D8
		// (set) Token: 0x06030FBF RID: 200639 RVA: 0x006A50E0 File Offset: 0x006A32E0
		public IMessageBoardT PhoneBoardType { get; set; }

		// Token: 0x06030FC0 RID: 200640 RVA: 0x006A50E9 File Offset: 0x006A32E9
		public IFlowOpenPhoneMessageT()
		{
			this.Type = EPhoneSystemInteractType.SendPhoneMessage;
			this.PhoneBoardType = null;
		}
	}
}
