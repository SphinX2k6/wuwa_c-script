using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200590A RID: 22794
	[NullableContext(1)]
	[Nullable(0)]
	public static class SolarSchoolRadarOverlapUtil
	{
		// Token: 0x06038326 RID: 230182 RVA: 0x00FB5E54 File Offset: 0x00FB4054
		public static double CalcProbability(IReadOnlyList<double> myRadii, IReadOnlyList<double> requireRadii)
		{
			double num = SolarSchoolRadarOverlapUtil.PolygonArea(requireRadii);
			if (num <= 9.99999993922529E-09)
			{
				return 0.0;
			}
			return Math.Clamp(SolarSchoolRadarOverlapUtil.IntersectionArea(myRadii, requireRadii) / num, 0.0, 1.0);
		}

		// Token: 0x06038327 RID: 230183 RVA: 0x00FB5EA0 File Offset: 0x00FB40A0
		private static double IntersectionArea(IReadOnlyList<double> radiiA, IReadOnlyList<double> radiiB)
		{
			int count = radiiA.Count;
			if (count < 3 || radiiB.Count != count)
			{
				return 0.0;
			}
			double num = 6.283185307179586 / (double)count;
			double[] array = new double[count];
			double[] array2 = new double[count];
			for (int i = 0; i < count; i++)
			{
				double num2 = (double)i * num;
				array[i] = Math.Cos(num2);
				array2[i] = Math.Sin(num2);
			}
			double num3 = 0.0;
			List<Vector2D> list = new List<Vector2D>(3);
			List<Vector2D> list2 = new List<Vector2D>(3);
			for (int j = 0; j < count; j++)
			{
				int num4 = (j + 1) % count;
				list.Clear();
				list.Add(Vector2D.Create(0.0, 0.0));
				list.Add(Vector2D.Create(array[j] * radiiA[j], array2[j] * radiiA[j]));
				list.Add(Vector2D.Create(array[num4] * radiiA[num4], array2[num4] * radiiA[num4]));
				list2.Clear();
				list2.Add(Vector2D.Create(0.0, 0.0));
				list2.Add(Vector2D.Create(array[j] * radiiB[j], array2[j] * radiiB[j]));
				list2.Add(Vector2D.Create(array[num4] * radiiB[num4], array2[num4] * radiiB[num4]));
				List<Vector2D> poly = SolarSchoolRadarOverlapUtil.ClipConvex(list, list2);
				num3 += SolarSchoolRadarOverlapUtil.ShoelaceAbs(poly);
			}
			return num3;
		}

		// Token: 0x06038328 RID: 230184 RVA: 0x00FB6048 File Offset: 0x00FB4248
		private static double PolygonArea(IReadOnlyList<double> radii)
		{
			int count = radii.Count;
			if (count < 3)
			{
				return 0.0;
			}
			double num = Math.Sin(6.283185307179586 / (double)count);
			double num2 = 0.0;
			for (int i = 0; i < count; i++)
			{
				int index = (i + 1) % count;
				num2 += 0.5 * radii[i] * radii[index] * num;
			}
			return num2;
		}

		// Token: 0x06038329 RID: 230185 RVA: 0x00FB60BC File Offset: 0x00FB42BC
		private static List<Vector2D> ClipConvex(List<Vector2D> subject, List<Vector2D> clip)
		{
			List<Vector2D> list = new List<Vector2D>(subject);
			int count = clip.Count;
			int num = 0;
			while (num < count && list.Count != 0)
			{
				Vector2D a = clip[num];
				Vector2D b = clip[(num + 1) % count];
				List<Vector2D> list2 = list;
				list = new List<Vector2D>(list2.Count + 2);
				Vector2D p = list2[list2.Count - 1];
				bool flag = SolarSchoolRadarOverlapUtil.Inside(a, b, p);
				for (int i = 0; i < list2.Count; i++)
				{
					Vector2D vector2D = list2[i];
					bool flag2 = SolarSchoolRadarOverlapUtil.Inside(a, b, vector2D);
					if (flag2)
					{
						if (!flag)
						{
							list.Add(SolarSchoolRadarOverlapUtil.Intersect(a, b, p, vector2D));
						}
						list.Add(vector2D);
					}
					else if (flag)
					{
						list.Add(SolarSchoolRadarOverlapUtil.Intersect(a, b, p, vector2D));
					}
					p = vector2D;
					flag = flag2;
				}
				num++;
			}
			return list;
		}

		// Token: 0x0603832A RID: 230186 RVA: 0x00FB61A4 File Offset: 0x00FB43A4
		private static bool Inside(Vector2D a, Vector2D b, Vector2D p)
		{
			return (b.X - a.X) * (p.Y - a.Y) - (b.Y - a.Y) * (p.X - a.X) >= -9.99999993922529E-09;
		}

		// Token: 0x0603832B RID: 230187 RVA: 0x00FB61F8 File Offset: 0x00FB43F8
		private static Vector2D Intersect(Vector2D a, Vector2D b, Vector2D p, Vector2D q)
		{
			double num = b.Y - a.Y;
			double num2 = a.X - b.X;
			double num3 = num * a.X + num2 * a.Y;
			double num4 = q.Y - p.Y;
			double num5 = p.X - q.X;
			double num6 = num4 * p.X + num5 * p.Y;
			double num7 = num * num5 - num4 * num2;
			if (Math.Abs(num7) < 9.99999993922529E-09)
			{
				return Vector2D.Create(q.X, q.Y);
			}
			return Vector2D.Create((num5 * num3 - num2 * num6) / num7, (num * num6 - num4 * num3) / num7);
		}

		// Token: 0x0603832C RID: 230188 RVA: 0x00FB62B0 File Offset: 0x00FB44B0
		private static double ShoelaceAbs(List<Vector2D> poly)
		{
			if (poly.Count < 3)
			{
				return 0.0;
			}
			double num = 0.0;
			for (int i = 0; i < poly.Count; i++)
			{
				Vector2D vector2D = poly[i];
				Vector2D vector2D2 = poly[(i + 1) % poly.Count];
				num += vector2D.X * vector2D2.Y - vector2D2.X * vector2D.Y;
			}
			return Math.Abs(num) * 0.5;
		}

		// Token: 0x0603832D RID: 230189 RVA: 0x00FB6334 File Offset: 0x00FB4534
		[return: TupleElementNames(new string[]
		{
			"Theta",
			"Dist"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public static List<ValueTuple<double, double>> SamplePoints(IReadOnlyList<float> radiiA, IReadOnlyList<float> radiiB, ERadarSampleRegion region, int count, double margin, double minGap, Random rng, double startAngleRad, [TupleElementNames(new string[]
		{
			"Theta",
			"Dist"
		})] [Nullable(new byte[]
		{
			2,
			0
		})] IReadOnlyList<ValueTuple<double, double>> avoid = null)
		{
			List<ValueTuple<double, double>> list = new List<ValueTuple<double, double>>(count);
			int count2 = radiiA.Count;
			if (count2 < 3 || radiiB.Count != count2 || count <= 0)
			{
				return list;
			}
			double sector = 6.283185307179586 / (double)count2;
			double num = 0.03490658503988659;
			double[] array = new double[180];
			double[] array2 = new double[180];
			double[] array3 = new double[180];
			double num2 = 0.0;
			for (int i = 0; i < 180; i++)
			{
				double ang = ((double)i + 0.5) * num;
				double num3 = SolarSchoolRadarOverlapUtil.RadialMax(radiiA, ang, sector);
				double num4 = SolarSchoolRadarOverlapUtil.RadialMax(radiiB, ang, sector);
				double num5;
				double num6;
				if (region != ERadarSampleRegion.AOnly)
				{
					if (region != ERadarSampleRegion.Overlap)
					{
						num5 = margin;
						num6 = num3 - margin;
					}
					else
					{
						num5 = margin;
						num6 = Math.Min(num3, num4) - margin;
					}
				}
				else
				{
					num5 = num4 + margin;
					num6 = num3 - margin;
				}
				array[i] = num5;
				array2[i] = num6;
				num2 += ((num6 > num5) ? (num6 * num6 - num5 * num5) : 0.0);
				array3[i] = num2;
			}
			if (num2 <= 9.99999993922529E-09)
			{
				return list;
			}
			for (int j = 0; j < count; j++)
			{
				ValueTuple<double, double> item = default(ValueTuple<double, double>);
				double num7 = -1.0;
				for (int k = 0; k < 30; k++)
				{
					int num8 = SolarSchoolRadarOverlapUtil.PickSlice(array3, num2, rng);
					double num9 = (double)num8 * num + rng.NextDouble() * num;
					double num10 = array[num8] * array[num8];
					double item2 = Math.Sqrt(num10 + rng.NextDouble() * (array2[num8] * array2[num8] - num10));
					ValueTuple<double, double> valueTuple = new ValueTuple<double, double>(startAngleRad + num9, item2);
					double num11 = Math.Min(SolarSchoolRadarOverlapUtil.NearestDist(list, valueTuple), SolarSchoolRadarOverlapUtil.NearestDist(avoid, valueTuple));
					if (num11 >= minGap)
					{
						item = valueTuple;
						break;
					}
					if (num11 > num7)
					{
						item = valueTuple;
						num7 = num11;
					}
				}
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0603832E RID: 230190 RVA: 0x00FB653C File Offset: 0x00FB473C
		public static double GetRadialBoundary(IReadOnlyList<float> radii, double theta, double startAngleRad)
		{
			int count = radii.Count;
			if (count < 3)
			{
				return 0.0;
			}
			double sector = 6.283185307179586 / (double)count;
			double num = (theta - startAngleRad) % 6.283185307179586;
			if (num < 0.0)
			{
				num += 6.283185307179586;
			}
			return SolarSchoolRadarOverlapUtil.RadialMax(radii, num, sector);
		}

		// Token: 0x0603832F RID: 230191 RVA: 0x00FB659C File Offset: 0x00FB479C
		private static double RadialMax(IReadOnlyList<float> radii, double ang, double sector)
		{
			int count = radii.Count;
			int num = (int)(ang / sector) % count;
			int num2 = (num + 1) % count;
			double num3 = Math.Cos(ang);
			double num4 = Math.Sin(ang);
			double num5 = (double)num * sector;
			double num6 = (double)num2 * sector;
			double num7 = Math.Cos(num5) * (double)radii[num];
			double num8 = Math.Sin(num5) * (double)radii[num];
			double num9 = Math.Cos(num6) * (double)radii[num2];
			double num10 = Math.Sin(num6) * (double)radii[num2];
			double num11 = num9 - num7;
			double num12 = num10 - num8;
			double num13 = num3 * num12 - num4 * num11;
			if (Math.Abs(num13) < 9.99999993922529E-09)
			{
				double num14 = (ang - num5) / sector;
				return (double)radii[num] + (double)(radii[num2] - radii[num]) * num14;
			}
			return Math.Max((num7 * num12 - num8 * num11) / num13, 0.0);
		}

		// Token: 0x06038330 RID: 230192 RVA: 0x00FB6680 File Offset: 0x00FB4880
		private static int PickSlice(double[] cum, double total, Random rng)
		{
			double num = rng.NextDouble() * total;
			int i = 0;
			int num2 = cum.Length - 1;
			while (i < num2)
			{
				int num3 = i + num2 >> 1;
				if (cum[num3] < num)
				{
					i = num3 + 1;
				}
				else
				{
					num2 = num3;
				}
			}
			return i;
		}

		// Token: 0x06038331 RID: 230193 RVA: 0x00FB66BC File Offset: 0x00FB48BC
		[NullableContext(0)]
		private static double NearestDist([TupleElementNames(new string[]
		{
			"Theta",
			"Dist"
		})] [Nullable(new byte[]
		{
			2,
			0
		})] IReadOnlyList<ValueTuple<double, double>> pts, [TupleElementNames(new string[]
		{
			"Theta",
			"Dist"
		})] ValueTuple<double, double> p)
		{
			if (pts == null || pts.Count == 0)
			{
				return double.MaxValue;
			}
			double num = Math.Cos(p.Item1) * p.Item2;
			double num2 = Math.Sin(p.Item1) * p.Item2;
			double num3 = double.MaxValue;
			foreach (ValueTuple<double, double> valueTuple in pts)
			{
				double num4 = Math.Cos(valueTuple.Item1) * valueTuple.Item2 - num;
				double num5 = Math.Sin(valueTuple.Item1) * valueTuple.Item2 - num2;
				num3 = Math.Min(num3, num4 * num4 + num5 * num5);
			}
			return Math.Sqrt(num3);
		}

		// Token: 0x0401D966 RID: 121190
		private const int SliceCount = 180;

		// Token: 0x0401D967 RID: 121191
		private const int MaxRetry = 30;

		// Token: 0x0401D968 RID: 121192
		public const double MarginPath = 0.06;

		// Token: 0x0401D969 RID: 121193
		public const double MarginEnd = 0.1;

		// Token: 0x0401D96A RID: 121194
		public const double MinGap = 0.22;
	}
}
