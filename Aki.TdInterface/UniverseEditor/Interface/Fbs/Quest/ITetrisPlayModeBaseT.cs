using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041BE RID: 16830
	public class ITetrisPlayModeBaseT
	{
		// Token: 0x17007757 RID: 30551
		// (get) Token: 0x06018C94 RID: 101524 RVA: 0x0039164A File Offset: 0x0038F84A
		// (set) Token: 0x06018C95 RID: 101525 RVA: 0x00391652 File Offset: 0x0038F852
		public ETetrisPlayMode Type { get; set; }

		// Token: 0x06018C96 RID: 101526 RVA: 0x0039165B File Offset: 0x0038F85B
		public ITetrisPlayModeBaseT()
		{
			this.Type = ETetrisPlayMode.Normal;
		}
	}
}
