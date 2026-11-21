using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl
{
	// Token: 0x02005BA7 RID: 23463
	public class GridState : IGridState
	{
		// Token: 0x17006DFA RID: 28154
		// (get) Token: 0x06039B1D RID: 236317 RVA: 0x01032FF1 File Offset: 0x010311F1
		// (set) Token: 0x06039B1E RID: 236318 RVA: 0x01032FF9 File Offset: 0x010311F9
		public bool IsFinished { get; set; }

		// Token: 0x17006DFB RID: 28155
		// (get) Token: 0x06039B1F RID: 236319 RVA: 0x01033002 File Offset: 0x01031202
		// (set) Token: 0x06039B20 RID: 236320 RVA: 0x0103300A File Offset: 0x0103120A
		public EPieceColorType Color { get; set; }
	}
}
