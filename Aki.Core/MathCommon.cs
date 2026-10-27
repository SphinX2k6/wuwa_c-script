using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000F8 RID: 248
public class MathCommon
{
	// Token: 0x0600081A RID: 2074 RVA: 0x0002C2D2 File Offset: 0x0002A4D2
	private MathCommon()
	{
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x0002C2DA File Offset: 0x0002A4DA
	public static float Clamp(float x, float min, float max)
	{
		if (x < min)
		{
			return min;
		}
		if (x >= max)
		{
			return max;
		}
		return x;
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x0002C2E9 File Offset: 0x0002A4E9
	public static int Clamp(int x, int min, int max)
	{
		if (x < min)
		{
			return min;
		}
		if (x >= max)
		{
			return max;
		}
		return x;
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x0002C2F8 File Offset: 0x0002A4F8
	public static double Clamp(double x, double min, double max)
	{
		if (x < min)
		{
			return min;
		}
		if (x >= max)
		{
			return max;
		}
		return x;
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x0002C308 File Offset: 0x0002A508
	public static float UnwindDegrees(float a)
	{
		float num;
		for (num = a; num > 180f; num -= 360f)
		{
		}
		while (num < -180f)
		{
			num += 360f;
		}
		return num;
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x0002C33C File Offset: 0x0002A53C
	public static double UnwindDegrees(double a)
	{
		double num;
		for (num = a; num > 180.0; num -= 360.0)
		{
		}
		while (num < -180.0)
		{
			num += 360.0;
		}
		return num;
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x0002C380 File Offset: 0x0002A580
	public static float FloatSelect(float compared, float valueGeZero, float valueLtZero)
	{
		if (compared < 0f)
		{
			return valueLtZero;
		}
		return valueGeZero;
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x0002C38D File Offset: 0x0002A58D
	public static double DoubleSelect(double compared, double valueGeZero, double valueLtZero)
	{
		if (compared < 0.0)
		{
			return valueLtZero;
		}
		return valueGeZero;
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x0002C39E File Offset: 0x0002A59E
	public static float DegreeToRadian(float degVal)
	{
		return 0.017453292f * degVal;
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x0002C3A7 File Offset: 0x0002A5A7
	public static double DegreeToRadian(double degVal)
	{
		return 0.01745329238474369 * degVal;
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x0002C3B4 File Offset: 0x0002A5B4
	public static float RadianToDegree(float radVal)
	{
		return 57.29578f * radVal;
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x0002C3BD File Offset: 0x0002A5BD
	public static float Lerp(float from, float to, float alpha)
	{
		return from * (1f - alpha) + to * alpha;
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x0002C3CC File Offset: 0x0002A5CC
	public static double Lerp(double from, double to, float alpha)
	{
		return from * (double)(1f - alpha) + to * (double)alpha;
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x0002C3E0 File Offset: 0x0002A5E0
	public static float LerpSin(float from, float to, float alpha)
	{
		float num = (float)Math.Sin((double)alpha * 3.141592653589793 / 2.0);
		return from * (1f - num) + to * num;
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x0002C418 File Offset: 0x0002A618
	public static double LerpSin(double from, double to, float alpha)
	{
		double num = Math.Sin((double)alpha * 3.141592653589793 / 2.0);
		return from * (1.0 - num) + to * num;
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x0002C454 File Offset: 0x0002A654
	[NullableContext(1)]
	public static void VectorNormalizeRotator(IRotator rotator)
	{
		float num = rotator.Pitch;
		float num2 = rotator.Yaw;
		float num3 = rotator.Roll;
		num = MathCommon.WrapAngle(num);
		num2 = MathCommon.WrapAngle(num2);
		num3 = MathCommon.WrapAngle(num3);
		rotator.Pitch = num;
		rotator.Yaw = num2;
		rotator.Roll = num3;
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x0002C4A0 File Offset: 0x0002A6A0
	public static float WrapAngle(float angle)
	{
		return (angle % 360f + 360f + 180f) % 360f - 180f;
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x0002C4C1 File Offset: 0x0002A6C1
	public static double WrapAngle(double angle)
	{
		return (angle % 360.0 + 360.0 + 180.0) % 360.0 - 180.0;
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x0002C4F8 File Offset: 0x0002A6F8
	public static float Warp(float x, float lower, float upper)
	{
		if (upper < lower)
		{
			float num = upper;
			upper = lower;
			lower = num;
		}
		float num2 = upper - lower;
		if (num2 < 1E-08f)
		{
			return lower;
		}
		return (x % num2 + num2 - lower) % num2 + lower;
	}

	// Token: 0x040005FE RID: 1534
	public const float ThreshPointOnPlane = 0.1f;

	// Token: 0x040005FF RID: 1535
	public const float ThreshVectorNormalized = 0.01f;

	// Token: 0x04000600 RID: 1536
	public const float ThreshPointAreSame = 2E-05f;

	// Token: 0x04000601 RID: 1537
	public const float ThreshNormalsAreParallel = 0.999845f;

	// Token: 0x04000602 RID: 1538
	public const float ThreshNormalsAreOrthogonal = 0.017455f;

	// Token: 0x04000603 RID: 1539
	public const float SmallNumber = 1E-08f;

	// Token: 0x04000604 RID: 1540
	public const float KindaSmallNumber = 0.0001f;

	// Token: 0x04000605 RID: 1541
	public const float BigNumber = 3.4E+38f;

	// Token: 0x04000606 RID: 1542
	public const float Delta = 1E-05f;

	// Token: 0x04000607 RID: 1543
	public const int MaxInt16 = 32767;

	// Token: 0x04000608 RID: 1544
	public const int RightAngle = 90;

	// Token: 0x04000609 RID: 1545
	public const int FlatAngle = 180;

	// Token: 0x0400060A RID: 1546
	public const int RoundAngle = 360;

	// Token: 0x0400060B RID: 1547
	public const int ProgressTotalValue = 100;

	// Token: 0x0400060C RID: 1548
	public const float DegToRad = 0.017453292f;

	// Token: 0x0400060D RID: 1549
	public const float RadDividedBy2 = 0.008726646f;

	// Token: 0x0400060E RID: 1550
	public const float RadToDeg = 57.29578f;

	// Token: 0x0400060F RID: 1551
	public const float MinNormalFloat = 1.1754944E-38f;

	// Token: 0x04000610 RID: 1552
	public const double MinNormalDouble = 2.2250738585072014E-308;

	// Token: 0x04000611 RID: 1553
	public const float MachineEpsilonFloat = 1.1920929E-07f;

	// Token: 0x04000612 RID: 1554
	public const double MachineEpsilonDouble = 2.220446049250313E-16;
}
