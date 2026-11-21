using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002645 RID: 9797
[NullableContext(1)]
[Nullable(0)]
public class BigJumpUnit
{
	// Token: 0x06018799 RID: 100249 RVA: 0x00765B8C File Offset: 0x00763D8C
	public Rotator GetEndRotator()
	{
		return this.EndRotator;
	}

	// Token: 0x0601879A RID: 100250 RVA: 0x00765B94 File Offset: 0x00763D94
	public void SetAll(float time1, Vector startPoint, Vector middlePoint, Vector endPoint, string curvePath = "", float gravity2 = 1960f, [Nullable(2)] Rotator endRotator = null, [Nullable(2)] Vector gravityDirect = null, string rotatorCurve = "", [Nullable(2)] Quat startQuat = null)
	{
		this.TimeLength1 = time1;
		this.StartPoint.DeepCopy(startPoint);
		this.MiddlePoint.DeepCopy(middlePoint);
		this.EndPoint.DeepCopy(endPoint);
		this.Curve = (string.IsNullOrEmpty(curvePath) ? null : ResourceSystem.Instance.Load<UCurveFloat>(curvePath, "js_undefined"));
		if (startQuat != null)
		{
			this.StartQuat.DeepCopy(startQuat);
			this.GotStartQuat = true;
		}
		else
		{
			this.GotStartQuat = true;
		}
		if (endRotator != null)
		{
			this.EndRotator.DeepCopy(endRotator);
			this.GotEndQuat = true;
			this.EndRotator.Quaternion(this.EndQuat);
			if (!this.GotStartQuat)
			{
				this.StartQuat.DeepCopy(this.EndQuat);
			}
		}
		else
		{
			this.GotEndQuat = false;
		}
		this.RotatorCurve = (string.IsNullOrEmpty(rotatorCurve) ? null : ResourceSystem.Instance.Load<UCurveFloat>(rotatorCurve, "js_undefined"));
		this.Gravity2 = gravity2;
		this.GravityDirect.DeepCopy(gravityDirect ?? Vector.DownVectorProxy);
	}

	// Token: 0x0601879B RID: 100251 RVA: 0x00765C9E File Offset: 0x00763E9E
	public void SetStartPoint(Vector startPoint)
	{
		this.StartPoint.DeepCopy(startPoint);
	}

	// Token: 0x0601879C RID: 100252 RVA: 0x00765CAC File Offset: 0x00763EAC
	public void Init()
	{
		this.EndPoint.Subtraction(this.MiddlePoint, BigJumpUnit.TmpVector);
		if (this.Gravity2 > 0f && GravityUtils.Instance.GetZnInGravity(this.GravityDirect, BigJumpUnit.TmpVector) < -1E-08)
		{
			this.EndPoint.Subtraction(this.StartPoint, BigJumpUnit.TmpVector);
			if (!this.GotEndQuat)
			{
				this.GravityDirect.UnaryNegation(BigJumpUnit.TmpVector2);
				MathUtils.Instance.LookRotationUpFirst(BigJumpUnit.TmpVector, BigJumpUnit.TmpVector2, this.EndQuat);
				this.EndQuat.Rotator(this.EndRotator);
			}
			this.MiddlePoint.Subtraction(this.StartPoint, BigJumpUnit.TmpVector2);
			GravityUtils.Instance.ConvertToPlanarVectorForDirect(this.GravityDirect, BigJumpUnit.TmpVector);
			GravityUtils.Instance.ConvertToPlanarVectorForDirect(this.GravityDirect, BigJumpUnit.TmpVector2);
			BigJumpUnit.TmpVector.Normalize(9.99999993922529E-09);
			BigJumpUnit.TmpVector.MultiplyEqual(BigJumpUnit.TmpVector2.DotProduct(BigJumpUnit.TmpVector));
			BigJumpUnit.TmpVector.AdditionEqual(this.StartPoint);
			double znInGravityForDirect = GravityUtils.Instance.GetZnInGravityForDirect(this.GravityDirect, this.MiddlePoint);
			this.MiddlePoint.DeepCopy(BigJumpUnit.TmpVector);
			GravityUtils.Instance.SetZnInGravity(this.GravityDirect, this.MiddlePoint, znInGravityForDirect);
			double znInGravityForDirect2 = GravityUtils.Instance.GetZnInGravityForDirect(this.GravityDirect, this.EndPoint);
			this.TimeLength2 = (float)Math.Sqrt((znInGravityForDirect - znInGravityForDirect2) * 2.0 / (double)this.Gravity2);
			this.EndPoint.Subtraction(this.MiddlePoint, BigJumpUnit.TmpVector);
			GravityUtils.Instance.ConvertToPlanarVectorForDirect(this.GravityDirect, BigJumpUnit.TmpVector);
			BigJumpUnit.TmpVector.Division((double)this.TimeLength2, this.Speed2);
			this.MiddlePoint.Subtraction(this.StartPoint, BigJumpUnit.TmpVector);
			GravityUtils.Instance.ConvertToPlanarVectorForDirect(this.GravityDirect, BigJumpUnit.TmpVector);
			BigJumpUnit.TmpVector.DivisionEqual((double)this.TimeLength1);
			BigJumpUnit.TmpVector.MultiplyEqual(2.0);
			BigJumpUnit.TmpVector.Subtraction(this.Speed2, this.Speed1);
		}
		else
		{
			this.MiddlePoint.Subtraction(this.StartPoint, BigJumpUnit.TmpVector);
			GravityUtils.Instance.ConvertToPlanarVectorForDirect(this.GravityDirect, BigJumpUnit.TmpVector);
			BigJumpUnit.TmpVector.DivisionEqual((double)this.TimeLength1);
			this.Speed1.DeepCopy(BigJumpUnit.TmpVector);
			this.Speed2.DeepCopy(this.Speed1);
			this.TimeLength2 = 0f;
		}
		if (!this.GotStartQuat)
		{
			this.StartQuat.DeepCopy(this.EndQuat);
		}
	}

	// Token: 0x0601879D RID: 100253 RVA: 0x00765F8C File Offset: 0x0076418C
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 8);
		defaultInterpolatedStringHandler.AppendLiteral("TimeLength: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.TimeLength1);
		defaultInterpolatedStringHandler.AppendLiteral(" + ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.TimeLength2);
		defaultInterpolatedStringHandler.AppendLiteral(", Points: ");
		defaultInterpolatedStringHandler.AppendFormatted(this.StartPoint.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(", ");
		defaultInterpolatedStringHandler.AppendFormatted(this.MiddlePoint.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(", ");
		defaultInterpolatedStringHandler.AppendFormatted(this.EndPoint.ToString());
		defaultInterpolatedStringHandler.AppendLiteral("\n  Gravity2: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.Gravity2);
		defaultInterpolatedStringHandler.AppendLiteral(", Speeds: ");
		defaultInterpolatedStringHandler.AppendFormatted(this.Speed1.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(", ");
		defaultInterpolatedStringHandler.AppendFormatted(this.Speed2.ToString());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x1700267D RID: 9853
	// (get) Token: 0x0601879E RID: 100254 RVA: 0x0076608B File Offset: 0x0076428B
	public float RisingTime
	{
		get
		{
			return this.TimeLength1;
		}
	}

	// Token: 0x1700267E RID: 9854
	// (get) Token: 0x0601879F RID: 100255 RVA: 0x00766093 File Offset: 0x00764293
	public float TimeLength
	{
		get
		{
			return this.TimeLength1 + this.TimeLength2;
		}
	}

	// Token: 0x060187A0 RID: 100256 RVA: 0x007660A4 File Offset: 0x007642A4
	public void GetLocation(float time, Vector output)
	{
		if (time < this.TimeLength1)
		{
			Vector.Lerp(this.Speed1, this.Speed2, (double)(time / this.TimeLength1), output);
			output.AdditionEqual(this.Speed1);
			output.MultiplyEqual((double)(time / 2f));
			output.AdditionEqual(this.StartPoint);
			float num = (this.Curve != null) ? this.Curve.GetFloatValue(time / this.TimeLength1) : CurveUtils.DefaultPara.GetCurrentValue(time / this.TimeLength1);
			double znInGravityForDirect = GravityUtils.Instance.GetZnInGravityForDirect(this.GravityDirect, this.StartPoint);
			double znInGravityForDirect2 = GravityUtils.Instance.GetZnInGravityForDirect(this.GravityDirect, this.MiddlePoint);
			GravityUtils.Instance.SetZnInGravity(this.GravityDirect, output, MathUtils.Instance.Lerp(znInGravityForDirect, znInGravityForDirect2, (double)num));
			return;
		}
		float num2 = time - this.TimeLength1;
		this.Speed2.Multiply((double)num2, output);
		GravityUtils.Instance.SetZnInGravity(this.GravityDirect, output, (double)(-(double)(this.Gravity2 * num2 * num2) / 2f));
		output.AdditionEqual(this.MiddlePoint);
	}

	// Token: 0x060187A1 RID: 100257 RVA: 0x007661C7 File Offset: 0x007643C7
	public void GetOffset(float time, float deltaTime, Vector output)
	{
		this.GetLocation(time, BigJumpUnit.TmpVector);
		this.GetLocation(time + deltaTime, output);
		output.SubtractionEqual(BigJumpUnit.TmpVector);
	}

	// Token: 0x060187A2 RID: 100258 RVA: 0x007661EC File Offset: 0x007643EC
	public void GetSpeed(float time, Vector output)
	{
		if (time < this.TimeLength1)
		{
			Vector.Lerp(this.Speed1, this.Speed2, (double)(time / this.TimeLength1), output);
			output.AdditionEqual(this.Speed1);
			output.MultiplyEqual(0.5);
			return;
		}
		output.DeepCopy(this.Speed2);
		float num = time - this.TimeLength1;
		GravityUtils.Instance.SetZnInGravity(this.GravityDirect, output, (double)(-(double)this.Gravity2 * num));
	}

	// Token: 0x060187A3 RID: 100259 RVA: 0x0076626C File Offset: 0x0076446C
	public void GetQuat(float time, Quat @out)
	{
		float num = time / this.TimeLength;
		if (this.RotatorCurve != null)
		{
			num = this.RotatorCurve.GetFloatValue(num);
		}
		Quat.Slerp(this.StartQuat, this.EndQuat, num, @out);
	}

	// Token: 0x060187A4 RID: 100260 RVA: 0x007662AC File Offset: 0x007644AC
	public void GetQuatOffset(float time, float deltaTime, Quat @out)
	{
		if (!this.GotEndQuat)
		{
			@out.DeepCopy(Quat.Identity);
			return;
		}
		this.GetQuat(time, BigJumpUnit.TmpQuat);
		BigJumpUnit.TmpQuat.Inverse(BigJumpUnit.TmpQuat2);
		this.GetQuat(time + deltaTime, BigJumpUnit.TmpQuat);
		BigJumpUnit.TmpQuat.Multiply(BigJumpUnit.TmpQuat2, @out);
	}

	// Token: 0x0400D387 RID: 54151
	public const float DEFAULT_GRAVITY = 1960f;

	// Token: 0x0400D388 RID: 54152
	private float TimeLength1;

	// Token: 0x0400D389 RID: 54153
	private float TimeLength2;

	// Token: 0x0400D38A RID: 54154
	private readonly Vector StartPoint = Vector.Create();

	// Token: 0x0400D38B RID: 54155
	private readonly Vector MiddlePoint = Vector.Create();

	// Token: 0x0400D38C RID: 54156
	private readonly Vector EndPoint = Vector.Create();

	// Token: 0x0400D38D RID: 54157
	[Nullable(2)]
	private UCurveFloat Curve;

	// Token: 0x0400D38E RID: 54158
	private float Gravity2;

	// Token: 0x0400D38F RID: 54159
	private Vector GravityDirect = Vector.Create(0.0, 0.0, -1.0);

	// Token: 0x0400D390 RID: 54160
	private readonly Vector Speed1 = Vector.Create();

	// Token: 0x0400D391 RID: 54161
	private readonly Vector Speed2 = Vector.Create();

	// Token: 0x0400D392 RID: 54162
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400D393 RID: 54163
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x0400D394 RID: 54164
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D395 RID: 54165
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D396 RID: 54166
	private bool GotStartQuat;

	// Token: 0x0400D397 RID: 54167
	private bool GotEndQuat;

	// Token: 0x0400D398 RID: 54168
	private readonly Quat StartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D399 RID: 54169
	private readonly Quat EndQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D39A RID: 54170
	private readonly Rotator EndRotator = Rotator.Create();

	// Token: 0x0400D39B RID: 54171
	[Nullable(2)]
	private UCurveFloat RotatorCurve;
}
