using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AD8 RID: 19160
	public class IGmTeleportToEntityT
	{
		// Token: 0x1700864B RID: 34379
		// (get) Token: 0x0601CDC2 RID: 118210 RVA: 0x0041044E File Offset: 0x0040E64E
		// (set) Token: 0x0601CDC3 RID: 118211 RVA: 0x00410456 File Offset: 0x0040E656
		public EGmCommand Type { get; set; }

		// Token: 0x1700864C RID: 34380
		// (get) Token: 0x0601CDC4 RID: 118212 RVA: 0x0041045F File Offset: 0x0040E65F
		// (set) Token: 0x0601CDC5 RID: 118213 RVA: 0x00410467 File Offset: 0x0040E667
		public int EntityId { get; set; }

		// Token: 0x1700864D RID: 34381
		// (get) Token: 0x0601CDC6 RID: 118214 RVA: 0x00410470 File Offset: 0x0040E670
		// (set) Token: 0x0601CDC7 RID: 118215 RVA: 0x00410478 File Offset: 0x0040E678
		public int PreIncId { get; set; }

		// Token: 0x0601CDC8 RID: 118216 RVA: 0x00410481 File Offset: 0x0040E681
		public IGmTeleportToEntityT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.EntityId = 0;
			this.PreIncId = 0;
		}
	}
}
