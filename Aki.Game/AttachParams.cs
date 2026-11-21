using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;

// Token: 0x0200010B RID: 267
[NullableContext(1)]
[Nullable(0)]
internal class AttachParams
{
	// Token: 0x06000FA7 RID: 4007 RVA: 0x0005B427 File Offset: 0x00059627
	public void Initialize(CharacterActorComponent actorComp, Vector attachTargetLocation, float totalDuration)
	{
		this.ElpasedDuration = 0f;
		this.TotalAnimDuration = totalDuration;
		AnimationUtils.GetRootLocationCurveValue(actorComp.Entity, this.PreFrameAnimLocation);
		AnimationUtils.GetRootLocationCurveValueWithDelta(actorComp.Entity, totalDuration, this.AnimEndLocation);
		this.UpdateAttachLocation(actorComp, attachTargetLocation);
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x0005B468 File Offset: 0x00059668
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

	// Token: 0x06000FA9 RID: 4009 RVA: 0x0005B4C8 File Offset: 0x000596C8
	private void UpdateAnimationScale()
	{
		Vector tmpVector = AttachParams.TmpVector1;
		Vector tmpVector2 = AttachParams.TmpVector2;
		this.AttachEndLocation.Subtraction(this.AttachStartLocation, tmpVector);
		this.AttachRotator.Set(0f, (float)tmpVector.HeadingAngle(), 0f);
		MathUtils.Instance.InverseTransformPositionNoScale(Vector.ZeroVectorProxy, this.AttachRotator, this.AnimDeltaLocation, tmpVector2);
		this.AnimScale.Set((!MathUtils.Instance.IsNearlyZero(tmpVector2.X, new double?(0.0001))) ? (tmpVector.X / tmpVector2.X) : 1.0, (!MathUtils.Instance.IsNearlyZero(tmpVector2.Y, new double?(0.0001))) ? (tmpVector.Y / tmpVector2.Y) : 1.0, (!MathUtils.Instance.IsNearlyZero(tmpVector2.Z, new double?(0.0001))) ? (tmpVector.Z / tmpVector2.Z) : 1.0);
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x0005B5E0 File Offset: 0x000597E0
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

	// Token: 0x04000C3B RID: 3131
	public Vector AttachStartLocation = Vector.Create();

	// Token: 0x04000C3C RID: 3132
	public Vector AttachEndLocation = Vector.Create();

	// Token: 0x04000C3D RID: 3133
	public Rotator AttachRotator = Rotator.Create();

	// Token: 0x04000C3E RID: 3134
	public Vector AnimEndLocation = Vector.Create();

	// Token: 0x04000C3F RID: 3135
	public Vector AnimDeltaLocation = Vector.Create();

	// Token: 0x04000C40 RID: 3136
	public Vector AnimScale = Vector.Create();

	// Token: 0x04000C41 RID: 3137
	public Vector PreFrameAnimLocation = Vector.Create();

	// Token: 0x04000C42 RID: 3138
	public float TotalAnimDuration;

	// Token: 0x04000C43 RID: 3139
	public float ElpasedDuration;

	// Token: 0x04000C44 RID: 3140
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x04000C45 RID: 3141
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000C46 RID: 3142
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector3 = Vector.Create();
}
