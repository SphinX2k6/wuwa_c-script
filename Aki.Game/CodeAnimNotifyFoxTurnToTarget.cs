using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026D6 RID: 9942
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeAnimNotifyFoxTurnToTarget : CodeAnimNotifyBase<SpecialSkillAnimalFox>
{
	// Token: 0x06018E67 RID: 101991 RVA: 0x00792450 File Offset: 0x00790650
	public CodeAnimNotifyFoxTurnToTarget(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018E68 RID: 101992 RVA: 0x00792508 File Offset: 0x00790708
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

	// Token: 0x06018E69 RID: 101993 RVA: 0x00792694 File Offset: 0x00790894
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

	// Token: 0x06018E6A RID: 101994 RVA: 0x00792725 File Offset: 0x00790925
	public override void OnNotifyEnd(FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		this.ActorComp = null;
	}

	// Token: 0x0400D86F RID: 55407
	public const string EventName = "Fox.TurnToTarget";

	// Token: 0x0400D870 RID: 55408
	private readonly Vector TmpDir = Vector.Create();

	// Token: 0x0400D871 RID: 55409
	private readonly Quat StartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D872 RID: 55410
	private readonly Quat TargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D873 RID: 55411
	private readonly Quat ResultQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D874 RID: 55412
	private readonly Rotator ResultRotator = Rotator.Create();

	// Token: 0x0400D875 RID: 55413
	private float TotalDuration;

	// Token: 0x0400D876 RID: 55414
	private float ElapsedTime;

	// Token: 0x0400D877 RID: 55415
	[Nullable(2)]
	private CharacterActorComponent ActorComp;
}
