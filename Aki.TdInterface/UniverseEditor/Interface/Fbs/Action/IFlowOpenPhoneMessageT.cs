using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200681D RID: 26653
	public class IFlowOpenPhoneMessageT
	{
		// Token: 0x1700C5FB RID: 50683
		// (get) Token: 0x0602E760 RID: 190304 RVA: 0x0065758F File Offset: 0x0065578F
		// (set) Token: 0x0602E761 RID: 190305 RVA: 0x00657597 File Offset: 0x00655797
		public EPhoneSystemInteractType Type { get; set; }

		// Token: 0x1700C5FC RID: 50684
		// (get) Token: 0x0602E762 RID: 190306 RVA: 0x006575A0 File Offset: 0x006557A0
		// (set) Token: 0x0602E763 RID: 190307 RVA: 0x006575A8 File Offset: 0x006557A8
		public IMessageBoardT PhoneBoardType { get; set; }

		// Token: 0x0602E764 RID: 190308 RVA: 0x006575B1 File Offset: 0x006557B1
		public IFlowOpenPhoneMessageT()
		{
			this.Type = EPhoneSystemInteractType.SendPhoneMessage;
			this.PhoneBoardType = null;
		}
	}
}
