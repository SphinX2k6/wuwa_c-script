using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F21 RID: 20257
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerPopupData : IWheelTowerPopupData
	{
		// Token: 0x1700632B RID: 25387
		// (get) Token: 0x06032E73 RID: 208499 RVA: 0x00E47578 File Offset: 0x00E45778
		// (set) Token: 0x06032E74 RID: 208500 RVA: 0x00E47580 File Offset: 0x00E45780
		public int TotalScore { get; set; }

		// Token: 0x1700632C RID: 25388
		// (get) Token: 0x06032E75 RID: 208501 RVA: 0x00E47589 File Offset: 0x00E45789
		// (set) Token: 0x06032E76 RID: 208502 RVA: 0x00E47591 File Offset: 0x00E45791
		public int RoundScore { get; set; }

		// Token: 0x1700632D RID: 25389
		// (get) Token: 0x06032E77 RID: 208503 RVA: 0x00E4759A File Offset: 0x00E4579A
		// (set) Token: 0x06032E78 RID: 208504 RVA: 0x00E475A2 File Offset: 0x00E457A2
		public int ScoreRecord { get; set; }

		// Token: 0x1700632E RID: 25390
		// (get) Token: 0x06032E79 RID: 208505 RVA: 0x00E475AB File Offset: 0x00E457AB
		// (set) Token: 0x06032E7A RID: 208506 RVA: 0x00E475B3 File Offset: 0x00E457B3
		public List<int> TeamRoleIdList { get; set; } = new List<int>();

		// Token: 0x1700632F RID: 25391
		// (get) Token: 0x06032E7B RID: 208507 RVA: 0x00E475BC File Offset: 0x00E457BC
		// (set) Token: 0x06032E7C RID: 208508 RVA: 0x00E475C4 File Offset: 0x00E457C4
		public int BuffId { get; set; }
	}
}
