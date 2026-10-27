using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data
{
	// Token: 0x0200485D RID: 18525
	[NullableContext(2)]
	[Nullable(0)]
	public class RegionalTerminalViewParams : IRegionalTerminalViewParams
	{
		// Token: 0x1700791D RID: 31005
		// (get) Token: 0x060307BB RID: 198587 RVA: 0x00B42190 File Offset: 0x00B40390
		// (set) Token: 0x060307BC RID: 198588 RVA: 0x00B42198 File Offset: 0x00B40398
		public bool ShowLockPanel { get; set; }

		// Token: 0x1700791E RID: 31006
		// (get) Token: 0x060307BD RID: 198589 RVA: 0x00B421A1 File Offset: 0x00B403A1
		// (set) Token: 0x060307BE RID: 198590 RVA: 0x00B421A9 File Offset: 0x00B403A9
		public bool ShowButton { get; set; }

		// Token: 0x1700791F RID: 31007
		// (get) Token: 0x060307BF RID: 198591 RVA: 0x00B421B2 File Offset: 0x00B403B2
		// (set) Token: 0x060307C0 RID: 198592 RVA: 0x00B421BA File Offset: 0x00B403BA
		public Action LockClickFunc { get; set; }

		// Token: 0x17007920 RID: 31008
		// (get) Token: 0x060307C1 RID: 198593 RVA: 0x00B421C3 File Offset: 0x00B403C3
		// (set) Token: 0x060307C2 RID: 198594 RVA: 0x00B421CB File Offset: 0x00B403CB
		public string LockTxtId { get; set; }

		// Token: 0x17007921 RID: 31009
		// (get) Token: 0x060307C3 RID: 198595 RVA: 0x00B421D4 File Offset: 0x00B403D4
		// (set) Token: 0x060307C4 RID: 198596 RVA: 0x00B421DC File Offset: 0x00B403DC
		public string ButtonTxtId { get; set; }
	}
}
