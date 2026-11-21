using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B2F RID: 19247
	public class ITeleportToPosInWorldT
	{
		// Token: 0x17008701 RID: 34561
		// (get) Token: 0x0601D094 RID: 118932 RVA: 0x00414C03 File Offset: 0x00412E03
		// (set) Token: 0x0601D095 RID: 118933 RVA: 0x00414C0B File Offset: 0x00412E0B
		public EGmCommand Type { get; set; }

		// Token: 0x17008702 RID: 34562
		// (get) Token: 0x0601D096 RID: 118934 RVA: 0x00414C14 File Offset: 0x00412E14
		// (set) Token: 0x0601D097 RID: 118935 RVA: 0x00414C1C File Offset: 0x00412E1C
		public IPosAT Pos { get; set; }

		// Token: 0x17008703 RID: 34563
		// (get) Token: 0x0601D098 RID: 118936 RVA: 0x00414C25 File Offset: 0x00412E25
		// (set) Token: 0x0601D099 RID: 118937 RVA: 0x00414C2D File Offset: 0x00412E2D
		public int DungeonId { get; set; }

		// Token: 0x17008704 RID: 34564
		// (get) Token: 0x0601D09A RID: 118938 RVA: 0x00414C36 File Offset: 0x00412E36
		// (set) Token: 0x0601D09B RID: 118939 RVA: 0x00414C3E File Offset: 0x00412E3E
		public byte NullMask { get; set; }

		// Token: 0x0601D09C RID: 118940 RVA: 0x00414C47 File Offset: 0x00412E47
		public ITeleportToPosInWorldT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Pos = null;
			this.DungeonId = 0;
			this.NullMask = 0;
		}
	}
}
