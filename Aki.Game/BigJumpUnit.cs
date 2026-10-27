using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020030ED RID: 12525
[NullableContext(1)]
[Nullable(0)]
public class BigJumpUnit
{
	// Token: 0x0601AD7A RID: 109946 RVA: 0x007401A0 File Offset: 0x0073E3A0
	public Rotator GetEndRotator()
	{
		return this.EndRotator;
	}

	// Token: 0x0601AD7B RID: 109947 RVA: 0x007401A8 File Offset: 0x0073E3A8
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

	// Token: 0x0601AD7C RID: 109948 RVA: 0x007402B2 File Offset: 0x0073E4B2
	public void SetStartPoint(Vector startPoint)
	{
		this.StartPoint.DeepCopy(startPoint);
	}

	// Token: 0x0601AD7D RID: 109949 RVA: 0x007402C0 File Offset: 0x0073E4C0
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

	// Token: 0x0601AD7E RID: 109950 RVA: 0x007405A0 File Offset: 0x0073E7A0
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

	// Token: 0x170024F1 RID: 9457
	// (get) Token: 0x0601AD7F RID: 109951 RVA: 0x0074069F File Offset: 0x0073E89F
	public float RisingTime
	{
		get
		{
			return this.TimeLength1;
		}
	}

	// Token: 0x170024F2 RID: 9458
	// (get) Token: 0x0601AD80 RID: 109952 RVA: 0x007406A7 File Offset: 0x0073E8A7
	public float TimeLength
	{
		get
		{
			return this.TimeLength1 + this.TimeLength2;
		}
	}

	// Token: 0x0601AD81 RID: 109953 RVA: 0x007406B8 File Offset: 0x0073E8B8
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

	// Token: 0x0601AD82 RID: 109954 RVA: 0x007407DB File Offset: 0x0073E9DB
	public void GetOffset(float time, float deltaTime, Vector output)
	{
		this.GetLocation(time, BigJumpUnit.TmpVector);
		this.GetLocation(time + deltaTime, output);
		output.SubtractionEqual(BigJumpUnit.TmpVector);
	}

	// Token: 0x0601AD83 RID: 109955 RVA: 0x00740800 File Offset: 0x0073EA00
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

	// Token: 0x0601AD84 RID: 109956 RVA: 0x00740880 File Offset: 0x0073EA80
	public void GetQuat(float time, Quat @out)
	{
		float num = time / this.TimeLength;
		if (this.RotatorCurve != null)
		{
			num = this.RotatorCurve.GetFloatValue(num);
		}
		Quat.Slerp(this.StartQuat, this.EndQuat, num, @out);
	}

	// Token: 0x0601AD85 RID: 109957 RVA: 0x007408C0 File Offset: 0x0073EAC0
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

	// Token: 0x0400CF96 RID: 53142
	public const float DEFAULT_GRAVITY = 1960f;

	// Token: 0x0400CF97 RID: 53143
	private float TimeLength1;

	// Token: 0x0400CF98 RID: 53144
	private float TimeLength2;

	// Token: 0x0400CF99 RID: 53145
	private readonly Vector StartPoint = Vector.Create();

	// Token: 0x0400CF9A RID: 53146
	private readonly Vector MiddlePoint = Vector.Create();

	// Token: 0x0400CF9B RID: 53147
	private readonly Vector EndPoint = Vector.Create();

	// Token: 0x0400CF9C RID: 53148
	[Nullable(2)]
	private UCurveFloat Curve;

	// Token: 0x0400CF9D RID: 53149
	private float Gravity2;

	// Token: 0x0400CF9E RID: 53150
	private Vector GravityDirect = Vector.Create(0.0, 0.0, -1.0);

	// Token: 0x0400CF9F RID: 53151
	private readonly Vector Speed1 = Vector.Create();

	// Token: 0x0400CFA0 RID: 53152
	private readonly Vector Speed2 = Vector.Create();

	// Token: 0x0400CFA1 RID: 53153
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400CFA2 RID: 53154
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x0400CFA3 RID: 53155
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CFA4 RID: 53156
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CFA5 RID: 53157
	private bool GotStartQuat;

	// Token: 0x0400CFA6 RID: 53158
	private bool GotEndQuat;

	// Token: 0x0400CFA7 RID: 53159
	private readonly Quat StartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CFA8 RID: 53160
	private readonly Quat EndQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CFA9 RID: 53161
	private readonly Rotator EndRotator = Rotator.Create();

	// Token: 0x0400CFAA RID: 53162
	[Nullable(2)]
	private UCurveFloat RotatorCurve;
}
