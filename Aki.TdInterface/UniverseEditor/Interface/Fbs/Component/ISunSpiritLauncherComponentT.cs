using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A0B RID: 23051
	public class ISunSpiritLauncherComponentT
	{
		// Token: 0x1700AD37 RID: 44343
		// (get) Token: 0x0602721E RID: 160286 RVA: 0x0056221A File Offset: 0x0056041A
		// (set) Token: 0x0602721F RID: 160287 RVA: 0x00562222 File Offset: 0x00560422
		public bool Disabled { get; set; }

		// Token: 0x1700AD38 RID: 44344
		// (get) Token: 0x06027220 RID: 160288 RVA: 0x0056222B File Offset: 0x0056042B
		// (set) Token: 0x06027221 RID: 160289 RVA: 0x00562233 File Offset: 0x00560433
		public int AreaId { get; set; }

		// Token: 0x1700AD39 RID: 44345
		// (get) Token: 0x06027222 RID: 160290 RVA: 0x0056223C File Offset: 0x0056043C
		// (set) Token: 0x06027223 RID: 160291 RVA: 0x00562244 File Offset: 0x00560444
		public int NeedsCount { get; set; }

		// Token: 0x1700AD3A RID: 44346
		// (get) Token: 0x06027224 RID: 160292 RVA: 0x0056224D File Offset: 0x0056044D
		// (set) Token: 0x06027225 RID: 160293 RVA: 0x00562255 File Offset: 0x00560455
		public int SunSpiritGearId { get; set; }

		// Token: 0x1700AD3B RID: 44347
		// (get) Token: 0x06027226 RID: 160294 RVA: 0x0056225E File Offset: 0x0056045E
		// (set) Token: 0x06027227 RID: 160295 RVA: 0x00562266 File Offset: 0x00560466
		public byte NullMask { get; set; }

		// Token: 0x06027228 RID: 160296 RVA: 0x0056226F File Offset: 0x0056046F
		public ISunSpiritLauncherComponentT()
		{
			this.Disabled = false;
			this.AreaId = 0;
			this.NeedsCount = 0;
			this.SunSpiritGearId = 0;
			this.NullMask = 0;
		}
	}
}
