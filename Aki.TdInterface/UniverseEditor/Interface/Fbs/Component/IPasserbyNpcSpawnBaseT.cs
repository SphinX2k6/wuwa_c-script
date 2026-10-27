using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D5 RID: 22229
	public class IPasserbyNpcSpawnBaseT
	{
		// Token: 0x1700A56C RID: 42348
		// (get) Token: 0x06025224 RID: 152100 RVA: 0x005203B8 File Offset: 0x0051E5B8
		// (set) Token: 0x06025225 RID: 152101 RVA: 0x005203C0 File Offset: 0x0051E5C0
		public EPasserbyNpcSpawnType Type { get; set; }

		// Token: 0x1700A56D RID: 42349
		// (get) Token: 0x06025226 RID: 152102 RVA: 0x005203C9 File Offset: 0x0051E5C9
		// (set) Token: 0x06025227 RID: 152103 RVA: 0x005203D1 File Offset: 0x0051E5D1
		public int MaxSpawnCount { get; set; }

		// Token: 0x1700A56E RID: 42350
		// (get) Token: 0x06025228 RID: 152104 RVA: 0x005203DA File Offset: 0x0051E5DA
		// (set) Token: 0x06025229 RID: 152105 RVA: 0x005203E2 File Offset: 0x0051E5E2
		public int MinDistance { get; set; }

		// Token: 0x1700A56F RID: 42351
		// (get) Token: 0x0602522A RID: 152106 RVA: 0x005203EB File Offset: 0x0051E5EB
		// (set) Token: 0x0602522B RID: 152107 RVA: 0x005203F3 File Offset: 0x0051E5F3
		public byte NullMask { get; set; }

		// Token: 0x0602522C RID: 152108 RVA: 0x005203FC File Offset: 0x0051E5FC
		public IPasserbyNpcSpawnBaseT()
		{
			this.Type = EPasserbyNpcSpawnType.FixInterval;
			this.MaxSpawnCount = 0;
			this.MinDistance = 0;
			this.NullMask = 0;
		}
	}
}
