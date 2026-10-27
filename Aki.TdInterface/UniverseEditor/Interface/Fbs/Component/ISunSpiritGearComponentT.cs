using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F9 RID: 23033
	public class ISunSpiritGearComponentT
	{
		// Token: 0x1700AD12 RID: 44306
		// (get) Token: 0x0602717C RID: 160124 RVA: 0x00560D7D File Offset: 0x0055EF7D
		// (set) Token: 0x0602717D RID: 160125 RVA: 0x00560D85 File Offset: 0x0055EF85
		public bool Disabled { get; set; }

		// Token: 0x1700AD13 RID: 44307
		// (get) Token: 0x0602717E RID: 160126 RVA: 0x00560D8E File Offset: 0x0055EF8E
		// (set) Token: 0x0602717F RID: 160127 RVA: 0x00560D96 File Offset: 0x0055EF96
		public TSunSpiritGearPerformConfigUnion PerformConfig { get; set; }

		// Token: 0x1700AD14 RID: 44308
		// (get) Token: 0x06027180 RID: 160128 RVA: 0x00560D9F File Offset: 0x0055EF9F
		// (set) Token: 0x06027181 RID: 160129 RVA: 0x00560DA7 File Offset: 0x0055EFA7
		public byte NullMask { get; set; }

		// Token: 0x06027182 RID: 160130 RVA: 0x00560DB0 File Offset: 0x0055EFB0
		public ISunSpiritGearComponentT()
		{
			this.Disabled = false;
			this.PerformConfig = null;
			this.NullMask = 0;
		}
	}
}
