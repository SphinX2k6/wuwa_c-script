using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068AE RID: 26798
	public class IBvbChangeHandCardT
	{
		// Token: 0x1700C4F1 RID: 50417
		// (get) Token: 0x0602DD1F RID: 187679 RVA: 0x00643112 File Offset: 0x00641312
		// (set) Token: 0x0602DD20 RID: 187680 RVA: 0x0064311A File Offset: 0x0064131A
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700C4F2 RID: 50418
		// (get) Token: 0x0602DD21 RID: 187681 RVA: 0x00643123 File Offset: 0x00641323
		// (set) Token: 0x0602DD22 RID: 187682 RVA: 0x0064312B File Offset: 0x0064132B
		public int HandCardIndex { get; set; }

		// Token: 0x1700C4F3 RID: 50419
		// (get) Token: 0x0602DD23 RID: 187683 RVA: 0x00643134 File Offset: 0x00641334
		// (set) Token: 0x0602DD24 RID: 187684 RVA: 0x0064313C File Offset: 0x0064133C
		public byte NullMask { get; set; }

		// Token: 0x0602DD25 RID: 187685 RVA: 0x00643145 File Offset: 0x00641345
		public IBvbChangeHandCardT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.HandCardIndex = 0;
			this.NullMask = 0;
		}
	}
}
