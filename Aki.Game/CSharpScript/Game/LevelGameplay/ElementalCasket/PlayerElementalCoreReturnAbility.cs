using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02005FF0 RID: 24560
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalCoreReturnAbility : PlayerElementalCoreFollowAbilityBase
	{
		// Token: 0x0603AFCE RID: 241614 RVA: 0x010AC56C File Offset: 0x010AA76C
		public PlayerElementalCoreReturnAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x0603AFCF RID: 241615 RVA: 0x010AC653 File Offset: 0x010AA853
		public override bool ShouldActivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().ElementalCoreState == EPlayerElementalCoreState.Returning;
		}

		// Token: 0x0603AFD0 RID: 241616 RVA: 0x010AC663 File Offset: 0x010AA863
		public override bool ShouldDeactivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().ElementalCoreState != EPlayerElementalCoreState.Returning;
		}

		// Token: 0x0603AFD1 RID: 241617 RVA: 0x010AC678 File Offset: 0x010AA878
		public override void OnActivated(Entity entity)
		{
			PlayerElementalCasketComponent component = entity.GetComponent<PlayerElementalCasketComponent>();
			AActor elementalCoreActor = component.GetElementalCoreActor();
			if (elementalCoreActor == null || !elementalCoreActor.IsValid())
			{
				return;
			}
			FTransformDouble? landedFoundationCoreTransform = component.GetLandedFoundationCoreTransform();
			if (landedFoundationCoreTransform == null)
			{
				Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.LYY, "归还核心时取不到目标底座核心位姿，进行重置", default(ReadOnlySpan<ValueTuple<string, object>>));
				component.ResetElementalCore();
				return;
			}
			this.Timer = 0f;
			Vector startLocation = this.StartLocation;
			FVectorDouble fvectorDouble = elementalCoreActor.D_K2_GetActorLocation();
			startLocation.FromUeVector(fvectorDouble);
			this.StartQuat.FromUeQuat(elementalCoreActor.K2_GetActorQuaternion());
			Vector targetLocation = this.TargetLocation;
			fvectorDouble = landedFoundationCoreTransform.Value.GetLocation();
			targetLocation.FromUeVector(fvectorDouble);
			Rotator targetRotation = this.TargetRotation;
			FRotator frotator = landedFoundationCoreTransform.Value.Rotator();
			targetRotation.FromUeRotator(frotator);
			this.TargetRotation.Quaternion(this.TargetQuat);
			string coreWhooshAudio = component.GetCoreWhooshAudio();
			if (coreWhooshAudio != null)
			{
				AudioSystem.Instance.PostEvent(coreWhooshAudio, elementalCoreActor, null);
			}
		}

		// Token: 0x0603AFD2 RID: 241618 RVA: 0x010AC77C File Offset: 0x010AA97C
		public override void OnDeactivated(Entity entity)
		{
			this.Timer = 0f;
			this.StartLocation.Reset();
			this.StartQuat.Reset();
			this.TargetLocation.Reset();
			this.TargetRotation.Reset();
			this.TargetQuat.Reset();
			this.TempTargetLocation.Reset();
			this.TempLocation.Reset();
			this.TempQuat.Reset();
			this.TempRotation.Reset();
		}

		// Token: 0x0603AFD3 RID: 241619 RVA: 0x010AC7F8 File Offset: 0x010AA9F8
		public override void OnTick(Entity entity, float deltaMilliseconds)
		{
			PlayerElementalCasketComponent component = entity.GetComponent<PlayerElementalCasketComponent>();
			ElementalCoreConfig coreConfig = component.Config.CoreConfig;
			if (coreConfig == null)
			{
				return;
			}
			AActor elementalCoreActor = component.GetElementalCoreActor();
			if (elementalCoreActor == null || !elementalCoreActor.IsValid())
			{
				return;
			}
			this.Timer += deltaMilliseconds / 1000f;
			if (this.Timer >= coreConfig.ReturnTime)
			{
				elementalCoreActor.D_K2_SetActorLocationAndRotation(this.TargetLocation.ToUeVector(false), this.TargetRotation.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, false);
				component.DestroyElementalCore();
				return;
			}
			float num = 1f;
			float num2 = coreConfig.ReturnTime - coreConfig.ReturnAlignTime;
			if (this.Timer > num2)
			{
				num = MathUtils.Instance.Clamp((coreConfig.ReturnTime - this.Timer) / coreConfig.ReturnAlignTime, 0f, 1f);
				num = UKismetMathLibrary.Ease(0f, 1f, num, EEasingFunc.EaseOut, 2f, 2);
			}
			this.TempTargetLocation.Set(this.TargetLocation.X, this.TargetLocation.Y, this.TargetLocation.Z + (double)(coreConfig.ReturnTractionHeight * num));
			float num3 = MathUtils.Instance.Clamp(this.Timer / (coreConfig.ReturnTime - coreConfig.ReturnDelay), 0f, 1f);
			num3 = UKismetMathLibrary.Ease(0f, 1f, num3, EEasingFunc.EaseInOut, 2f, 2);
			Vector.Lerp(this.StartLocation, this.TempTargetLocation, (double)num3, this.TempLocation);
			Quat.Slerp(this.StartQuat, this.TargetQuat, num3, this.TempQuat);
			this.TempQuat.Rotator(this.TempRotation);
			elementalCoreActor.D_K2_SetActorLocationAndRotation(this.TempLocation.ToUeVector(false), this.TempRotation.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x17006F6D RID: 28525
		// (get) Token: 0x0603AFD4 RID: 241620 RVA: 0x010AC9C7 File Offset: 0x010AABC7
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401F099 RID: 127129
		private float Timer;

		// Token: 0x0401F09A RID: 127130
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0401F09B RID: 127131
		private readonly Quat StartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401F09C RID: 127132
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x0401F09D RID: 127133
		private readonly Rotator TargetRotation = Rotator.Create();

		// Token: 0x0401F09E RID: 127134
		private readonly Quat TargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401F09F RID: 127135
		private readonly Vector TempTargetLocation = Vector.Create();

		// Token: 0x0401F0A0 RID: 127136
		private readonly Vector TempLocation = Vector.Create();

		// Token: 0x0401F0A1 RID: 127137
		private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401F0A2 RID: 127138
		private readonly Rotator TempRotation = Rotator.Create();
	}
}
