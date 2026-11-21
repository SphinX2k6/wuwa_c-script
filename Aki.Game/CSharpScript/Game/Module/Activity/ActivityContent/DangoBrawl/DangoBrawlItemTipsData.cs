using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056F4 RID: 22260
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlItemTipsData
	{
		// Token: 0x0401D08D RID: 118925
		public int ItemId;

		// Token: 0x0401D08E RID: 118926
		public EDangoBrawlItemTipsFrom From;

		// Token: 0x0401D08F RID: 118927
		public int? ItemUid;

		// Token: 0x0401D090 RID: 118928
		public float? GridSize;

		// Token: 0x0401D091 RID: 118929
		public UUIItem GridItem;

		// Token: 0x0401D092 RID: 118930
		public float? ChangeY;

		// Token: 0x0401D093 RID: 118931
		public Vector FixedLocation;

		// Token: 0x0401D094 RID: 118932
		public bool? ShowCombine;

		// Token: 0x0401D095 RID: 118933
		public bool? ShowSell;

		// Token: 0x0401D096 RID: 118934
		public int? Damage;

		// Token: 0x0401D097 RID: 118935
		public int? Cd;

		// Token: 0x0401D098 RID: 118936
		public int? Cost;

		// Token: 0x0401D099 RID: 118937
		public EDangoBrawlTipsOperationMode OperationMode;

		// Token: 0x0401D09A RID: 118938
		public PanelPos? ItemLeftTopPos;
	}
}
