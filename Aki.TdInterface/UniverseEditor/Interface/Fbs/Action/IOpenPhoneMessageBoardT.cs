using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200737D RID: 29565
	public class IOpenPhoneMessageBoardT
	{
		// Token: 0x1700D8EB RID: 55531
		// (get) Token: 0x060339F5 RID: 211445 RVA: 0x006F57C7 File Offset: 0x006F39C7
		// (set) Token: 0x060339F6 RID: 211446 RVA: 0x006F57CF File Offset: 0x006F39CF
		public EPhoneSystemInteractType Type { get; set; }

		// Token: 0x1700D8EC RID: 55532
		// (get) Token: 0x060339F7 RID: 211447 RVA: 0x006F57D8 File Offset: 0x006F39D8
		// (set) Token: 0x060339F8 RID: 211448 RVA: 0x006F57E0 File Offset: 0x006F39E0
		public IMessageBoardT PhoneBoardType { get; set; }

		// Token: 0x060339F9 RID: 211449 RVA: 0x006F57E9 File Offset: 0x006F39E9
		public IOpenPhoneMessageBoardT()
		{
			this.Type = EPhoneSystemInteractType.SendPhoneMessage;
			this.PhoneBoardType = null;
		}
	}
}
