using System;
using UnrealEngine;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000158 RID: 344
	public class Vector3SpaceDouble : IGraphSpace<FVectorDouble>
	{
		// Token: 0x06000C22 RID: 3106 RVA: 0x00038CF8 File Offset: 0x00036EF8
		public double DistSquared(FVectorDouble a, FVectorDouble b)
		{
			double num = a.X - b.X;
			double num2 = a.Y - b.Y;
			double num3 = a.Z - b.Z;
			return num * num + num2 * num2 + num3 * num3;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00038D38 File Offset: 0x00036F38
		public double DistSquaredPointToSegment(FVectorDouble point, FVectorDouble segmentStart, FVectorDouble segmentEnd)
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
