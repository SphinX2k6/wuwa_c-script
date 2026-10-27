using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200414F RID: 16719
	public class ISunSpiritProcessT
	{
		// Token: 0x17007681 RID: 30337
		// (get) Token: 0x060188DE RID: 100574 RVA: 0x0038A16A File Offset: 0x0038836A
		// (set) Token: 0x060188DF RID: 100575 RVA: 0x0038A172 File Offset: 0x00388372
		public int LauncherId { get; set; }

		// Token: 0x17007682 RID: 30338
		// (get) Token: 0x060188E0 RID: 100576 RVA: 0x0038A17B File Offset: 0x0038837B
		// (set) Token: 0x060188E1 RID: 100577 RVA: 0x0038A183 File Offset: 0x00388383
		public bool IsRecycle { get; set; }

		// Token: 0x17007683 RID: 30339
		// (get) Token: 0x060188E2 RID: 100578 RVA: 0x0038A18C File Offset: 0x0038838C
		// (set) Token: 0x060188E3 RID: 100579 RVA: 0x0038A194 File Offset: 0x00388394
		public byte NullMask { get; set; }

		// Token: 0x060188E4 RID: 100580 RVA: 0x0038A19D File Offset: 0x0038839D
		public ISunSpiritProcessT()
		{
			this.LauncherId = 0;
			this.IsRecycle = false;
			this.NullMask = 0;
		}
	}
}
