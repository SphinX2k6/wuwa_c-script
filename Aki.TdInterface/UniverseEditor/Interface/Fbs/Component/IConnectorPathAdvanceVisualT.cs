using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005016 RID: 20502
	public class IConnectorPathAdvanceVisualT
	{
		// Token: 0x170094A6 RID: 38054
		// (get) Token: 0x06020CF5 RID: 134389 RVA: 0x0048FB92 File Offset: 0x0048DD92
		// (set) Token: 0x06020CF6 RID: 134390 RVA: 0x0048FB9A File Offset: 0x0048DD9A
		public EConnectorPathAdvanceVisualType Type { get; set; }

		// Token: 0x06020CF7 RID: 134391 RVA: 0x0048FBA3 File Offset: 0x0048DDA3
		public IConnectorPathAdvanceVisualT()
		{
			this.Type = EConnectorPathAdvanceVisualType.VasePlant;
		}
	}
}
