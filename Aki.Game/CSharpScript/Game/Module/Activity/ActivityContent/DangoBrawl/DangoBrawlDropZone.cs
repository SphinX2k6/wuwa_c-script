using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056E5 RID: 22245
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlDropZone
	{
		// Token: 0x0401D078 RID: 118904
		public EDragTargetKind Kind;

		// Token: 0x0401D079 RID: 118905
		[Nullable(1)]
		public UUIItem HitItem;

		// Token: 0x0401D07A RID: 118906
		public IDangoBrawlBagDropZoneExtra BagExtra;

		// Token: 0x0401D07B RID: 118907
		public IDangoBrawlBenchDropZoneExtra BenchExtra;

		// Token: 0x0401D07C RID: 118908
		public IDangoBrawlShopDropZoneExtra Shop;
	}
}
