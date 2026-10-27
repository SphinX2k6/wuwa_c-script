using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200638F RID: 25487
	public class IClientDisableAllPlayerOperationT
	{
		// Token: 0x1700BE06 RID: 48646
		// (get) Token: 0x0602C168 RID: 180584 RVA: 0x0060E1D6 File Offset: 0x0060C3D6
		// (set) Token: 0x0602C169 RID: 180585 RVA: 0x0060E1DE File Offset: 0x0060C3DE
		public EPlayerOperationType Type { get; set; }

		// Token: 0x1700BE07 RID: 48647
		// (get) Token: 0x0602C16A RID: 180586 RVA: 0x0060E1E7 File Offset: 0x0060C3E7
		// (set) Token: 0x0602C16B RID: 180587 RVA: 0x0060E1EF File Offset: 0x0060C3EF
		public EDisplayModeInPlayerOp DisplayMode { get; set; }

		// Token: 0x1700BE08 RID: 48648
		// (get) Token: 0x0602C16C RID: 180588 RVA: 0x0060E1F8 File Offset: 0x0060C3F8
		// (set) Token: 0x0602C16D RID: 180589 RVA: 0x0060E200 File Offset: 0x0060C400
		public byte NullMask { get; set; }

		// Token: 0x0602C16E RID: 180590 RVA: 0x0060E209 File Offset: 0x0060C409
		public IClientDisableAllPlayerOperationT()
		{
			this.Type = EPlayerOperationType.EnableAll;
			this.DisplayMode = EDisplayModeInPlayerOp.ShowUi;
			this.NullMask = 0;
		}
	}
}
