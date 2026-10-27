using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl
{
	// Token: 0x02006A49 RID: 27209
	public interface IGridState
	{
		// Token: 0x17009913 RID: 39187
		// (get) Token: 0x06043ACB RID: 277195
		// (set) Token: 0x06043ACC RID: 277196
		bool IsFinished { get; set; }

		// Token: 0x17009914 RID: 39188
		// (get) Token: 0x06043ACD RID: 277197
		// (set) Token: 0x06043ACE RID: 277198
		EPieceColorType Color { get; set; }
	}
}
