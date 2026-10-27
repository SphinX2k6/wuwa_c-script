using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200014F RID: 335
	[NullableContext(1)]
	public interface IGraphSpace<[Nullable(2)] TVec>
	{
		// Token: 0x06000BA8 RID: 2984
		double DistSquared(TVec a, TVec b);

		// Token: 0x06000BA9 RID: 2985
		double DistSquaredPointToSegment(TVec point, TVec segmentStart, TVec segmentEnd);
	}
}
