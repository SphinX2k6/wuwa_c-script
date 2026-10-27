using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004998 RID: 18840
	public class ICheckChessWinnerT
	{
		// Token: 0x1700881F RID: 34847
		// (get) Token: 0x0601D62A RID: 120362 RVA: 0x0042457A File Offset: 0x0042277A
		// (set) Token: 0x0601D62B RID: 120363 RVA: 0x00424582 File Offset: 0x00422782
		public ECondition Type { get; set; }

		// Token: 0x17008820 RID: 34848
		// (get) Token: 0x0601D62C RID: 120364 RVA: 0x0042458B File Offset: 0x0042278B
		// (set) Token: 0x0601D62D RID: 120365 RVA: 0x00424593 File Offset: 0x00422793
		public int ChessboardId { get; set; }

		// Token: 0x17008821 RID: 34849
		// (get) Token: 0x0601D62E RID: 120366 RVA: 0x0042459C File Offset: 0x0042279C
		// (set) Token: 0x0601D62F RID: 120367 RVA: 0x004245A4 File Offset: 0x004227A4
		public ERenjuController Winner { get; set; }

		// Token: 0x0601D630 RID: 120368 RVA: 0x004245AD File Offset: 0x004227AD
		public ICheckChessWinnerT()
		{
			this.Type = ECondition.CompareVar;
			this.ChessboardId = 0;
			this.Winner = ERenjuController.Computer;
		}
	}
}
