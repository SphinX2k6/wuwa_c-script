using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003169 RID: 12649
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeAnimNotifyFoxTurnToTarget : CodeAnimNotifyBase<SpecialSkillAnimalFox>
{
	// Token: 0x0601B362 RID: 111458 RVA: 0x0076AAEC File Offset: 0x00768CEC
	public CodeAnimNotifyFoxTurnToTarget(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B363 RID: 111459 RVA: 0x0076ABA4 File Offset: 0x00768DA4
	public override void OnNotifyBegin(float totalDuration, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		Entity ownerEntity = this.SpecialSkill.GetOwnerEntity();
		if (!this.SpecialSkill.HasJumpTarget)
		{
			return;
		}
		CharacterActorComponent component = ownerEntity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return;
		}
		CharacterMoveComponent component2 = ownerEntity.GetComponent<CharacterMoveComponent>();
		if (component2 == null)
		{
			return;
		}
		this.ActorComp = component;
		this.TotalDuration = totalDuration;
		this.ElapsedTime = 0f;
		Vector actorLocationProxy = component.ActorLocationProxy;
		Vector jumpTarget = this.SpecialSkill.JumpTarget;
		Vector tmpDir = this.TmpDir;
		tmpDir.Set(jumpTarget.X - actorLocationProxy.X, jumpTarget.Y - actorLocationProxy.Y, jumpTarget.Z - actorLocationProxy.Z);
		Vector gravityDirect = component2.GravityDirect;
		double num = tmpDir.X * gravityDirect.X + tmpDir.Y * gravityDirect.Y + tmpDir.Z * gravityDirect.Z;
		tmpDir.Set(tmpDir.X - num * gravityDirect.X, tmpDir.Y - num * gravityDirect.Y, tmpDir.Z - num * gravityDirect.Z);
		tmpDir.Normalize(9.99999993922529E-09);
		Vector gravityUp = component2.GravityUp;
		MathUtils.Instance.LookRotationUpFirst(tmpDir, gravityUp, this.TargetQuat);
		Rotator actorRotationProxy = component.ActorRotationProxy;
		Rotator.Create(actorRotationProxy.Pitch, actorRotationProxy.Yaw, actorRotationProxy.Roll).Quaternion(this.StartQuat);
		Rotator outR = Rotator.Create();
		this.TargetQuat.Rotator(outR);
	}

	// Token: 0x0601B364 RID: 111460 RVA: 0x0076AD30 File Offset: 0x00768F30
	public override void OnNotifyTick(float delta, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		if (this.ActorComp == null || this.TotalDuration <= 0f)
		{
			return;
		}
		this.ElapsedTime = Math.Min(this.ElapsedTime + delta, this.TotalDuration);
		float slerp = this.ElapsedTime / this.TotalDuration;
		Quat.Slerp(this.StartQuat, this.TargetQuat, slerp, this.ResultQuat);
		this.ResultQuat.Rotator(this.ResultRotator);
		this.ActorComp.SetActorRotation(this.ResultRotator.ToUeRotator(), "CodeAnimNotifyFoxTurnToTarget", false);
	}

	// Token: 0x0601B365 RID: 111461 RVA: 0x0076ADC1 File Offset: 0x00768FC1
	public override void OnNotifyEnd(FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		this.ActorComp = null;
	}

	// Token: 0x0400D40C RID: 54284
	public const string EventName = "Fox.TurnToTarget";

	// Token: 0x0400D40D RID: 54285
	private readonly Vector TmpDir = Vector.Create();

	// Token: 0x0400D40E RID: 54286
	private readonly Quat StartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D40F RID: 54287
	private readonly Quat TargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D410 RID: 54288
	private readonly Quat ResultQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D411 RID: 54289
	private readonly Rotator ResultRotator = Rotator.Create();

	// Token: 0x0400D412 RID: 54290
	private float TotalDuration;

	// Token: 0x0400D413 RID: 54291
	private float ElapsedTime;

	// Token: 0x0400D414 RID: 54292
	[Nullable(2)]
	private CharacterActorComponent ActorComp;
}
