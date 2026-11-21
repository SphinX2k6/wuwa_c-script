using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ACB RID: 31435
	public class ITalkItemPhoneMessageSystemTipT
	{
		// Token: 0x1700E965 RID: 59749
		// (get) Token: 0x060381BF RID: 229823 RVA: 0x0078C1AA File Offset: 0x0078A3AA
		// (set) Token: 0x060381C0 RID: 229824 RVA: 0x0078C1B2 File Offset: 0x0078A3B2
		public EPhoneMessageType Type { get; set; }

		// Token: 0x060381C1 RID: 229825 RVA: 0x0078C1BB File Offset: 0x0078A3BB
		public ITalkItemPhoneMessageSystemTipT()
		{
			this.Type = EPhoneMessageType.Voice;
		}
	}
}
