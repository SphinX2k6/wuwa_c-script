using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006795 RID: 26517
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlDropZone
	{
		// Token: 0x0402281B RID: 141339
		public EDragTargetKind Kind;

		// Token: 0x0402281C RID: 141340
		[Nullable(1)]
		public UUIItem HitItem;

		// Token: 0x0402281D RID: 141341
		public IDangoBrawlBagDropZoneExtra BagExtra;

		// Token: 0x0402281E RID: 141342
		public IDangoBrawlBenchDropZoneExtra BenchExtra;

		// Token: 0x0402281F RID: 141343
		public IDangoBrawlShopDropZoneExtra Shop;
	}
}
