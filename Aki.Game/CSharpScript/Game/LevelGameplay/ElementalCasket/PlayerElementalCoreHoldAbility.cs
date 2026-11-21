using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02005FEC RID: 24556
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalCoreHoldAbility : PlayerElementalCoreFollowAbilityBase
	{
		// Token: 0x0603AFB0 RID: 241584 RVA: 0x010AB667 File Offset: 0x010A9867
		public PlayerElementalCoreHoldAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x0603AFB1 RID: 241585 RVA: 0x010AB6A0 File Offset: 0x010A98A0
		public override bool ShouldActivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().ElementalCoreState == EPlayerElementalCoreState.Holding;
		}

		// Token: 0x0603AFB2 RID: 241586 RVA: 0x010AB6B0 File Offset: 0x010A98B0
		public override bool ShouldDeactivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().ElementalCoreState != EPlayerElementalCoreState.Holding;
		}

		// Token: 0x0603AFB3 RID: 241587 RVA: 0x010AB6C4 File Offset: 0x010A98C4
		public override void OnActivated(Entity entity)
		{
			PlayerElementalCasketComponent component = entity.GetComponent<PlayerElementalCasketComponent>();
			AActor elementalCoreActor = component.GetElementalCoreActor();
			if (elementalCoreActor == null || !elementalCoreActor.IsValid())
			{
				return;
			}
			Vector currentLocation = this.CurrentLocation;
			FVectorDouble fvectorDouble = elementalCoreActor.D_K2_GetActorLocation();
			currentLocation.FromUeVector(fvectorDouble);
			Rotator currentRotation = this.CurrentRotation;
			FRotator frotator = elementalCoreActor.K2_GetActorRotation();
			currentRotation.FromUeRotator(frotator);
			string coreLoopAudio = component.GetCoreLoopAudio();
			if (coreLoopAudio != null)
			{
				this.HoldAudioHandle = AudioSystem.Instance.PostEvent(coreLoopAudio, elementalCoreActor, null);
			}
		}

		// Token: 0x0603AFB4 RID: 241588 RVA: 0x010AB740 File Offset: 0x010A9940
		public override void OnDeactivated(Entity entity)
		{
			this.TargetLocation.Reset();
			this.TargetRotation.Reset();
			this.CurrentLocation.Reset();
			this.CurrentRotation.Reset();
			if (this.HoldAudioHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.HoldAudioHandle, EAudioActionType.Stop, null);
				this.HoldAudioHandle = 0;
			}
		}

		// Token: 0x0603AFB5 RID: 241589 RVA: 0x010AB7A4 File Offset: 0x010A99A4
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
			if (!base.GetTargetLocationAndRotation(coreConfig, this.TargetLocation, this.TargetRotation))
			{
				return;
			}
			if (Vector.DistSquared(this.CurrentLocation, this.TargetLocation) > (double)(coreConfig.InterpDistanceThreshold * coreConfig.InterpDistanceThreshold))
			{
				this.CurrentLocation.Set(this.TargetLocation.X, this.TargetLocation.Y, this.TargetLocation.Z);
				this.CurrentRotation.Set(this.TargetRotation.Pitch, this.TargetRotation.Yaw, this.TargetRotation.Roll);
			}
			else
			{
				double num = (double)deltaMilliseconds * 0.001;
				double alpha = 1.0 - Math.Exp((double)(-(double)coreConfig.LocationInterpSpeed) * num);
				double num2 = 1.0 - Math.Exp((double)(-(double)coreConfig.RotationInterpSpeed) * num);
				Vector.Lerp(this.CurrentLocation, this.TargetLocation, alpha, this.CurrentLocation);
				Rotator.Lerp(this.CurrentRotation, this.TargetRotation, (float)num2, this.CurrentRotation);
			}
			elementalCoreActor.D_K2_SetActorLocationAndRotation(this.CurrentLocation.ToUeVector(false), this.CurrentRotation.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x17006F69 RID: 28521
		// (get) Token: 0x0603AFB6 RID: 241590 RVA: 0x010AB90D File Offset: 0x010A9B0D
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401F075 RID: 127093
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x0401F076 RID: 127094
		private readonly Rotator TargetRotation = Rotator.Create();

		// Token: 0x0401F077 RID: 127095
		private readonly Vector CurrentLocation = Vector.Create();

		// Token: 0x0401F078 RID: 127096
		private readonly Rotator CurrentRotation = Rotator.Create();

		// Token: 0x0401F079 RID: 127097
		private int HoldAudioHandle;
	}
}
