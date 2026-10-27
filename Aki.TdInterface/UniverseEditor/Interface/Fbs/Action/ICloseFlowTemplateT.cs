using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200641C RID: 25628
	public class ICloseFlowTemplateT
	{
		// Token: 0x1700BED3 RID: 48851
		// (get) Token: 0x0602C589 RID: 181641 RVA: 0x00615F0B File Offset: 0x0061410B
		// (set) Token: 0x0602C58A RID: 181642 RVA: 0x00615F13 File Offset: 0x00614113
		public bool IsResetPosition { get; set; }

		// Token: 0x1700BED4 RID: 48852
		// (get) Token: 0x0602C58B RID: 181643 RVA: 0x00615F1C File Offset: 0x0061411C
		// (set) Token: 0x0602C58C RID: 181644 RVA: 0x00615F24 File Offset: 0x00614124
		public IEndStateT EndState { get; set; }

		// Token: 0x1700BED5 RID: 48853
		// (get) Token: 0x0602C58D RID: 181645 RVA: 0x00615F2D File Offset: 0x0061412D
		// (set) Token: 0x0602C58E RID: 181646 RVA: 0x00615F35 File Offset: 0x00614135
		public bool ExitFilmAspectRatio { get; set; }

		// Token: 0x1700BED6 RID: 48854
		// (get) Token: 0x0602C58F RID: 181647 RVA: 0x00615F3E File Offset: 0x0061413E
		// (set) Token: 0x0602C590 RID: 181648 RVA: 0x00615F46 File Offset: 0x00614146
		public byte NullMask { get; set; }

		// Token: 0x0602C591 RID: 181649 RVA: 0x00615F4F File Offset: 0x0061414F
		public ICloseFlowTemplateT()
		{
			this.IsResetPosition = false;
			this.EndState = null;
			this.ExitFilmAspectRatio = false;
			this.NullMask = 0;
		}
	}
}
