using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006258 RID: 25176
	public class IBvbRecycleHandCardT
	{
		// Token: 0x1700BBA3 RID: 48035
		// (get) Token: 0x0602B6D2 RID: 177874 RVA: 0x005FA306 File Offset: 0x005F8506
		// (set) Token: 0x0602B6D3 RID: 177875 RVA: 0x005FA30E File Offset: 0x005F850E
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700BBA4 RID: 48036
		// (get) Token: 0x0602B6D4 RID: 177876 RVA: 0x005FA317 File Offset: 0x005F8517
		// (set) Token: 0x0602B6D5 RID: 177877 RVA: 0x005FA31F File Offset: 0x005F851F
		public int HandCardIndex { get; set; }

		// Token: 0x1700BBA5 RID: 48037
		// (get) Token: 0x0602B6D6 RID: 177878 RVA: 0x005FA328 File Offset: 0x005F8528
		// (set) Token: 0x0602B6D7 RID: 177879 RVA: 0x005FA330 File Offset: 0x005F8530
		public byte NullMask { get; set; }

		// Token: 0x0602B6D8 RID: 177880 RVA: 0x005FA339 File Offset: 0x005F8539
		public IBvbRecycleHandCardT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.HandCardIndex = 0;
			this.NullMask = 0;
		}
	}
}
