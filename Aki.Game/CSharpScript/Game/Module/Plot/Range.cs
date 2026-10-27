using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FDE RID: 20446
	[NullableContext(1)]
	[Nullable(0)]
	internal class Range
	{
		// Token: 0x06034527 RID: 214311 RVA: 0x00C49EFB File Offset: 0x00C480FB
		public Range(Vector center, double radiusSquare, HashSet<int> ignoreList)
		{
		}

		// Token: 0x0401BD2D RID: 113965
		public Vector Center = center;

		// Token: 0x0401BD2E RID: 113966
		public double RadiusSquare = radiusSquare;

		// Token: 0x0401BD2F RID: 113967
		public HashSet<int> IgnoreList = ignoreList;
	}
}
