using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044F8 RID: 17656
	public class ILevelPlayInfoMappingNightmareSpawnPointT
	{
		// Token: 0x17007D1D RID: 32029
		// (get) Token: 0x0601A80B RID: 108555 RVA: 0x003C9238 File Offset: 0x003C7438
		// (set) Token: 0x0601A80C RID: 108556 RVA: 0x003C9240 File Offset: 0x003C7440
		public ELevelPlayInfoMappingType Type { get; set; }

		// Token: 0x17007D1E RID: 32030
		// (get) Token: 0x0601A80D RID: 108557 RVA: 0x003C9249 File Offset: 0x003C7449
		// (set) Token: 0x0601A80E RID: 108558 RVA: 0x003C9251 File Offset: 0x003C7451
		public int LevelPlayId { get; set; }

		// Token: 0x17007D1F RID: 32031
		// (get) Token: 0x0601A80F RID: 108559 RVA: 0x003C925A File Offset: 0x003C745A
		// (set) Token: 0x0601A810 RID: 108560 RVA: 0x003C9262 File Offset: 0x003C7462
		public List<string> Vars { get; set; }

		// Token: 0x17007D20 RID: 32032
		// (get) Token: 0x0601A811 RID: 108561 RVA: 0x003C926B File Offset: 0x003C746B
		// (set) Token: 0x0601A812 RID: 108562 RVA: 0x003C9273 File Offset: 0x003C7473
		public List<int> DefaultValues { get; set; }

		// Token: 0x17007D21 RID: 32033
		// (get) Token: 0x0601A813 RID: 108563 RVA: 0x003C927C File Offset: 0x003C747C
		// (set) Token: 0x0601A814 RID: 108564 RVA: 0x003C9284 File Offset: 0x003C7484
		public byte NullMask { get; set; }

		// Token: 0x0601A815 RID: 108565 RVA: 0x003C928D File Offset: 0x003C748D
		public ILevelPlayInfoMappingNightmareSpawnPointT()
		{
			this.Type = ELevelPlayInfoMappingType.PunishReport;
			this.LevelPlayId = 0;
			this.Vars = null;
			this.DefaultValues = null;
			this.NullMask = 0;
		}
	}
}
