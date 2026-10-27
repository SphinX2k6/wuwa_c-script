using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02003164 RID: 12644
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeAnimNotifyFoxJumpCurve : CodeAnimNotifyBase<SpecialSkillAnimalFox>
{
	// Token: 0x0601B33D RID: 111421 RVA: 0x007698D3 File Offset: 0x00767AD3
	public CodeAnimNotifyFoxJumpCurve(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B33E RID: 111422 RVA: 0x007698E7 File Offset: 0x00767AE7
	private void DoLand()
	{
		this.Landed = true;
		this.SpecialSkill.DoJumpLand();
	}

	// Token: 0x0601B33F RID: 111423 RVA: 0x007698FC File Offset: 0x00767AFC
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
		UObject uobject;
		if (payload.ObjectValues.TryGetValue("JumpCurve", out uobject))
		{
			UCurveFloat ucurveFloat = uobject as UCurveFloat;
			if (ucurveFloat != null)
			{
				this.ActorComp = component;
				this.JumpCurve = ucurveFloat;
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
				this.SpecialSkill.PrepareJumpMovement();
				return;
			}
		}
		Log.Instance.Error(ELogModule.Character, ELogAuthor.CWZ, "[FoxJump.Curve] payload 缺少 JumpCurve，跳过移动", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601B340 RID: 111424 RVA: 0x00769ADC File Offset: 0x00767CDC
	public override void OnNotifyTick(float delta, FKuroCodeFunctionPayload payload, [Nullable(2)] UAnimSequenceBase animation)
	{
		if (this.MoveComp == null || this.ActorComp == null || this.JumpCurve == null || this.Landed)
		{
			return;
		}
		this.Elapsed += delta;
		float num = Math.Min(this.Elapsed / this.TotalDuration, 1f);
		float num2 = this.StartX + this.DirX * this.HorizontalDist * num;
		float num3 = this.StartY + this.DirY * this.HorizontalDist * num;
		float floatValue = this.JumpCurve.GetFloatValue(num);
		float num4 = this.StartZ + this.VerticalDist * floatValue;
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

	// Token: 0x0601B341 RID: 111425 RVA: 0x00769C20 File Offset: 0x00767E20
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
		this.JumpCurve = null;
	}

	// Token: 0x0400D3BF RID: 54207
	public const string EventName = "Fox.JumpCurve";

	// Token: 0x0400D3C0 RID: 54208
	private const float FIX_LOCATION_TOLERANCE = 2f;

	// Token: 0x0400D3C1 RID: 54209
	private const float MS_PER_SECOND = 1000f;

	// Token: 0x0400D3C2 RID: 54210
	private const float DEBUG_SPHERE_RADIUS = 5f;

	// Token: 0x0400D3C3 RID: 54211
	private readonly Vector TmpOffset = Vector.Create();

	// Token: 0x0400D3C4 RID: 54212
	private float StartX;

	// Token: 0x0400D3C5 RID: 54213
	private float StartY;

	// Token: 0x0400D3C6 RID: 54214
	private float StartZ;

	// Token: 0x0400D3C7 RID: 54215
	private float DirX;

	// Token: 0x0400D3C8 RID: 54216
	private float DirY;

	// Token: 0x0400D3C9 RID: 54217
	private float TargetX;

	// Token: 0x0400D3CA RID: 54218
	private float TargetY;

	// Token: 0x0400D3CB RID: 54219
	private float TargetZ;

	// Token: 0x0400D3CC RID: 54220
	private float HorizontalDist;

	// Token: 0x0400D3CD RID: 54221
	private float VerticalDist;

	// Token: 0x0400D3CE RID: 54222
	private float TotalDuration;

	// Token: 0x0400D3CF RID: 54223
	private float Elapsed;

	// Token: 0x0400D3D0 RID: 54224
	private bool Landed;

	// Token: 0x0400D3D1 RID: 54225
	[Nullable(2)]
	private UCurveFloat JumpCurve;

	// Token: 0x0400D3D2 RID: 54226
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D3D3 RID: 54227
	[Nullable(2)]
	private CharacterActorComponent ActorComp;
}
