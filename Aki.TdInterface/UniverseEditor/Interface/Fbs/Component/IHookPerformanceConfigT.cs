using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200595E RID: 22878
	public class IHookPerformanceConfigT
	{
		// Token: 0x1700A621 RID: 42529
		// (get) Token: 0x06025453 RID: 152659 RVA: 0x0051DBA8 File Offset: 0x0051BDA8
		// (set) Token: 0x06025454 RID: 152660 RVA: 0x0051DBB0 File Offset: 0x0051BDB0
		public long HookEffectBuffId { get; set; }

		// Token: 0x1700A622 RID: 42530
		// (get) Token: 0x06025455 RID: 152661 RVA: 0x0051DBB9 File Offset: 0x0051BDB9
		// (set) Token: 0x06025456 RID: 152662 RVA: 0x0051DBC1 File Offset: 0x0051BDC1
		public byte NullMask { get; set; }

		// Token: 0x06025457 RID: 152663 RVA: 0x0051DBCA File Offset: 0x0051BDCA
		public IHookPerformanceConfigT()
		{
			this.HookEffectBuffId = 0L;
			this.NullMask = 0;
		}
	}
}
