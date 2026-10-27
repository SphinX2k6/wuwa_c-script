using System;
using System.Runtime.CompilerServices;

// Token: 0x020032EE RID: 13038
[NullableContext(1)]
[Nullable(0)]
public class GongduolaSplineMoveComponent : VehicleSplineMoveComponent
{
	// Token: 0x0601C60B RID: 116235 RVA: 0x007F1A68 File Offset: 0x007EFC68
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
		vehicleActorComp.SetInputDirect(this.TmpVector1, false);
	}

	// Token: 0x0601C60C RID: 116236 RVA: 0x007F1BC4 File Offset: 0x007EFDC4
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

	// Token: 0x0601C60D RID: 116237 RVA: 0x007F1C09 File Offset: 0x007EFE09
	protected void ConvertToCircleInput(Vector inOutInput)
	{
		if (inOutInput.Size() < 1.0)
		{
			return;
		}
		inOutInput.Normalize(9.99999993922529E-09);
	}

	// Token: 0x0601C60E RID: 116238 RVA: 0x007F1C30 File Offset: 0x007EFE30
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

	// Token: 0x0601C60F RID: 116239 RVA: 0x007F1D9C File Offset: 0x007EFF9C
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

	// Token: 0x0601C610 RID: 116240 RVA: 0x007F1E2A File Offset: 0x007F002A
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

	// Token: 0x0601C611 RID: 116241 RVA: 0x007F1E50 File Offset: 0x007F0050
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		GongduolaSplineMoveComponent gongduolaSplineMoveComponent = (GongduolaSplineMoveComponent)componentTemplate;
		if (base.CanResetComponentProperty("LastLockedInput"))
		{
			if (gongduolaSplineMoveComponent.LastLockedInput == null)
			{
				this.LastLockedInput = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.LastLockedInput), "LastLockedInput"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400E119 RID: 57625
	private const float UNLOCK_TURN_INPUT_MIN_ANGLE = 10f;

	// Token: 0x0400E11A RID: 57626
	private const float INPUT_ADJUST_FORWARD_MIN_YAW = 45f;

	// Token: 0x0400E11B RID: 57627
	private const float INPUT_ADJUST_FORWARD_MAX_YAW = 60f;

	// Token: 0x0400E11C RID: 57628
	protected Vector LastLockedInput = Vector.Create();
}
