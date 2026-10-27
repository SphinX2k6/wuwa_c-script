using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02003165 RID: 12645
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeAnimNotifyFoxJumpHeight : CodeAnimNotifyBase<SpecialSkillAnimalFox>
{
	// Token: 0x0601B342 RID: 111426 RVA: 0x00769CBC File Offset: 0x00767EBC
	public CodeAnimNotifyFoxJumpHeight(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B343 RID: 111427 RVA: 0x00769CD0 File Offset: 0x00767ED0
	private void DoLand()
	{
		this.Landed = true;
		this.SpecialSkill.DoJumpLand();
	}

	// Token: 0x0601B344 RID: 111428 RVA: 0x00769CE4 File Offset: 0x00767EE4
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
		Vector actorLocationProxy = component.ActorLocationProxy;
		Vector jumpTarget = this.SpecialSkill.JumpTarget;
		float num = this.SpecialSkill.TraceJumpGroundZ(jumpTarget);
		this.StartX = (float)actorLocationProxy.X;
		this.StartY = (float)actorLocationProxy.Y;
		this.StartZ = (float)actorLocationProxy.Z;
		float num2 = (float)(jumpTarget.X - actorLocationProxy.X);
		float num3 = (float)(jumpTarget.Y - actorLocationProxy.Y);
		float num4 = (float)Math.Sqrt((double)(num2 * num2 + num3 * num3));
		if (num4 > 0f)
		{
			this.DirX = num2 / num4;
			this.DirY = num3 / num4;
		}
		else
		{
			this.DirX = 0f;
			this.DirY = 0f;
		}
		float num5 = num - (float)actorLocationProxy.Z + component.ScaledHalfHeight + 2f;
		this.TargetX = (float)jumpTarget.X;
		this.TargetY = (float)jumpTarget.Y;
		this.TargetZ = this.StartZ + num5;
		this.HorizontalDist = num4;
		this.VerticalDist = num5;
		this.TotalDuration = totalDuration;
		this.Elapsed = 0f;
		this.Landed = false;
		float num7;
		float num6 = payload.FloatValues.TryGetValue("Height", out num7) ? num7 : 50f;
		bool flag2;
		bool flag = payload.BoolValues.TryGetValue("CompareHigher", out flag2) && flag2;
		if (flag || Math.Abs(num5) <= num6)
		{
			this.JumpMode = 0;
			float num8 = flag ? (Math.Max(0f, num5) + num6) : (Math.Min(0f, num5) + num6);
			this.ArcAdd = 2f * num8 - num5 + 2f * (float)Math.Sqrt((double)(num8 * (num8 - num5)));
		}
		else if (num5 > 0f)
		{
			this.JumpMode = 1;
		}
		else
		{
			this.JumpMode = 2;
		}
		this.SpecialSkill.PrepareJumpMovement();
	}

	// Token: 0x0601B345 RID: 111429 RVA: 0x00769F28 File Offset: 0x00768128
	public override void OnNotifyTick(float delta, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		if (this.MoveComp == null || this.ActorComp == null || this.Landed)
		{
			return;
		}
		this.Elapsed += delta;
		float num = Math.Min(this.Elapsed / this.TotalDuration, 1f);
		float num2 = this.StartX + this.DirX * this.HorizontalDist * num;
		float num3 = this.StartY + this.DirY * this.HorizontalDist * num;
		float num4;
		if (this.JumpMode == 1)
		{
			num4 = this.StartZ + this.VerticalDist * (2f * num - num * num);
		}
		else if (this.JumpMode == 2)
		{
			num4 = this.StartZ + this.VerticalDist * num * num;
		}
		else
		{
			num4 = this.StartZ + this.VerticalDist * num + this.ArcAdd * num * (1f - num);
		}
		Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		this.TmpOffset.Set((double)num2 - actorLocationProxy.X, (double)num3 - actorLocationProxy.Y, (double)num4 - actorLocationProxy.Z);
		this.MoveComp.MoveCharacter(this.TmpOffset, delta, "");
		if (num >= 1f)
		{
			this.DoLand();
			return;
		}
		bool flag;
		if (payload.BoolValues.TryGetValue("Debug", out flag) && flag)
		{
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, this.ActorComp.ActorLocation, 5f, 5, new FLinearColor?(ColorUtils.LinearCyan), 10f, 0f);
		}
	}

	// Token: 0x0601B346 RID: 111430 RVA: 0x0076A0A8 File Offset: 0x007682A8
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

	// Token: 0x0400D3D4 RID: 54228
	public const string EventName = "Fox.JumpHeight";

	// Token: 0x0400D3D5 RID: 54229
	private const float FIX_LOCATION_TOLERANCE = 2f;

	// Token: 0x0400D3D6 RID: 54230
	private const float DEFAULT_ARC_HEIGHT = 50f;

	// Token: 0x0400D3D7 RID: 54231
	private const float MS_PER_SECOND = 1000f;

	// Token: 0x0400D3D8 RID: 54232
	private const float DEBUG_SPHERE_RADIUS = 5f;

	// Token: 0x0400D3D9 RID: 54233
	private readonly Vector TmpOffset = Vector.Create();

	// Token: 0x0400D3DA RID: 54234
	private float StartX;

	// Token: 0x0400D3DB RID: 54235
	private float StartY;

	// Token: 0x0400D3DC RID: 54236
	private float StartZ;

	// Token: 0x0400D3DD RID: 54237
	private float DirX;

	// Token: 0x0400D3DE RID: 54238
	private float DirY;

	// Token: 0x0400D3DF RID: 54239
	private float TargetX;

	// Token: 0x0400D3E0 RID: 54240
	private float TargetY;

	// Token: 0x0400D3E1 RID: 54241
	private float TargetZ;

	// Token: 0x0400D3E2 RID: 54242
	private float HorizontalDist;

	// Token: 0x0400D3E3 RID: 54243
	private float VerticalDist;

	// Token: 0x0400D3E4 RID: 54244
	private float TotalDuration;

	// Token: 0x0400D3E5 RID: 54245
	private float Elapsed;

	// Token: 0x0400D3E6 RID: 54246
	private int JumpMode;

	// Token: 0x0400D3E7 RID: 54247
	private float ArcAdd;

	// Token: 0x0400D3E8 RID: 54248
	private bool Landed;

	// Token: 0x0400D3E9 RID: 54249
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D3EA RID: 54250
	[Nullable(2)]
	private CharacterActorComponent ActorComp;
}
