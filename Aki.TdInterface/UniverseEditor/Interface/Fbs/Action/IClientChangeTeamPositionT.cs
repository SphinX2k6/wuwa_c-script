using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200638C RID: 25484
	public class IClientChangeTeamPositionT
	{
		// Token: 0x1700BDFF RID: 48639
		// (get) Token: 0x0602C14E RID: 180558 RVA: 0x0060DF46 File Offset: 0x0060C146
		// (set) Token: 0x0602C14F RID: 180559 RVA: 0x0060DF4E File Offset: 0x0060C14E
		public int PositionId { get; set; }

		// Token: 0x1700BE00 RID: 48640
		// (get) Token: 0x0602C150 RID: 180560 RVA: 0x0060DF57 File Offset: 0x0060C157
		// (set) Token: 0x0602C151 RID: 180561 RVA: 0x0060DF5F File Offset: 0x0060C15F
		public bool RestoreToPrevious { get; set; }

		// Token: 0x1700BE01 RID: 48641
		// (get) Token: 0x0602C152 RID: 180562 RVA: 0x0060DF68 File Offset: 0x0060C168
		// (set) Token: 0x0602C153 RID: 180563 RVA: 0x0060DF70 File Offset: 0x0060C170
		public byte NullMask { get; set; }

		// Token: 0x0602C154 RID: 180564 RVA: 0x0060DF79 File Offset: 0x0060C179
		public IClientChangeTeamPositionT()
		{
			this.PositionId = 0;
			this.RestoreToPrevious = false;
			this.NullMask = 0;
		}
	}
}
