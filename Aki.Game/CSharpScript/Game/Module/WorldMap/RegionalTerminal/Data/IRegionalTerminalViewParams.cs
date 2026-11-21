using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data
{
	// Token: 0x0200378D RID: 14221
	[NullableContext(2)]
	public interface IRegionalTerminalViewParams
	{
		// Token: 0x17004BD5 RID: 19413
		// (get) Token: 0x06024F80 RID: 151424
		// (set) Token: 0x06024F81 RID: 151425
		bool ShowLockPanel { get; set; }

		// Token: 0x17004BD6 RID: 19414
		// (get) Token: 0x06024F82 RID: 151426
		// (set) Token: 0x06024F83 RID: 151427
		bool ShowButton { get; set; }

		// Token: 0x17004BD7 RID: 19415
		// (get) Token: 0x06024F84 RID: 151428
		// (set) Token: 0x06024F85 RID: 151429
		Action LockClickFunc { get; set; }

		// Token: 0x17004BD8 RID: 19416
		// (get) Token: 0x06024F86 RID: 151430
		// (set) Token: 0x06024F87 RID: 151431
		string LockTxtId { get; set; }

		// Token: 0x17004BD9 RID: 19417
		// (get) Token: 0x06024F88 RID: 151432
		// (set) Token: 0x06024F89 RID: 151433
		string ButtonTxtId { get; set; }
	}
}
