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
	// Token: 0x02003695 RID: 13973
	[NullableContext(1)]
	[Nullable(0)]
	public class HurtCapability : CapabilityBase
	{
		// Token: 0x06024430 RID: 148528 RVA: 0x00A4166A File Offset: 0x00A3F86A
		public HurtCapability(WuWaGoRole role) : base(role)
		{
		}

		// Token: 0x06024431 RID: 148529 RVA: 0x00A41674 File Offset: 0x00A3F874
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

		// Token: 0x06024432 RID: 148530 RVA: 0x00A416C8 File Offset: 0x00A3F8C8
		private UniTask PerformBeAttackAnim()
		{
			HurtCapability.<PerformBeAttackAnim>d__11 <PerformBeAttackAnim>d__;
			<PerformBeAttackAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PerformBeAttackAnim>d__.<>4__this = this;
			<PerformBeAttackAnim>d__.<>1__state = -1;
			<PerformBeAttackAnim>d__.<>t__builder.Start<HurtCapability.<PerformBeAttackAnim>d__11>(ref <PerformBeAttackAnim>d__);
			return <PerformBeAttackAnim>d__.<>t__builder.Task;
		}

		// Token: 0x06024433 RID: 148531 RVA: 0x00A4170C File Offset: 0x00A3F90C
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

		// Token: 0x06024434 RID: 148532 RVA: 0x00A41758 File Offset: 0x00A3F958
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

		// Token: 0x06024435 RID: 148533 RVA: 0x00A417A4 File Offset: 0x00A3F9A4
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

		// Token: 0x06024436 RID: 148534 RVA: 0x00A418E4 File Offset: 0x00A3FAE4
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

		// Token: 0x06024437 RID: 148535 RVA: 0x00A41A92 File Offset: 0x00A3FC92
		private bool ShouldWaitAnimBeforeExit()
		{
			return base.RoleType == EWuWaGoRoleType.AircraftSoldiers;
		}

		// Token: 0x0401430C RID: 82700
		[StaticVariableRuleIgnore]
		private static readonly FName SectionLoop = new FName("Loop");

		// Token: 0x0401430D RID: 82701
		[StaticVariableRuleIgnore]
		private static readonly FName SectionFall = new FName("End");

		// Token: 0x0401430E RID: 82702
		private const int FALLBACK_FALL_SPEED = 200;

		// Token: 0x0401430F RID: 82703
		private const int GROUND_TRACE_START_OFFSET = 50;

		// Token: 0x04014310 RID: 82704
		private const int GROUND_TRACE_END_OFFSET = -5000;

		// Token: 0x04014311 RID: 82705
		private const int SECTION_POLL_INTERVAL_MS = 20;

		// Token: 0x04014312 RID: 82706
		private const int MS_PER_SECOND = 1000;

		// Token: 0x04014313 RID: 82707
		[StaticVariableRuleIgnore]
		private static readonly Vector DeathSnapTempLocation = Vector.Create();

		// Token: 0x0200938B RID: 37771
		[NullableContext(0)]
		private enum EClimbDeathPhase
		{
			// Token: 0x0402E28E RID: 189070
			BeforeLoop,
			// Token: 0x0402E28F RID: 189071
			Falling,
			// Token: 0x0402E290 RID: 189072
			Done
		}
	}
}
