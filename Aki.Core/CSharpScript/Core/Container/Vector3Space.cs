using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000150 RID: 336
	[NullableContext(1)]
	[Nullable(0)]
	public class Vector3Space : IGraphSpace<Vector>
	{
		// Token: 0x06000BAA RID: 2986 RVA: 0x00037959 File Offset: 0x00035B59
		public double DistSquared(Vector a, Vector b)
		{
			return Vector.DistSquared(a, b);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00037964 File Offset: 0x00035B64
		public double DistSquaredPointToSegment(Vector point, Vector segmentStart, Vector segmentEnd)
		{
			double num = segmentEnd.X - segmentStart.X;
			double num2 = segmentEnd.Y - segmentStart.Y;
			double num3 = segmentEnd.Z - segmentStart.Z;
			double num4 = point.X - segmentStart.X;
			double num5 = point.Y - segmentStart.Y;
			double num6 = point.Z - segmentStart.Z;
			double num7 = num * num + num2 * num2 + num3 * num3;
			double num8 = 0.0;
			if (num7 > 0.0)
			{
				num8 = (num4 * num + num5 * num2 + num6 * num3) / num7;
				num8 = Math.Max(0.0, Math.Min(1.0, num8));
			}
			double num9 = num4 - num * num8;
			double num10 = num5 - num2 * num8;
			double num11 = num6 - num3 * num8;
			return num9 * num9 + num10 * num10 + num11 * num11;
		}
	}
}
