using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E6F RID: 28271
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalCoreReturnAbility : PlayerElementalCoreFollowAbilityBase
	{
		// Token: 0x06044E3B RID: 282171 RVA: 0x01102000 File Offset: 0x01100200
		public PlayerElementalCoreReturnAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x06044E3C RID: 282172 RVA: 0x011020E7 File Offset: 0x011002E7
		public override bool ShouldActivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().ElementalCoreState == EPlayerElementalCoreState.Returning;
		}

		// Token: 0x06044E3D RID: 282173 RVA: 0x011020F7 File Offset: 0x011002F7
		public override bool ShouldDeactivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().ElementalCoreState != EPlayerElementalCoreState.Returning;
		}

		// Token: 0x06044E3E RID: 282174 RVA: 0x0110210C File Offset: 0x0110030C
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

		// Token: 0x06044E3F RID: 282175 RVA: 0x01102210 File Offset: 0x01100410
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

		// Token: 0x06044E40 RID: 282176 RVA: 0x0110228C File Offset: 0x0110048C
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

		// Token: 0x04023DE4 RID: 146916
		private float Timer;

		// Token: 0x04023DE5 RID: 146917
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x04023DE6 RID: 146918
		private readonly Quat StartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04023DE7 RID: 146919
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x04023DE8 RID: 146920
		private readonly Rotator TargetRotation = Rotator.Create();

		// Token: 0x04023DE9 RID: 146921
		private readonly Quat TargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04023DEA RID: 146922
		private readonly Vector TempTargetLocation = Vector.Create();

		// Token: 0x04023DEB RID: 146923
		private readonly Vector TempLocation = Vector.Create();

		// Token: 0x04023DEC RID: 146924
		private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04023DED RID: 146925
		private readonly Rotator TempRotation = Rotator.Create();
	}
}
