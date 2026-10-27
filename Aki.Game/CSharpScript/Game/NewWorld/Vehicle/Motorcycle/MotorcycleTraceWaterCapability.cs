using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x0200702C RID: 28716
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleTraceWaterCapability : GameCapability
	{
		// Token: 0x06045E85 RID: 286341 RVA: 0x011655AA File Offset: 0x011637AA
		public MotorcycleTraceWaterCapability(VehicleActorComponent ActorComp)
		{
			this.ActorComp = ActorComp;
		}

		// Token: 0x06045E86 RID: 286342 RVA: 0x011655D0 File Offset: 0x011637D0
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

		// Token: 0x06045E87 RID: 286343 RVA: 0x01165670 File Offset: 0x01163870
		public override void Deactivate()
		{
			UTraceSphereElement waterTrace = this.WaterTrace;
			if (waterTrace != null)
			{
				waterTrace.Dispose();
			}
			this.WaterTrace = null;
		}

		// Token: 0x06045E88 RID: 286344 RVA: 0x0116568C File Offset: 0x0116388C
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

		// Token: 0x06045E89 RID: 286345 RVA: 0x01165860 File Offset: 0x01163A60
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

		// Token: 0x040248D4 RID: 149716
		private const string PROFILE_DETECT_WATER_DEPTH = "MotorWaterTrace";

		// Token: 0x040248D5 RID: 149717
		[StaticVariableRuleIgnore]
		public static FName waterCollisionProfileName = new FName("水体");

		// Token: 0x040248D6 RID: 149718
		public const int ONE_HUNDRED = 100;

		// Token: 0x040248D7 RID: 149719
		public const int FIVE_HUNDRED = 500;

		// Token: 0x040248D8 RID: 149720
		public const string MOTORCYCLE_WATER_DEBUG_KEY = "MotorWater";

		// Token: 0x040248D9 RID: 149721
		[Nullable(2)]
		private UTraceSphereElement WaterTrace;

		// Token: 0x040248DA RID: 149722
		public readonly Vector ImpactPoint = Vector.Create();

		// Token: 0x040248DB RID: 149723
		public readonly Vector ImpactNormal = Vector.Create();

		// Token: 0x040248DC RID: 149724
		private readonly VehicleActorComponent ActorComp;
	}
}
