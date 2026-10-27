using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E68 RID: 28264
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalCoreDrawAbility : PlayerElementalCoreFollowAbilityBase
	{
		// Token: 0x06044E0A RID: 282122 RVA: 0x01100998 File Offset: 0x010FEB98
		public PlayerElementalCoreDrawAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x06044E0B RID: 282123 RVA: 0x01100A3A File Offset: 0x010FEC3A
		public override bool ShouldActivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().ElementalCoreState == EPlayerElementalCoreState.Drawing;
		}

		// Token: 0x06044E0C RID: 282124 RVA: 0x01100A4A File Offset: 0x010FEC4A
		public override bool ShouldDeactivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().ElementalCoreState != EPlayerElementalCoreState.Drawing;
		}

		// Token: 0x06044E0D RID: 282125 RVA: 0x01100A60 File Offset: 0x010FEC60
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

		// Token: 0x06044E0E RID: 282126 RVA: 0x01100AE0 File Offset: 0x010FECE0
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

		// Token: 0x06044E0F RID: 282127 RVA: 0x01100B3C File Offset: 0x010FED3C
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

		// Token: 0x04023DB1 RID: 146865
		private float Timer;

		// Token: 0x04023DB2 RID: 146866
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x04023DB3 RID: 146867
		private readonly Quat StartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04023DB4 RID: 146868
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x04023DB5 RID: 146869
		private readonly Rotator TargetRotation = Rotator.Create();

		// Token: 0x04023DB6 RID: 146870
		private readonly Vector TempStartLocation = Vector.Create();

		// Token: 0x04023DB7 RID: 146871
		private readonly Quat TargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
	}
}
