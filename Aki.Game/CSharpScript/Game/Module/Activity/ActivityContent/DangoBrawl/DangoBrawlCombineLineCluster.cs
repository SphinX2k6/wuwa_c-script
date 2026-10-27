using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200678F RID: 26511
	[NullableContext(1)]
	[Nullable(0)]
	public struct DangoBrawlCombineLineCluster
	{
		// Token: 0x0402280E RID: 141326
		public DangoBrawlCombineRowData Row;

		// Token: 0x0402280F RID: 141327
		public int MainUid;

		// Token: 0x04022810 RID: 141328
		public int[] MemberUids;

		// Token: 0x04022811 RID: 141329
		[TupleElementNames(new string[]
		{
			"FromUid",
			"ToUid"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public ValueTuple<int, int>[] Edges;

		// Token: 0x04022812 RID: 141330
		public Dictionary<int, FVector2D> UidToLgui;
	}
}
