using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl
{
	// Token: 0x02005BA6 RID: 23462
	public interface IGridState
	{
		// Token: 0x17006DF8 RID: 28152
		// (get) Token: 0x06039B19 RID: 236313
		// (set) Token: 0x06039B1A RID: 236314
		bool IsFinished { get; set; }

		// Token: 0x17006DF9 RID: 28153
		// (get) Token: 0x06039B1B RID: 236315
		// (set) Token: 0x06039B1C RID: 236316
		EPieceColorType Color { get; set; }
	}
}
