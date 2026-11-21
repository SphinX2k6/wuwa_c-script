using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006006 RID: 24582
	public class ISunSpiritGearComponentT
	{
		// Token: 0x1700B64A RID: 46666
		// (get) Token: 0x060296F4 RID: 169716 RVA: 0x005A7D41 File Offset: 0x005A5F41
		// (set) Token: 0x060296F5 RID: 169717 RVA: 0x005A7D49 File Offset: 0x005A5F49
		public bool Disabled { get; set; }

		// Token: 0x1700B64B RID: 46667
		// (get) Token: 0x060296F6 RID: 169718 RVA: 0x005A7D52 File Offset: 0x005A5F52
		// (set) Token: 0x060296F7 RID: 169719 RVA: 0x005A7D5A File Offset: 0x005A5F5A
		public TSunSpiritGearPerformConfigUnion PerformConfig { get; set; }

		// Token: 0x1700B64C RID: 46668
		// (get) Token: 0x060296F8 RID: 169720 RVA: 0x005A7D63 File Offset: 0x005A5F63
		// (set) Token: 0x060296F9 RID: 169721 RVA: 0x005A7D6B File Offset: 0x005A5F6B
		public byte NullMask { get; set; }

		// Token: 0x060296FA RID: 169722 RVA: 0x005A7D74 File Offset: 0x005A5F74
		public ISunSpiritGearComponentT()
		{
			this.Disabled = false;
			this.PerformConfig = null;
			this.NullMask = 0;
		}
	}
}
