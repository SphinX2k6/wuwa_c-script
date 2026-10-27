using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;

// Token: 0x0200010E RID: 270
[NullableContext(1)]
[Nullable(0)]
internal class AttachGroupMonsterParams
{
	// Token: 0x06000FE0 RID: 4064 RVA: 0x0005B44B File Offset: 0x0005964B
	public void Initialize(CharacterActorComponent actorComp, Vector attachTargetLocation, float totalDuration)
	{
		this.ElpasedDuration = 0f;
		this.TotalAnimDuration = totalDuration;
		AnimationUtils.GetRootLocationCurveValue(actorComp.Entity, this.PreFrameAnimLocation);
		AnimationUtils.GetRootLocationCurveValueWithDelta(actorComp.Entity, totalDuration, this.AnimEndLocation);
		this.UpdateAttachLocation(actorComp, attachTargetLocation);
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x0005B48C File Offset: 0x0005968C
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

	// Token: 0x06000FE2 RID: 4066 RVA: 0x0005B4EC File Offset: 0x000596EC
	private void UpdateAnimationScale()
	{
		Vector tmpVector = AttachGroupMonsterParams.TmpVector1;
		Vector tmpVector2 = AttachGroupMonsterParams.TmpVector2;
		this.AttachEndLocation.Subtraction(this.AttachStartLocation, tmpVector);
		this.AttachRotator.Set(0f, (float)tmpVector.HeadingAngle(), 0f);
		MathUtils.Instance.InverseTransformPositionNoScale(Vector.ZeroVectorProxy, this.AttachRotator, this.AnimDeltaLocation, tmpVector2);
		this.AnimScale.Set((!MathUtils.Instance.IsNearlyZero(tmpVector2.X, new double?(0.0001))) ? (tmpVector.X / tmpVector2.X) : 1.0, (!MathUtils.Instance.IsNearlyZero(tmpVector2.Y, new double?(0.0001))) ? (tmpVector.Y / tmpVector2.Y) : 1.0, (!MathUtils.Instance.IsNearlyZero(tmpVector2.Z, new double?(0.0001))) ? (tmpVector.Z / tmpVector2.Z) : 1.0);
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x0005B604 File Offset: 0x00059804
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

	// Token: 0x04000C56 RID: 3158
	public Vector AttachStartLocation = Vector.Create();

	// Token: 0x04000C57 RID: 3159
	public Vector AttachEndLocation = Vector.Create();

	// Token: 0x04000C58 RID: 3160
	public Rotator AttachRotator = Rotator.Create();

	// Token: 0x04000C59 RID: 3161
	public Vector AnimEndLocation = Vector.Create();

	// Token: 0x04000C5A RID: 3162
	public Vector AnimDeltaLocation = Vector.Create();

	// Token: 0x04000C5B RID: 3163
	public Vector AnimScale = Vector.Create();

	// Token: 0x04000C5C RID: 3164
	public Vector PreFrameAnimLocation = Vector.Create();

	// Token: 0x04000C5D RID: 3165
	public float TotalAnimDuration;

	// Token: 0x04000C5E RID: 3166
	public float ElpasedDuration;

	// Token: 0x04000C5F RID: 3167
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x04000C60 RID: 3168
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000C61 RID: 3169
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector3 = Vector.Create();
}
