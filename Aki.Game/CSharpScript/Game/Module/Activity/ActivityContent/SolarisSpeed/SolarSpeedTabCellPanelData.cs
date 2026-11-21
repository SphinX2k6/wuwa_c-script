using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005033 RID: 20531
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSpeedTabCellPanelData : ISolarSpeedTabCellPanelData
	{
		// Token: 0x1700642E RID: 25646
		// (get) Token: 0x0603363C RID: 210492 RVA: 0x00E67229 File Offset: 0x00E65429
		// (set) Token: 0x0603363D RID: 210493 RVA: 0x00E67231 File Offset: 0x00E65431
		public int LevelId { get; set; }

		// Token: 0x1700642F RID: 25647
		// (get) Token: 0x0603363E RID: 210494 RVA: 0x00E6723A File Offset: 0x00E6543A
		// (set) Token: 0x0603363F RID: 210495 RVA: 0x00E67242 File Offset: 0x00E65442
		public string RomeNumberPath { get; set; }

		// Token: 0x17006430 RID: 25648
		// (get) Token: 0x06033640 RID: 210496 RVA: 0x00E6724B File Offset: 0x00E6544B
		// (set) Token: 0x06033641 RID: 210497 RVA: 0x00E67253 File Offset: 0x00E65453
		public string TitleTextId { get; set; }

		// Token: 0x17006431 RID: 25649
		// (get) Token: 0x06033642 RID: 210498 RVA: 0x00E6725C File Offset: 0x00E6545C
		// (set) Token: 0x06033643 RID: 210499 RVA: 0x00E67264 File Offset: 0x00E65464
		public bool IsChosen { get; set; }

		// Token: 0x17006432 RID: 25650
		// (get) Token: 0x06033644 RID: 210500 RVA: 0x00E6726D File Offset: 0x00E6546D
		// (set) Token: 0x06033645 RID: 210501 RVA: 0x00E67275 File Offset: 0x00E65475
		public bool IsRedDot { get; set; }
	}
}
