using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl
{
	// Token: 0x02006A4A RID: 27210
	public class GridState : IGridState
	{
		// Token: 0x17009915 RID: 39189
		// (get) Token: 0x06043ACF RID: 277199 RVA: 0x0108E7E9 File Offset: 0x0108C9E9
		// (set) Token: 0x06043AD0 RID: 277200 RVA: 0x0108E7F1 File Offset: 0x0108C9F1
		public bool IsFinished { get; set; }

		// Token: 0x17009916 RID: 39190
		// (get) Token: 0x06043AD1 RID: 277201 RVA: 0x0108E7FA File Offset: 0x0108C9FA
		// (set) Token: 0x06043AD2 RID: 277202 RVA: 0x0108E802 File Offset: 0x0108CA02
		public EPieceColorType Color { get; set; }
	}
}
