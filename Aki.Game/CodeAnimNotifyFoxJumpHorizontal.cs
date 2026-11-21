using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020026D3 RID: 9939
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeAnimNotifyFoxJumpHorizontal : CodeAnimNotifyBase<SpecialSkillAnimalFox>
{
	// Token: 0x06018E4C RID: 101964 RVA: 0x00791AA1 File Offset: 0x0078FCA1
	public CodeAnimNotifyFoxJumpHorizontal(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018E4D RID: 101965 RVA: 0x00791AB5 File Offset: 0x0078FCB5
	private void DoLand()
	{
		this.Landed = true;
		this.SpecialSkill.DoJumpLand();
	}

	// Token: 0x06018E4E RID: 101966 RVA: 0x00791ACC File Offset: 0x0078FCCC
	public override void OnNotifyBegin(float totalDuration, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		if (!this.SpecialSkill.HasJumpTarget || this.SpecialSkill.JumpTarget.IsNearlyZero(9.999999747378752E-05))
		{
			return;
		}
		Entity ownerEntity = this.SpecialSkill.GetOwnerEntity();
		CharacterActorComponent component = ownerEntity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return;
		}
		this.MoveComp = ownerEntity.GetComponent<CharacterMoveComponent>();
		if (this.MoveComp == null)
		{
			return;
		}
		this.ActorComp = component;
		UCharacterMovementComponent characterMovement = this.MoveComp.CharacterMovement;
		if (characterMovement == null)
		{
			return;
		}
		Vector actorLocationProxy = component.ActorLocationProxy;
		Vector jumpTarget = this.SpecialSkill.JumpTarget;
		this.StartX = (float)actorLocationProxy.X;
		this.StartY = (float)actorLocationProxy.Y;
		this.StartZ = (float)actorLocationProxy.Z;
		this.TargetX = (float)jumpTarget.X;
		this.TargetY = (float)jumpTarget.Y;
		this.TargetZ = this.SpecialSkill.TraceJumpGroundZ(jumpTarget) + component.ScaledHalfHeight + 5f;
		float num = -characterMovement.GetGravityZ();
		this.Gravity = num;
		float num2 = 15f;
		this.InitialVz = (float)Math.Sqrt((double)(2f * num * num2));
		float num3 = (float)Math.Sqrt((double)(2f * num2 / num));
		float num4 = (float)actorLocationProxy.Z + num2 - this.TargetZ;
		if (num4 <= 0f)
		{
			this.TotalFlightTime = num3;
		}
		else
		{
			float num5 = (float)Math.Sqrt((double)(2f * num4 / num));
			this.TotalFlightTime = num3 + num5;
		}
		this.Elapsed = 0f;
		this.Landed = false;
		this.SpecialSkill.PrepareJumpMovement();
	}

	// Token: 0x06018E4F RID: 101967 RVA: 0x00791C64 File Offset: 0x0078FE64
	public override void OnNotifyTick(float delta, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		if (this.MoveComp == null || this.ActorComp == null || this.Landed)
		{
			return;
		}
		this.Elapsed += delta;
		Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		bool flag;
		if (payload.BoolValues.TryGetValue("Debug", out flag) && flag)
		{
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, this.ActorComp.ActorLocation, 5f, 5, new FLinearColor?(ColorUtils.LinearCyan), 10f, 0f);
		}
		if (this.Elapsed >= this.TotalFlightTime)
		{
			this.TmpOffset.Set((double)this.TargetX - actorLocationProxy.X, (double)this.TargetY - actorLocationProxy.Y, (double)this.TargetZ - actorLocationProxy.Z);
			this.MoveComp.MoveCharacter(this.TmpOffset, delta, "");
			this.DoLand();
			return;
		}
		float elapsed = this.Elapsed;
		float num = elapsed / this.TotalFlightTime;
		float num2 = this.StartX + (this.TargetX - this.StartX) * num;
		float num3 = this.StartY + (this.TargetY - this.StartY) * num;
		float num4 = this.StartZ + this.InitialVz * elapsed - 0.5f * this.Gravity * elapsed * elapsed;
		this.TmpOffset.Set((double)num2 - actorLocationProxy.X, (double)num3 - actorLocationProxy.Y, (double)num4 - actorLocationProxy.Z);
		this.MoveComp.MoveCharacter(this.TmpOffset, delta, "");
		if ((float)this.ActorComp.ActorLocationProxy.Z - this.TargetZ <= 5f)
		{
			this.DoLand();
		}
	}

	// Token: 0x06018E50 RID: 101968 RVA: 0x00791E14 File Offset: 0x00790014
	public override void OnNotifyEnd(FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		if (this.MoveComp != null && this.ActorComp != null && !this.Landed)
		{
			Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
			this.TmpOffset.Set((double)this.TargetX - actorLocationProxy.X, (double)this.TargetY - actorLocationProxy.Y, (double)this.TargetZ - actorLocationProxy.Z);
			this.MoveComp.MoveCharacter(this.TmpOffset, 0f, "");
			this.DoLand();
		}
		this.MoveComp = null;
		this.ActorComp = null;
	}

	// Token: 0x0400D84E RID: 55374
	public const string EventName = "Fox.JumpHorizontal";

	// Token: 0x0400D84F RID: 55375
	private const float PEAK_HEIGHT = 15f;

	// Token: 0x0400D850 RID: 55376
	private const float MS_PER_SECOND = 1000f;

	// Token: 0x0400D851 RID: 55377
	private const float FIX_LOCATION_TOLERANCE = 5f;

	// Token: 0x0400D852 RID: 55378
	private const float DEBUG_SPHERE_RADIUS = 5f;

	// Token: 0x0400D853 RID: 55379
	private readonly Vector TmpOffset = Vector.Create();

	// Token: 0x0400D854 RID: 55380
	private float StartX;

	// Token: 0x0400D855 RID: 55381
	private float StartY;

	// Token: 0x0400D856 RID: 55382
	private float StartZ;

	// Token: 0x0400D857 RID: 55383
	private float TargetX;

	// Token: 0x0400D858 RID: 55384
	private float TargetY;

	// Token: 0x0400D859 RID: 55385
	private float TargetZ;

	// Token: 0x0400D85A RID: 55386
	private float Gravity;

	// Token: 0x0400D85B RID: 55387
	private float InitialVz;

	// Token: 0x0400D85C RID: 55388
	private float TotalFlightTime;

	// Token: 0x0400D85D RID: 55389
	private float Elapsed;

	// Token: 0x0400D85E RID: 55390
	private bool Landed;

	// Token: 0x0400D85F RID: 55391
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D860 RID: 55392
	[Nullable(2)]
	private CharacterActorComponent ActorComp;
}
