using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004963 RID: 18787
	public class ILevelPlayInfoMappingPunishReportT
	{
		// Token: 0x17008369 RID: 33641
		// (get) Token: 0x0601C010 RID: 114704 RVA: 0x003F5AE8 File Offset: 0x003F3CE8
		// (set) Token: 0x0601C011 RID: 114705 RVA: 0x003F5AF0 File Offset: 0x003F3CF0
		public ELevelPlayInfoMappingType Type { get; set; }

		// Token: 0x1700836A RID: 33642
		// (get) Token: 0x0601C012 RID: 114706 RVA: 0x003F5AF9 File Offset: 0x003F3CF9
		// (set) Token: 0x0601C013 RID: 114707 RVA: 0x003F5B01 File Offset: 0x003F3D01
		public int LevelPlayId { get; set; }

		// Token: 0x1700836B RID: 33643
		// (get) Token: 0x0601C014 RID: 114708 RVA: 0x003F5B0A File Offset: 0x003F3D0A
		// (set) Token: 0x0601C015 RID: 114709 RVA: 0x003F5B12 File Offset: 0x003F3D12
		public List<string> Vars { get; set; }

		// Token: 0x1700836C RID: 33644
		// (get) Token: 0x0601C016 RID: 114710 RVA: 0x003F5B1B File Offset: 0x003F3D1B
		// (set) Token: 0x0601C017 RID: 114711 RVA: 0x003F5B23 File Offset: 0x003F3D23
		public List<int> Chests { get; set; }

		// Token: 0x1700836D RID: 33645
		// (get) Token: 0x0601C018 RID: 114712 RVA: 0x003F5B2C File Offset: 0x003F3D2C
		// (set) Token: 0x0601C019 RID: 114713 RVA: 0x003F5B34 File Offset: 0x003F3D34
		public byte NullMask { get; set; }

		// Token: 0x0601C01A RID: 114714 RVA: 0x003F5B3D File Offset: 0x003F3D3D
		public ILevelPlayInfoMappingPunishReportT()
		{
			this.Type = ELevelPlayInfoMappingType.PunishReport;
			this.LevelPlayId = 0;
			this.Vars = null;
			this.Chests = null;
			this.NullMask = 0;
		}
	}
}
