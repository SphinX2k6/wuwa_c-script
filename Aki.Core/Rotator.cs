using System;
using System.Runtime.CompilerServices;
using Aki.Common.Common;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Bulitin.Utils;
using UnrealEngine.Extension;

// Token: 0x020000FC RID: 252
[NullableContext(1)]
[Nullable(0)]
public class Rotator : IRotator, IClearable, ILogFormattedPrint
{
	// Token: 0x06000870 RID: 2160 RVA: 0x0002D628 File Offset: 0x0002B828
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
		defaultInterpolatedStringHandler.AppendLiteral("(Pitch = ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.Pitch);
		defaultInterpolatedStringHandler.AppendLiteral(", Yaw = ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.Yaw);
		defaultInterpolatedStringHandler.AppendLiteral(", Roll = ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.Roll);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0002D69D File Offset: 0x0002B89D
	public string ToFormattedString()
	{
		return this.ToString();
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x0002D6A8 File Offset: 0x0002B8A8
	public void ToFormattedString(UnsafeStringBuilder sb)
	{
		UnsafeStringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new UnsafeStringBuilder.AppendInterpolatedStringHandler(27, 3, sb);
		appendInterpolatedStringHandler.AppendLiteral("(Pitch = ");
		appendInterpolatedStringHandler.AppendFormatted<float>(this.Pitch);
		appendInterpolatedStringHandler.AppendLiteral(", Yaw = ");
		appendInterpolatedStringHandler.AppendFormatted<float>(this.Yaw);
		appendInterpolatedStringHandler.AppendLiteral(", Roll = ");
		appendInterpolatedStringHandler.AppendFormatted<float>(this.Roll);
		appendInterpolatedStringHandler.AppendLiteral(")");
		sb.Append(ref appendInterpolatedStringHandler);
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x0002D722 File Offset: 0x0002B922
	public void Clear()
	{
		this.Reset();
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x0002D72A File Offset: 0x0002B92A
	public Rotator()
	{
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x0002D732 File Offset: 0x0002B932
	public Rotator(float inPitch, float inYaw, float inRoll)
	{
		this.Pitch = inPitch;
		this.Yaw = inYaw;
		this.Roll = inRoll;
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06000876 RID: 2166 RVA: 0x0002D74F File Offset: 0x0002B94F
	// (set) Token: 0x06000877 RID: 2167 RVA: 0x0002D757 File Offset: 0x0002B957
	float IRotator.Pitch
	{
		get
		{
			return this.Pitch;
		}
		set
		{
			this.Pitch = value;
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x06000878 RID: 2168 RVA: 0x0002D760 File Offset: 0x0002B960
	// (set) Token: 0x06000879 RID: 2169 RVA: 0x0002D768 File Offset: 0x0002B968
	float IRotator.Yaw
	{
		get
		{
			return this.Yaw;
		}
		set
		{
			this.Yaw = value;
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x0600087A RID: 2170 RVA: 0x0002D771 File Offset: 0x0002B971
	// (set) Token: 0x0600087B RID: 2171 RVA: 0x0002D779 File Offset: 0x0002B979
	float IRotator.Roll
	{
		get
		{
			return this.Roll;
		}
		set
		{
			this.Roll = value;
		}
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x0002D782 File Offset: 0x0002B982
	public void Set(float inPitch, float inYaw, float inRoll)
	{
		this.Pitch = inPitch;
		this.Yaw = inYaw;
		this.Roll = inRoll;
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x0002D799 File Offset: 0x0002B999
	public void FromUeRotator(IRotator inR)
	{
		this.Pitch = inR.Pitch;
		this.Yaw = inR.Yaw;
		this.Roll = inR.Roll;
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x0002D7BF File Offset: 0x0002B9BF
	public void FromUeRotator(Aki.Protocol.Rotator inR)
	{
		this.Pitch = inR.Pitch;
		this.Yaw = inR.Yaw;
		this.Roll = inR.Roll;
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x0002D7E5 File Offset: 0x0002B9E5
	public void FromUeRotator(global::Rotator inR)
	{
		this.Pitch = inR.Pitch;
		this.Yaw = inR.Yaw;
		this.Roll = inR.Roll;
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x0002D80B File Offset: 0x0002BA0B
	public void FromUeRotator(in FRotator inR)
	{
		this.Pitch = inR.Pitch;
		this.Yaw = inR.Yaw;
		this.Roll = inR.Roll;
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x0002D831 File Offset: 0x0002BA31
	public void DeepCopy(IRotator inR)
	{
		this.Set(inR.Pitch, inR.Yaw, inR.Roll);
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x0002D84B File Offset: 0x0002BA4B
	public void DeepCopy(global::Rotator inR)
	{
		this.Set(inR.Pitch, inR.Yaw, inR.Roll);
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x0002D865 File Offset: 0x0002BA65
	public void DeepCopy(in FRotator inR)
	{
		this.Set(inR.Pitch, inR.Yaw, inR.Roll);
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x0002D87F File Offset: 0x0002BA7F
	public static global::Rotator Create(float pitch, float yaw, float roll)
	{
		return new global::Rotator(pitch, yaw, roll);
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x0002D889 File Offset: 0x0002BA89
	public static global::Rotator Create([Nullable(2)] IRotator inR)
	{
		if (inR == null)
		{
			return new global::Rotator();
		}
		return new global::Rotator(inR.Pitch, inR.Yaw, inR.Roll);
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x0002D8AB File Offset: 0x0002BAAB
	public static global::Rotator Create()
	{
		return new global::Rotator();
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x0002D8B2 File Offset: 0x0002BAB2
	public FRotator ToUeRotator()
	{
		return new FRotator(this.Pitch, this.Yaw, this.Roll);
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x0002D8CC File Offset: 0x0002BACC
	public static float NormalizeAxis(float angle)
	{
		float num = global::Rotator.ClampAxis(angle);
		if (num > 180f)
		{
			num -= 360f;
		}
		return num;
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x0002D8F4 File Offset: 0x0002BAF4
	public static double NormalizeAxis(double angle)
	{
		double num = global::Rotator.ClampAxis(angle);
		if (num > 180.0)
		{
			num -= 360.0;
		}
		return num;
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x0002D921 File Offset: 0x0002BB21
	public global::Rotator Normalize(global::Rotator outR)
	{
		outR.Pitch = global::Rotator.NormalizeAxis(this.Pitch);
		outR.Yaw = global::Rotator.NormalizeAxis(this.Yaw);
		outR.Roll = global::Rotator.NormalizeAxis(this.Roll);
		return outR;
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x0002D958 File Offset: 0x0002BB58
	public static float ClampAxis(float angle)
	{
		float num = angle % 360f;
		if (num < 0f)
		{
			num += 360f;
		}
		return num;
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x0002D980 File Offset: 0x0002BB80
	public static double ClampAxis(double angle)
	{
		double num = angle % 360.0;
		if (num < 0.0)
		{
			num += 360.0;
		}
		return num;
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x0002D9B2 File Offset: 0x0002BBB2
	public global::Rotator Clamp(global::Rotator outR)
	{
		outR.Pitch = global::Rotator.ClampAxis(this.Pitch);
		outR.Yaw = global::Rotator.ClampAxis(this.Yaw);
		outR.Roll = global::Rotator.ClampAxis(this.Roll);
		return outR;
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x0002D9E8 File Offset: 0x0002BBE8
	public void Vector(global::Vector outV)
	{
		float degVal = MathCommon.WrapAngle(this.Pitch);
		float degVal2 = MathCommon.WrapAngle(this.Yaw);
		float num = MathCommon.DegreeToRadian(degVal);
		float num2 = MathCommon.DegreeToRadian(degVal2);
		double num3 = Math.Cos((double)num);
		double z = Math.Sin((double)num);
		double num4 = Math.Cos((double)num2);
		double num5 = Math.Sin((double)num2);
		outV.X = num3 * num4;
		outV.Y = num3 * num5;
		outV.Z = z;
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x0002DA54 File Offset: 0x0002BC54
	public Quat Quaternion([Nullable(2)] Quat outQ = null)
	{
		Quat quat = outQ;
		if (quat == null)
		{
			if (this.QuatInternal == null)
			{
				this.QuatInternal = Quat.Create(0.0, 0.0, 0.0, 1.0);
			}
			quat = this.QuatInternal;
		}
		float num = this.Pitch % 360f;
		float num2 = this.Yaw % 360f;
		float num3 = this.Roll % 360f;
		float num4 = num * 0.008726646f;
		float num5 = num2 * 0.008726646f;
		float num6 = num3 * 0.008726646f;
		double num7 = Math.Sin((double)num4);
		double num8 = Math.Cos((double)num4);
		double num9 = Math.Sin((double)num5);
		double num10 = Math.Cos((double)num5);
		double num11 = Math.Sin((double)num6);
		double num12 = Math.Cos((double)num6);
		double x = num12 * num7 * num9 - num11 * num8 * num10;
		double y = -num12 * num7 * num10 - num11 * num8 * num9;
		double z = num12 * num8 * num9 - num11 * num7 * num10;
		double w = num12 * num8 * num10 + num11 * num7 * num9;
		quat.X = x;
		quat.Y = y;
		quat.Z = z;
		quat.W = w;
		return quat;
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x0002DB80 File Offset: 0x0002BD80
	public bool IsNearlyZero()
	{
		float num = 0.0001f;
		return Math.Abs(global::Rotator.NormalizeAxis(this.Yaw)) <= num && Math.Abs(global::Rotator.NormalizeAxis(this.Pitch)) <= num && Math.Abs(global::Rotator.NormalizeAxis(this.Roll)) <= num;
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x0002DBD4 File Offset: 0x0002BDD4
	public bool Equals(global::Rotator b, float tolerance = 0.0001f)
	{
		return Math.Abs(global::Rotator.NormalizeAxis(this.Yaw - b.Yaw)) <= tolerance && Math.Abs(global::Rotator.NormalizeAxis(this.Pitch - b.Pitch)) <= tolerance && Math.Abs(global::Rotator.NormalizeAxis(this.Roll - b.Roll)) <= tolerance;
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x0002DC34 File Offset: 0x0002BE34
	public bool Equals2(IRotator inB, float tolerance = 0.0001f)
	{
		return Math.Abs(global::Rotator.NormalizeAxis(this.Yaw - inB.Yaw)) <= tolerance && Math.Abs(global::Rotator.NormalizeAxis(this.Pitch - inB.Pitch)) <= tolerance && Math.Abs(global::Rotator.NormalizeAxis(this.Roll - inB.Roll)) <= tolerance;
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x0002DC94 File Offset: 0x0002BE94
	public global::Rotator AdditionEqual(IRotator inB)
	{
		this.Pitch += inB.Pitch;
		this.Yaw += inB.Yaw;
		this.Roll += inB.Roll;
		return this;
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x0002DCD0 File Offset: 0x0002BED0
	public global::Rotator SubtractionEqual(IRotator inB)
	{
		this.Pitch -= inB.Pitch;
		this.Yaw -= inB.Yaw;
		this.Roll -= inB.Roll;
		return this;
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x0002DD0C File Offset: 0x0002BF0C
	public global::Rotator MultiplyEqual(float inV)
	{
		this.Pitch *= inV;
		this.Yaw *= inV;
		this.Roll *= inV;
		return this;
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x0002DD39 File Offset: 0x0002BF39
	public void UnaryNegation(global::Rotator outV)
	{
		outV.Pitch = -this.Pitch;
		outV.Yaw = -this.Yaw;
		outV.Roll = -this.Roll;
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x0002DD62 File Offset: 0x0002BF62
	public void Reset()
	{
		this.Pitch = 0f;
		this.Yaw = 0f;
		this.Roll = 0f;
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x0002DD85 File Offset: 0x0002BF85
	public static void UeRotatorCopy(FRotator inR, FRotator outR)
	{
		outR.Pitch = inR.Pitch;
		outR.Yaw = inR.Yaw;
		outR.Roll = inR.Roll;
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x0002DDB0 File Offset: 0x0002BFB0
	public static void Lerp(global::Rotator from, global::Rotator to, float alpha, global::Rotator outR)
	{
		outR.Pitch = to.Pitch - from.Pitch;
		outR.Yaw = to.Yaw - from.Yaw;
		outR.Roll = to.Roll - from.Roll;
		MathCommon.VectorNormalizeRotator(outR);
		outR.Pitch *= alpha;
		outR.Pitch += from.Pitch;
		outR.Yaw *= alpha;
		outR.Yaw += from.Yaw;
		outR.Roll *= alpha;
		outR.Roll += from.Roll;
		MathCommon.VectorNormalizeRotator(outR);
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x0002DE65 File Offset: 0x0002C065
	public static float AxisLerp(float from, float to, float alpha)
	{
		return MathCommon.WrapAngle(MathCommon.WrapAngle(to - from) * alpha + from);
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x0002DE78 File Offset: 0x0002C078
	public Aki.Protocol.Rotator ToProtocolRotator()
	{
		Aki.Protocol.Rotator rotator = Aki.Protocol.Rotator.Create();
		rotator.Pitch = this.Pitch;
		rotator.Roll = this.Roll;
		rotator.Yaw = this.Yaw;
		return rotator;
	}

	// Token: 0x0400062A RID: 1578
	public float Pitch;

	// Token: 0x0400062B RID: 1579
	public float Yaw;

	// Token: 0x0400062C RID: 1580
	public float Roll;

	// Token: 0x0400062D RID: 1581
	[Nullable(2)]
	private Quat QuatInternal;

	// Token: 0x0400062E RID: 1582
	[StaticVariableRuleIgnore]
	public static readonly global::Rotator ZeroRotatorProxy = new global::Rotator(0f, 0f, 0f);

	// Token: 0x0400062F RID: 1583
	[StaticVariableRuleIgnore]
	public static readonly FRotator ZeroRotator = new FRotator(0f, 0f, 0f);
}
