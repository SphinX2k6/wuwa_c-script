using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;

// Token: 0x0200010E RID: 270
[NullableContext(1)]
[Nullable(0)]
internal class AttachGroupMonsterParams
{
	// Token: 0x06000FE6 RID: 4070 RVA: 0x0005C5F3 File Offset: 0x0005A7F3
	public void Initialize(CharacterActorComponent actorComp, Vector attachTargetLocation, float totalDuration)
	{
		this.ElpasedDuration = 0f;
		this.TotalAnimDuration = totalDuration;
		AnimationUtils.GetRootLocationCurveValue(actorComp.Entity, this.PreFrameAnimLocation);
		AnimationUtils.GetRootLocationCurveValueWithDelta(actorComp.Entity, totalDuration, this.AnimEndLocation);
		this.UpdateAttachLocation(actorComp, attachTargetLocation);
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x0005C634 File Offset: 0x0005A834
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

	// Token: 0x06000FE8 RID: 4072 RVA: 0x0005C694 File Offset: 0x0005A894
	private void UpdateAnimationScale()
	{
		Vector tmpVector = AttachGroupMonsterParams.TmpVector1;
		Vector tmpVector2 = AttachGroupMonsterParams.TmpVector2;
		this.AttachEndLocation.Subtraction(this.AttachStartLocation, tmpVector);
		this.AttachRotator.Set(0f, (float)tmpVector.HeadingAngle(), 0f);
		MathUtils.Instance.InverseTransformPositionNoScale(Vector.ZeroVectorProxy, this.AttachRotator, this.AnimDeltaLocation, tmpVector2);
		this.AnimScale.Set((!MathUtils.Instance.IsNearlyZero(tmpVector2.X, new double?(0.0001))) ? (tmpVector.X / tmpVector2.X) : 1.0, (!MathUtils.Instance.IsNearlyZero(tmpVector2.Y, new double?(0.0001))) ? (tmpVector.Y / tmpVector2.Y) : 1.0, (!MathUtils.Instance.IsNearlyZero(tmpVector2.Z, new double?(0.0001))) ? (tmpVector.Z / tmpVector2.Z) : 1.0);
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x0005C7AC File Offset: 0x0005A9AC
	public Vector StepFrameLocationOffset(CharacterActorComponent actorComp, float frameDeltaTime)
	{
		this.ElpasedDuration += frameDeltaTime;
		Vector tmpVector = AttachGroupMonsterParams.TmpVector1;
		Vector tmpVector2 = AttachGroupMonsterParams.TmpVector2;
		Vector tmpVector3 = AttachGroupMonsterParams.TmpVector3;
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

	// Token: 0x04000C5E RID: 3166
	public Vector AttachStartLocation = Vector.Create();

	// Token: 0x04000C5F RID: 3167
	public Vector AttachEndLocation = Vector.Create();

	// Token: 0x04000C60 RID: 3168
	public Rotator AttachRotator = Rotator.Create();

	// Token: 0x04000C61 RID: 3169
	public Vector AnimEndLocation = Vector.Create();

	// Token: 0x04000C62 RID: 3170
	public Vector AnimDeltaLocation = Vector.Create();

	// Token: 0x04000C63 RID: 3171
	public Vector AnimScale = Vector.Create();

	// Token: 0x04000C64 RID: 3172
	public Vector PreFrameAnimLocation = Vector.Create();

	// Token: 0x04000C65 RID: 3173
	public float TotalAnimDuration;

	// Token: 0x04000C66 RID: 3174
	public float ElpasedDuration;

	// Token: 0x04000C67 RID: 3175
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x04000C68 RID: 3176
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000C69 RID: 3177
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector3 = Vector.Create();
}
