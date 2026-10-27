using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;

// Token: 0x0200010B RID: 267
[NullableContext(1)]
[Nullable(0)]
internal class AttachParams
{
	// Token: 0x06000FA1 RID: 4001 RVA: 0x0005A323 File Offset: 0x00058523
	public void Initialize(CharacterActorComponent actorComp, Vector attachTargetLocation, float totalDuration)
	{
		this.ElpasedDuration = 0f;
		this.TotalAnimDuration = totalDuration;
		AnimationUtils.GetRootLocationCurveValue(actorComp.Entity, this.PreFrameAnimLocation);
		AnimationUtils.GetRootLocationCurveValueWithDelta(actorComp.Entity, totalDuration, this.AnimEndLocation);
		this.UpdateAttachLocation(actorComp, attachTargetLocation);
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x0005A364 File Offset: 0x00058564
	public void UpdateAttachLocation(CharacterActorComponent actorComp, Vector attachEndLocation)
	{
		if (attachEndLocation.Equals(this.AttachEndLocation, 0.0001))
		{
			return;
		}
		this.AttachStartLocation.DeepCopy(actorComp.FloorLocation);
		this.AttachEndLocation.DeepCopy(attachEndLocation);
		this.AnimEndLocation.Subtraction(this.PreFrameAnimLocation, this.AnimDeltaLocation);
		this.UpdateAnimationScale();
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x0005A3C4 File Offset: 0x000585C4
	private void UpdateAnimationScale()
	{
		Vector tmpVector = AttachParams.TmpVector1;
		Vector tmpVector2 = AttachParams.TmpVector2;
		this.AttachEndLocation.Subtraction(this.AttachStartLocation, tmpVector);
		this.AttachRotator.Set(0f, (float)tmpVector.HeadingAngle(), 0f);
		MathUtils.Instance.InverseTransformPositionNoScale(Vector.ZeroVectorProxy, this.AttachRotator, this.AnimDeltaLocation, tmpVector2);
		this.AnimScale.Set((!MathUtils.Instance.IsNearlyZero(tmpVector2.X, new double?(0.0001))) ? (tmpVector.X / tmpVector2.X) : 1.0, (!MathUtils.Instance.IsNearlyZero(tmpVector2.Y, new double?(0.0001))) ? (tmpVector.Y / tmpVector2.Y) : 1.0, (!MathUtils.Instance.IsNearlyZero(tmpVector2.Z, new double?(0.0001))) ? (tmpVector.Z / tmpVector2.Z) : 1.0);
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x0005A4DC File Offset: 0x000586DC
	public Vector StepFrameLocationOffset(CharacterActorComponent actorComp, float frameDeltaTime)
	{
		this.ElpasedDuration += frameDeltaTime;
		Vector tmpVector = AttachParams.TmpVector1;
		Vector tmpVector2 = AttachParams.TmpVector2;
		Vector tmpVector3 = AttachParams.TmpVector3;
		if (this.ElpasedDuration > this.TotalAnimDuration)
		{
			tmpVector.DeepCopy(this.AnimEndLocation);
		}
		else
		{
			AnimationUtils.GetRootLocationCurveValue(actorComp.Entity, tmpVector);
		}
		tmpVector.Subtraction(this.PreFrameAnimLocation, tmpVector2);
		this.PreFrameAnimLocation.DeepCopy(tmpVector);
		MathUtils.Instance.InverseTransformPosition(Vector.ZeroVectorProxy, this.AttachRotator, this.AnimScale, tmpVector2, tmpVector3);
		return tmpVector3;
	}

	// Token: 0x04000C33 RID: 3123
	public Vector AttachStartLocation = Vector.Create();

	// Token: 0x04000C34 RID: 3124
	public Vector AttachEndLocation = Vector.Create();

	// Token: 0x04000C35 RID: 3125
	public Rotator AttachRotator = Rotator.Create();

	// Token: 0x04000C36 RID: 3126
	public Vector AnimEndLocation = Vector.Create();

	// Token: 0x04000C37 RID: 3127
	public Vector AnimDeltaLocation = Vector.Create();

	// Token: 0x04000C38 RID: 3128
	public Vector AnimScale = Vector.Create();

	// Token: 0x04000C39 RID: 3129
	public Vector PreFrameAnimLocation = Vector.Create();

	// Token: 0x04000C3A RID: 3130
	public float TotalAnimDuration;

	// Token: 0x04000C3B RID: 3131
	public float ElpasedDuration;

	// Token: 0x04000C3C RID: 3132
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x04000C3D RID: 3133
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000C3E RID: 3134
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector3 = Vector.Create();
}
