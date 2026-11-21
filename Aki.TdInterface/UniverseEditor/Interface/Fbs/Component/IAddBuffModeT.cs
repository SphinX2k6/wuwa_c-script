using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200536B RID: 21355
	public class IAddBuffModeT
	{
		// Token: 0x170096C8 RID: 38600
		// (get) Token: 0x06021427 RID: 136231 RVA: 0x00496F8A File Offset: 0x0049518A
		// (set) Token: 0x06021428 RID: 136232 RVA: 0x00496F92 File Offset: 0x00495192
		public EBuffProducerMode Type { get; set; }

		// Token: 0x06021429 RID: 136233 RVA: 0x00496F9B File Offset: 0x0049519B
		public IAddBuffModeT()
		{
			this.Type = EBuffProducerMode.Immediate;
		}
	}
}
