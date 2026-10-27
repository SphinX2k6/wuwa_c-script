using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability
{
	// Token: 0x02004764 RID: 18276
	[NullableContext(1)]
	[Nullable(0)]
	public class HurtCapability : CapabilityBase
	{
		// Token: 0x0602FC66 RID: 195686 RVA: 0x00B116AA File Offset: 0x00B0F8AA
		public HurtCapability(WuWaGoRole role) : base(role)
		{
		}

		// Token: 0x0602FC67 RID: 195687 RVA: 0x00B116B4 File Offset: 0x00B0F8B4
		[NullableContext(2)]
		public UniTask TakeAttack(bool playBeHitAnim, UAnimMontage deathMontage = null)
		{
			HurtCapability.<TakeAttack>d__10 <TakeAttack>d__;
			<TakeAttack>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TakeAttack>d__.<>4__this = this;
			<TakeAttack>d__.playBeHitAnim = playBeHitAnim;
			<TakeAttack>d__.deathMontage = deathMontage;
			<TakeAttack>d__.<>1__state = -1;
			<TakeAttack>d__.<>t__builder.Start<HurtCapability.<TakeAttack>d__10>(ref <TakeAttack>d__);
			return <TakeAttack>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC68 RID: 195688 RVA: 0x00B11708 File Offset: 0x00B0F908
		private UniTask PerformBeAttackAnim()
		{
			HurtCapability.<PerformBeAttackAnim>d__11 <PerformBeAttackAnim>d__;
			<PerformBeAttackAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PerformBeAttackAnim>d__.<>4__this = this;
			<PerformBeAttackAnim>d__.<>1__state = -1;
			<PerformBeAttackAnim>d__.<>t__builder.Start<HurtCapability.<PerformBeAttackAnim>d__11>(ref <PerformBeAttackAnim>d__);
			return <PerformBeAttackAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC69 RID: 195689 RVA: 0x00B1174C File Offset: 0x00B0F94C
		[NullableContext(2)]
		private UniTask PerformDeathAnim(UAnimMontage deathMontage = null)
		{
			HurtCapability.<PerformDeathAnim>d__12 <PerformDeathAnim>d__;
			<PerformDeathAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PerformDeathAnim>d__.<>4__this = this;
			<PerformDeathAnim>d__.deathMontage = deathMontage;
			<PerformDeathAnim>d__.<>1__state = -1;
			<PerformDeathAnim>d__.<>t__builder.Start<HurtCapability.<PerformDeathAnim>d__12>(ref <PerformDeathAnim>d__);
			return <PerformDeathAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC6A RID: 195690 RVA: 0x00B11798 File Offset: 0x00B0F998
		private UniTask PerformClimbDeathSequence(UAnimMontage montage)
		{
			HurtCapability.<PerformClimbDeathSequence>d__13 <PerformClimbDeathSequence>d__;
			<PerformClimbDeathSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PerformClimbDeathSequence>d__.<>4__this = this;
			<PerformClimbDeathSequence>d__.montage = montage;
			<PerformClimbDeathSequence>d__.<>1__state = -1;
			<PerformClimbDeathSequence>d__.<>t__builder.Start<HurtCapability.<PerformClimbDeathSequence>d__13>(ref <PerformClimbDeathSequence>d__);
			return <PerformClimbDeathSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC6B RID: 195691 RVA: 0x00B117E4 File Offset: 0x00B0F9E4
		private HurtCapability.EClimbDeathPhase OnClimbDeathTick(UAnimInstance animInstance, UAnimMontage montage, float? groundZ, float delta, HurtCapability.EClimbDeathPhase phase)
		{
			FVectorDouble? worldLocation = this.Role.GetWorldLocation();
			if (worldLocation == null)
			{
				return phase;
			}
			FVectorDouble value = worldLocation.Value;
			switch (phase)
			{
			case HurtCapability.EClimbDeathPhase.BeforeLoop:
				if (animInstance.Montage_GetCurrentSection(montage) == HurtCapability.SectionLoop)
				{
					return HurtCapability.EClimbDeathPhase.Falling;
				}
				return phase;
			case HurtCapability.EClimbDeathPhase.Falling:
			{
				if (groundZ == null)
				{
					return phase;
				}
				BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
				int? num = (setting != null) ? new int?(setting.CharacterMoveSpeed) : null;
				float num2 = (float)((num > 0) ? num.Value : 200) * WuWaGoUtil.GetMontagePlayRate() * delta / 1000f;
				double num3 = value.Z - (double)num2;
				if (num3 <= (double)groundZ.Value)
				{
					HurtCapability.DeathSnapTempLocation.Set(value.X, value.Y, (double)groundZ.Value);
					this.Role.SetActorWorldLocation(HurtCapability.DeathSnapTempLocation, false);
					animInstance.Montage_JumpToSection(HurtCapability.SectionFall, montage);
					return HurtCapability.EClimbDeathPhase.Done;
				}
				HurtCapability.DeathSnapTempLocation.Set(value.X, value.Y, num3);
				this.Role.SetActorWorldLocation(HurtCapability.DeathSnapTempLocation, false);
				return phase;
			}
			}
			return phase;
		}

		// Token: 0x0602FC6C RID: 195692 RVA: 0x00B11924 File Offset: 0x00B0FB24
		private float? SolveGroundZ()
		{
			FVectorDouble? worldLocation = this.Role.GetWorldLocation();
			if (worldLocation == null)
			{
				return null;
			}
			FVectorDouble value = worldLocation.Value;
			UWorld world = GlobalData.World;
			AActor aactor = this.Role.GetActorAsObject() as AActor;
			if (world == null || (aactor == null || !aactor.IsValid()))
			{
				return null;
			}
			UTraceLineElement traceTypeElement = TraceElementModel.Instance.GetTraceTypeElement<UTraceLineElement>(KuroTraceTypeQuery.IkGround, world, false, true);
			traceTypeElement.ActorsToIgnore.Add(aactor);
			HurtCapability.DeathSnapTempLocation.Set(value.X, value.Y, value.Z + 50.0);
			TraceElementCommon.Instance.SetStartLocation(traceTypeElement, HurtCapability.DeathSnapTempLocation);
			HurtCapability.DeathSnapTempLocation.Set(value.X, value.Y, value.Z + -5000.0);
			TraceElementCommon.Instance.SetEndLocation(traceTypeElement, HurtCapability.DeathSnapTempLocation);
			if (!TraceElementCommon.Instance.LineTrace(traceTypeElement, "WuWaGo.ClimbDeath.Ground"))
			{
				return null;
			}
			UKuroHitResult hitResult = traceTypeElement.HitResult;
			if (hitResult == null)
			{
				return null;
			}
			int num = hitResult.Actors.Num();
			for (int i = 0; i < num; i++)
			{
				AActor aactor2 = hitResult.Actors.Get(i).Get();
				if (aactor2 != null && aactor2.IsValid() && aactor2 is BP_WuWaGo_LandBox_C)
				{
					return new float?(hitResult.ImpactPointZ_Array.Get(i) + this.Role.GetCapsuleHalfHeight());
				}
			}
			return null;
		}

		// Token: 0x0602FC6D RID: 195693 RVA: 0x00B11AD2 File Offset: 0x00B0FCD2
		private bool ShouldWaitAnimBeforeExit()
		{
			return base.RoleType == EWuWaGoRoleType.AircraftSoldiers;
		}

		// Token: 0x04019C5C RID: 105564
		[StaticVariableRuleIgnore]
		private static readonly FName SectionLoop = new FName("Loop");

		// Token: 0x04019C5D RID: 105565
		[StaticVariableRuleIgnore]
		private static readonly FName SectionFall = new FName("End");

		// Token: 0x04019C5E RID: 105566
		private const int FALLBACK_FALL_SPEED = 200;

		// Token: 0x04019C5F RID: 105567
		private const int GROUND_TRACE_START_OFFSET = 50;

		// Token: 0x04019C60 RID: 105568
		private const int GROUND_TRACE_END_OFFSET = -5000;

		// Token: 0x04019C61 RID: 105569
		private const int SECTION_POLL_INTERVAL_MS = 20;

		// Token: 0x04019C62 RID: 105570
		private const int MS_PER_SECOND = 1000;

		// Token: 0x04019C63 RID: 105571
		[StaticVariableRuleIgnore]
		private static readonly Vector DeathSnapTempLocation = Vector.Create();

		// Token: 0x0200A9D6 RID: 43478
		[NullableContext(0)]
		private enum EClimbDeathPhase
		{
			// Token: 0x04033AFE RID: 211710
			BeforeLoop,
			// Token: 0x04033AFF RID: 211711
			Falling,
			// Token: 0x04033B00 RID: 211712
			Done
		}
	}
}
