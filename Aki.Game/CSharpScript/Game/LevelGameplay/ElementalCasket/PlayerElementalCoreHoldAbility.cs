using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E6B RID: 28267
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalCoreHoldAbility : PlayerElementalCoreFollowAbilityBase
	{
		// Token: 0x06044E21 RID: 282145 RVA: 0x011010FF File Offset: 0x010FF2FF
		public PlayerElementalCoreHoldAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x06044E22 RID: 282146 RVA: 0x01101138 File Offset: 0x010FF338
		public override bool ShouldActivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().ElementalCoreState == EPlayerElementalCoreState.Holding;
		}

		// Token: 0x06044E23 RID: 282147 RVA: 0x01101148 File Offset: 0x010FF348
		public override bool ShouldDeactivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().ElementalCoreState != EPlayerElementalCoreState.Holding;
		}

		// Token: 0x06044E24 RID: 282148 RVA: 0x0110115C File Offset: 0x010FF35C
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

		// Token: 0x06044E25 RID: 282149 RVA: 0x011011D8 File Offset: 0x010FF3D8
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

		// Token: 0x06044E26 RID: 282150 RVA: 0x0110123C File Offset: 0x010FF43C
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

		// Token: 0x04023DC0 RID: 146880
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x04023DC1 RID: 146881
		private readonly Rotator TargetRotation = Rotator.Create();

		// Token: 0x04023DC2 RID: 146882
		private readonly Vector CurrentLocation = Vector.Create();

		// Token: 0x04023DC3 RID: 146883
		private readonly Rotator CurrentRotation = Rotator.Create();

		// Token: 0x04023DC4 RID: 146884
		private int HoldAudioHandle;
	}
}
