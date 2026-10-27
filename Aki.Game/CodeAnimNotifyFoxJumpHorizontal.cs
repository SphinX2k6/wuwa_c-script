using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02003166 RID: 12646
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeAnimNotifyFoxJumpHorizontal : CodeAnimNotifyBase<SpecialSkillAnimalFox>
{
	// Token: 0x0601B347 RID: 111431 RVA: 0x0076A13D File Offset: 0x0076833D
	public CodeAnimNotifyFoxJumpHorizontal(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B348 RID: 111432 RVA: 0x0076A151 File Offset: 0x00768351
	private void DoLand()
	{
		this.Landed = true;
		this.SpecialSkill.DoJumpLand();
	}

	// Token: 0x0601B349 RID: 111433 RVA: 0x0076A168 File Offset: 0x00768368
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

	// Token: 0x0601B34A RID: 111434 RVA: 0x0076A300 File Offset: 0x00768500
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

	// Token: 0x0601B34B RID: 111435 RVA: 0x0076A4B0 File Offset: 0x007686B0
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

	// Token: 0x0400D3EB RID: 54251
	public const string EventName = "Fox.JumpHorizontal";

	// Token: 0x0400D3EC RID: 54252
	private const float PEAK_HEIGHT = 15f;

	// Token: 0x0400D3ED RID: 54253
	private const float MS_PER_SECOND = 1000f;

	// Token: 0x0400D3EE RID: 54254
	private const float FIX_LOCATION_TOLERANCE = 5f;

	// Token: 0x0400D3EF RID: 54255
	private const float DEBUG_SPHERE_RADIUS = 5f;

	// Token: 0x0400D3F0 RID: 54256
	private readonly Vector TmpOffset = Vector.Create();

	// Token: 0x0400D3F1 RID: 54257
	private float StartX;

	// Token: 0x0400D3F2 RID: 54258
	private float StartY;

	// Token: 0x0400D3F3 RID: 54259
	private float StartZ;

	// Token: 0x0400D3F4 RID: 54260
	private float TargetX;

	// Token: 0x0400D3F5 RID: 54261
	private float TargetY;

	// Token: 0x0400D3F6 RID: 54262
	private float TargetZ;

	// Token: 0x0400D3F7 RID: 54263
	private float Gravity;

	// Token: 0x0400D3F8 RID: 54264
	private float InitialVz;

	// Token: 0x0400D3F9 RID: 54265
	private float TotalFlightTime;

	// Token: 0x0400D3FA RID: 54266
	private float Elapsed;

	// Token: 0x0400D3FB RID: 54267
	private bool Landed;

	// Token: 0x0400D3FC RID: 54268
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D3FD RID: 54269
	[Nullable(2)]
	private CharacterActorComponent ActorComp;
}
