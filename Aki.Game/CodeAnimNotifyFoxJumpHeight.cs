using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020026D2 RID: 9938
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeAnimNotifyFoxJumpHeight : CodeAnimNotifyBase<SpecialSkillAnimalFox>
{
	// Token: 0x06018E47 RID: 101959 RVA: 0x00791620 File Offset: 0x0078F820
	public CodeAnimNotifyFoxJumpHeight(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018E48 RID: 101960 RVA: 0x00791634 File Offset: 0x0078F834
	private void DoLand()
	{
		this.Landed = true;
		this.SpecialSkill.DoJumpLand();
	}

	// Token: 0x06018E49 RID: 101961 RVA: 0x00791648 File Offset: 0x0078F848
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

	// Token: 0x06018E4A RID: 101962 RVA: 0x0079188C File Offset: 0x0078FA8C
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

	// Token: 0x06018E4B RID: 101963 RVA: 0x00791A0C File Offset: 0x0078FC0C
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

	// Token: 0x0400D837 RID: 55351
	public const string EventName = "Fox.JumpHeight";

	// Token: 0x0400D838 RID: 55352
	private const float FIX_LOCATION_TOLERANCE = 2f;

	// Token: 0x0400D839 RID: 55353
	private const float DEFAULT_ARC_HEIGHT = 50f;

	// Token: 0x0400D83A RID: 55354
	private const float MS_PER_SECOND = 1000f;

	// Token: 0x0400D83B RID: 55355
	private const float DEBUG_SPHERE_RADIUS = 5f;

	// Token: 0x0400D83C RID: 55356
	private readonly Vector TmpOffset = Vector.Create();

	// Token: 0x0400D83D RID: 55357
	private float StartX;

	// Token: 0x0400D83E RID: 55358
	private float StartY;

	// Token: 0x0400D83F RID: 55359
	private float StartZ;

	// Token: 0x0400D840 RID: 55360
	private float DirX;

	// Token: 0x0400D841 RID: 55361
	private float DirY;

	// Token: 0x0400D842 RID: 55362
	private float TargetX;

	// Token: 0x0400D843 RID: 55363
	private float TargetY;

	// Token: 0x0400D844 RID: 55364
	private float TargetZ;

	// Token: 0x0400D845 RID: 55365
	private float HorizontalDist;

	// Token: 0x0400D846 RID: 55366
	private float VerticalDist;

	// Token: 0x0400D847 RID: 55367
	private float TotalDuration;

	// Token: 0x0400D848 RID: 55368
	private float Elapsed;

	// Token: 0x0400D849 RID: 55369
	private int JumpMode;

	// Token: 0x0400D84A RID: 55370
	private float ArcAdd;

	// Token: 0x0400D84B RID: 55371
	private bool Landed;

	// Token: 0x0400D84C RID: 55372
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D84D RID: 55373
	[Nullable(2)]
	private CharacterActorComponent ActorComp;
}
