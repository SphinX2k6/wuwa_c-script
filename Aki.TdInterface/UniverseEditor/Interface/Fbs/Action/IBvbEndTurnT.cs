using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006243 RID: 25155
	public class IBvbEndTurnT
	{
		// Token: 0x1700BB79 RID: 47993
		// (get) Token: 0x0602B5FE RID: 177662 RVA: 0x005F89B2 File Offset: 0x005F6BB2
		// (set) Token: 0x0602B5FF RID: 177663 RVA: 0x005F89BA File Offset: 0x005F6BBA
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x0602B600 RID: 177664 RVA: 0x005F89C3 File Offset: 0x005F6BC3
		public IBvbEndTurnT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
		}
	}
}
