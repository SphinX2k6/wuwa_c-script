using System;
using UnrealEngine;

namespace CSharpScript.Core.Extension
{
	// Token: 0x02000135 RID: 309
	public static class FVectorDoubleExtension
	{
		// Token: 0x06000B50 RID: 2896 RVA: 0x0003586C File Offset: 0x00033A6C
		public static FVectorDouble Lerp(this FVectorDouble from, FVectorDouble to, double alpha)
		{
			double scale = (alpha < 0.0) ? 0.0 : ((alpha < 1.0) ? alpha : 1.0);
			FVectorDouble fvectorDouble = to - from;
			FVectorDouble fvectorDouble2 = fvectorDouble * scale;
			return from + fvectorDouble2;
		}
	}
}
