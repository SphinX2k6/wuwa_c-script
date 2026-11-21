using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E4F RID: 20047
	public class ICheckChessWinnerT
	{
		// Token: 0x17008EDA RID: 36570
		// (get) Token: 0x0601F04F RID: 127055 RVA: 0x00454A2E File Offset: 0x00452C2E
		// (set) Token: 0x0601F050 RID: 127056 RVA: 0x00454A36 File Offset: 0x00452C36
		public ECondition Type { get; set; }

		// Token: 0x17008EDB RID: 36571
		// (get) Token: 0x0601F051 RID: 127057 RVA: 0x00454A3F File Offset: 0x00452C3F
		// (set) Token: 0x0601F052 RID: 127058 RVA: 0x00454A47 File Offset: 0x00452C47
		public int ChessboardId { get; set; }

		// Token: 0x17008EDC RID: 36572
		// (get) Token: 0x0601F053 RID: 127059 RVA: 0x00454A50 File Offset: 0x00452C50
		// (set) Token: 0x0601F054 RID: 127060 RVA: 0x00454A58 File Offset: 0x00452C58
		public ERenjuController Winner { get; set; }

		// Token: 0x0601F055 RID: 127061 RVA: 0x00454A61 File Offset: 0x00452C61
		public ICheckChessWinnerT()
		{
			this.Type = ECondition.CompareVar;
			this.ChessboardId = 0;
			this.Winner = ERenjuController.Computer;
		}
	}
}
