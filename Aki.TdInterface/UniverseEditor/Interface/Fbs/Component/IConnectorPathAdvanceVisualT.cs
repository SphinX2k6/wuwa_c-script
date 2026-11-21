using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005575 RID: 21877
	public class IConnectorPathAdvanceVisualT
	{
		// Token: 0x17009C87 RID: 40071
		// (get) Token: 0x06022C15 RID: 142357 RVA: 0x004C95E2 File Offset: 0x004C77E2
		// (set) Token: 0x06022C16 RID: 142358 RVA: 0x004C95EA File Offset: 0x004C77EA
		public EConnectorPathAdvanceVisualType Type { get; set; }

		// Token: 0x06022C17 RID: 142359 RVA: 0x004C95F3 File Offset: 0x004C77F3
		public IConnectorPathAdvanceVisualT()
		{
			this.Type = EConnectorPathAdvanceVisualType.VasePlant;
		}
	}
}
