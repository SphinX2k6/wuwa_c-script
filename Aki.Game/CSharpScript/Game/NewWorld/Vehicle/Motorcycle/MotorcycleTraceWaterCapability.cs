using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x020061AD RID: 25005
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleTraceWaterCapability : GameCapability
	{
		// Token: 0x0603C05E RID: 245854 RVA: 0x0110F509 File Offset: 0x0110D709
		public MotorcycleTraceWaterCapability(VehicleActorComponent ActorComp)
		{
			this.ActorComp = ActorComp;
		}

		// Token: 0x0603C05F RID: 245855 RVA: 0x0110F530 File Offset: 0x0110D730
		public override void Activate()
		{
			this.WaterTrace = new UTraceSphereElement();
			this.WaterTrace.WorldContextObject = this.ActorComp.Owner;
			this.WaterTrace.Radius = 1f;
			this.WaterTrace.bIgnoreSelf = true;
			this.WaterTrace.bIsSingle = false;
			this.WaterTrace.DrawTime = 0.1f;
			this.WaterTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
			TraceElementCommon.Instance.SetTraceColor(this.WaterTrace, CharacterSwimUtils.DebugColor3);
			TraceElementCommon.Instance.SetTraceHitColor(this.WaterTrace, CharacterSwimUtils.DebugColor4);
		}

		// Token: 0x0603C060 RID: 245856 RVA: 0x0110F5D0 File Offset: 0x0110D7D0
		public override void Deactivate()
		{
			UTraceSphereElement waterTrace = this.WaterTrace;
			if (waterTrace != null)
			{
				waterTrace.Dispose();
			}
			this.WaterTrace = null;
		}

		// Token: 0x0603C061 RID: 245857 RVA: 0x0110F5EC File Offset: 0x0110D7EC
		public TraceWaterResult TraceWater(double relativeStartHeight, double relativeEndHeight)
		{
			VehicleActorComponent actorComp = this.ActorComp;
			MathUtils.Instance.CommonTempVector.DeepCopy(actorComp.ActorLocationProxy);
			GravityUtils.Instance.AddZnInGravityForActor(actorComp, MathUtils.Instance.CommonTempVector, relativeStartHeight);
			TraceElementCommon.Instance.SetStartLocation(this.WaterTrace, MathUtils.Instance.CommonTempVector);
			MathUtils.Instance.CommonTempVector.DeepCopy(actorComp.ActorLocationProxy);
			GravityUtils.Instance.AddZnInGravityForActor(actorComp, MathUtils.Instance.CommonTempVector, relativeEndHeight);
			TraceElementCommon.Instance.SetEndLocation(this.WaterTrace, MathUtils.Instance.CommonTempVector);
			this.WaterTrace.SetDrawDebugTrace((SundryModel.Instance.GetModuleDebugLevel("MotorWater") > 0) ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None);
			bool flag = TraceElementCommon.Instance.SphereTrace(this.WaterTrace, "MotorWaterTrace");
			bool foundWater = false;
			double num = relativeStartHeight + 1.0;
			if (flag)
			{
				UKuroHitResult hitResult = this.WaterTrace.HitResult;
				int hitCount = hitResult.GetHitCount();
				for (int i = 0; i < hitCount; i++)
				{
					if (hitResult.Actors.Get(i).IsValid(false, false))
					{
						TraceElementCommon.Instance.GetImpactPoint(hitResult, i, MathUtils.Instance.CommonTempVector);
						MathUtils.Instance.CommonTempVector.SubtractionEqual(actorComp.ActorLocationProxy);
						double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, MathUtils.Instance.CommonTempVector);
						foundWater = true;
						if (znInGravityForActor < num)
						{
							num = znInGravityForActor;
							TraceElementCommon.Instance.GetImpactPoint(hitResult, i, this.ImpactPoint);
							TraceElementCommon.Instance.GetImpactNormal(hitResult, i, this.ImpactNormal);
						}
					}
				}
			}
			return new TraceWaterResult
			{
				FoundWater = foundWater,
				MinWaterHeight = (float)num,
				ImpactPoint = this.ImpactPoint,
				ImpactNormal = this.ImpactNormal
			};
		}

		// Token: 0x0603C062 RID: 245858 RVA: 0x0110F7C0 File Offset: 0x0110D9C0
		public bool CeilingCheck(double relativeHeight)
		{
			UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
			VehicleActorComponent actorComp = this.ActorComp;
			actorTrace.WorldContextObject = this.ActorComp.Owner;
			actorTrace.Radius = 5f;
			MathUtils.Instance.CommonTempVector.DeepCopy(actorComp.ActorLocationProxy);
			TraceElementCommon.Instance.SetStartLocation(actorTrace, MathUtils.Instance.CommonTempVector);
			MathUtils.Instance.CommonTempVector.DeepCopy(actorComp.ActorLocationProxy);
			GravityUtils.Instance.AddZnInGravityForActor(actorComp, MathUtils.Instance.CommonTempVector, relativeHeight);
			TraceElementCommon.Instance.SetEndLocation(actorTrace, MathUtils.Instance.CommonTempVector);
			actorTrace.ActorsToIgnore.Empty(true);
			foreach (AActor value in WorldModel.Instance.ActorsToIgnoreSet)
			{
				actorTrace.ActorsToIgnore.Add(value);
			}
			if (TraceElementCommon.Instance.ShapeTrace(actorComp.Actor.CapsuleComponent, actorTrace, "MotorWaterTrace", "MotorWaterTrace"))
			{
				UKuroHitResult hitResult = actorTrace.HitResult;
				int hitCount = hitResult.GetHitCount();
				for (int i = 0; i < hitCount; i++)
				{
					if (!(UKuroCollisionLibrary.GetBodyInstance(hitResult, i).ObjectType == KuroCollisionChannel.KuroWater))
					{
						TWeakObjectPtr<AActor> tweakObjectPtr = hitResult.Actors.Get(i);
						if (tweakObjectPtr.IsValid(false, false) && !(tweakObjectPtr.Get() is TsBaseCharacter) && !(tweakObjectPtr.Get() is TsBaseVehicle))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0401FB8A RID: 129930
		private const string PROFILE_DETECT_WATER_DEPTH = "MotorWaterTrace";

		// Token: 0x0401FB8B RID: 129931
		[StaticVariableRuleIgnore]
		public static FName waterCollisionProfileName = new FName("水体");

		// Token: 0x0401FB8C RID: 129932
		public const int ONE_HUNDRED = 100;

		// Token: 0x0401FB8D RID: 129933
		public const int FIVE_HUNDRED = 500;

		// Token: 0x0401FB8E RID: 129934
		public const string MOTORCYCLE_WATER_DEBUG_KEY = "MotorWater";

		// Token: 0x0401FB8F RID: 129935
		[Nullable(2)]
		private UTraceSphereElement WaterTrace;

		// Token: 0x0401FB90 RID: 129936
		public readonly Vector ImpactPoint = Vector.Create();

		// Token: 0x0401FB91 RID: 129937
		public readonly Vector ImpactNormal = Vector.Create();

		// Token: 0x0401FB92 RID: 129938
		private readonly VehicleActorComponent ActorComp;
	}
}
