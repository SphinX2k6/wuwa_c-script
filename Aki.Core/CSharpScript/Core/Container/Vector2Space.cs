using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000151 RID: 337
	[NullableContext(1)]
	[Nullable(0)]
	public class Vector2Space : IGraphSpace<Vector2D>
	{
		// Token: 0x06000BAD RID: 2989 RVA: 0x00037A4C File Offset: 0x00035C4C
		public double DistSquared(Vector2D a, Vector2D b)
		{
			return Vector2D.DistSquared(a, b);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00037A58 File Offset: 0x00035C58
		public double DistSquaredPointToSegment(Vector2D point, Vector2D segmentStart, Vector2D segmentEnd)
		{
			double num = segmentEnd.X - segmentStart.X;
			double num2 = segmentEnd.Y - segmentStart.Y;
			double num3 = point.X - segmentStart.X;
			double num4 = point.Y - segmentStart.Y;
			double num5 = num * num + num2 * num2;
			double num6 = 0.0;
			if (num5 > 0.0)
			{
				num6 = (num3 * num + num4 * num2) / num5;
				num6 = Math.Max(0.0, Math.Min(1.0, num6));
			}
			double num7 = num3 - num * num6;
			double num8 = num4 - num2 * num6;
			return num7 * num7 + num8 * num8;
		}
	}
}
