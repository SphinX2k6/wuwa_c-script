using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068BA RID: 26810
	public class IBvbPlayDialogT
	{
		// Token: 0x1700C50F RID: 50447
		// (get) Token: 0x0602DD9B RID: 187803 RVA: 0x00643E0A File Offset: 0x0064200A
		// (set) Token: 0x0602DD9C RID: 187804 RVA: 0x00643E12 File Offset: 0x00642012
		public EBvbPlayDialogType DialogType { get; set; }

		// Token: 0x0602DD9D RID: 187805 RVA: 0x00643E1B File Offset: 0x0064201B
		public IBvbPlayDialogT()
		{
			this.DialogType = EBvbPlayDialogType.DungeonBegin;
		}
	}
}
