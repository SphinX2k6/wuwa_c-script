using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056DF RID: 22239
	[NullableContext(1)]
	[Nullable(0)]
	public struct DangoBrawlCombineLineCluster
	{
		// Token: 0x0401D06B RID: 118891
		public DangoBrawlCombineRowData Row;

		// Token: 0x0401D06C RID: 118892
		public int MainUid;

		// Token: 0x0401D06D RID: 118893
		public int[] MemberUids;

		// Token: 0x0401D06E RID: 118894
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

		// Token: 0x0401D06F RID: 118895
		public Dictionary<int, FVector2D> UidToLgui;
	}
}
