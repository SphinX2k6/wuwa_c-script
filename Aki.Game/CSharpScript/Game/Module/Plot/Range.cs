using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FA8 RID: 16296
	[NullableContext(1)]
	[Nullable(0)]
	internal class Range
	{
		// Token: 0x060293B0 RID: 168880 RVA: 0x00B93F43 File Offset: 0x00B92143
		public Range(Vector center, double radiusSquare, HashSet<int> ignoreList)
		{
		}

		// Token: 0x04016708 RID: 91912
		public Vector Center = center;

		// Token: 0x04016709 RID: 91913
		public double RadiusSquare = radiusSquare;

		// Token: 0x0401670A RID: 91914
		public HashSet<int> IgnoreList = ignoreList;
	}
}
