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
[Obsolete("手写数学库已废弃，请改用 UnrealEngine.FRotator")]
public class Rotator : IRotator, IClearable, ILogFormattedPrint
{
	// Token: 0x060008B8 RID: 2232 RVA: 0x0002DE6C File Offset: 0x0002C06C
	[Obsolete("迁移期隐式转换：请确认不在每帧热点路径上")]
	public static implicit operator FRotator(global::Rotator v)
	{
		if (v != null)
		{
			return new FRotator(v.Pitch, v.Yaw, v.Roll);
		}
		return default(FRotator);
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x0002DE9D File Offset: 0x0002C09D
	[Obsolete("迁移期隐式转换：请确认不在每帧热点路径上")]
	public static implicit operator global::Rotator(FRotator v)
	{
		return global::Rotator.Create(v.Pitch, v.Yaw, v.Roll);
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x0002DEB8 File Offset: 0x0002C0B8
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

	// Token: 0x060008BB RID: 2235 RVA: 0x0002DF2D File Offset: 0x0002C12D
	public string ToFormattedString()
	{
		return this.ToString();
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x0002DF38 File Offset: 0x0002C138
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

	// Token: 0x060008BD RID: 2237 RVA: 0x0002DFB2 File Offset: 0x0002C1B2
	public void Clear()
	{
		this.Reset();
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x0002DFBA File Offset: 0x0002C1BA
	public Rotator()
	{
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x0002DFC2 File Offset: 0x0002C1C2
	public Rotator(float inPitch, float inYaw, float inRoll)
	{
		this.Pitch = inPitch;
		this.Yaw = inYaw;
		this.Roll = inRoll;
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0002DFDF File Offset: 0x0002C1DF
	// (set) Token: 0x060008C1 RID: 2241 RVA: 0x0002DFE7 File Offset: 0x0002C1E7
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

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0002DFF0 File Offset: 0x0002C1F0
	// (set) Token: 0x060008C3 RID: 2243 RVA: 0x0002DFF8 File Offset: 0x0002C1F8
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

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0002E001 File Offset: 0x0002C201
	// (set) Token: 0x060008C5 RID: 2245 RVA: 0x0002E009 File Offset: 0x0002C209
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

	// Token: 0x060008C6 RID: 2246 RVA: 0x0002E012 File Offset: 0x0002C212
	public void Set(float inPitch, float inYaw, float inRoll)
	{
		this.Pitch = inPitch;
		this.Yaw = inYaw;
		this.Roll = inRoll;
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x0002E029 File Offset: 0x0002C229
	public void FromUeRotator(IRotator inR)
	{
		this.Pitch = inR.Pitch;
		this.Yaw = inR.Yaw;
		this.Roll = inR.Roll;
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x0002E04F File Offset: 0x0002C24F
	public void FromUeRotator(Aki.Protocol.Rotator inR)
	{
		this.Pitch = inR.Pitch;
		this.Yaw = inR.Yaw;
		this.Roll = inR.Roll;
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x0002E075 File Offset: 0x0002C275
	public void FromUeRotator(global::Rotator inR)
	{
		this.Pitch = inR.Pitch;
		this.Yaw = inR.Yaw;
		this.Roll = inR.Roll;
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x0002E09B File Offset: 0x0002C29B
	public void FromUeRotator(in FRotator inR)
	{
		this.Pitch = inR.Pitch;
		this.Yaw = inR.Yaw;
		this.Roll = inR.Roll;
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x0002E0C1 File Offset: 0x0002C2C1
	public void DeepCopy(IRotator inR)
	{
		this.Set(inR.Pitch, inR.Yaw, inR.Roll);
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x0002E0DB File Offset: 0x0002C2DB
	public void DeepCopy(global::Rotator inR)
	{
		this.Set(inR.Pitch, inR.Yaw, inR.Roll);
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x0002E0F5 File Offset: 0x0002C2F5
	public void DeepCopy(in FRotator inR)
	{
		this.Set(inR.Pitch, inR.Yaw, inR.Roll);
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x0002E10F File Offset: 0x0002C30F
	public static global::Rotator Create(float pitch, float yaw, float roll)
	{
		return new global::Rotator(pitch, yaw, roll);
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x0002E119 File Offset: 0x0002C319
	public static global::Rotator Create([Nullable(2)] IRotator inR)
	{
		if (inR == null)
		{
			return new global::Rotator();
		}
		return new global::Rotator(inR.Pitch, inR.Yaw, inR.Roll);
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x0002E13B File Offset: 0x0002C33B
	public static global::Rotator Create()
	{
		return new global::Rotator();
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x0002E142 File Offset: 0x0002C342
	public FRotator ToUeRotator()
	{
		return new FRotator(this.Pitch, this.Yaw, this.Roll);
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x0002E15C File Offset: 0x0002C35C
	public static float NormalizeAxis(float angle)
	{
		float num = global::Rotator.ClampAxis(angle);
		if (num > 180f)
		{
			num -= 360f;
		}
		return num;
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x0002E184 File Offset: 0x0002C384
	public static double NormalizeAxis(double angle)
	{
		double num = global::Rotator.ClampAxis(angle);
		if (num > 180.0)
		{
			num -= 360.0;
		}
		return num;
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x0002E1B1 File Offset: 0x0002C3B1
	public global::Rotator Normalize(global::Rotator outR)
	{
		outR.Pitch = global::Rotator.NormalizeAxis(this.Pitch);
		outR.Yaw = global::Rotator.NormalizeAxis(this.Yaw);
		outR.Roll = global::Rotator.NormalizeAxis(this.Roll);
		return outR;
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x0002E1E8 File Offset: 0x0002C3E8
	public static float ClampAxis(float angle)
	{
		float num = angle % 360f;
		if (num < 0f)
		{
			num += 360f;
		}
		return num;
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x0002E210 File Offset: 0x0002C410
	public static double ClampAxis(double angle)
	{
		double num = angle % 360.0;
		if (num < 0.0)
		{
			num += 360.0;
		}
		return num;
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x0002E242 File Offset: 0x0002C442
	public global::Rotator Clamp(global::Rotator outR)
	{
		outR.Pitch = global::Rotator.ClampAxis(this.Pitch);
		outR.Yaw = global::Rotator.ClampAxis(this.Yaw);
		outR.Roll = global::Rotator.ClampAxis(this.Roll);
		return outR;
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x0002E278 File Offset: 0x0002C478
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

	// Token: 0x060008D9 RID: 2265 RVA: 0x0002E2E4 File Offset: 0x0002C4E4
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

	// Token: 0x060008DA RID: 2266 RVA: 0x0002E410 File Offset: 0x0002C610
	public bool IsNearlyZero()
	{
		float num = 0.0001f;
		return Math.Abs(global::Rotator.NormalizeAxis(this.Yaw)) <= num && Math.Abs(global::Rotator.NormalizeAxis(this.Pitch)) <= num && Math.Abs(global::Rotator.NormalizeAxis(this.Roll)) <= num;
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x0002E464 File Offset: 0x0002C664
	public bool Equals(global::Rotator b, float tolerance = 0.0001f)
	{
		return Math.Abs(global::Rotator.NormalizeAxis(this.Yaw - b.Yaw)) <= tolerance && Math.Abs(global::Rotator.NormalizeAxis(this.Pitch - b.Pitch)) <= tolerance && Math.Abs(global::Rotator.NormalizeAxis(this.Roll - b.Roll)) <= tolerance;
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x0002E4C4 File Offset: 0x0002C6C4
	public bool Equals2(IRotator inB, float tolerance = 0.0001f)
	{
		return Math.Abs(global::Rotator.NormalizeAxis(this.Yaw - inB.Yaw)) <= tolerance && Math.Abs(global::Rotator.NormalizeAxis(this.Pitch - inB.Pitch)) <= tolerance && Math.Abs(global::Rotator.NormalizeAxis(this.Roll - inB.Roll)) <= tolerance;
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x0002E524 File Offset: 0x0002C724
	public global::Rotator AdditionEqual(IRotator inB)
	{
		this.Pitch += inB.Pitch;
		this.Yaw += inB.Yaw;
		this.Roll += inB.Roll;
		return this;
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x0002E560 File Offset: 0x0002C760
	public global::Rotator SubtractionEqual(IRotator inB)
	{
		this.Pitch -= inB.Pitch;
		this.Yaw -= inB.Yaw;
		this.Roll -= inB.Roll;
		return this;
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x0002E59C File Offset: 0x0002C79C
	public global::Rotator MultiplyEqual(float inV)
	{
		this.Pitch *= inV;
		this.Yaw *= inV;
		this.Roll *= inV;
		return this;
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x0002E5C9 File Offset: 0x0002C7C9
	public void UnaryNegation(global::Rotator outV)
	{
		outV.Pitch = -this.Pitch;
		outV.Yaw = -this.Yaw;
		outV.Roll = -this.Roll;
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x0002E5F2 File Offset: 0x0002C7F2
	public void Reset()
	{
		this.Pitch = 0f;
		this.Yaw = 0f;
		this.Roll = 0f;
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x0002E615 File Offset: 0x0002C815
	public static void UeRotatorCopy(FRotator inR, FRotator outR)
	{
		outR.Pitch = inR.Pitch;
		outR.Yaw = inR.Yaw;
		outR.Roll = inR.Roll;
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x0002E640 File Offset: 0x0002C840
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

	// Token: 0x060008E4 RID: 2276 RVA: 0x0002E6F5 File Offset: 0x0002C8F5
	public static float AxisLerp(float from, float to, float alpha)
	{
		return MathCommon.WrapAngle(MathCommon.WrapAngle(to - from) * alpha + from);
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x0002E708 File Offset: 0x0002C908
	public Aki.Protocol.Rotator ToProtocolRotator()
	{
		Aki.Protocol.Rotator rotator = Aki.Protocol.Rotator.Create();
		rotator.Pitch = this.Pitch;
		rotator.Roll = this.Roll;
		rotator.Yaw = this.Yaw;
		return rotator;
	}

	// Token: 0x04000635 RID: 1589
	public float Pitch;

	// Token: 0x04000636 RID: 1590
	public float Yaw;

	// Token: 0x04000637 RID: 1591
	public float Roll;

	// Token: 0x04000638 RID: 1592
	[Nullable(2)]
	private Quat QuatInternal;

	// Token: 0x04000639 RID: 1593
	[StaticVariableRuleIgnore]
	public static readonly global::Rotator ZeroRotatorProxy = new global::Rotator(0f, 0f, 0f);

	// Token: 0x0400063A RID: 1594
	[StaticVariableRuleIgnore]
	public static readonly FRotator ZeroRotator = new FRotator(0f, 0f, 0f);
}
