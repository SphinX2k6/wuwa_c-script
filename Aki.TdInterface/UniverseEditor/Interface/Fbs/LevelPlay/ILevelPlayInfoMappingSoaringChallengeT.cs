using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004966 RID: 18790
	public class ILevelPlayInfoMappingSoaringChallengeT
	{
		// Token: 0x17008373 RID: 33651
		// (get) Token: 0x0601C036 RID: 114742 RVA: 0x003F5F67 File Offset: 0x003F4167
		// (set) Token: 0x0601C037 RID: 114743 RVA: 0x003F5F6F File Offset: 0x003F416F
		public ELevelPlayInfoMappingType Type { get; set; }

		// Token: 0x17008374 RID: 33652
		// (get) Token: 0x0601C038 RID: 114744 RVA: 0x003F5F78 File Offset: 0x003F4178
		// (set) Token: 0x0601C039 RID: 114745 RVA: 0x003F5F80 File Offset: 0x003F4180
		public int LevelPlayId { get; set; }

		// Token: 0x17008375 RID: 33653
		// (get) Token: 0x0601C03A RID: 114746 RVA: 0x003F5F89 File Offset: 0x003F4189
		// (set) Token: 0x0601C03B RID: 114747 RVA: 0x003F5F91 File Offset: 0x003F4191
		public List<string> Vars { get; set; }

		// Token: 0x17008376 RID: 33654
		// (get) Token: 0x0601C03C RID: 114748 RVA: 0x003F5F9A File Offset: 0x003F419A
		// (set) Token: 0x0601C03D RID: 114749 RVA: 0x003F5FA2 File Offset: 0x003F41A2
		public byte NullMask { get; set; }

		// Token: 0x0601C03E RID: 114750 RVA: 0x003F5FAB File Offset: 0x003F41AB
		public ILevelPlayInfoMappingSoaringChallengeT()
		{
			this.Type = ELevelPlayInfoMappingType.PunishReport;
			this.LevelPlayId = 0;
			this.Vars = null;
			this.NullMask = 0;
		}
	}
}
