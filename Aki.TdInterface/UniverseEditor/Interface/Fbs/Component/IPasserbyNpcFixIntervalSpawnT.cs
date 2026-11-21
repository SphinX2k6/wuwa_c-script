using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C79 RID: 23673
	public class IPasserbyNpcFixIntervalSpawnT
	{
		// Token: 0x1700ADF0 RID: 44528
		// (get) Token: 0x06027455 RID: 160853 RVA: 0x00560E86 File Offset: 0x0055F086
		// (set) Token: 0x06027456 RID: 160854 RVA: 0x00560E8E File Offset: 0x0055F08E
		public EPasserbyNpcSpawnType Type { get; set; }

		// Token: 0x1700ADF1 RID: 44529
		// (get) Token: 0x06027457 RID: 160855 RVA: 0x00560E97 File Offset: 0x0055F097
		// (set) Token: 0x06027458 RID: 160856 RVA: 0x00560E9F File Offset: 0x0055F09F
		public int MaxSpawnCount { get; set; }

		// Token: 0x1700ADF2 RID: 44530
		// (get) Token: 0x06027459 RID: 160857 RVA: 0x00560EA8 File Offset: 0x0055F0A8
		// (set) Token: 0x0602745A RID: 160858 RVA: 0x00560EB0 File Offset: 0x0055F0B0
		public int MinDistance { get; set; }

		// Token: 0x1700ADF3 RID: 44531
		// (get) Token: 0x0602745B RID: 160859 RVA: 0x00560EB9 File Offset: 0x0055F0B9
		// (set) Token: 0x0602745C RID: 160860 RVA: 0x00560EC1 File Offset: 0x0055F0C1
		public float Interval { get; set; }

		// Token: 0x1700ADF4 RID: 44532
		// (get) Token: 0x0602745D RID: 160861 RVA: 0x00560ECA File Offset: 0x0055F0CA
		// (set) Token: 0x0602745E RID: 160862 RVA: 0x00560ED2 File Offset: 0x0055F0D2
		public byte NullMask { get; set; }

		// Token: 0x0602745F RID: 160863 RVA: 0x00560EDB File Offset: 0x0055F0DB
		public IPasserbyNpcFixIntervalSpawnT()
		{
			this.Type = EPasserbyNpcSpawnType.FixInterval;
			this.MaxSpawnCount = 0;
			this.MinDistance = 0;
			this.Interval = 0f;
			this.NullMask = 0;
		}
	}
}
