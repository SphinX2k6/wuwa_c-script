using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02005FE9 RID: 24553
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalCoreDrawAbility : PlayerElementalCoreFollowAbilityBase
	{
		// Token: 0x0603AF97 RID: 241559 RVA: 0x010AAEF8 File Offset: 0x010A90F8
		public PlayerElementalCoreDrawAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x0603AF98 RID: 241560 RVA: 0x010AAF9A File Offset: 0x010A919A
		public override bool ShouldActivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().ElementalCoreState == EPlayerElementalCoreState.Drawing;
		}

		// Token: 0x0603AF99 RID: 241561 RVA: 0x010AAFAA File Offset: 0x010A91AA
		public override bool ShouldDeactivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().ElementalCoreState != EPlayerElementalCoreState.Drawing;
		}

		// Token: 0x0603AF9A RID: 241562 RVA: 0x010AAFC0 File Offset: 0x010A91C0
		public override void OnActivated(Entity entity)
		{
			PlayerElementalCasketComponent component = entity.GetComponent<PlayerElementalCasketComponent>();
			AActor elementalCoreActor = component.GetElementalCoreActor();
			if (elementalCoreActor == null || !elementalCoreActor.IsValid())
			{
				return;
			}
			this.Timer = 0f;
			Vector startLocation = this.StartLocation;
			FVectorDouble fvectorDouble = elementalCoreActor.D_K2_GetActorLocation();
			startLocation.FromUeVector(fvectorDouble);
			this.StartQuat.FromUeQuat(elementalCoreActor.K2_GetActorQuaternion());
			string coreWhooshAudio = component.GetCoreWhooshAudio();
			if (coreWhooshAudio != null)
			{
				AudioSystem.Instance.PostEvent(coreWhooshAudio, elementalCoreActor, null);
			}
		}

		// Token: 0x0603AF9B RID: 241563 RVA: 0x010AB040 File Offset: 0x010A9240
		public override void OnDeactivated(Entity entity)
		{
			this.Timer = 0f;
			this.StartLocation.Reset();
			this.StartQuat.Reset();
			this.TargetLocation.Reset();
			this.TargetRotation.Reset();
			this.TempStartLocation.Reset();
			this.TargetQuat.Reset();
		}

		// Token: 0x0603AF9C RID: 241564 RVA: 0x010AB09C File Offset: 0x010A929C
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
			this.Timer += deltaMilliseconds / 1000f;
			if (this.Timer >= coreConfig.DrawTime)
			{
				elementalCoreActor.D_K2_SetActorLocationAndRotation(this.TargetLocation.ToUeVector(false), this.TargetRotation.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, false);
				component.OnDrawAnimationFinished();
				return;
			}
			float num = 1f;
			if (this.Timer < coreConfig.DrawAlignTime)
			{
				num = MathUtils.Instance.Clamp(this.Timer / coreConfig.DrawAlignTime, 0f, 1f);
				num = UKismetMathLibrary.Ease(0f, 1f, num, EEasingFunc.EaseIn, 2f, 2);
			}
			this.TempStartLocation.Set(this.StartLocation.X, this.StartLocation.Y, this.StartLocation.Z + (double)(coreConfig.DrawTractionHeight * num));
			float num2 = MathUtils.Instance.Clamp((this.Timer - coreConfig.DrawDelay) / (coreConfig.DrawTime - coreConfig.DrawDelay), 0f, 1f);
			num2 = UKismetMathLibrary.Ease(0f, 1f, num2, EEasingFunc.EaseInOut, 2f, 2);
			if (num2 < 1f)
			{
				Vector.Lerp(this.TempStartLocation, this.TargetLocation, (double)num2, this.TargetLocation);
				this.TargetRotation.Quaternion(this.TargetQuat);
				Quat.Slerp(this.StartQuat, this.TargetQuat, num2, this.TargetQuat);
				this.TargetQuat.Rotator(this.TargetRotation);
			}
			elementalCoreActor.D_K2_SetActorLocationAndRotation(this.TargetLocation.ToUeVector(false), this.TargetRotation.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x17006F67 RID: 28519
		// (get) Token: 0x0603AF9D RID: 241565 RVA: 0x010AB293 File Offset: 0x010A9493
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401F066 RID: 127078
		private float Timer;

		// Token: 0x0401F067 RID: 127079
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0401F068 RID: 127080
		private readonly Quat StartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401F069 RID: 127081
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x0401F06A RID: 127082
		private readonly Rotator TargetRotation = Rotator.Create();

		// Token: 0x0401F06B RID: 127083
		private readonly Vector TempStartLocation = Vector.Create();

		// Token: 0x0401F06C RID: 127084
		private readonly Quat TargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
	}
}
