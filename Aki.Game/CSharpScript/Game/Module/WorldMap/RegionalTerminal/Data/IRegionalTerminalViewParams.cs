using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data
{
	// Token: 0x0200485C RID: 18524
	[NullableContext(2)]
	public interface IRegionalTerminalViewParams
	{
		// Token: 0x17007918 RID: 31000
		// (get) Token: 0x060307B1 RID: 198577
		// (set) Token: 0x060307B2 RID: 198578
		bool ShowLockPanel { get; set; }

		// Token: 0x17007919 RID: 31001
		// (get) Token: 0x060307B3 RID: 198579
		// (set) Token: 0x060307B4 RID: 198580
		bool ShowButton { get; set; }

		// Token: 0x1700791A RID: 31002
		// (get) Token: 0x060307B5 RID: 198581
		// (set) Token: 0x060307B6 RID: 198582
		Action LockClickFunc { get; set; }

		// Token: 0x1700791B RID: 31003
		// (get) Token: 0x060307B7 RID: 198583
		// (set) Token: 0x060307B8 RID: 198584
		string LockTxtId { get; set; }

		// Token: 0x1700791C RID: 31004
		// (get) Token: 0x060307B9 RID: 198585
		// (set) Token: 0x060307BA RID: 198586
		string ButtonTxtId { get; set; }
	}
}
