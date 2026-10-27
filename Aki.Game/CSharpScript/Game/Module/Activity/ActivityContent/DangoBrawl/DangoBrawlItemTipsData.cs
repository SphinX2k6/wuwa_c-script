using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067A4 RID: 26532
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlItemTipsData
	{
		// Token: 0x04022830 RID: 141360
		public int ItemId;

		// Token: 0x04022831 RID: 141361
		public EDangoBrawlItemTipsFrom From;

		// Token: 0x04022832 RID: 141362
		public int? ItemUid;

		// Token: 0x04022833 RID: 141363
		public float? GridSize;

		// Token: 0x04022834 RID: 141364
		public UUIItem GridItem;

		// Token: 0x04022835 RID: 141365
		public float? ChangeY;

		// Token: 0x04022836 RID: 141366
		public Vector FixedLocation;

		// Token: 0x04022837 RID: 141367
		public bool? ShowCombine;

		// Token: 0x04022838 RID: 141368
		public bool? ShowSell;

		// Token: 0x04022839 RID: 141369
		public int? Damage;

		// Token: 0x0402283A RID: 141370
		public int? Cd;

		// Token: 0x0402283B RID: 141371
		public int? Cost;

		// Token: 0x0402283C RID: 141372
		public EDangoBrawlTipsOperationMode OperationMode;

		// Token: 0x0402283D RID: 141373
		public PanelPos? ItemLeftTopPos;
	}
}
