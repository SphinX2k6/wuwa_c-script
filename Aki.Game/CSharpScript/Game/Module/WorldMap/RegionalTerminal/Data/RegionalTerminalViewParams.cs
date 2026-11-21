using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data
{
	// Token: 0x0200378E RID: 14222
	[NullableContext(2)]
	[Nullable(0)]
	public class RegionalTerminalViewParams : IRegionalTerminalViewParams
	{
		// Token: 0x17004BDA RID: 19418
		// (get) Token: 0x06024F8A RID: 151434 RVA: 0x00A723D4 File Offset: 0x00A705D4
		// (set) Token: 0x06024F8B RID: 151435 RVA: 0x00A723DC File Offset: 0x00A705DC
		public bool ShowLockPanel { get; set; }

		// Token: 0x17004BDB RID: 19419
		// (get) Token: 0x06024F8C RID: 151436 RVA: 0x00A723E5 File Offset: 0x00A705E5
		// (set) Token: 0x06024F8D RID: 151437 RVA: 0x00A723ED File Offset: 0x00A705ED
		public bool ShowButton { get; set; }

		// Token: 0x17004BDC RID: 19420
		// (get) Token: 0x06024F8E RID: 151438 RVA: 0x00A723F6 File Offset: 0x00A705F6
		// (set) Token: 0x06024F8F RID: 151439 RVA: 0x00A723FE File Offset: 0x00A705FE
		public Action LockClickFunc { get; set; }

		// Token: 0x17004BDD RID: 19421
		// (get) Token: 0x06024F90 RID: 151440 RVA: 0x00A72407 File Offset: 0x00A70607
		// (set) Token: 0x06024F91 RID: 151441 RVA: 0x00A7240F File Offset: 0x00A7060F
		public string LockTxtId { get; set; }

		// Token: 0x17004BDE RID: 19422
		// (get) Token: 0x06024F92 RID: 151442 RVA: 0x00A72418 File Offset: 0x00A70618
		// (set) Token: 0x06024F93 RID: 151443 RVA: 0x00A72420 File Offset: 0x00A70620
		public string ButtonTxtId { get; set; }
	}
}
