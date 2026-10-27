using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200679B RID: 26523
	public class ItemSucAnchor
	{
		// Token: 0x04022826 RID: 141350
		public EDragSourceKind SourceKind;

		// Token: 0x04022827 RID: 141351
		[TupleElementNames(new string[]
		{
			"LeftTopPos",
			"Rotate"
		})]
		public ValueTuple<PanelPos, EDangoBrawlRotate>? BagPos;

		// Token: 0x04022828 RID: 141352
		public FVector2D? BenchPos;

		// Token: 0x04022829 RID: 141353
		public int? ShopSlotUid;
	}
}
