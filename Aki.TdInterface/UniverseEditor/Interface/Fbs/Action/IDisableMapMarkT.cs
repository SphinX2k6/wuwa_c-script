using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065E6 RID: 26086
	public class IDisableMapMarkT
	{
		// Token: 0x1700C1AE RID: 49582
		// (get) Token: 0x0602D424 RID: 185380 RVA: 0x00633D3C File Offset: 0x00631F3C
		// (set) Token: 0x0602D425 RID: 185381 RVA: 0x00633D44 File Offset: 0x00631F44
		public EMapMarkState Type { get; set; }

		// Token: 0x1700C1AF RID: 49583
		// (get) Token: 0x0602D426 RID: 185382 RVA: 0x00633D4D File Offset: 0x00631F4D
		// (set) Token: 0x0602D427 RID: 185383 RVA: 0x00633D55 File Offset: 0x00631F55
		public int MarkId { get; set; }

		// Token: 0x0602D428 RID: 185384 RVA: 0x00633D5E File Offset: 0x00631F5E
		public IDisableMapMarkT()
		{
			this.Type = EMapMarkState.Show;
			this.MarkId = 0;
		}
	}
}
