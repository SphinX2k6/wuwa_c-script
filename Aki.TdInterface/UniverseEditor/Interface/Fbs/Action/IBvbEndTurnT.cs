using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B4 RID: 26804
	public class IBvbEndTurnT
	{
		// Token: 0x1700C501 RID: 50433
		// (get) Token: 0x0602DD5F RID: 187743 RVA: 0x006437BA File Offset: 0x006419BA
		// (set) Token: 0x0602DD60 RID: 187744 RVA: 0x006437C2 File Offset: 0x006419C2
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x0602DD61 RID: 187745 RVA: 0x006437CB File Offset: 0x006419CB
		public IBvbEndTurnT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
		}
	}
}
