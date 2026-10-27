using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F2C RID: 24364
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerBossAttrData : IWheelTowerBossAttrData
	{
		// Token: 0x17008F1C RID: 36636
		// (get) Token: 0x0603DE57 RID: 253527 RVA: 0x00EF55D4 File Offset: 0x00EF37D4
		// (set) Token: 0x0603DE58 RID: 253528 RVA: 0x00EF55DC File Offset: 0x00EF37DC
		public string AttrName { get; set; } = string.Empty;

		// Token: 0x17008F1D RID: 36637
		// (get) Token: 0x0603DE59 RID: 253529 RVA: 0x00EF55E5 File Offset: 0x00EF37E5
		// (set) Token: 0x0603DE5A RID: 253530 RVA: 0x00EF55ED File Offset: 0x00EF37ED
		public int AttrLevel { get; set; }

		// Token: 0x17008F1E RID: 36638
		// (get) Token: 0x0603DE5B RID: 253531 RVA: 0x00EF55F6 File Offset: 0x00EF37F6
		// (set) Token: 0x0603DE5C RID: 253532 RVA: 0x00EF55FE File Offset: 0x00EF37FE
		public int ElementId { get; set; }

		// Token: 0x17008F1F RID: 36639
		// (get) Token: 0x0603DE5D RID: 253533 RVA: 0x00EF5607 File Offset: 0x00EF3807
		// (set) Token: 0x0603DE5E RID: 253534 RVA: 0x00EF560F File Offset: 0x00EF380F
		public List<int> TagIdList { get; set; } = new List<int>();
	}
}
