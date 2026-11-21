using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056EB RID: 22251
	public class ItemSucAnchor
	{
		// Token: 0x0401D083 RID: 118915
		public EDragSourceKind SourceKind;

		// Token: 0x0401D084 RID: 118916
		[TupleElementNames(new string[]
		{
			"LeftTopPos",
			"Rotate"
		})]
		public ValueTuple<PanelPos, EDangoBrawlRotate>? BagPos;

		// Token: 0x0401D085 RID: 118917
		public FVector2D? BenchPos;

		// Token: 0x0401D086 RID: 118918
		public int? ShopSlotUid;
	}
}
