using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020000F6 RID: 246
[NullableContext(1)]
[Nullable(0)]
public class MathUtils : Singleton
{
	// Token: 0x060007B2 RID: 1970 RVA: 0x00028C28 File Offset: 0x00026E28
	public bool IsNearlyEqual(double a, double b, double? tolerance = null)
	{
		double valueOrDefault = tolerance.GetValueOrDefault(1E-08);
		return Math.Abs(a - b) <= valueOrDefault;
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x00028C54 File Offset: 0x00026E54
	public bool IsNearlyZero(double value, double? tolerance = null)
	{
		double valueOrDefault = tolerance.GetValueOrDefault(1E-08);
		return Math.Abs(value) <= valueOrDefault;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00028C7E File Offset: 0x00026E7E
	public bool IsAngleNearEqual(double a, double b, double tolerance = 9.999999747378752E-05)
	{
		return Math.Abs(this.WrapAngle(a - b)) <= tolerance;
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x00028C94 File Offset: 0x00026E94
	public double Clamp(double currentValue, double min, double max)
	{
		return MathCommon.Clamp(currentValue, min, max);
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00028C9E File Offset: 0x00026E9E
	public float Clamp(float currentValue, float min, float max)
	{
		return MathCommon.Clamp(currentValue, min, max);
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00028CA8 File Offset: 0x00026EA8
	public int Clamp(int currentValue, int min, int max)
	{
		return MathCommon.Clamp(currentValue, min, max);
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00028CB4 File Offset: 0x00026EB4
	public float GetRangePct(float min, float max, float value)
	{
		float num = max - min;
		if (this.IsNearlyZero((double)num, null))
		{
			return value >= max;
		}
		return (value - min) / num;
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00028CE8 File Offset: 0x00026EE8
	public double GetRangePct(double min, double max, double value)
	{
		double num = max - min;
		if (this.IsNearlyZero(num, null))
		{
			return value >= max;
		}
		return (value - min) / num;
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x00028D1C File Offset: 0x00026F1C
	public double RangeClamp(double value, double inRangeA, double inRangeB, double outRangeA, double outRangeB)
	{
		double alpha = this.Clamp(this.GetRangePct(inRangeA, inRangeB, value), 0.0, 1.0);
		return this.Lerp(outRangeA, outRangeB, alpha);
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x00028D58 File Offset: 0x00026F58
	public float RangeClamp(float value, float inRangeA, float inRangeB, float outRangeA, float outRangeB)
	{
		float alpha = this.Clamp(this.GetRangePct(inRangeA, inRangeB, value), 0f, 1f);
		return this.Lerp(outRangeA, outRangeB, alpha);
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x00028D8A File Offset: 0x00026F8A
	public double Lerp(double from, double to, double alpha)
	{
		return from * (1.0 - alpha) + to * alpha;
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x00028D9D File Offset: 0x00026F9D
	public float Lerp(float from, float to, float alpha)
	{
		return from * (1f - alpha) + to * alpha;
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x00028DAC File Offset: 0x00026FAC
	public double InverseLerp(double value, double min, double max)
	{
		double val = (value - min) / (max - min);
		return Math.Max(0.0, Math.Min(1.0, val));
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00028DE0 File Offset: 0x00026FE0
	public double LerpCubic(double p0, double t0, double p1, double t1, double alpha)
	{
		double num = alpha * alpha;
		double num2 = num * alpha;
		return (2.0 * num2 - 3.0 * num + 1.0) * p0 + (num2 - 2.0 * num + alpha) * t0 + (num2 - num) * t1 + (-2.0 * num2 + 3.0 * num) * p1;
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00028E50 File Offset: 0x00027050
	public double LerpSin(double from, double to, double alpha)
	{
		double num = Math.Sin(alpha * 3.141592653589793 / 2.0);
		return from * (1.0 - num) + to * num;
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x00028E8C File Offset: 0x0002708C
	public void LerpVectorOld(FVector from, FVector to, float alpha, ref FVector refVector)
	{
		float alpha2 = this.Clamp(alpha, 0f, 1f);
		refVector.X = this.Lerp(from.X, to.X, alpha2);
		refVector.Y = this.Lerp(from.Y, to.Y, alpha2);
		refVector.Z = this.Lerp(from.Z, to.Z, alpha2);
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00028EFC File Offset: 0x000270FC
	public void LerpVector(FVectorDouble from, FVectorDouble to, float alpha, ref FVectorDouble refVector)
	{
		float num = this.Clamp(alpha, 0f, 1f);
		refVector.X = this.Lerp(from.X, to.X, (double)num);
		refVector.Y = this.Lerp(from.Y, to.Y, (double)num);
		refVector.Z = this.Lerp(from.Z, to.Z, (double)num);
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00028F6C File Offset: 0x0002716C
	public void LerpDirect2dByMaxAngle(global::Vector from, global::Vector to, double zAngleScale, double maxAngle, bool invertYaw, global::Vector @out)
	{
		double angleByVector2D = this.GetAngleByVector2D(from);
		double angleByVector2D2 = this.GetAngleByVector2D(to);
		double num = Math.Asin(from.Z) * 57.295780181884766;
		double num2 = Math.Asin(to.Z) * 57.295780181884766 * zAngleScale;
		double num3;
		for (num3 = angleByVector2D2 - angleByVector2D; num3 > 180.0; num3 -= 360.0)
		{
		}
		while (-num3 > 180.0)
		{
			num3 += 360.0;
		}
		if (invertYaw)
		{
			num3 = ((num3 > 0.0) ? (num3 - 360.0) : (num3 + 360.0));
		}
		double num4 = num2 - num;
		double num5 = Math.Sqrt(num3 * num3 + num4 * num4);
		if (num5 > maxAngle)
		{
			num3 *= maxAngle / num5;
			num4 *= maxAngle / num5;
		}
		double num6 = angleByVector2D + num3;
		double num7 = (num + num4) * 0.01745329238474369;
		@out.Z = Math.Sin(num7);
		double num8 = Math.Cos(num7);
		@out.X = Math.Cos(num6 * 0.01745329238474369) * num8;
		@out.Y = Math.Sin(num6 * 0.01745329238474369) * num8;
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x000290A8 File Offset: 0x000272A8
	public double InterpTo(double from, double to, double deltaTime, double interpSpeed)
	{
		double num = to - from;
		if (Math.Abs(num) < 9.999999747378752E-05)
		{
			return to;
		}
		return from + num * this.Clamp(deltaTime * interpSpeed, 0.0, 1.0);
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x000290EC File Offset: 0x000272EC
	public double InterpConstantTo(double from, double to, double deltaTime, double interpSpeed)
	{
		double num = to - from;
		if (Math.Abs(num) < 9.999999747378752E-05)
		{
			return to;
		}
		double num2 = deltaTime * interpSpeed;
		return from + this.Clamp(num, -num2, num2);
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x00029124 File Offset: 0x00027324
	public float InterpConstantTo(float from, float to, float deltaTime, float interpSpeed)
	{
		float num = to - from;
		if (Math.Abs(num) < 0.0001f)
		{
			return to;
		}
		float num2 = deltaTime * interpSpeed;
		return from + this.Clamp(num, -num2, num2);
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x00029158 File Offset: 0x00027358
	public void VectorInterpTo(global::Vector from, global::Vector to, double deltaTime, double interpSpeed, global::Vector outResult)
	{
		to.Subtraction(from, this.TempVector);
		this.TempVector.MultiplyEqual(this.Clamp(deltaTime * interpSpeed, 0.0, 1.0));
		this.TempVector.Addition(from, outResult);
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x000291AC File Offset: 0x000273AC
	public void RotatorInterpTo(Rotator from, Rotator to, double deltaTime, double interpSpeed, Rotator res)
	{
		if (interpSpeed <= 0.0)
		{
			res.DeepCopy(to);
			return;
		}
		double num = interpSpeed * deltaTime;
		res.Pitch = to.Pitch - from.Pitch;
		res.Yaw = to.Yaw - from.Yaw;
		res.Roll = to.Roll - from.Roll;
		MathCommon.VectorNormalizeRotator(res);
		res.Pitch = (float)((num >= 1.0) ? ((double)res.Pitch) : ((double)res.Pitch * num));
		res.Yaw = (float)((num >= 1.0) ? ((double)res.Yaw) : ((double)res.Yaw * num));
		res.Roll = (float)((num >= 1.0) ? ((double)res.Roll) : ((double)res.Roll * num));
		res.Pitch += from.Pitch;
		res.Yaw += from.Yaw;
		res.Roll += from.Roll;
		MathCommon.VectorNormalizeRotator(res);
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x000292D4 File Offset: 0x000274D4
	public float RotatorAxisInterpTo(float from, float to, float deltaTime, float interpSpeed)
	{
		if (interpSpeed <= 0f)
		{
			return to;
		}
		float num = interpSpeed * deltaTime;
		float num2 = MathCommon.WrapAngle(to - from);
		num2 = ((num >= 1f) ? num2 : (num2 * num));
		num2 += from;
		return MathCommon.WrapAngle(num2);
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x00029314 File Offset: 0x00027514
	public double RotatorAxisInterpTo(double from, double to, double deltaTime, double interpSpeed)
	{
		if (interpSpeed <= 0.0)
		{
			return to;
		}
		double num = interpSpeed * deltaTime;
		double num2 = MathCommon.WrapAngle(to - from);
		num2 = ((num >= 1.0) ? num2 : (num2 * num));
		num2 += from;
		return MathCommon.WrapAngle(num2);
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x0002935C File Offset: 0x0002755C
	[Obsolete("请改用 RotatorInterpConstantTo(FRotator, FRotator, float, float, out FRotator)")]
	public void RotatorInterpConstantTo(Rotator from, Rotator to, float deltaTime, float interpSpeed, Rotator res)
	{
		if (deltaTime <= 0f || interpSpeed <= 0f)
		{
			res.DeepCopy(from);
			return;
		}
		float num = interpSpeed * deltaTime;
		res.Pitch = to.Pitch - from.Pitch;
		res.Yaw = to.Yaw - from.Yaw;
		res.Roll = to.Roll - from.Roll;
		MathCommon.VectorNormalizeRotator(res);
		res.Pitch = this.Clamp(res.Pitch, -num, num);
		res.Yaw = this.Clamp(res.Yaw, -num, num);
		res.Roll = this.Clamp(res.Roll, -num, num);
		res.Pitch += from.Pitch;
		res.Yaw += from.Yaw;
		res.Roll += from.Roll;
		MathCommon.VectorNormalizeRotator(res);
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x00029454 File Offset: 0x00027654
	public void RotatorInterpConstantToAvoid(Rotator from, Rotator to, float avoidYaw, float deltaTime, float interpSpeed, Rotator res)
	{
		if (deltaTime <= 0f || interpSpeed <= 0f)
		{
			res.DeepCopy(from);
			return;
		}
		float num = interpSpeed * deltaTime;
		res.Pitch = to.Pitch - from.Pitch;
		res.Yaw = to.Yaw - from.Yaw;
		res.Roll = to.Roll - from.Roll;
		MathCommon.VectorNormalizeRotator(res);
		res.Pitch = this.Clamp(res.Pitch, -num, num);
		res.Yaw = this.Clamp(res.Yaw, -num, num);
		res.Roll = this.Clamp(res.Roll, -num, num);
		res.Pitch += from.Pitch;
		res.Yaw += from.Yaw;
		res.Roll += from.Roll;
		MathCommon.VectorNormalizeRotator(res);
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x0002954D File Offset: 0x0002774D
	public float GetRandomFloatNumber(float min, float max)
	{
		return (float)((double)min + (double)(max - min) * this.Random.NextDouble());
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x00029563 File Offset: 0x00027763
	public double GetRandomDoubleNumber(double min, double max)
	{
		return min + (max - min) * this.Random.NextDouble();
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00029578 File Offset: 0x00027778
	public FVector GetRandomVector(float min, float max)
	{
		return new FVector
		{
			X = this.GetRandomFloatNumber(min, max),
			Y = this.GetRandomFloatNumber(min, max),
			Z = this.GetRandomFloatNumber(min, max)
		};
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x000295BC File Offset: 0x000277BC
	public FVectorDouble GetRandomVector(double min, double max)
	{
		return new FVectorDouble
		{
			X = this.GetRandomDoubleNumber(min, max),
			Y = this.GetRandomDoubleNumber(min, max),
			Z = this.GetRandomDoubleNumber(min, max)
		};
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00029600 File Offset: 0x00027800
	public FVector2D GetRandomVector2d(float min, float max)
	{
		return new FVector2D
		{
			X = this.GetRandomFloatNumber(min, max),
			Y = this.GetRandomFloatNumber(min, max)
		};
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00029634 File Offset: 0x00027834
	public double GetAngleByVector2D(IVector vector)
	{
		double num = 0.0;
		if (vector is FVector)
		{
			FVector fvector = (FVector)vector;
			this.TempVector.FromUeVector(fvector);
			num = this.TempVector.HeadingAngle();
		}
		else if (vector is FVectorDouble)
		{
			num = ((FVectorDouble)vector).HeadingAngle();
		}
		else
		{
			global::Vector vector2 = vector as global::Vector;
			if (vector2 != null)
			{
				num = vector2.HeadingAngle();
			}
		}
		return num * 57.295780181884766;
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x000296AC File Offset: 0x000278AC
	public FVector GetUeVector2dByAngle(double angle)
	{
		double num = angle * 0.01745329238474369;
		return new FVector((float)Math.Cos(num), (float)Math.Sin(num), 0f);
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x000296E0 File Offset: 0x000278E0
	public void GetVector2dByAngle(double angle, global::Vector refVector)
	{
		double num = angle * 0.01745329238474369;
		refVector.X = Math.Cos(num);
		refVector.Y = Math.Sin(num);
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00029711 File Offset: 0x00027911
	public bool InRange(double value, FloatRange range)
	{
		return value >= (double)range.Min && value <= (double)range.Max;
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x0002972E File Offset: 0x0002792E
	public bool InRangeArray(double value, double[] range)
	{
		return value >= range[0] && value <= range[1];
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00029744 File Offset: 0x00027944
	public bool InRangeAngle(double value, FloatRange range)
	{
		double num = value;
		while (num + 360.0 <= (double)range.Max)
		{
			num += 360.0;
		}
		while (num - 360.0 >= (double)range.Min)
		{
			num -= 360.0;
		}
		return this.InRange(num, range);
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x000297A4 File Offset: 0x000279A4
	public bool InRangeAngleArray(double value, double[] range)
	{
		double num = value;
		while (num + 360.0 <= range[1])
		{
			num += 360.0;
		}
		while (num - 360.0 >= range[0])
		{
			num -= 360.0;
		}
		return this.InRangeArray(num, range);
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x000297F8 File Offset: 0x000279F8
	public bool InUeRange(double value, FFloatRange range)
	{
		if (!((range.LowerBound.Type == ERangeBoundTypes.Exclusive) ? (value > (double)range.LowerBound.Value) : (value >= (double)range.LowerBound.Value)))
		{
			return false;
		}
		if (!(range.UpperBound.Type == ERangeBoundTypes.Exclusive))
		{
			return value <= (double)range.UpperBound.Value;
		}
		return value < (double)range.UpperBound.Value;
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x00029880 File Offset: 0x00027A80
	public bool InFastUeRange(double value, FastUeFloatRange range)
	{
		if (!((range.LowerBoundType == ERangeBoundTypes.Exclusive) ? (value > range.LowerBoundValue) : (value >= range.LowerBoundValue)))
		{
			return false;
		}
		if (range.UpperBoundType != ERangeBoundTypes.Exclusive)
		{
			return value <= range.UpperBoundValue;
		}
		return value < range.UpperBoundValue;
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x000298D0 File Offset: 0x00027AD0
	public bool InUeRangeAngle(double value, FFloatRange range)
	{
		double num = value;
		while (num + 360.0 <= (double)range.UpperBound.Value)
		{
			num += 360.0;
		}
		while (num - 360.0 >= (double)range.LowerBound.Value)
		{
			num -= 360.0;
		}
		return this.InUeRange(num, range);
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x00029938 File Offset: 0x00027B38
	public bool InFastUeRangeAngle(double value, FastUeFloatRange range)
	{
		double num = value;
		while (num + 360.0 <= range.UpperBoundValue)
		{
			num += 360.0;
		}
		while (num - 360.0 >= range.LowerBoundValue)
		{
			num -= 360.0;
		}
		return this.InFastUeRange(num, range);
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00029994 File Offset: 0x00027B94
	[Obsolete("请改用 LocationInRangeArray(FVectorDouble, FRotator, FVectorDouble, ...)")]
	public bool LocationInRangeArray(global::Vector transformLocation, Rotator transformRotator, global::Vector location, double radius, double[] distanceRange, double[] angleRange, double[] heightRange)
	{
		this.InverseTransformPositionNoScale(transformLocation, transformRotator, location, this.TempVector);
		double z = this.TempVector.Z;
		if (!this.InRangeArray(z, heightRange))
		{
			return false;
		}
		double value = this.TempVector.Size2D() - radius;
		if (!this.InRangeArray(value, distanceRange))
		{
			return false;
		}
		double angleByVector2D = this.GetAngleByVector2D(this.TempVector);
		return this.InRangeAngleArray(angleByVector2D, angleRange);
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x000299FC File Offset: 0x00027BFC
	public bool LocationInUeRange(global::Vector transformLocation, Rotator transformRotator, global::Vector location, double radius, FFloatRange distanceRange, FFloatRange angleRange, FFloatRange heightRange)
	{
		this.InverseTransformPositionNoScale(transformLocation, transformRotator, location, this.TempVector);
		double z = this.TempVector.Z;
		if (!this.InUeRange(z, heightRange))
		{
			return false;
		}
		double value = this.TempVector.Size2D() - radius;
		if (!this.InUeRange(value, distanceRange))
		{
			return false;
		}
		double angleByVector2D = this.GetAngleByVector2D(this.TempVector);
		return this.InUeRangeAngle(angleByVector2D, angleRange);
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x00029A64 File Offset: 0x00027C64
	[Obsolete("请改用 LocationInFastUeRange(FVectorDouble, FRotator, FVectorDouble, ...)")]
	public bool LocationInFastUeRange(global::Vector transformLocation, Rotator transformRotator, global::Vector location, double radius, FastUeFloatRange distanceRange, FastUeFloatRange angleRange, FastUeFloatRange heightRange)
	{
		this.InverseTransformPositionNoScale(transformLocation, transformRotator, location, this.TempVector);
		double z = this.TempVector.Z;
		if (!this.InFastUeRange(z, heightRange))
		{
			return false;
		}
		double value = Math.Max(1E-08, this.TempVector.Size2D() - radius);
		if (!this.InFastUeRange(value, distanceRange))
		{
			return false;
		}
		double angleByVector2D = this.GetAngleByVector2D(this.TempVector);
		return this.InFastUeRangeAngle(angleByVector2D, angleRange);
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x00029ADC File Offset: 0x00027CDC
	public float GetFloatPointFloor(float value, int digits = 0)
	{
		float num = (float)Math.Pow(10.0, (double)digits);
		return (float)Math.Floor((double)(value * num)) / num;
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x00029B08 File Offset: 0x00027D08
	public double GetFloatPointFloor(double value, int digits = 0)
	{
		double num = Math.Pow(10.0, (double)digits);
		return Math.Floor(value * num) / num;
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x00029B30 File Offset: 0x00027D30
	public double GetFloatPointCeil(double value, int digits = 0)
	{
		double num = Math.Pow(10.0, (double)digits);
		return Math.Ceiling(value * num) / num;
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x00029B58 File Offset: 0x00027D58
	public double GetRoundToNDecimalPlaces(double value, int n)
	{
		double num = Math.Pow(10.0, (double)n);
		return Math.Round(value * num) / num;
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00029B80 File Offset: 0x00027D80
	public global::Vector RoundVector(global::Vector inVector, int digits)
	{
		return global::Vector.Create(this.GetRoundToNDecimalPlaces(inVector.X, digits), this.GetRoundToNDecimalPlaces(inVector.Y, digits), this.GetRoundToNDecimalPlaces(inVector.Z, digits));
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00029BB0 File Offset: 0x00027DB0
	public string GetFloatPointFloorString(double value, int digits = 0)
	{
		double floatPointFloor = this.GetFloatPointFloor(value, digits);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("F");
		defaultInterpolatedStringHandler.AppendFormatted<int>(digits);
		return floatPointFloor.ToString(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x00029BF1 File Offset: 0x00027DF1
	public double SafeDivide(double a, double b)
	{
		if (b == 0.0)
		{
			return 0.0;
		}
		return a / b;
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x00029C0C File Offset: 0x00027E0C
	[Obsolete("直接强转即可")]
	public long LongToBigInt(int value)
	{
		return (long)value;
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x00029C10 File Offset: 0x00027E10
	[Obsolete("直接使用即可")]
	public long LongToBigInt(long value)
	{
		return value;
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x00029C13 File Offset: 0x00027E13
	[Obsolete("直接使用即可")]
	public long LongToNumber(long value)
	{
		return value;
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x00029C16 File Offset: 0x00027E16
	[Obsolete("直接使用即可")]
	public long NumberToLong(long value)
	{
		return value;
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x00029C19 File Offset: 0x00027E19
	[Obsolete("直接使用即可")]
	public long BigIntToLong(long value)
	{
		return value;
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x00029C1C File Offset: 0x00027E1C
	public Number? StringToNumber(string s)
	{
		if (string.IsNullOrWhiteSpace(s))
		{
			return null;
		}
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		int value;
		if (int.TryParse(s, NumberStyles.Integer, invariantCulture, out value))
		{
			return new Number?(Number.FromInt(value));
		}
		double value2;
		if (double.TryParse(s, NumberStyles.Float, invariantCulture, out value2))
		{
			return new Number?(Number.FromDouble(value2));
		}
		return null;
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x00029C80 File Offset: 0x00027E80
	public double GetRandomRange(double min, double max)
	{
		double num = max - min;
		double num2 = this.Random.NextDouble();
		return min + num2 * num;
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x00029CA4 File Offset: 0x00027EA4
	[NullableContext(2)]
	public T GetRandomItem<T>([Nullable(1)] IReadOnlyList<T> array)
	{
		if (array.Count == 0)
		{
			return default(T);
		}
		int index = (int)Math.Floor(this.Random.NextDouble() * (double)array.Count);
		return array[index];
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x00029CE4 File Offset: 0x00027EE4
	public double BlendEaseIn(double from, double to, float alpha, double exp)
	{
		double num = this.Lerp(0.0, 1.0, Math.Pow((double)alpha, exp));
		return from + (to - from) * num;
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x00029D1A File Offset: 0x00027F1A
	public double StandardizingPitch(double pitch)
	{
		if (pitch > 180.0)
		{
			return pitch - 360.0;
		}
		if (pitch < -180.0)
		{
			return pitch + 360.0;
		}
		return pitch;
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x00029D4D File Offset: 0x00027F4D
	public float WrapAngle(float angle)
	{
		return MathCommon.WrapAngle(angle);
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x00029D55 File Offset: 0x00027F55
	public double WrapAngle(double angle)
	{
		return MathCommon.WrapAngle(angle);
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00029D60 File Offset: 0x00027F60
	[Obsolete("请改用 GetAngleByVectorDot(FVectorDouble, FVectorDouble)")]
	public double GetAngleByVectorDot(IVector inA, IVector inB)
	{
		double num = Math.Sqrt(inA.X * inA.X + inA.Y * inA.Y + inA.Z * inA.Z);
		double num2 = Math.Sqrt(inB.X * inB.X + inB.Y * inB.Y + inB.Z * inB.Z);
		return Math.Acos(MathCommon.Clamp(this.DotProduct(inA, inB) / (num * num2), -1.0, 1.0)) * 57.295780181884766;
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x00029E00 File Offset: 0x00028000
	public double SignedAngleDeg(IVector inA, IVector inB, bool yDown = false)
	{
		double y = inA.X * inB.Y - inA.Y * inB.X;
		double x = inA.X * inB.X + inA.Y * inB.Y;
		double num = Math.Atan2(y, x) * 57.295780181884766;
		if (yDown)
		{
			num = -num;
		}
		return num;
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x00029E5C File Offset: 0x0002805C
	public double SignedAngleOnPlaneDeg(IVector inA, IVector inB, IVector inN)
	{
		double num = Math.Sqrt(inN.X * inN.X + inN.Y * inN.Y + inN.Z * inN.Z);
		if (num < 9.999999747378752E-05)
		{
			return 0.0;
		}
		double num2 = inN.X / num;
		double num3 = inN.Y / num;
		double num4 = inN.Z / num;
		double num5 = inA.X * num2 + inA.Y * num3 + inA.Z * num4;
		double num6 = inB.X * num2 + inB.Y * num3 + inB.Z * num4;
		double num7 = inA.X - num5 * num2;
		double num8 = inA.Y - num5 * num3;
		double num9 = inA.Z - num5 * num4;
		double num10 = inB.X - num6 * num2;
		double num11 = inB.Y - num6 * num3;
		double num12 = inB.Z - num6 * num4;
		double x = num7 * num10 + num8 * num11 + num9 * num12;
		double num13 = num8 * num12 - num9 * num11;
		double num14 = num9 * num10 - num7 * num12;
		double num15 = num7 * num11 - num8 * num10;
		return Math.Atan2(num2 * num13 + num3 * num14 + num4 * num15, x) * 57.295780181884766;
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x00029FA8 File Offset: 0x000281A8
	public double DotProduct(IVector inA, IVector inB)
	{
		return inA.X * inB.X + inA.Y * inB.Y + inA.Z * inB.Z;
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x00029FD4 File Offset: 0x000281D4
	public void ComposeRotator(Rotator a, Rotator b, object @out)
	{
		Quat inQ = a.Quaternion(null);
		Quat quat = b.Quaternion(null);
		Quat quat2 = @out as Quat;
		if (quat2 != null)
		{
			quat.Multiply(inQ, quat2);
			return;
		}
		Rotator rotator = @out as Rotator;
		if (rotator != null)
		{
			quat.Multiply(inQ, this.TmpQuat);
			this.TmpQuat.Rotator(rotator);
		}
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x0002A028 File Offset: 0x00028228
	[Obsolete("请改用 VectorToRotator(FVectorDouble)")]
	public IRotator VectorToRotator(IVector inA, IRotator @out)
	{
		@out.Yaw = (float)(Math.Atan2(inA.Y, inA.X) * 57.295780181884766);
		@out.Pitch = (float)(Math.Atan2(inA.Z, Math.Sqrt(inA.X * inA.X + inA.Y * inA.Y)) * 57.295780181884766);
		@out.Roll = 0f;
		return @out;
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x0002A0A0 File Offset: 0x000282A0
	public IVector RotatorToVector(IRotator inA, IVector @out)
	{
		double degVal = (double)MathCommon.WrapAngle(inA.Pitch);
		double degVal2 = (double)MathCommon.WrapAngle(inA.Yaw);
		double num = MathCommon.DegreeToRadian(degVal);
		double num2 = MathCommon.DegreeToRadian(degVal2);
		double num3 = Math.Cos(num);
		double z = Math.Sin(num);
		double num4 = Math.Cos(num2);
		double num5 = Math.Sin(num2);
		@out.X = num3 * num4;
		@out.Y = num3 * num5;
		@out.Z = z;
		return @out;
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x0002A10C File Offset: 0x0002830C
	public double Bisection(TCheck<double> check, double left, double right, double limit)
	{
		double num = left;
		double num2 = right;
		while (num2 - num > limit)
		{
			double num3 = (num + num2) / 2.0;
			if (check(num3))
			{
				num2 = num3;
			}
			else
			{
				num = num3 + limit;
			}
		}
		return num;
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x0002A147 File Offset: 0x00028347
	public double Square(double v)
	{
		return v * v;
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x0002A14C File Offset: 0x0002834C
	public void TransformPosition(global::Vector translation, Rotator rotation, global::Vector scale3D, global::Vector v, global::Vector @out)
	{
		scale3D.Multiply(v, @out);
		rotation.Quaternion(null).RotateVector(@out, @out);
		translation.Addition(@out, @out);
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x0002A174 File Offset: 0x00028374
	public void TransformPosition(FVectorDouble translation, FRotator rotation, FVectorDouble scale3D, FVectorDouble v, out FVectorDouble @out)
	{
		FQuat fquat = rotation.Quaternion();
		FVectorDouble fvectorDouble = scale3D * v;
		FVector fvector = fvectorDouble;
		FVector fvector2 = fquat.RotateVector(fvector);
		FVectorDouble fvectorDouble2 = new FVectorDouble(ref fvector2);
		@out = fvectorDouble2 + translation;
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x0002A1C0 File Offset: 0x000283C0
	public void LookRotationUpFirst(FVectorDouble forward, FVectorDouble up, out FQuat @out)
	{
		FVector fvector = forward;
		FVector fvector2 = up;
		@out = UKuroAnimMathLibrary.LookQuat_UpFirst(fvector, fvector2);
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x0002A1EC File Offset: 0x000283EC
	public void LookRotationForwardFirst(FVectorDouble forward, FVectorDouble up, out FQuat @out)
	{
		FVector fvector = forward;
		FVector fvector2 = up;
		@out = UKuroAnimMathLibrary.LookQuat_ForwardFirst(fvector, fvector2);
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x0002A218 File Offset: 0x00028418
	public void TransformPositionNoScale(global::Vector translation, Rotator rotation, global::Vector v, global::Vector @out)
	{
		rotation.Quaternion(null).RotateVector(v, @out);
		translation.Addition(@out, @out);
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x0002A234 File Offset: 0x00028434
	public void InverseTransformPosition(global::Vector translation, Rotator rotation, global::Vector scale3D, global::Vector v, global::Vector @out)
	{
		v.Subtraction(translation, @out);
		rotation.Quaternion(this.TmpQuat);
		this.TmpQuat.Inverse(this.TmpQuat);
		this.TmpQuat.RotateVector(@out, @out);
		scale3D.Multiply(@out, @out);
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x0002A284 File Offset: 0x00028484
	public void InverseTransformPosition(FVectorDouble translation, FRotator rotation, FVectorDouble scale3D, FVectorDouble v, out FVectorDouble @out)
	{
		FQuat fquat = rotation.Quaternion().Inverse();
		FVectorDouble fvectorDouble = v - translation;
		FVector fvector = fvectorDouble;
		FVector fvector2 = fquat.RotateVector(fvector);
		FVectorDouble fvectorDouble2 = new FVectorDouble(ref fvector2);
		@out = scale3D * fvectorDouble2;
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x0002A2D6 File Offset: 0x000284D6
	[Obsolete("请改用 InverseTransformPositionNoScale(FVectorDouble, FRotator, FVectorDouble, out FVectorDouble)")]
	public void InverseTransformPositionNoScale(global::Vector translation, Rotator rotation, global::Vector v, global::Vector @out)
	{
		v.Subtraction(translation, @out);
		rotation.Quaternion(this.TmpQuat);
		this.TmpQuat.Inverse(this.TmpQuat);
		this.TmpQuat.RotateVector(@out, @out);
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x0002A310 File Offset: 0x00028510
	private double[][] GetRotArray()
	{
		if (this.RotArray == null)
		{
			int num = 3;
			this.RotArray = new double[num][];
			this.RotArray[0] = new double[num];
			this.RotArray[1] = new double[num];
			this.RotArray[2] = new double[num];
		}
		return this.RotArray;
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x0002A364 File Offset: 0x00028564
	private double[] GetTmpArray()
	{
		if (this.TmpArray == null)
		{
			int num = 3;
			this.TmpArray = new double[num];
		}
		return this.TmpArray;
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x0002A390 File Offset: 0x00028590
	public void LookRotation(global::Vector forward, global::Vector right, global::Vector up, Quat @out)
	{
		double num = forward.X + right.Y + up.Z;
		if (num > 0.0)
		{
			num += 1.0;
			double num2 = 0.5 / Math.Sqrt(num);
			double inW = num2 * num;
			double inX = (right.Z - up.Y) * num2;
			double inY = (up.X - forward.Z) * num2;
			double inZ = (forward.Y - right.X) * num2;
			@out.Set(inX, inY, inZ, inW);
			@out.Normalize(1E-06f);
			return;
		}
		double[][] rotArray = this.GetRotArray();
		rotArray[0][0] = forward.X;
		rotArray[0][1] = right.X;
		rotArray[0][2] = up.X;
		rotArray[1][0] = forward.Y;
		rotArray[1][1] = right.Y;
		rotArray[1][2] = up.Y;
		rotArray[2][0] = forward.Z;
		rotArray[2][1] = right.Z;
		rotArray[2][2] = up.Z;
		double[] tmpArray = this.GetTmpArray();
		int num3 = 0;
		if (right.Y > forward.Y)
		{
			num3 = 1;
		}
		if (up.Z > rotArray[num3][num3])
		{
			num3 = 2;
		}
		int num4 = 3;
		int num5 = (num3 + 1) % num4;
		int num6 = (num5 + 1) % num4;
		num = rotArray[num3][num3] - rotArray[num5][num5] - rotArray[num6][num6] + 1.0;
		double num7 = 0.5 / Math.Sqrt(num);
		tmpArray[num3] = num7 * num;
		double inW2 = (rotArray[num6][num5] - rotArray[num5][num6]) * num7;
		tmpArray[num5] = (rotArray[num5][num3] + rotArray[num3][num5]) * num7;
		tmpArray[num6] = (rotArray[num6][num3] + rotArray[num3][num6]) * num7;
		@out.Set(tmpArray[0], tmpArray[1], tmpArray[2], inW2);
		@out.Normalize(1E-06f);
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x0002A590 File Offset: 0x00028790
	public void LookRotationUpFirst(global::Vector forward, global::Vector up, [Nullable(2)] object @out)
	{
		global::Vector tempVector = this.TempVector;
		tempVector.FromUeVector(up);
		tempVector.Normalize(9.99999993922529E-09);
		global::Vector tempVector2 = this.TempVector2;
		tempVector.CrossProduct(forward, tempVector2);
		tempVector2.Normalize(9.99999993922529E-09);
		global::Vector tempVector3 = this.TempVector3;
		tempVector2.CrossProduct(tempVector, tempVector3);
		Quat quat = @out as Quat;
		if (quat != null)
		{
			this.LookRotation(tempVector3, tempVector2, tempVector, quat);
			return;
		}
		Rotator rotator = @out as Rotator;
		if (rotator != null)
		{
			this.LookRotation(tempVector3, tempVector2, tempVector, this.TmpQuat);
			this.TmpQuat.Rotator(rotator);
		}
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x0002A628 File Offset: 0x00028828
	[Obsolete("请改用 LookRotationForwardFirst(FVectorDouble, FVectorDouble, out FRotator)")]
	public void LookRotationForwardFirst(global::Vector forward, global::Vector up, object @out)
	{
		global::Vector tempVector = this.TempVector;
		tempVector.FromUeVector(forward);
		tempVector.Normalize(9.99999993922529E-09);
		global::Vector tempVector2 = this.TempVector2;
		up.CrossProduct(tempVector, tempVector2);
		tempVector2.Normalize(9.99999993922529E-09);
		global::Vector tempVector3 = this.TempVector3;
		tempVector.CrossProduct(tempVector2, tempVector3);
		Quat quat = @out as Quat;
		if (quat != null)
		{
			this.LookRotation(tempVector, tempVector2, tempVector3, quat);
			return;
		}
		Rotator rotator = @out as Rotator;
		if (rotator != null)
		{
			this.LookRotation(tempVector, tempVector2, tempVector3, this.TmpQuat);
			this.TmpQuat.Rotator(rotator);
		}
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x0002A6BF File Offset: 0x000288BF
	public double GetCubicValue(double t)
	{
		return (-2.0 * t + 3.0) * t * t;
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x0002A6DC File Offset: 0x000288DC
	public string DecimalToBinary(int inDecimal)
	{
		int i = inDecimal;
		string text;
		if (i < 0)
		{
			text = "-";
			i = 0 - i;
		}
		else
		{
			if (i == 0)
			{
				return "0";
			}
			text = "+";
		}
		global::Stack<int> stack = new global::Stack<int>();
		while (i > 0)
		{
			stack.Push((int)Math.Floor((double)(i % 2)));
			i = (int)Math.Floor((double)(i / 2));
		}
		int size = stack.Size;
		for (int j = 0; j < size; j++)
		{
			text += stack.Pop().ToString();
		}
		return text;
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x0002A765 File Offset: 0x00028965
	public double GetObliqueTriangleAngle(double a, double b, double c)
	{
		return Math.Acos((a * a + b * b - c * c) / (2.0 * a * b));
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x0002A788 File Offset: 0x00028988
	public double GetTriangleCircumradius(double a, double b, double c)
	{
		double num = (a + b + c) / 2.0;
		return a * b * c / (4.0 * Math.Sqrt(num * (num - a) * (num - b) * (num - c)));
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x0002A7C7 File Offset: 0x000289C7
	public double VerticalFovToHorizontally(double verticalFov, double aspectRatio)
	{
		return Math.Atan(Math.Tan(verticalFov / 2.0 * 0.01745329238474369) * aspectRatio) * 2.0 * 57.295780181884766;
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x0002A7FE File Offset: 0x000289FE
	public double HorizontalFovToVertically(double horizontalFov, double aspectRatio)
	{
		return Math.Atan(Math.Tan(horizontalFov / 2.0 * 0.01745329238474369) / aspectRatio) * 2.0 * 57.295780181884766;
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x0002A835 File Offset: 0x00028A35
	public bool IsValidNumber(double num)
	{
		return !double.IsNaN(num) && double.IsFinite(num);
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x0002A84C File Offset: 0x00028A4C
	public bool IsValidNumbers(double x, double y, double z, int maxAbs = 100000000)
	{
		return !double.IsNaN(x) && !double.IsNaN(y) && !double.IsNaN(z) && double.IsFinite(x) && double.IsFinite(y) && double.IsFinite(z) && (Math.Abs(x) < (double)maxAbs || Math.Abs(x) == double.MaxValue) && (Math.Abs(y) < (double)maxAbs || Math.Abs(y) == double.MaxValue) && (Math.Abs(z) < (double)maxAbs || Math.Abs(z) == double.MaxValue);
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x0002A8E4 File Offset: 0x00028AE4
	[NullableContext(2)]
	public bool IsValidVector(IVector vector, int maxAbs = 100000000)
	{
		if (vector == null)
		{
			return false;
		}
		double x = vector.X;
		double y = vector.Y;
		double z = vector.Z;
		return !double.IsNaN(x) && !double.IsNaN(y) && !double.IsNaN(z) && double.IsFinite(x) && double.IsFinite(y) && double.IsFinite(z) && (Math.Abs(x) < (double)maxAbs || Math.Abs(x) == double.MaxValue) && (Math.Abs(y) < (double)maxAbs || Math.Abs(y) == double.MaxValue) && (Math.Abs(z) < (double)maxAbs || Math.Abs(z) == double.MaxValue);
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x0002A994 File Offset: 0x00028B94
	[NullableContext(2)]
	public bool IsValidRotator(IRotator rotator, int maxAbs = 100000000)
	{
		if (rotator == null)
		{
			return false;
		}
		double num = (double)rotator.Roll;
		double num2 = (double)rotator.Pitch;
		double num3 = (double)rotator.Yaw;
		return !double.IsNaN(num) && !double.IsNaN(num2) && !double.IsNaN(num3) && double.IsFinite(num) && double.IsFinite(num2) && double.IsFinite(num3) && (Math.Abs(num) < (double)maxAbs || Math.Abs(num) == double.MaxValue) && (Math.Abs(num2) < (double)maxAbs || Math.Abs(num2) == double.MaxValue) && (Math.Abs(num3) < (double)maxAbs || Math.Abs(num3) == double.MaxValue);
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x0002AA48 File Offset: 0x00028C48
	[NullableContext(2)]
	public bool IsValidQuat(IQuat quat, int maxAbs = 100000000)
	{
		if (quat == null)
		{
			return false;
		}
		double x = quat.X;
		double y = quat.Y;
		double z = quat.Z;
		double w = quat.W;
		return !double.IsNaN(x) && !double.IsNaN(y) && !double.IsNaN(z) && !double.IsNaN(w) && double.IsFinite(x) && double.IsFinite(y) && double.IsFinite(z) && double.IsFinite(w) && (Math.Abs(x) < (double)maxAbs || Math.Abs(x) == double.MaxValue) && (Math.Abs(y) < (double)maxAbs || Math.Abs(y) == double.MaxValue) && (Math.Abs(z) < (double)maxAbs || Math.Abs(z) == double.MaxValue) && (Math.Abs(w) < (double)maxAbs || Math.Abs(w) == double.MaxValue);
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x0002AB2C File Offset: 0x00028D2C
	public bool LinePlaneIntersectionOriginNormal(global::Vector lineStart, global::Vector lineEnd, global::Vector planeOrigin, global::Vector planeNormal, global::Vector outIntersection)
	{
		lineEnd.Subtraction(lineStart, this.TempVector);
		global::Vector tempVector = this.TempVector;
		double num = tempVector.DotProduct(planeNormal);
		if (num == 0.0)
		{
			outIntersection.Reset();
			return false;
		}
		planeOrigin.Subtraction(lineStart, this.TempVector2);
		double num2 = this.TempVector2.DotProduct(planeNormal) / num;
		if (num2 < 0.0 || num2 > 1.0)
		{
			outIntersection.Reset();
			return false;
		}
		lineStart.Addition(tempVector.Multiply(num2, this.TempVector3), outIntersection);
		return true;
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x0002ABD8 File Offset: 0x00028DD8
	public bool IsLocationInsideCone(global::Vector coneLocation, global::Vector coneDirection, double coneHeight, double coneRadius, global::Vector point)
	{
		point.Subtraction(coneLocation, this.TempVector);
		double num = this.DotProduct(this.TempVector, coneDirection);
		if (num < 0.0 || num > coneHeight)
		{
			return false;
		}
		double num2 = num / coneHeight * coneRadius;
		coneDirection.Multiply(num, this.TempVector2);
		this.TempVector.Subtraction(this.TempVector2, this.TempVector2);
		return this.TempVector2.SizeSquared() <= num2 * num2;
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x0002AC54 File Offset: 0x00028E54
	public double SegmentToSegmentDistance(global::Vector p1, global::Vector q1, global::Vector p2, global::Vector q2)
	{
		q1.Subtraction(p1, this.SegTempD1);
		q2.Subtraction(p2, this.SegTempD2);
		p1.Subtraction(p2, this.SegTempR);
		double num = this.SegTempD1.SizeSquared();
		double num2 = this.SegTempD2.SizeSquared();
		double num3 = this.DotProduct(this.SegTempD2, this.SegTempR);
		if (num <= 9.999999747378752E-05 && num2 <= 9.999999747378752E-05)
		{
			return global::Vector.Dist(p1, p2);
		}
		double num4;
		double num5;
		if (num <= 9.999999747378752E-05)
		{
			num4 = 0.0;
			num5 = this.Clamp(num3 / num2, 0.0, 1.0);
		}
		else
		{
			double num6 = this.DotProduct(this.SegTempD1, this.SegTempR);
			if (num2 <= 9.999999747378752E-05)
			{
				num5 = 0.0;
				num4 = this.Clamp(-num6 / num, 0.0, 1.0);
			}
			else
			{
				double num7 = this.DotProduct(this.SegTempD1, this.SegTempD2);
				double num8 = num * num2 - num7 * num7;
				if (num8 > 9.999999747378752E-05)
				{
					num4 = this.Clamp((num7 * num3 - num6 * num2) / num8, 0.0, 1.0);
				}
				else
				{
					num4 = 0.0;
				}
				num5 = (num7 * num4 + num3) / num2;
				if (num5 < 0.0)
				{
					num5 = 0.0;
					num4 = this.Clamp(-num6 / num, 0.0, 1.0);
				}
				else if (num5 > 1.0)
				{
					num5 = 1.0;
					num4 = this.Clamp((num7 - num6) / num, 0.0, 1.0);
				}
			}
		}
		this.SegTempD1.Multiply(num4, this.SegTempC1);
		this.SegTempC1.AdditionEqual(p1);
		this.SegTempD2.Multiply(num5, this.SegTempC2);
		this.SegTempC2.AdditionEqual(p2);
		return global::Vector.Dist(this.SegTempC1, this.SegTempC2);
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x0002AE9C File Offset: 0x0002909C
	public void SqInterpToVector(global::Vector from, global::Vector to, float maxAngle, global::Vector @out)
	{
		float num = (float)(Math.Acos(from.DotProduct(to)) * 57.295780181884766);
		if (num < maxAngle)
		{
			@out.DeepCopy(to);
			return;
		}
		Quat.FindBetween(from, to, this.TmpQuat);
		Quat.Slerp(Quat.IdentityProxy, this.TmpQuat, maxAngle / num, this.TmpQuat);
		this.TmpQuat.RotateVector(from, @out);
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x0002AF02 File Offset: 0x00029102
	public void SqLerpVector(global::Vector from, global::Vector to, float alpha, global::Vector @out)
	{
		Quat.FindBetween(from, to, this.TmpQuat);
		Quat.Slerp(Quat.IdentityProxy, this.TmpQuat, alpha, this.TmpQuat);
		this.TmpQuat.RotateVector(from, @out);
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x0002AF38 File Offset: 0x00029138
	public double ClampAngle(double angleDeg, double minAngleDeg, double maxAngleDeg)
	{
		double num = Rotator.ClampAxis(maxAngleDeg - minAngleDeg) * 0.5;
		double num2 = Rotator.ClampAxis(minAngleDeg + num);
		double num3 = Rotator.NormalizeAxis(angleDeg - num2);
		if (num3 > num)
		{
			return Rotator.NormalizeAxis(num2 + num);
		}
		if (num3 < -num)
		{
			return Rotator.NormalizeAxis(num2 - num);
		}
		return Rotator.NormalizeAxis(angleDeg);
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x0002AF8C File Offset: 0x0002918C
	public void CheckNanObject(object obj, ref bool outHasNan, [Nullable(new byte[]
	{
		2,
		1
	})] ref List<string> outPaths, int maxDepth = 100)
	{
		MathUtils.<>c__DisplayClass142_0 CS$<>8__locals1;
		CS$<>8__locals1.maxDepth = maxDepth;
		CS$<>8__locals1.<>4__this = this;
		outHasNan = false;
		outPaths = null;
		if (this.NanCheckCount >= this.MaxCheckTime)
		{
			return;
		}
		this.NanCheckCount++;
		CS$<>8__locals1.visited = new HashSet<object>(ReferenceEqualityComparer.Instance);
		CS$<>8__locals1.hasNan = false;
		CS$<>8__locals1.paths = new List<string>();
		CS$<>8__locals1.currentPath = new List<string>();
		this.<CheckNanObject>g__Traverse|142_0(obj, 0, ref CS$<>8__locals1);
		outHasNan = CS$<>8__locals1.hasNan;
		outPaths = CS$<>8__locals1.paths;
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x0002B018 File Offset: 0x00029218
	public T[] Shuffle<[Nullable(2)] T>(T[] array)
	{
		for (int i = array.Length - 1; i > 0; i--)
		{
			int num = (int)Math.Floor(this.Random.NextDouble() * (double)(i + 1));
			int num2 = i;
			int num3 = num;
			T t = array[num];
			T t2 = array[i];
			array[num2] = t;
			array[num3] = t2;
		}
		return array;
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x0002B07C File Offset: 0x0002927C
	public FBox BoxUnion(FBox a, FVector b)
	{
		if (a.IsValid != 0)
		{
			a.Min = new FVector(Math.Min(a.Min.X, b.X), Math.Min(a.Min.Y, b.Y), Math.Min(a.Min.Z, b.Z));
			a.Max = new FVector(Math.Max(a.Max.X, b.X), Math.Max(a.Max.Y, b.Y), Math.Max(a.Max.Z, b.Z));
		}
		else
		{
			a.Min = b;
			a.Max = b;
			a.IsValid = 1;
		}
		return a;
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x0002B14C File Offset: 0x0002934C
	public FBoxSphereBounds BoxSphereBoundsUnion(FBoxSphereBounds a, FBoxSphereBounds b)
	{
		FBox a2 = new FBox();
		a2 = this.BoxUnion(a2, a.Origin - a.BoxExtent);
		a2 = this.BoxUnion(a2, a.Origin + a.BoxExtent);
		a2 = this.BoxUnion(a2, b.Origin - b.BoxExtent);
		a2 = this.BoxUnion(a2, b.Origin + b.BoxExtent);
		FBoxSphereBounds fboxSphereBounds = new FBoxSphereBounds();
		FVector fvector = a2.Max - a2.Min;
		fboxSphereBounds.BoxExtent = fvector * 0.5f;
		fboxSphereBounds.Origin = a2.Min + fboxSphereBounds.BoxExtent;
		fboxSphereBounds.SphereRadius = fboxSphereBounds.BoxExtent.Size();
		float sphereRadius = fboxSphereBounds.SphereRadius;
		fvector = a.Origin - fboxSphereBounds.Origin;
		float val = fvector.Size() + a.SphereRadius;
		fvector = b.Origin - fboxSphereBounds.Origin;
		fboxSphereBounds.SphereRadius = Math.Min(sphereRadius, Math.Max(val, fvector.Size() + b.SphereRadius));
		return fboxSphereBounds;
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x0002B284 File Offset: 0x00029484
	public bool IsInSideBox(FBox box, FVector point)
	{
		return point.X > box.Min.X && point.X < box.Max.X && point.Y > box.Min.Y && point.Y < box.Max.Y && point.Z > box.Min.Z && point.Z < box.Max.Z;
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x0002B308 File Offset: 0x00029508
	public FBox BoxSphereBoundsGetBox(FBoxSphereBounds bounds)
	{
		FVector fvector = bounds.Origin - bounds.BoxExtent;
		FVector fvector2 = bounds.Origin + bounds.BoxExtent;
		return new FBox(ref fvector, ref fvector2);
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x0002B348 File Offset: 0x00029548
	public bool IsInsideSphere(FVector center, double radius, FVector point, double tolerance = 9.999999747378752E-05)
	{
		return (double)(center - point).SizeSquared() <= Math.Pow(radius + tolerance, 2.0);
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x0002B37E File Offset: 0x0002957E
	public bool IsInsideBoxSphereBounds(FBoxSphereBounds bounds, FVector point)
	{
		return this.IsInsideSphere(bounds.Origin, (double)bounds.SphereRadius, point, 9.999999747378752E-05) && this.IsInSideBox(this.BoxSphereBoundsGetBox(bounds), point);
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x0002B3AF File Offset: 0x000295AF
	public bool IsAngleInRange(double angle, double left, double right)
	{
		if (left <= right)
		{
			return angle >= left && angle <= right;
		}
		return angle >= left || angle <= right;
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x0002B3D0 File Offset: 0x000295D0
	public double NormalizeDeg180(double a)
	{
		double num = a % 360.0;
		if (num > 180.0)
		{
			num -= 360.0;
		}
		else if (num < -180.0)
		{
			num += 360.0;
		}
		return num;
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x0002B41C File Offset: 0x0002961C
	public double VectorDistanceSquared(IVector v1, IVector v2)
	{
		return Math.Pow(v2.X - v1.X, 2.0) + Math.Pow(v2.Y - v1.Y, 2.0) + Math.Pow(v2.Z - v1.Z, 2.0);
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x0002B47C File Offset: 0x0002967C
	public double VectorDistance(IVector v1, IVector v2)
	{
		return Math.Sqrt(this.VectorDistanceSquared(v1, v2));
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x0002B48C File Offset: 0x0002968C
	private global::Vector GetTmpVector()
	{
		global::Vector vector = null;
		if (this.TmpVectorCache.Count > 0)
		{
			vector = this.TmpVectorCache[this.TmpVectorCache.Count - 1];
			this.TmpVectorCache.RemoveAt(this.TmpVectorCache.Count - 1);
			if (vector != null)
			{
				vector.Reset();
			}
		}
		if (vector == null)
		{
			vector = global::Vector.Create();
		}
		return vector;
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x0002B4ED File Offset: 0x000296ED
	private void PutTmpVector(global::Vector tmpVec)
	{
		tmpVec.Reset();
		this.TmpVectorCache.Add(tmpVec);
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x0002B504 File Offset: 0x00029704
	private Rotator GetTmpRotator()
	{
		Rotator rotator = null;
		if (this.TmpRotatorCache.Count > 0)
		{
			rotator = this.TmpRotatorCache[this.TmpRotatorCache.Count - 1];
			this.TmpRotatorCache.RemoveAt(this.TmpRotatorCache.Count - 1);
			if (rotator != null)
			{
				rotator.Reset();
			}
		}
		if (rotator == null)
		{
			rotator = Rotator.Create();
		}
		return rotator;
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x0002B565 File Offset: 0x00029765
	private void PutTmpRotator(Rotator tmpRot)
	{
		tmpRot.Reset();
		this.TmpRotatorCache.Add(tmpRot);
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x0002B57C File Offset: 0x0002977C
	public void ExecWithTmpVectorAndRotator(int vectorNum, int rotatorNum, Action<List<global::Vector>, List<Rotator>> func)
	{
		List<global::Vector> list = new List<global::Vector>();
		List<Rotator> list2 = new List<Rotator>();
		for (int i = 0; i < vectorNum; i++)
		{
			list.Add(this.GetTmpVector());
		}
		for (int j = 0; j < rotatorNum; j++)
		{
			list2.Add(this.GetTmpRotator());
		}
		func(list, list2);
		for (int k = 0; k < vectorNum; k++)
		{
			this.PutTmpVector(list[k]);
		}
		for (int l = 0; l < rotatorNum; l++)
		{
			this.PutTmpRotator(list2[l]);
		}
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x0002B60C File Offset: 0x0002980C
	public Vector2D GetSpiralGrid(int testIndex, int totalN)
	{
		int num = testIndex;
		if (num >= totalN)
		{
			num %= totalN;
		}
		int num2 = (int)Math.Ceiling((Math.Sqrt((double)totalN) + 1.0) / 2.0);
		int i = 0;
		int num3 = 0;
		while (i < num2)
		{
			int num4;
			if (i == 0)
			{
				num4 = 1;
			}
			else
			{
				num4 = 8 * i;
			}
			if (num < num3 + num4)
			{
				break;
			}
			num3 += num4;
			i++;
		}
		int num5 = num - num3;
		int num6 = 0;
		int num7 = 0;
		if (i == 0)
		{
			num6 = 0;
			num7 = 0;
		}
		else
		{
			int num8 = i * 2;
			int num9 = (int)Math.Floor((double)num5 / (double)num8);
			int num10 = num5 % num8;
			if (num9 == 0)
			{
				num6 = -i + num10;
				num7 = -i;
			}
			else if (num9 == 1)
			{
				num6 = i;
				num7 = -i + num10;
			}
			else if (num9 == 2)
			{
				num6 = i - num10;
				num7 = i;
			}
			else if (num9 == 3)
			{
				num6 = -i;
				num7 = i - num10;
			}
		}
		return new Vector2D((double)num6, (double)num7);
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x0002B6EC File Offset: 0x000298EC
	public Vector2D GetSequentialGrid(int testIndex, int totalN = 25, int xMax = 5)
	{
		int num = testIndex % totalN;
		if (num < 0)
		{
			num += totalN;
		}
		return new Vector2D((double)(num % xMax), (double)((int)Math.Floor((double)num / (double)xMax)));
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x0002B71C File Offset: 0x0002991C
	public int[] GenerateUniqueRandomNumbers(int min = 0, int max = 30)
	{
		if (min > max)
		{
			int num = max;
			max = min;
			min = num;
		}
		List<int> list = new List<int>();
		for (int i = min; i <= max; i++)
		{
			list.Add(i);
		}
		for (int j = list.Count - 1; j > 0; j--)
		{
			int num2 = (int)Math.Floor(this.Random.NextDouble() * (double)(j + 1));
			List<int> list2 = list;
			int index = j;
			List<int> list3 = list;
			int index2 = num2;
			int value = list[num2];
			int value2 = list[j];
			list2[index] = value;
			list3[index2] = value2;
		}
		return list.ToArray();
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x0002B7B0 File Offset: 0x000299B0
	public global::Vector GetGravityPointOfPoints(global::Vector[] points)
	{
		if (points.Length == 0)
		{
			return global::Vector.Create(0.0, 0.0, 0.0);
		}
		global::Vector vector = global::Vector.Create(0.0, 0.0, 0.0);
		foreach (global::Vector vector2 in points)
		{
			vector.X += vector2.X;
			vector.Y += vector2.Y;
			vector.Z += vector2.Z;
		}
		vector.X /= (double)points.Length;
		vector.Y /= (double)points.Length;
		vector.Z /= (double)points.Length;
		return vector;
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x0002B884 File Offset: 0x00029A84
	public global::Vector GetCenterOfPoints(global::Vector[] points)
	{
		this.TempVector.DeepCopy(points[0]);
		this.TempVector2.DeepCopy(points[0]);
		global::Vector tempVector = this.TempVector;
		global::Vector tempVector2 = this.TempVector2;
		foreach (global::Vector vector in points)
		{
			tempVector.X = Math.Min(tempVector.X, vector.X);
			tempVector.Y = Math.Min(tempVector.Y, vector.Y);
			tempVector.Z = Math.Min(tempVector.Z, vector.Z);
			tempVector2.X = Math.Max(tempVector2.X, vector.X);
			tempVector2.Y = Math.Max(tempVector2.Y, vector.Y);
			tempVector2.Z = Math.Max(tempVector2.Z, vector.Z);
		}
		return global::Vector.Create((tempVector.X + tempVector2.X) / 2.0, (tempVector.Y + tempVector2.Y) / 2.0, (tempVector.Z + tempVector2.Z) / 2.0);
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x0002B9A8 File Offset: 0x00029BA8
	public global::Vector GetNextPointWithDistance(global::Vector p0, global::Vector p1, double distance)
	{
		global::Vector vector = global::Vector.Create(p0);
		global::Vector tempVector = this.TempVector;
		tempVector.DeepCopy(p1);
		tempVector.SubtractionEqual(vector).Normalize(9.99999993922529E-09);
		return vector.AdditionEqual(tempVector.MultiplyEqual(distance));
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x0002B9ED File Offset: 0x00029BED
	public double ClampedAsin(double d)
	{
		return Math.Asin(MathCommon.Clamp(d, -1.0, 1.0));
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x0002BA0C File Offset: 0x00029C0C
	public double ClampedAcos(double d)
	{
		return Math.Acos(MathCommon.Clamp(d, -1.0, 1.0));
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x0002BA2C File Offset: 0x00029C2C
	public bool LocationInFastUeRange(FVectorDouble transformLocation, FRotator transformRotator, FVectorDouble location, double radius, FastUeFloatRange distanceRange, FastUeFloatRange angleRange, FastUeFloatRange heightRange)
	{
		FQuat fquat = transformRotator.Quaternion().Inverse();
		FVectorDouble fvectorDouble = location - transformLocation;
		FVector fvector = fvectorDouble;
		FVector fvector2 = fquat.RotateVector(fvector);
		double value = (double)fvector2.Z;
		if (!this.InFastUeRange(value, heightRange))
		{
			return false;
		}
		double value2 = Math.Max(1E-08, (double)fvector2.Size2D() - radius);
		if (!this.InFastUeRange(value2, distanceRange))
		{
			return false;
		}
		double angleByVector2D = this.GetAngleByVector2D(fvector2);
		return this.InFastUeRangeAngle(angleByVector2D, angleRange);
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x0002BABC File Offset: 0x00029CBC
	public bool LocationInRangeArray(FVectorDouble transformLocation, FRotator transformRotator, FVectorDouble location, double radius, double[] distanceRange, double[] angleRange, double[] heightRange)
	{
		FQuat fquat = transformRotator.Quaternion().Inverse();
		FVectorDouble fvectorDouble = location - transformLocation;
		FVector fvector = fvectorDouble;
		FVector fvector2 = fquat.RotateVector(fvector);
		double value = (double)fvector2.Z;
		if (!this.InRangeArray(value, heightRange))
		{
			return false;
		}
		double value2 = (double)fvector2.Size2D() - radius;
		if (!this.InRangeArray(value2, distanceRange))
		{
			return false;
		}
		double angleByVector2D = this.GetAngleByVector2D(fvector2);
		return this.InRangeAngleArray(angleByVector2D, angleRange);
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x0002BB40 File Offset: 0x00029D40
	public double GetAngleByVectorDot(FVectorDouble inA, FVectorDouble inB)
	{
		double num = Math.Sqrt(inA.X * inA.X + inA.Y * inA.Y + inA.Z * inA.Z);
		double num2 = Math.Sqrt(inB.X * inB.X + inB.Y * inB.Y + inB.Z * inB.Z);
		return Math.Acos(MathCommon.Clamp((inA.X * inB.X + inA.Y * inB.Y + inA.Z * inB.Z) / (num * num2), -1.0, 1.0)) * 57.295780181884766;
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x0002BC00 File Offset: 0x00029E00
	public FRotator VectorToRotator(FVectorDouble inA)
	{
		return new FRotator((float)(Math.Atan2(inA.Z, Math.Sqrt(inA.X * inA.X + inA.Y * inA.Y)) * 57.295780181884766), (float)(Math.Atan2(inA.Y, inA.X) * 57.295780181884766), 0f);
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x0002BC6C File Offset: 0x00029E6C
	public void InverseTransformPositionNoScale(FVectorDouble translation, FRotator rotation, FVectorDouble v, out FVectorDouble @out)
	{
		FQuat fquat = rotation.Quaternion().Inverse();
		FVectorDouble fvectorDouble = v - translation;
		FVector fvector = fvectorDouble;
		FVector fvector2 = fquat.RotateVector(fvector);
		@out = fvector2;
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x0002BCB4 File Offset: 0x00029EB4
	public void LookRotationForwardFirst(FVectorDouble forward, FVectorDouble up, out FRotator @out)
	{
		FVector fvector = forward;
		FVector fvector2 = up;
		@out = UKuroAnimMathLibrary.LookRotation_ForwardFirst(fvector, fvector2);
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x0002BCE0 File Offset: 0x00029EE0
	public void RotatorInterpConstantTo(FRotator from, FRotator to, float deltaTime, float interpSpeed, out FRotator res)
	{
		if (deltaTime <= 0f || interpSpeed <= 0f)
		{
			res = from;
			return;
		}
		float num = interpSpeed * deltaTime;
		res = MathUtils.WrapRotator(new FRotator(to.Pitch - from.Pitch, to.Yaw - from.Yaw, to.Roll - from.Roll));
		res = new FRotator(this.Clamp(res.Pitch, -num, num) + from.Pitch, this.Clamp(res.Yaw, -num, num) + from.Yaw, this.Clamp(res.Roll, -num, num) + from.Roll);
		res = MathUtils.WrapRotator(res);
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x0002BDA8 File Offset: 0x00029FA8
	private static FRotator WrapRotator(FRotator rotator)
	{
		return new FRotator(MathCommon.WrapAngle(rotator.Pitch), MathCommon.WrapAngle(rotator.Yaw), MathCommon.WrapAngle(rotator.Roll));
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x0600083B RID: 2107 RVA: 0x0002BDD0 File Offset: 0x00029FD0
	public static MathUtils Instance
	{
		get
		{
			if (MathUtils._instance == null)
			{
				MathUtils._instance = new MathUtils();
				MathUtils._instance.OnInit();
			}
			return MathUtils._instance;
		}
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x0002BDF3 File Offset: 0x00029FF3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x0002BDF5 File Offset: 0x00029FF5
	public static void ResetStaticDefaultValue()
	{
		MathUtils instance = MathUtils._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		MathUtils._instance = null;
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x0002BE0E File Offset: 0x0002A00E
	static MathUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MathUtils.CreateStaticDefaultValue), new Action(MathUtils.ResetStaticDefaultValue));
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x0002BF70 File Offset: 0x0002A170
	[NullableContext(2)]
	[CompilerGenerated]
	private void <CheckNanObject>g__Traverse|142_0(object value, int depth, ref MathUtils.<>c__DisplayClass142_0 A_3)
	{
		if (depth >= A_3.maxDepth)
		{
			return;
		}
		if (value == null)
		{
			return;
		}
		if (value is double)
		{
			double num = (double)value;
			if (!this.IsValidNumber(num))
			{
				A_3.hasNan = true;
				A_3.paths.Add(string.Join(".", A_3.currentPath) + ": " + num.ToString());
			}
			return;
		}
		if (value is float)
		{
			float num2 = (float)value;
			if (!this.IsValidNumber((double)num2))
			{
				A_3.hasNan = true;
				A_3.paths.Add(string.Join(".", A_3.currentPath) + ": " + num2.ToString());
			}
			return;
		}
		Type type = value.GetType();
		if (type.IsPrimitive || type.IsEnum || value is string || value is decimal)
		{
			return;
		}
		if (!type.IsValueType && !A_3.visited.Add(value))
		{
			return;
		}
		global::Vector vector = value as global::Vector;
		if (vector != null)
		{
			if (!this.IsValidVector(vector, 999999999))
			{
				A_3.hasNan = true;
				A_3.paths.Add(string.Join(".", A_3.currentPath) + ": " + vector.ToString());
			}
		}
		else
		{
			Rotator rotator = value as Rotator;
			if (rotator != null)
			{
				if (!this.IsValidRotator(rotator, 999999999))
				{
					A_3.hasNan = true;
					A_3.paths.Add(string.Join(".", A_3.currentPath) + ": " + rotator.ToString());
				}
			}
			else
			{
				Quat quat = value as Quat;
				if (quat != null && !this.IsValidQuat(quat, 999999999))
				{
					A_3.hasNan = true;
					A_3.paths.Add(string.Join(".", A_3.currentPath) + ": " + quat.ToString());
				}
			}
		}
		Array array = value as Array;
		if (array != null)
		{
			int[] array2 = new int[array.Rank];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = array.GetLowerBound(i);
			}
			for (int j = 0; j < array.Length; j++)
			{
				A_3.currentPath.Add("[" + string.Join<int>(",", array2) + "]");
				this.<CheckNanObject>g__Traverse|142_0(array.GetValue(array2), depth + 1, ref A_3);
				A_3.currentPath.RemoveAt(A_3.currentPath.Count - 1);
				for (int k = array2.Length - 1; k >= 0; k--)
				{
					if (array2[k] < array.GetUpperBound(k))
					{
						array2[k]++;
						break;
					}
					array2[k] = array.GetLowerBound(k);
				}
			}
			return;
		}
		FieldInfo[] fields;
		if (!this.NanInstanceFieldCache.TryGetValue(type, out fields))
		{
			fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public);
			this.NanInstanceFieldCache.Add(type, fields);
		}
		foreach (FieldInfo fieldInfo in fields)
		{
			A_3.currentPath.Add(fieldInfo.Name);
			this.<CheckNanObject>g__Traverse|142_0(fieldInfo.GetValue(value), depth + 1, ref A_3);
			A_3.currentPath.RemoveAt(A_3.currentPath.Count - 1);
		}
	}

	// Token: 0x040005E0 RID: 1504
	public const int PI_DEG = 180;

	// Token: 0x040005E1 RID: 1505
	public const int PI_DEG_DOUBLE = 360;

	// Token: 0x040005E2 RID: 1506
	public const long intBit = 32L;

	// Token: 0x040005E3 RID: 1507
	public const int INT_BIT = 32;

	// Token: 0x040005E4 RID: 1508
	private const int MAX_INVALID_NUMBER = 999999999;

	// Token: 0x040005E5 RID: 1509
	public const double MaxFloat = 3.402823466E+38;

	// Token: 0x040005E6 RID: 1510
	public const int Int32Max = 2147483647;

	// Token: 0x040005E7 RID: 1511
	public const int Int16Max = 32767;

	// Token: 0x040005E8 RID: 1512
	public const double SmallNumber = 1E-08;

	// Token: 0x040005E9 RID: 1513
	public const double KindaSmallNumber = 0.0001;

	// Token: 0x040005EA RID: 1514
	public const double LargeNumber = 1E+50;

	// Token: 0x040005EB RID: 1515
	public const float MillisecondToSecond = 0.001f;

	// Token: 0x040005EC RID: 1516
	public const int SecondToMillisecond = 1000;

	// Token: 0x040005ED RID: 1517
	public const int CircumradiusRatio = 4;

	// Token: 0x040005EE RID: 1518
	public const float RadToDeg = 57.29578f;

	// Token: 0x040005EF RID: 1519
	public const float DegToRad = 0.017453292f;

	// Token: 0x040005F0 RID: 1520
	public readonly FTransform DefaultTransform = new FTransform();

	// Token: 0x040005F1 RID: 1521
	public readonly FTransformDouble DefaultTransformDouble = new FTransformDouble();

	// Token: 0x040005F2 RID: 1522
	public readonly Transform DefaultTransformProxy = Transform.Create();

	// Token: 0x040005F3 RID: 1523
	public readonly Random Random = new Random();

	// Token: 0x040005F4 RID: 1524
	private readonly global::Vector TempVector = global::Vector.Create();

	// Token: 0x040005F5 RID: 1525
	private readonly global::Vector TempVector2 = global::Vector.Create();

	// Token: 0x040005F6 RID: 1526
	private readonly global::Vector TempVector3 = global::Vector.Create();

	// Token: 0x040005F7 RID: 1527
	public global::Vector CommonTempVector = global::Vector.Create();

	// Token: 0x040005F8 RID: 1528
	public global::Vector CommonTempVector2 = global::Vector.Create();

	// Token: 0x040005F9 RID: 1529
	public Rotator CommonTempRotator = Rotator.Create();

	// Token: 0x040005FA RID: 1530
	public Quat CommonTempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040005FB RID: 1531
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private double[][] RotArray;

	// Token: 0x040005FC RID: 1532
	[Nullable(2)]
	private double[] TmpArray;

	// Token: 0x040005FD RID: 1533
	private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040005FE RID: 1534
	private readonly global::Vector SegTempD1 = global::Vector.Create();

	// Token: 0x040005FF RID: 1535
	private readonly global::Vector SegTempD2 = global::Vector.Create();

	// Token: 0x04000600 RID: 1536
	private readonly global::Vector SegTempR = global::Vector.Create();

	// Token: 0x04000601 RID: 1537
	private readonly global::Vector SegTempC1 = global::Vector.Create();

	// Token: 0x04000602 RID: 1538
	private readonly global::Vector SegTempC2 = global::Vector.Create();

	// Token: 0x04000603 RID: 1539
	public int MaxCheckTime = 1;

	// Token: 0x04000604 RID: 1540
	private int NanCheckCount;

	// Token: 0x04000605 RID: 1541
	private readonly Dictionary<Type, FieldInfo[]> NanInstanceFieldCache = new Dictionary<Type, FieldInfo[]>();

	// Token: 0x04000606 RID: 1542
	private readonly List<global::Vector> TmpVectorCache = new List<global::Vector>();

	// Token: 0x04000607 RID: 1543
	private readonly List<Rotator> TmpRotatorCache = new List<Rotator>();

	// Token: 0x04000608 RID: 1544
	[Nullable(2)]
	private static MathUtils _instance;
}
