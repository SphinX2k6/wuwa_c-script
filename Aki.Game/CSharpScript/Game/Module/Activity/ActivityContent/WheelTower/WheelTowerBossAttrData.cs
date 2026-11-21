using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F13 RID: 20243
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerBossAttrData : IWheelTowerBossAttrData
	{
		// Token: 0x170062EE RID: 25326
		// (get) Token: 0x06032DF2 RID: 208370 RVA: 0x00E47300 File Offset: 0x00E45500
		// (set) Token: 0x06032DF3 RID: 208371 RVA: 0x00E47308 File Offset: 0x00E45508
		public string AttrName { get; set; } = string.Empty;

		// Token: 0x170062EF RID: 25327
		// (get) Token: 0x06032DF4 RID: 208372 RVA: 0x00E47311 File Offset: 0x00E45511
		// (set) Token: 0x06032DF5 RID: 208373 RVA: 0x00E47319 File Offset: 0x00E45519
		public int AttrLevel { get; set; }

		// Token: 0x170062F0 RID: 25328
		// (get) Token: 0x06032DF6 RID: 208374 RVA: 0x00E47322 File Offset: 0x00E45522
		// (set) Token: 0x06032DF7 RID: 208375 RVA: 0x00E4732A File Offset: 0x00E4552A
		public int ElementId { get; set; }

		// Token: 0x170062F1 RID: 25329
		// (get) Token: 0x06032DF8 RID: 208376 RVA: 0x00E47333 File Offset: 0x00E45533
		// (set) Token: 0x06032DF9 RID: 208377 RVA: 0x00E4733B File Offset: 0x00E4553B
		public List<int> TagIdList { get; set; } = new List<int>();
	}
}
