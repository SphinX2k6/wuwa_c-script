using System;
using System.Runtime.CompilerServices;

// Token: 0x02002860 RID: 10336
[NullableContext(1)]
[Nullable(0)]
public class GongduolaSplineMoveComponent : VehicleSplineMoveComponent
{
	// Token: 0x0601A2CD RID: 107213 RVA: 0x00817FA4 File Offset: 0x008161A4
	protected override void InputAdjustSlideTrack(Vector inputDirect)
	{
		this.SplineQuat.Inverse(this.TmpQuat);
		this.ActorComp.ActorLocationProxy.Subtraction(this.SplineLocation, this.TmpVector1);
		this.TmpQuat.RotateVector(this.TmpVector1, this.TmpVector);
		this.TmpQuat.Multiply(this.ActorComp.ActorQuatProxy, this.TmpQuat1);
		this.TmpQuat1.Rotator(this.TmpRotator);
		SplineMoveParams currentSplineMoveParamsInternal = this.CurrentSplineMoveParamsInternal;
		float currentValue = currentSplineMoveParamsInternal.EdgeLimitCurve.GetCurrentValue((float)Math.Abs(this.TmpVector.Y) / currentSplineMoveParamsInternal.MaxOffsetDist);
		float num = -currentSplineMoveParamsInternal.InputLimitAngle;
		float num2 = currentSplineMoveParamsInternal.InputLimitAngle;
		if (this.TmpVector.Y < 0.0)
		{
			num *= 1f - currentValue;
		}
		else
		{
			num2 *= 1f - currentValue;
		}
		this.TmpVector1.DeepCopy(inputDirect);
		this.ConvertToTriangleInput(this.TmpVector1);
		this.TmpVector1.X = 1.0;
		this.AdjustInputForValid(this.TmpVector1, (float)this.TmpVector.Y, this.TmpRotator.Yaw, num, num2);
		this.ConvertToCircleInput(this.TmpVector1);
		VehicleActorComponent vehicleActorComp = this.VehicleActorComp;
		if (vehicleActorComp == null)
		{
			return;
		}
		vehicleActorComp.SetInputDirect(this.TmpVector1, false, EInputDirectSpace.Relative);
	}

	// Token: 0x0601A2CE RID: 107214 RVA: 0x00818100 File Offset: 0x00816300
	protected void ConvertToTriangleInput(Vector inOutInput)
	{
		double absMax = inOutInput.GetAbsMax();
		if (inOutInput.Size() < 1.0)
		{
			return;
		}
		if (absMax < 0.0001)
		{
			return;
		}
		inOutInput.MultiplyEqual(1.0 / absMax);
	}

	// Token: 0x0601A2CF RID: 107215 RVA: 0x00818145 File Offset: 0x00816345
	protected void ConvertToCircleInput(Vector inOutInput)
	{
		if (inOutInput.Size() < 1.0)
		{
			return;
		}
		inOutInput.Normalize(9.99999993922529E-09);
	}

	// Token: 0x0601A2D0 RID: 107216 RVA: 0x0081816C File Offset: 0x0081636C
	protected void AdjustInputForValid(Vector inOutInput, float curDist, float curYaw, float minYaw, float maxYaw)
	{
		SplineMoveParams currentSplineMoveParams = base.CurrentSplineMoveParams;
		if (currentSplineMoveParams == null || !currentSplineMoveParams.OnlyForward)
		{
			return;
		}
		float num = Math.Min(maxYaw - curYaw, curYaw - minYaw);
		if (this.TmpVector1.Y * this.LastLockedInput.Y <= 0.0 || num > 10f)
		{
			this.LastLockedInput.Reset();
		}
		SplineMoveParams currentSplineMoveParams2 = base.CurrentSplineMoveParams;
		bool flag = currentSplineMoveParams2.CurrentMaxOffset <= currentSplineMoveParams2.MaxOffsetDist;
		bool flag2 = MathUtils.Instance.InRangeArray((double)curYaw, new double[]
		{
			(double)minYaw,
			(double)maxYaw
		});
		if (!flag)
		{
			if (Math.Abs(curYaw) >= 90f)
			{
				inOutInput.Y = (double)(-(double)Math.Sign(curDist));
				return;
			}
			int num2 = (curDist > 0f) ? 1 : -1;
			int num3 = (curYaw > 0f) ? 1 : -1;
			if (num2 * num3 > 0)
			{
				inOutInput.Y = (double)(-(double)Math.Sign(curYaw));
				return;
			}
			float num4 = Math.Abs(curYaw);
			int num5 = (num4 < 45f) ? 1 : ((num4 > 60f) ? -1 : 0);
			inOutInput.Y = (double)(num5 * Math.Sign(curYaw));
			return;
		}
		else
		{
			if (!flag2)
			{
				this.LastLockedInput.DeepCopy(inOutInput);
				inOutInput.Y = (double)(-(double)Math.Sign(curYaw));
				return;
			}
			if (this.LastLockedInput.Y * inOutInput.Y > 0.0)
			{
				inOutInput.Y = 0.0;
			}
			return;
		}
	}

	// Token: 0x0601A2D1 RID: 107217 RVA: 0x008182D8 File Offset: 0x008164D8
	protected override void ApplySplineMoveDaConfig()
	{
		if (this.ExtraMoveParams == null)
		{
			return;
		}
		GongduolaPerformComponent component = base.Entity.GetComponent<GongduolaPerformComponent>();
		if (!(((component != null) ? component.Config : null) is GongduolaConfig))
		{
			return;
		}
		((GongduolaConfig)component.Config).BaseMaxSpeed = this.ExtraMoveParams.ForwardSpeed;
		((GongduolaConfig)component.Config).BaseMaxAcceleration = this.ExtraMoveParams.ForwardAcceleration;
		component.RefreshMoveConfigFromVehicleConfig();
		component.SetEnableInputSprint(!this.ExtraMoveParams.DisableSprint.GetValueOrDefault());
	}

	// Token: 0x0601A2D2 RID: 107218 RVA: 0x00818366 File Offset: 0x00816566
	protected override void ResetSplineMoveDaConfig()
	{
		GongduolaPerformComponent component = base.Entity.GetComponent<GongduolaPerformComponent>();
		if (component != null)
		{
			component.ResetVehicleConfig(true);
		}
		if (component == null)
		{
			return;
		}
		component.SetEnableInputSprint(true);
	}

	// Token: 0x0601A2D3 RID: 107219 RVA: 0x0081838B File Offset: 0x0081658B
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		if (((GongduolaSplineMoveComponent)componentTemplate).LastLockedInput == null)
		{
			this.LastLockedInput = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastLockedInput), "LastLockedInput"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002AB4 RID: 10932
	// (get) Token: 0x0601A2D4 RID: 107220 RVA: 0x008183C9 File Offset: 0x008165C9
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AB5 RID: 10933
	// (get) Token: 0x0601A2D5 RID: 107221 RVA: 0x008183CC File Offset: 0x008165CC
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AB6 RID: 10934
	// (get) Token: 0x0601A2D6 RID: 107222 RVA: 0x008183CF File Offset: 0x008165CF
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E5C4 RID: 58820
	private const float UNLOCK_TURN_INPUT_MIN_ANGLE = 10f;

	// Token: 0x0400E5C5 RID: 58821
	private const float INPUT_ADJUST_FORWARD_MIN_YAW = 45f;

	// Token: 0x0400E5C6 RID: 58822
	private const float INPUT_ADJUST_FORWARD_MAX_YAW = 60f;

	// Token: 0x0400E5C7 RID: 58823
	protected Vector LastLockedInput = Vector.Create();
}
