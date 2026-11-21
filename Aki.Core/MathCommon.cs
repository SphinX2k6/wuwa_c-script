using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000F8 RID: 248
public class MathCommon
{
	// Token: 0x06000860 RID: 2144 RVA: 0x0002CAC6 File Offset: 0x0002ACC6
	private MathCommon()
	{
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x0002CACE File Offset: 0x0002ACCE
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

	// Token: 0x06000862 RID: 2146 RVA: 0x0002CADD File Offset: 0x0002ACDD
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

	// Token: 0x06000863 RID: 2147 RVA: 0x0002CAEC File Offset: 0x0002ACEC
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

	// Token: 0x06000864 RID: 2148 RVA: 0x0002CAFC File Offset: 0x0002ACFC
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

	// Token: 0x06000865 RID: 2149 RVA: 0x0002CB30 File Offset: 0x0002AD30
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

	// Token: 0x06000866 RID: 2150 RVA: 0x0002CB74 File Offset: 0x0002AD74
	public static float FloatSelect(float compared, float valueGeZero, float valueLtZero)
	{
		if (compared < 0f)
		{
			return valueLtZero;
		}
		return valueGeZero;
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x0002CB81 File Offset: 0x0002AD81
	public static double DoubleSelect(double compared, double valueGeZero, double valueLtZero)
	{
		if (compared < 0.0)
		{
			return valueLtZero;
		}
		return valueGeZero;
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x0002CB92 File Offset: 0x0002AD92
	public static float DegreeToRadian(float degVal)
	{
		return 0.017453292f * degVal;
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x0002CB9B File Offset: 0x0002AD9B
	public static double DegreeToRadian(double degVal)
	{
		return 0.01745329238474369 * degVal;
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x0002CBA8 File Offset: 0x0002ADA8
	public static float RadianToDegree(float radVal)
	{
		return 57.29578f * radVal;
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0002CBB1 File Offset: 0x0002ADB1
	public static float Lerp(float from, float to, float alpha)
	{
		return from * (1f - alpha) + to * alpha;
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x0002CBC0 File Offset: 0x0002ADC0
	public static double Lerp(double from, double to, float alpha)
	{
		return from * (double)(1f - alpha) + to * (double)alpha;
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x0002CBD4 File Offset: 0x0002ADD4
	public static float LerpSin(float from, float to, float alpha)
	{
		float num = (float)Math.Sin((double)alpha * 3.141592653589793 / 2.0);
		return from * (1f - num) + to * num;
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x0002CC0C File Offset: 0x0002AE0C
	public static double LerpSin(double from, double to, float alpha)
	{
		double num = Math.Sin((double)alpha * 3.141592653589793 / 2.0);
		return from * (1.0 - num) + to * num;
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x0002CC48 File Offset: 0x0002AE48
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

	// Token: 0x06000870 RID: 2160 RVA: 0x0002CC94 File Offset: 0x0002AE94
	public static float WrapAngle(float angle)
	{
		return (angle % 360f + 360f + 180f) % 360f - 180f;
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0002CCB5 File Offset: 0x0002AEB5
	public static double WrapAngle(double angle)
	{
		return (angle % 360.0 + 360.0 + 180.0) % 360.0 - 180.0;
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x0002CCEC File Offset: 0x0002AEEC
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

	// Token: 0x04000609 RID: 1545
	public const float ThreshPointOnPlane = 0.1f;

	// Token: 0x0400060A RID: 1546
	public const float ThreshVectorNormalized = 0.01f;

	// Token: 0x0400060B RID: 1547
	public const float ThreshPointAreSame = 2E-05f;

	// Token: 0x0400060C RID: 1548
	public const float ThreshNormalsAreParallel = 0.999845f;

	// Token: 0x0400060D RID: 1549
	public const float ThreshNormalsAreOrthogonal = 0.017455f;

	// Token: 0x0400060E RID: 1550
	public const float SmallNumber = 1E-08f;

	// Token: 0x0400060F RID: 1551
	public const float KindaSmallNumber = 0.0001f;

	// Token: 0x04000610 RID: 1552
	public const float BigNumber = 3.4E+38f;

	// Token: 0x04000611 RID: 1553
	public const float Delta = 1E-05f;

	// Token: 0x04000612 RID: 1554
	public const int MaxInt16 = 32767;

	// Token: 0x04000613 RID: 1555
	public const int RightAngle = 90;

	// Token: 0x04000614 RID: 1556
	public const int FlatAngle = 180;

	// Token: 0x04000615 RID: 1557
	public const int RoundAngle = 360;

	// Token: 0x04000616 RID: 1558
	public const int ProgressTotalValue = 100;

	// Token: 0x04000617 RID: 1559
	public const float DegToRad = 0.017453292f;

	// Token: 0x04000618 RID: 1560
	public const float RadDividedBy2 = 0.008726646f;

	// Token: 0x04000619 RID: 1561
	public const float RadToDeg = 57.29578f;

	// Token: 0x0400061A RID: 1562
	public const float MinNormalFloat = 1.1754944E-38f;

	// Token: 0x0400061B RID: 1563
	public const double MinNormalDouble = 2.2250738585072014E-308;

	// Token: 0x0400061C RID: 1564
	public const float MachineEpsilonFloat = 1.1920929E-07f;

	// Token: 0x0400061D RID: 1565
	public const double MachineEpsilonDouble = 2.220446049250313E-16;
}
