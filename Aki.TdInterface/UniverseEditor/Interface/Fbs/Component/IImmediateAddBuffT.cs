using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005970 RID: 22896
	public class IImmediateAddBuffT
	{
		// Token: 0x1700A658 RID: 42584
		// (get) Token: 0x06025531 RID: 152881 RVA: 0x0051F94E File Offset: 0x0051DB4E
		// (set) Token: 0x06025532 RID: 152882 RVA: 0x0051F956 File Offset: 0x0051DB56
		public EBuffProducerMode Type { get; set; }

		// Token: 0x06025533 RID: 152883 RVA: 0x0051F95F File Offset: 0x0051DB5F
		public IImmediateAddBuffT()
		{
			this.Type = EBuffProducerMode.Immediate;
		}
	}
}
