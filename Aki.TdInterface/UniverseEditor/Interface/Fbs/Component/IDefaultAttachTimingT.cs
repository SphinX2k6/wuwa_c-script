using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E1 RID: 21985
	public class IDefaultAttachTimingT
	{
		// Token: 0x17009D67 RID: 40295
		// (get) Token: 0x06022FD3 RID: 143315 RVA: 0x004D088A File Offset: 0x004CEA8A
		// (set) Token: 0x06022FD4 RID: 143316 RVA: 0x004D0892 File Offset: 0x004CEA92
		public EAttachTimingType Type { get; set; }

		// Token: 0x06022FD5 RID: 143317 RVA: 0x004D089B File Offset: 0x004CEA9B
		public IDefaultAttachTimingT()
		{
			this.Type = EAttachTimingType.Default;
		}
	}
}
