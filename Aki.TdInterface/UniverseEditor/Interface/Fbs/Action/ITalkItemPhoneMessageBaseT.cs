using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072ED RID: 29421
	public class ITalkItemPhoneMessageBaseT
	{
		// Token: 0x1700DD62 RID: 56674
		// (get) Token: 0x06034E7F RID: 216703 RVA: 0x0072A806 File Offset: 0x00728A06
		// (set) Token: 0x06034E80 RID: 216704 RVA: 0x0072A80E File Offset: 0x00728A0E
		public EPhoneMessageType Type { get; set; }

		// Token: 0x06034E81 RID: 216705 RVA: 0x0072A817 File Offset: 0x00728A17
		public ITalkItemPhoneMessageBaseT()
		{
			this.Type = EPhoneMessageType.Voice;
		}
	}
}
