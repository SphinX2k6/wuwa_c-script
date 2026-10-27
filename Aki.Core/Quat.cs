using System;
using System.Runtime.CompilerServices;
using Aki.Common.Common;
using UnrealEngine;
using UnrealEngine.Bulitin.Utils;
using UnrealEngine.Extension;

// Token: 0x020000FB RID: 251
[NullableContext(1)]
[Nullable(0)]
public class Quat : IQuat, IClearable, ILogFormattedPrint
{
	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06000836 RID: 2102 RVA: 0x0002C528 File Offset: 0x0002A728
	// (set) Token: 0x06000837 RID: 2103 RVA: 0x0002C530 File Offset: 0x0002A730
	double IQuat.X
	{
		get
		{
			return this.X;
		}
		set
		{
			this.X = value;
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x06000838 RID: 2104 RVA: 0x0002C539 File Offset: 0x0002A739
	// (set) Token: 0x06000839 RID: 2105 RVA: 0x0002C541 File Offset: 0x0002A741
	double IQuat.Y
	{
		get
		{
			return this.Y;
		}
		set
		{
			this.Y = value;
		}
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x0600083A RID: 2106 RVA: 0x0002C54A File Offset: 0x0002A74A
	// (set) Token: 0x0600083B RID: 2107 RVA: 0x0002C552 File Offset: 0x0002A752
	double IQuat.Z
	{
		get
		{
			return this.Z;
		}
		set
		{
			this.Z = value;
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x0600083C RID: 2108 RVA: 0x0002C55B File Offset: 0x0002A75B
	// (set) Token: 0x0600083D RID: 2109 RVA: 0x0002C563 File Offset: 0x0002A763
	double IQuat.W
	{
		get
		{
			return this.W;
		}
		set
		{
			this.W = value;
		}
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x0002C56C File Offset: 0x0002A76C
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 4);
		defaultInterpolatedStringHandler.AppendLiteral("X=");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.X);
		defaultInterpolatedStringHandler.AppendLiteral(", Y=");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.Y);
		defaultInterpolatedStringHandler.AppendLiteral(", Z=");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.Z);
		defaultInterpolatedStringHandler.AppendLiteral(", W=");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.W);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x0002C5EE File Offset: 0x0002A7EE
	public string ToFormattedString()
	{
		return this.ToString();
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x0002C5F8 File Offset: 0x0002A7F8
	public void ToFormattedString(UnsafeStringBuilder sb)
	{
		UnsafeStringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new UnsafeStringBuilder.AppendInterpolatedStringHandler(14, 4, sb);
		appendInterpolatedStringHandler.AppendLiteral("X=");
		appendInterpolatedStringHandler.AppendFormatted<double>(this.X);
		appendInterpolatedStringHandler.AppendLiteral(", Y=");
		appendInterpolatedStringHandler.AppendFormatted<double>(this.Y);
		appendInterpolatedStringHandler.AppendLiteral(", Z=");
		appendInterpolatedStringHandler.AppendFormatted<double>(this.Z);
		appendInterpolatedStringHandler.AppendLiteral(", W=");
		appendInterpolatedStringHandler.AppendFormatted<double>(this.W);
		sb.Append(ref appendInterpolatedStringHandler);
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x0002C67F File Offset: 0x0002A87F
	public void Clear()
	{
		this.Reset();
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x0002C687 File Offset: 0x0002A887
	public FQuat ToUeQuat()
	{
		return new FQuat((float)this.X, (float)this.Y, (float)this.Z, (float)this.W);
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x0002C6AA File Offset: 0x0002A8AA
	public void FromUeQuat(IQuat inQ)
	{
		this.X = inQ.X;
		this.Y = inQ.Y;
		this.Z = inQ.Z;
		this.W = inQ.W;
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x0002C6DC File Offset: 0x0002A8DC
	public void FromUeQuat(Quat inQ)
	{
		this.X = inQ.X;
		this.Y = inQ.Y;
		this.Z = inQ.Z;
		this.W = inQ.W;
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x0002C70E File Offset: 0x0002A90E
	public void FromUeQuat(FQuat inQ)
	{
		this.X = (double)inQ.X;
		this.Y = (double)inQ.Y;
		this.Z = (double)inQ.Z;
		this.W = (double)inQ.W;
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x0002C744 File Offset: 0x0002A944
	public static Quat Create(double x = 0.0, double y = 0.0, double z = 0.0, double w = 1.0)
	{
		return new Quat(x, y, z, w);
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x0002C74F File Offset: 0x0002A94F
	public static Quat Create(IQuat inQ)
	{
		return new Quat(inQ.X, inQ.Y, inQ.Z, inQ.W);
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x0002C76E File Offset: 0x0002A96E
	public static Quat Create(Quat inQ)
	{
		return new Quat(inQ.X, inQ.Y, inQ.Z, inQ.W);
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x0002C78D File Offset: 0x0002A98D
	public static Quat Create(FQuat inQ)
	{
		return new Quat((double)inQ.X, (double)inQ.Y, (double)inQ.Z, (double)inQ.W);
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x0002C7B0 File Offset: 0x0002A9B0
	public Quat()
	{
		this.W = 1.0;
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x0002C7C7 File Offset: 0x0002A9C7
	public Quat(double inX = 0.0, double inY = 0.0, double inZ = 0.0, double inW = 1.0)
	{
		this.X = inX;
		this.Y = inY;
		this.Z = inZ;
		this.W = inW;
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x0002C7EC File Offset: 0x0002A9EC
	public void DeepCopy(Quat inQ)
	{
		this.Set(inQ.X, inQ.Y, inQ.Z, inQ.W);
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x0002C80C File Offset: 0x0002AA0C
	public void DeepCopy(FQuat inQ)
	{
		this.Set((double)inQ.X, (double)inQ.Y, (double)inQ.Z, (double)inQ.W);
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x0002C830 File Offset: 0x0002AA30
	public void Set(double inX, double inY, double inZ, double inW)
	{
		this.X = inX;
		this.Y = inY;
		this.Z = inZ;
		this.W = inW;
		this.ToUeQuat();
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x0002C856 File Offset: 0x0002AA56
	public void Multiply(Quat inQ, Quat outQ)
	{
		Quat.VectorQuaternionMultiply(this, inQ, outQ);
		outQ.Inverse2(outQ);
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x0002C867 File Offset: 0x0002AA67
	public void Multiply(float inQ, Quat outQ)
	{
		outQ.X *= (double)inQ;
		outQ.Y *= (double)inQ;
		outQ.Z *= (double)inQ;
		outQ.W *= (double)inQ;
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x0002C8A8 File Offset: 0x0002AAA8
	private static void FindBetweenHelper(Vector aV, Vector bV, float normAvBv, Quat outQ)
	{
		double num = (double)normAvBv + Vector.DotProduct(aV, bV);
		if (num > 9.999999974752427E-07 * (double)normAvBv)
		{
			outQ.X = aV.Y * bV.Z - aV.Z * bV.Y;
			outQ.Y = aV.Z * bV.X - aV.X * bV.Z;
			outQ.Z = aV.X * bV.Y - aV.Y * bV.X;
			outQ.W = num;
		}
		else
		{
			bool flag = Math.Abs(aV.X) > Math.Abs(aV.Y);
			outQ.X = (flag ? (-aV.Z) : 0.0);
			outQ.Y = (flag ? 0.0 : (-aV.Z));
			outQ.Z = (flag ? aV.X : aV.Y);
			outQ.W = 0.0;
		}
		outQ.Normalize(1E-06f);
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x0002C9BC File Offset: 0x0002ABBC
	private static void SlerpNotNormalized(Quat quat1, Quat quat2, float slerp, Quat outR)
	{
		double num = quat1.X * quat2.X + quat1.Y * quat2.Y + quat1.Z * quat2.Z + quat1.W * quat2.W;
		double num2 = Math.Abs(num);
		double num5;
		double num6;
		if (num2 < 0.9998999834060669)
		{
			double num3 = Math.Acos(num2);
			double num4 = 1.0 / Math.Sin(num3);
			num5 = Math.Sin((double)(1f - slerp) * num3) * num4;
			num6 = Math.Sin((double)slerp * num3) * num4;
		}
		else
		{
			num5 = (double)(1f - slerp);
			num6 = (double)slerp;
		}
		num6 = ((num < 0.0) ? (-num6) : num6);
		outR.X = num5 * quat1.X + num6 * quat2.X;
		outR.Y = num5 * quat1.Y + num6 * quat2.Y;
		outR.Z = num5 * quat1.Z + num6 * quat2.Z;
		outR.W = num5 * quat1.W + num6 * quat2.W;
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x0002CAC7 File Offset: 0x0002ACC7
	public static void Squad(Quat quat1, Quat tang1, Quat quat2, Quat tang2, float alpha, Quat outQ)
	{
		Quat.SlerpNotNormalized(quat1, quat2, alpha, Quat.TmpQuat1);
		Quat.SlerpNotNormalized(tang1, tang2, alpha, Quat.TmpQuat2);
		Quat.Slerp(Quat.TmpQuat1, Quat.TmpQuat2, 2f * alpha * (1f - alpha), outQ);
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x0002CB07 File Offset: 0x0002AD07
	public static void FindBetween(Vector from, Vector to, Quat outQ)
	{
		Quat.FindBetweenVectors(from, to, outQ);
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x0002CB14 File Offset: 0x0002AD14
	public static double AngularDistance(Quat q1, Quat q2)
	{
		double value = q1.X * q2.X + q1.Y * q2.Y + q1.Z * q2.Z + q1.W * q2.W;
		return 2.0 * Math.Acos(Math.Min(Math.Abs(value), 1.0));
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x0002CB7C File Offset: 0x0002AD7C
	public static void FindBetweenVectors(Vector aV, Vector bV, Quat outQ)
	{
		float normAvBv = (float)Math.Sqrt(aV.SizeSquared() * bV.SizeSquared());
		Quat.FindBetweenHelper(aV, bV, normAvBv, outQ);
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x0002CBA6 File Offset: 0x0002ADA6
	public static void Slerp(Quat quat1, Quat quat2, float slerp, Quat outQ)
	{
		Quat.SlerpNotNormalized(quat1, quat2, slerp, outQ);
		outQ.Normalize(1E-06f);
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x0002CBBD File Offset: 0x0002ADBD
	public bool Normalize(float tolerance = 1E-06f)
	{
		this.GetNormalized(this, tolerance);
		return true;
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x0002CBC8 File Offset: 0x0002ADC8
	public void GetNormalized(Quat outQ, float tolerance = 1E-06f)
	{
		double num = this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W;
		if (num >= (double)tolerance)
		{
			double num2 = 1.0 / Math.Sqrt(num);
			outQ.X = this.X * num2;
			outQ.Y = this.Y * num2;
			outQ.Z = this.Z * num2;
			outQ.W = this.W * num2;
			return;
		}
		outQ.Reset();
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x0002CC64 File Offset: 0x0002AE64
	public void Reset()
	{
		this.X = 0.0;
		this.Y = 0.0;
		this.Z = 0.0;
		this.W = 1.0;
		this.ToUeQuat();
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x0002CCB4 File Offset: 0x0002AEB4
	public void RotateVector(Vector inV, Vector outV)
	{
		double num = (this.Y * inV.Z - this.Z * inV.Y) * 2.0;
		double num2 = (this.Z * inV.X - this.X * inV.Z) * 2.0;
		double num3 = (this.X * inV.Y - this.Y * inV.X) * 2.0;
		double num4 = this.Y * num3 - this.Z * num2;
		double num5 = this.Z * num - this.X * num3;
		double num6 = this.X * num2 - this.Y * num;
		outV.X = inV.X + this.W * num + num4;
		outV.Y = inV.Y + this.W * num2 + num5;
		outV.Z = inV.Z + this.W * num3 + num6;
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x0002CDB4 File Offset: 0x0002AFB4
	public void UnRotateVector(Vector inV, Vector outV)
	{
		double num = -this.X;
		double num2 = -this.Y;
		double num3 = -this.Z;
		double num4 = (num2 * inV.Z - num3 * inV.Y) * 2.0;
		double num5 = (num3 * inV.X - num * inV.Z) * 2.0;
		double num6 = (num * inV.Y - num2 * inV.X) * 2.0;
		double num7 = num2 * num6 - num3 * num5;
		double num8 = num3 * num4 - num * num6;
		double num9 = num * num5 - num2 * num4;
		outV.X = inV.X + this.W * num4 + num7;
		outV.Y = inV.Y + this.W * num5 + num8;
		outV.Z = inV.Z + this.W * num6 + num9;
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x0002CE98 File Offset: 0x0002B098
	public Rotator Rotator([Nullable(2)] Rotator outR = null)
	{
		Rotator rotator = outR;
		if (outR == null && (rotator = this.RotatorInternal) == null)
		{
			rotator = (this.RotatorInternal = new Rotator());
		}
		Rotator rotator2 = rotator;
		double num = this.Z * this.X - this.W * this.Y;
		double y = 2.0 * (this.W * this.Z + this.X * this.Y);
		double x = 1.0 - 2.0 * (this.Y * this.Y + this.Z * this.Z);
		if (num < -0.4999994933605194)
		{
			rotator2.Pitch = -90f;
			rotator2.Yaw = (float)Math.Atan2(y, x) * 57.29578f;
			rotator2.Roll = global::Rotator.NormalizeAxis(-rotator2.Yaw - 2f * (float)Math.Atan2(this.X, this.W) * 57.29578f);
		}
		else if (num > 0.4999994933605194)
		{
			rotator2.Pitch = 90f;
			rotator2.Yaw = (float)Math.Atan2(y, x) * 57.29578f;
			rotator2.Roll = global::Rotator.NormalizeAxis(rotator2.Yaw - 2f * (float)Math.Atan2(this.X, this.W) * 57.29578f);
		}
		else
		{
			rotator2.Pitch = (float)Math.Asin(2.0 * num) * 57.29578f;
			rotator2.Yaw = (float)Math.Atan2(y, x) * 57.29578f;
			rotator2.Roll = (float)Math.Atan2(-(this.W * this.X + this.Y * this.Z) * 2.0, 1.0 - 2.0 * (this.Y * this.Y + this.X * this.X)) * 57.29578f;
		}
		return rotator2;
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x0002D091 File Offset: 0x0002B291
	public void Inverse(Quat outQ)
	{
		outQ.X = -this.X;
		outQ.Y = -this.Y;
		outQ.Z = -this.Z;
		outQ.W = this.W;
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x0002D0C6 File Offset: 0x0002B2C6
	public void Inverse2(Quat outQ)
	{
		outQ.X = -this.X;
		outQ.Y = -this.Y;
		outQ.Z = -this.Z;
		outQ.W = -this.W;
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x0002D0FC File Offset: 0x0002B2FC
	public bool IsNearZero(float tolerance = 1E-06f)
	{
		return Math.Abs(this.X) < (double)tolerance && Math.Abs(this.Y) < (double)tolerance && Math.Abs(this.Z) < (double)tolerance && Math.Abs(this.W) < (double)tolerance;
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x0002D13C File Offset: 0x0002B33C
	public Vector GetAxisX(Vector outV)
	{
		this.RotateVector(Vector.ForwardVectorProxy, outV);
		return outV;
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x0002D14B File Offset: 0x0002B34B
	public Vector GetAxisY(Vector outV)
	{
		this.RotateVector(Vector.RightVectorProxy, outV);
		return outV;
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x0002D15A File Offset: 0x0002B35A
	public Vector GetAxisZ(Vector outV)
	{
		this.RotateVector(Vector.UpVectorProxy, outV);
		return outV;
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x0002D169 File Offset: 0x0002B369
	public Vector GetForwardVector(Vector outV)
	{
		return this.GetAxisX(outV);
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x0002D172 File Offset: 0x0002B372
	public Vector GetRightVector(Vector outV)
	{
		return this.GetAxisY(outV);
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x0002D17B File Offset: 0x0002B37B
	public Vector GetUpVector(Vector outV)
	{
		return this.GetAxisZ(outV);
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x0002D184 File Offset: 0x0002B384
	public static void ConstructorByAxisAngle(Vector axis, float angleRad, Quat outQ)
	{
		float num = 0.5f * angleRad;
		double num2 = Math.Sin((double)num);
		double w = Math.Cos((double)num);
		outQ.X = num2 * axis.X;
		outQ.Y = num2 * axis.Y;
		outQ.Z = num2 * axis.Z;
		outQ.W = w;
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x0002D1D8 File Offset: 0x0002B3D8
	public bool Equals(Quat b, float tolerance = 0.0001f)
	{
		return Math.Abs(this.X - b.X) <= (double)tolerance && Math.Abs(this.Y - b.Y) <= (double)tolerance && Math.Abs(this.Z - b.Z) <= (double)tolerance && Math.Abs(this.W - b.W) <= (double)tolerance;
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x0002D244 File Offset: 0x0002B444
	public static void VectorQuaternionMultiply(Quat quat1, Quat quat2, Quat outQ)
	{
		Quat.OriginQuat1.FromUeQuat(quat1);
		Quat.OriginQuat2.FromUeQuat(quat2);
		Quat.TmpQuat1.Reset();
		Quat.TmpQuat2.Reset();
		Quat.TmpQuat3.Reset();
		Quat.VectorReplicate(Quat.OriginQuat1, 3, Quat.TmpQuat1);
		Quat.VectorMultiply(Quat.TmpQuat1, Quat.OriginQuat2, outQ);
		Quat.VectorReplicate(Quat.OriginQuat1, 0, Quat.TmpQuat1);
		Quat.VectorSwizzle(Quat.OriginQuat2, 3, 2, 1, 0, Quat.TmpQuat2);
		Quat.VectorMultiply(Quat.TmpQuat1, Quat.TmpQuat2, Quat.TmpQuat3);
		Quat.VectorMultiplyAdd(Quat.TmpQuat3, Quat.QuatMultiSignMask0, outQ, outQ);
		Quat.VectorReplicate(Quat.OriginQuat1, 1, Quat.TmpQuat1);
		Quat.VectorSwizzle(Quat.OriginQuat2, 2, 3, 0, 1, Quat.TmpQuat2);
		Quat.VectorMultiply(Quat.TmpQuat1, Quat.TmpQuat2, Quat.TmpQuat3);
		Quat.VectorMultiplyAdd(Quat.TmpQuat3, Quat.QuatMultiSignMask1, outQ, outQ);
		Quat.VectorReplicate(Quat.OriginQuat1, 2, Quat.TmpQuat1);
		Quat.VectorSwizzle(Quat.OriginQuat2, 1, 0, 3, 2, Quat.TmpQuat2);
		Quat.VectorMultiply(Quat.TmpQuat1, Quat.TmpQuat2, Quat.TmpQuat3);
		Quat.VectorMultiplyAdd(Quat.TmpQuat3, Quat.QuatMultiSignMask2, outQ, outQ);
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x0002D380 File Offset: 0x0002B580
	private static void VectorMultiply(Quat q1, Quat q2, Quat outQ)
	{
		outQ.X = q1.X * q2.X;
		outQ.Y = q1.Y * q2.Y;
		outQ.Z = q1.Z * q2.Z;
		outQ.W = q1.W * q2.W;
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0002D3DC File Offset: 0x0002B5DC
	private static void VectorMultiplyAdd(Quat q1, Quat q2, Quat q3, Quat outQ)
	{
		outQ.X = q1.X * q2.X + q3.X;
		outQ.Y = q1.Y * q2.Y + q3.Y;
		outQ.Z = q1.Z * q2.Z + q3.Z;
		outQ.W = q1.W * q2.W + q3.W;
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x0002D454 File Offset: 0x0002B654
	private static void VectorReplicate(Quat quat, int index, Quat outQ)
	{
		double num = quat[index];
		outQ.X = num;
		outQ.Y = num;
		outQ.Z = num;
		outQ.W = num;
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x0002D485 File Offset: 0x0002B685
	private static void VectorSwizzle(Quat quat, int x, int y, int z, int w, Quat outQ)
	{
		outQ.X = quat[x];
		outQ.Y = quat[y];
		outQ.Z = quat[z];
		outQ.W = quat[w];
	}

	// Token: 0x170000F1 RID: 241
	public double this[int index]
	{
		get
		{
			double result;
			switch (index)
			{
			case 0:
				result = this.X;
				break;
			case 1:
				result = this.Y;
				break;
			case 2:
				result = this.Z;
				break;
			case 3:
				result = this.W;
				break;
			default:
				throw new IndexOutOfRangeException();
			}
			return result;
		}
	}

	// Token: 0x04000618 RID: 1560
	public const double FindBetweenConst = 9.999999974752427E-07;

	// Token: 0x04000619 RID: 1561
	public const double SlerpConst = 0.9998999834060669;

	// Token: 0x0400061A RID: 1562
	public const double SingularityThreshold = 0.4999994933605194;

	// Token: 0x0400061B RID: 1563
	public double X;

	// Token: 0x0400061C RID: 1564
	public double Y;

	// Token: 0x0400061D RID: 1565
	public double Z;

	// Token: 0x0400061E RID: 1566
	public double W;

	// Token: 0x0400061F RID: 1567
	[StaticVariableRuleIgnore]
	public static readonly FQuat Identity = new FQuat(0f, 0f, 0f, 1f);

	// Token: 0x04000620 RID: 1568
	[StaticVariableRuleIgnore]
	public static readonly Quat IdentityProxy = new Quat(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000621 RID: 1569
	[Nullable(2)]
	private Rotator RotatorInternal;

	// Token: 0x04000622 RID: 1570
	[StaticVariableRuleIgnore]
	private static readonly Quat QuatMultiSignMask0 = new Quat(1.0, -1.0, 1.0, -1.0);

	// Token: 0x04000623 RID: 1571
	[StaticVariableRuleIgnore]
	private static readonly Quat QuatMultiSignMask1 = new Quat(1.0, 1.0, -1.0, -1.0);

	// Token: 0x04000624 RID: 1572
	[StaticVariableRuleIgnore]
	private static readonly Quat QuatMultiSignMask2 = new Quat(-1.0, 1.0, 1.0, -1.0);

	// Token: 0x04000625 RID: 1573
	[StaticVariableRuleIgnore]
	private static readonly Quat OriginQuat1 = new Quat();

	// Token: 0x04000626 RID: 1574
	[StaticVariableRuleIgnore]
	private static readonly Quat OriginQuat2 = new Quat();

	// Token: 0x04000627 RID: 1575
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat1 = new Quat();

	// Token: 0x04000628 RID: 1576
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat2 = new Quat();

	// Token: 0x04000629 RID: 1577
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat3 = new Quat();
}
