using System;
using System.Runtime.CompilerServices;
using Aki.Common.Common;
using UnrealEngine;
using UnrealEngine.Bulitin.Utils;
using UnrealEngine.Extension;

// Token: 0x020000FB RID: 251
[NullableContext(1)]
[Nullable(0)]
[Obsolete("手写数学库已废弃，请改用 UnrealEngine.FQuat")]
public class Quat : IQuat, IClearable, ILogFormattedPrint
{
	// Token: 0x0600087C RID: 2172 RVA: 0x0002CD1C File Offset: 0x0002AF1C
	[Obsolete("迁移期隐式转换：请确认不在每帧热点路径上")]
	public static implicit operator FQuat(Quat v)
	{
		if (v != null)
		{
			return new FQuat((float)v.X, (float)v.Y, (float)v.Z, (float)v.W);
		}
		return FQuat.Identity;
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x0002CD48 File Offset: 0x0002AF48
	[Obsolete("迁移期隐式转换：请确认不在每帧热点路径上")]
	public static implicit operator Quat(FQuat v)
	{
		return Quat.Create((double)v.X, (double)v.Y, (double)v.Z, (double)v.W);
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x0600087E RID: 2174 RVA: 0x0002CD6B File Offset: 0x0002AF6B
	// (set) Token: 0x0600087F RID: 2175 RVA: 0x0002CD73 File Offset: 0x0002AF73
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

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000880 RID: 2176 RVA: 0x0002CD7C File Offset: 0x0002AF7C
	// (set) Token: 0x06000881 RID: 2177 RVA: 0x0002CD84 File Offset: 0x0002AF84
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

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06000882 RID: 2178 RVA: 0x0002CD8D File Offset: 0x0002AF8D
	// (set) Token: 0x06000883 RID: 2179 RVA: 0x0002CD95 File Offset: 0x0002AF95
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

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000884 RID: 2180 RVA: 0x0002CD9E File Offset: 0x0002AF9E
	// (set) Token: 0x06000885 RID: 2181 RVA: 0x0002CDA6 File Offset: 0x0002AFA6
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

	// Token: 0x06000886 RID: 2182 RVA: 0x0002CDB0 File Offset: 0x0002AFB0
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

	// Token: 0x06000887 RID: 2183 RVA: 0x0002CE32 File Offset: 0x0002B032
	public string ToFormattedString()
	{
		return this.ToString();
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x0002CE3C File Offset: 0x0002B03C
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

	// Token: 0x06000889 RID: 2185 RVA: 0x0002CEC3 File Offset: 0x0002B0C3
	public void Clear()
	{
		this.Reset();
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x0002CECB File Offset: 0x0002B0CB
	public FQuat ToUeQuat()
	{
		return new FQuat((float)this.X, (float)this.Y, (float)this.Z, (float)this.W);
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x0002CEEE File Offset: 0x0002B0EE
	public void FromUeQuat(IQuat inQ)
	{
		this.X = inQ.X;
		this.Y = inQ.Y;
		this.Z = inQ.Z;
		this.W = inQ.W;
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x0002CF20 File Offset: 0x0002B120
	public void FromUeQuat(Quat inQ)
	{
		this.X = inQ.X;
		this.Y = inQ.Y;
		this.Z = inQ.Z;
		this.W = inQ.W;
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x0002CF52 File Offset: 0x0002B152
	public void FromUeQuat(FQuat inQ)
	{
		this.X = (double)inQ.X;
		this.Y = (double)inQ.Y;
		this.Z = (double)inQ.Z;
		this.W = (double)inQ.W;
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x0002CF88 File Offset: 0x0002B188
	public static Quat Create(double x = 0.0, double y = 0.0, double z = 0.0, double w = 1.0)
	{
		return new Quat(x, y, z, w);
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x0002CF93 File Offset: 0x0002B193
	public static Quat Create(IQuat inQ)
	{
		return new Quat(inQ.X, inQ.Y, inQ.Z, inQ.W);
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x0002CFB2 File Offset: 0x0002B1B2
	public static Quat Create(Quat inQ)
	{
		return new Quat(inQ.X, inQ.Y, inQ.Z, inQ.W);
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x0002CFD1 File Offset: 0x0002B1D1
	public static Quat Create(FQuat inQ)
	{
		return new Quat((double)inQ.X, (double)inQ.Y, (double)inQ.Z, (double)inQ.W);
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x0002CFF4 File Offset: 0x0002B1F4
	public Quat()
	{
		this.W = 1.0;
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x0002D00B File Offset: 0x0002B20B
	public Quat(double inX = 0.0, double inY = 0.0, double inZ = 0.0, double inW = 1.0)
	{
		this.X = inX;
		this.Y = inY;
		this.Z = inZ;
		this.W = inW;
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x0002D030 File Offset: 0x0002B230
	public void DeepCopy(Quat inQ)
	{
		this.Set(inQ.X, inQ.Y, inQ.Z, inQ.W);
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x0002D050 File Offset: 0x0002B250
	public void DeepCopy(FQuat inQ)
	{
		this.Set((double)inQ.X, (double)inQ.Y, (double)inQ.Z, (double)inQ.W);
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x0002D074 File Offset: 0x0002B274
	public void Set(double inX, double inY, double inZ, double inW)
	{
		this.X = inX;
		this.Y = inY;
		this.Z = inZ;
		this.W = inW;
		this.ToUeQuat();
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x0002D09A File Offset: 0x0002B29A
	public void Multiply(Quat inQ, Quat outQ)
	{
		Quat.VectorQuaternionMultiply(this, inQ, outQ);
		outQ.Inverse2(outQ);
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x0002D0AB File Offset: 0x0002B2AB
	public void Multiply(float inQ, Quat outQ)
	{
		outQ.X *= (double)inQ;
		outQ.Y *= (double)inQ;
		outQ.Z *= (double)inQ;
		outQ.W *= (double)inQ;
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x0002D0EC File Offset: 0x0002B2EC
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

	// Token: 0x0600089A RID: 2202 RVA: 0x0002D200 File Offset: 0x0002B400
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

	// Token: 0x0600089B RID: 2203 RVA: 0x0002D30B File Offset: 0x0002B50B
	public static void Squad(Quat quat1, Quat tang1, Quat quat2, Quat tang2, float alpha, Quat outQ)
	{
		Quat.SlerpNotNormalized(quat1, quat2, alpha, Quat.TmpQuat1);
		Quat.SlerpNotNormalized(tang1, tang2, alpha, Quat.TmpQuat2);
		Quat.Slerp(Quat.TmpQuat1, Quat.TmpQuat2, 2f * alpha * (1f - alpha), outQ);
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x0002D34B File Offset: 0x0002B54B
	public static void FindBetween(Vector from, Vector to, Quat outQ)
	{
		Quat.FindBetweenVectors(from, to, outQ);
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x0002D358 File Offset: 0x0002B558
	public static double AngularDistance(Quat q1, Quat q2)
	{
		double value = q1.X * q2.X + q1.Y * q2.Y + q1.Z * q2.Z + q1.W * q2.W;
		return 2.0 * Math.Acos(Math.Min(Math.Abs(value), 1.0));
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x0002D3C0 File Offset: 0x0002B5C0
	public static void FindBetweenVectors(Vector aV, Vector bV, Quat outQ)
	{
		float normAvBv = (float)Math.Sqrt(aV.SizeSquared() * bV.SizeSquared());
		Quat.FindBetweenHelper(aV, bV, normAvBv, outQ);
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x0002D3EA File Offset: 0x0002B5EA
	public static void Slerp(Quat quat1, Quat quat2, float slerp, Quat outQ)
	{
		Quat.SlerpNotNormalized(quat1, quat2, slerp, outQ);
		outQ.Normalize(1E-06f);
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x0002D401 File Offset: 0x0002B601
	public bool Normalize(float tolerance = 1E-06f)
	{
		this.GetNormalized(this, tolerance);
		return true;
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x0002D40C File Offset: 0x0002B60C
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

	// Token: 0x060008A2 RID: 2210 RVA: 0x0002D4A8 File Offset: 0x0002B6A8
	public void Reset()
	{
		this.X = 0.0;
		this.Y = 0.0;
		this.Z = 0.0;
		this.W = 1.0;
		this.ToUeQuat();
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
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

	// Token: 0x060008A4 RID: 2212 RVA: 0x0002D5F8 File Offset: 0x0002B7F8
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

	// Token: 0x060008A5 RID: 2213 RVA: 0x0002D6DC File Offset: 0x0002B8DC
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

	// Token: 0x060008A6 RID: 2214 RVA: 0x0002D8D5 File Offset: 0x0002BAD5
	public void Inverse(Quat outQ)
	{
		outQ.X = -this.X;
		outQ.Y = -this.Y;
		outQ.Z = -this.Z;
		outQ.W = this.W;
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x0002D90A File Offset: 0x0002BB0A
	public void Inverse2(Quat outQ)
	{
		outQ.X = -this.X;
		outQ.Y = -this.Y;
		outQ.Z = -this.Z;
		outQ.W = -this.W;
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x0002D940 File Offset: 0x0002BB40
	public bool IsNearZero(float tolerance = 1E-06f)
	{
		return Math.Abs(this.X) < (double)tolerance && Math.Abs(this.Y) < (double)tolerance && Math.Abs(this.Z) < (double)tolerance && Math.Abs(this.W) < (double)tolerance;
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x0002D980 File Offset: 0x0002BB80
	public Vector GetAxisX(Vector outV)
	{
		this.RotateVector(Vector.ForwardVectorProxy, outV);
		return outV;
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x0002D98F File Offset: 0x0002BB8F
	public Vector GetAxisY(Vector outV)
	{
		this.RotateVector(Vector.RightVectorProxy, outV);
		return outV;
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x0002D99E File Offset: 0x0002BB9E
	public Vector GetAxisZ(Vector outV)
	{
		this.RotateVector(Vector.UpVectorProxy, outV);
		return outV;
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x0002D9AD File Offset: 0x0002BBAD
	public Vector GetForwardVector(Vector outV)
	{
		return this.GetAxisX(outV);
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x0002D9B6 File Offset: 0x0002BBB6
	public Vector GetRightVector(Vector outV)
	{
		return this.GetAxisY(outV);
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x0002D9BF File Offset: 0x0002BBBF
	public Vector GetUpVector(Vector outV)
	{
		return this.GetAxisZ(outV);
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x0002D9C8 File Offset: 0x0002BBC8
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

	// Token: 0x060008B0 RID: 2224 RVA: 0x0002DA1C File Offset: 0x0002BC1C
	public bool Equals(Quat b, float tolerance = 0.0001f)
	{
		return Math.Abs(this.X - b.X) <= (double)tolerance && Math.Abs(this.Y - b.Y) <= (double)tolerance && Math.Abs(this.Z - b.Z) <= (double)tolerance && Math.Abs(this.W - b.W) <= (double)tolerance;
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x0002DA88 File Offset: 0x0002BC88
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

	// Token: 0x060008B2 RID: 2226 RVA: 0x0002DBC4 File Offset: 0x0002BDC4
	private static void VectorMultiply(Quat q1, Quat q2, Quat outQ)
	{
		outQ.X = q1.X * q2.X;
		outQ.Y = q1.Y * q2.Y;
		outQ.Z = q1.Z * q2.Z;
		outQ.W = q1.W * q2.W;
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x0002DC20 File Offset: 0x0002BE20
	private static void VectorMultiplyAdd(Quat q1, Quat q2, Quat q3, Quat outQ)
	{
		outQ.X = q1.X * q2.X + q3.X;
		outQ.Y = q1.Y * q2.Y + q3.Y;
		outQ.Z = q1.Z * q2.Z + q3.Z;
		outQ.W = q1.W * q2.W + q3.W;
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x0002DC98 File Offset: 0x0002BE98
	private static void VectorReplicate(Quat quat, int index, Quat outQ)
	{
		double num = quat[index];
		outQ.X = num;
		outQ.Y = num;
		outQ.Z = num;
		outQ.W = num;
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x0002DCC9 File Offset: 0x0002BEC9
	private static void VectorSwizzle(Quat quat, int x, int y, int z, int w, Quat outQ)
	{
		outQ.X = quat[x];
		outQ.Y = quat[y];
		outQ.Z = quat[z];
		outQ.W = quat[w];
	}

	// Token: 0x17000103 RID: 259
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

	// Token: 0x04000623 RID: 1571
	public const double FindBetweenConst = 9.999999974752427E-07;

	// Token: 0x04000624 RID: 1572
	public const double SlerpConst = 0.9998999834060669;

	// Token: 0x04000625 RID: 1573
	public const double SingularityThreshold = 0.4999994933605194;

	// Token: 0x04000626 RID: 1574
	public double X;

	// Token: 0x04000627 RID: 1575
	public double Y;

	// Token: 0x04000628 RID: 1576
	public double Z;

	// Token: 0x04000629 RID: 1577
	public double W;

	// Token: 0x0400062A RID: 1578
	[StaticVariableRuleIgnore]
	public static readonly FQuat Identity = new FQuat(0f, 0f, 0f, 1f);

	// Token: 0x0400062B RID: 1579
	[StaticVariableRuleIgnore]
	public static readonly Quat IdentityProxy = new Quat(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400062C RID: 1580
	[Nullable(2)]
	private Rotator RotatorInternal;

	// Token: 0x0400062D RID: 1581
	[StaticVariableRuleIgnore]
	private static readonly Quat QuatMultiSignMask0 = new Quat(1.0, -1.0, 1.0, -1.0);

	// Token: 0x0400062E RID: 1582
	[StaticVariableRuleIgnore]
	private static readonly Quat QuatMultiSignMask1 = new Quat(1.0, 1.0, -1.0, -1.0);

	// Token: 0x0400062F RID: 1583
	[StaticVariableRuleIgnore]
	private static readonly Quat QuatMultiSignMask2 = new Quat(-1.0, 1.0, 1.0, -1.0);

	// Token: 0x04000630 RID: 1584
	[StaticVariableRuleIgnore]
	private static readonly Quat OriginQuat1 = new Quat();

	// Token: 0x04000631 RID: 1585
	[StaticVariableRuleIgnore]
	private static readonly Quat OriginQuat2 = new Quat();

	// Token: 0x04000632 RID: 1586
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat1 = new Quat();

	// Token: 0x04000633 RID: 1587
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat2 = new Quat();

	// Token: 0x04000634 RID: 1588
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat3 = new Quat();
}
