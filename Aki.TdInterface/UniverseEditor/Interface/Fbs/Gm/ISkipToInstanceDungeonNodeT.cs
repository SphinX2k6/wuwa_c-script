using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B08 RID: 19208
	public class ISkipToInstanceDungeonNodeT
	{
		// Token: 0x170086A6 RID: 34470
		// (get) Token: 0x0601CF3E RID: 118590 RVA: 0x004128D4 File Offset: 0x00410AD4
		// (set) Token: 0x0601CF3F RID: 118591 RVA: 0x004128DC File Offset: 0x00410ADC
		public EGmCommand Type { get; set; }

		// Token: 0x170086A7 RID: 34471
		// (get) Token: 0x0601CF40 RID: 118592 RVA: 0x004128E5 File Offset: 0x00410AE5
		// (set) Token: 0x0601CF41 RID: 118593 RVA: 0x004128ED File Offset: 0x00410AED
		public int ChildQuestId { get; set; }

		// Token: 0x170086A8 RID: 34472
		// (get) Token: 0x0601CF42 RID: 118594 RVA: 0x004128F6 File Offset: 0x00410AF6
		// (set) Token: 0x0601CF43 RID: 118595 RVA: 0x004128FE File Offset: 0x00410AFE
		public bool IsTeleport { get; set; }

		// Token: 0x170086A9 RID: 34473
		// (get) Token: 0x0601CF44 RID: 118596 RVA: 0x00412907 File Offset: 0x00410B07
		// (set) Token: 0x0601CF45 RID: 118597 RVA: 0x0041290F File Offset: 0x00410B0F
		public bool IsFastMode { get; set; }

		// Token: 0x0601CF46 RID: 118598 RVA: 0x00412918 File Offset: 0x00410B18
		public ISkipToInstanceDungeonNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.ChildQuestId = 0;
			this.IsTeleport = false;
			this.IsFastMode = false;
		}
	}
}
