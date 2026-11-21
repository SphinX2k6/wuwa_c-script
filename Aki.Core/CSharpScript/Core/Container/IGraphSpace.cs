using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000153 RID: 339
	[NullableContext(1)]
	public interface IGraphSpace<[Nullable(2)] TVec>
	{
		// Token: 0x06000C04 RID: 3076
		double DistSquared(TVec a, TVec b);

		// Token: 0x06000C05 RID: 3077
		double DistSquaredPointToSegment(TVec point, TVec segmentStart, TVec segmentEnd);
	}
}
