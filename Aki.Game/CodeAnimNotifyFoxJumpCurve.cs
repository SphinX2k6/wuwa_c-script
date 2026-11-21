using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020026D1 RID: 9937
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeAnimNotifyFoxJumpCurve : CodeAnimNotifyBase<SpecialSkillAnimalFox>
{
	// Token: 0x06018E42 RID: 101954 RVA: 0x00791237 File Offset: 0x0078F437
	public CodeAnimNotifyFoxJumpCurve(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018E43 RID: 101955 RVA: 0x0079124B File Offset: 0x0078F44B
	private void DoLand()
	{
		this.Landed = true;
		this.SpecialSkill.DoJumpLand();
	}

	// Token: 0x06018E44 RID: 101956 RVA: 0x00791260 File Offset: 0x0078F460
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

	// Token: 0x06018E45 RID: 101957 RVA: 0x00791440 File Offset: 0x0078F640
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

	// Token: 0x06018E46 RID: 101958 RVA: 0x00791584 File Offset: 0x0078F784
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

	// Token: 0x0400D822 RID: 55330
	public const string EventName = "Fox.JumpCurve";

	// Token: 0x0400D823 RID: 55331
	private const float FIX_LOCATION_TOLERANCE = 2f;

	// Token: 0x0400D824 RID: 55332
	private const float MS_PER_SECOND = 1000f;

	// Token: 0x0400D825 RID: 55333
	private const float DEBUG_SPHERE_RADIUS = 5f;

	// Token: 0x0400D826 RID: 55334
	private readonly Vector TmpOffset = Vector.Create();

	// Token: 0x0400D827 RID: 55335
	private float StartX;

	// Token: 0x0400D828 RID: 55336
	private float StartY;

	// Token: 0x0400D829 RID: 55337
	private float StartZ;

	// Token: 0x0400D82A RID: 55338
	private float DirX;

	// Token: 0x0400D82B RID: 55339
	private float DirY;

	// Token: 0x0400D82C RID: 55340
	private float TargetX;

	// Token: 0x0400D82D RID: 55341
	private float TargetY;

	// Token: 0x0400D82E RID: 55342
	private float TargetZ;

	// Token: 0x0400D82F RID: 55343
	private float HorizontalDist;

	// Token: 0x0400D830 RID: 55344
	private float VerticalDist;

	// Token: 0x0400D831 RID: 55345
	private float TotalDuration;

	// Token: 0x0400D832 RID: 55346
	private float Elapsed;

	// Token: 0x0400D833 RID: 55347
	private bool Landed;

	// Token: 0x0400D834 RID: 55348
	[Nullable(2)]
	private UCurveFloat JumpCurve;

	// Token: 0x0400D835 RID: 55349
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D836 RID: 55350
	[Nullable(2)]
	private CharacterActorComponent ActorComp;
}
