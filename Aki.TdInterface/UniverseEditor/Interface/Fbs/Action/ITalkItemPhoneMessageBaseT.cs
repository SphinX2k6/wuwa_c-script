using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AC2 RID: 31426
	public class ITalkItemPhoneMessageBaseT
	{
		// Token: 0x1700E95B RID: 59739
		// (get) Token: 0x06038185 RID: 229765 RVA: 0x0078BC6A File Offset: 0x00789E6A
		// (set) Token: 0x06038186 RID: 229766 RVA: 0x0078BC72 File Offset: 0x00789E72
		public EPhoneMessageType Type { get; set; }

		// Token: 0x06038187 RID: 229767 RVA: 0x0078BC7B File Offset: 0x00789E7B
		public ITalkItemPhoneMessageBaseT()
		{
			this.Type = EPhoneMessageType.Voice;
		}
	}
}
