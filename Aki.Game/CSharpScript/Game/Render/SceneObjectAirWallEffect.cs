using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem.RefCompController;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x0200350F RID: 13583
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneObjectAirWallEffect
	{
		// Token: 0x0602295A RID: 141658 RVA: 0x009D5D1C File Offset: 0x009D3F1C
		private void InitTraceInfo()
		{
			UTraceSphereElement utraceSphereElement = new UTraceSphereElement();
			utraceSphereElement.WorldContextObject = GlobalData.World;
			utraceSphereElement.bIsSingle = false;
			utraceSphereElement.bIgnoreSelf = true;
			utraceSphereElement.Radius = 1f;
			TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>();
			tarray.Add(KuroObjectTypeQuery.WorldStatic);
			tarray.Add(KuroObjectTypeQuery.WorldStaticIgnoreBullet);
			utraceSphereElement.SetObjectTypesQuery(ref tarray);
			if (EffectGlobal.Instance.SceneObjectAirWallEffectShowDebugTrace)
			{
				utraceSphereElement.DrawTime = 5f;
				utraceSphereElement.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
				TraceElementCommon.Instance.SetTraceColor(utraceSphereElement, ColorUtils.LinearGreen);
				TraceElementCommon.Instance.SetTraceHitColor(utraceSphereElement, ColorUtils.LinearRed);
			}
			this.SphereTrace = utraceSphereElement;
		}

		// Token: 0x0602295B RID: 141659 RVA: 0x009D5DC8 File Offset: 0x009D3FC8
		protected void GetActorLocation()
		{
			Vector curPosition = this.CurPosition;
			FVectorDouble fvectorDouble = this.ActorToAttach.D_K2_GetComponentLocation();
			curPosition.FromUeVector(fvectorDouble);
		}

		// Token: 0x0602295C RID: 141660 RVA: 0x009D5DEE File Offset: 0x009D3FEE
		[NullableContext(2)]
		public void Start(USceneComponent actorToAttach)
		{
			if (actorToAttach == null)
			{
				return;
			}
			this.ActorToAttach = actorToAttach;
			this.IsReady = true;
			this.InitTraceInfo();
		}

		// Token: 0x0602295D RID: 141661 RVA: 0x009D5E08 File Offset: 0x009D4008
		public void AfterRegistered()
		{
			if (!this.IsReady)
			{
				return;
			}
			this.GetActorLocation();
			this.LastPosition.DeepCopy(this.CurPosition);
			this.IsEnabled = true;
		}

		// Token: 0x0602295E RID: 141662 RVA: 0x009D5E31 File Offset: 0x009D4031
		public void BeforeUnregistered()
		{
			this.IsEnabled = false;
		}

		// Token: 0x0602295F RID: 141663 RVA: 0x009D5E3C File Offset: 0x009D403C
		public void Update(double deltaTime)
		{
			if (this.IsEnabled)
			{
				USceneComponent actorToAttach = this.ActorToAttach;
				if (actorToAttach != null && actorToAttach.IsValid())
				{
					this.GetActorLocation();
					UTraceSphereElement sphereTrace = this.SphereTrace;
					TraceElementCommon.Instance.SetStartLocation(sphereTrace, this.LastPosition);
					TraceElementCommon.Instance.SetEndLocation(sphereTrace, this.CurPosition);
					bool flag = TraceElementCommon.Instance.SphereTrace(sphereTrace, "SceneObjectAirWallEffect_Update");
					UKuroHitResult hitResult = sphereTrace.HitResult;
					if (flag && hitResult != null && hitResult.bBlockingHit)
					{
						int hitCount = hitResult.GetHitCount();
						for (int i = 0; i < hitCount; i++)
						{
							AActor aactor = hitResult.Actors.Get(i).Get();
							if (aactor.Tags.FindIndex(RefCompAirWallController.AIR_WALL) != -1)
							{
								Vector vector = Vector.Create();
								TraceElementCommon.Instance.GetImpactPoint(hitResult, i, vector);
								Vector vector2 = Vector.Create();
								TraceElementCommon.Instance.GetImpactNormal(hitResult, i, vector2);
								EventSystem.Instance.EmitWithTarget<AActor, Vector, Vector>(aactor, EEventName.BulletHitAirWall, aactor, vector, vector2);
							}
						}
					}
					this.LastPosition.DeepCopy(this.CurPosition);
					return;
				}
			}
		}

		// Token: 0x04013268 RID: 78440
		private const string PROFILE_KEY = "SceneObjectAirWallEffect_Update";

		// Token: 0x04013269 RID: 78441
		private const int RADIUS = 1;

		// Token: 0x0401326A RID: 78442
		[Nullable(2)]
		public USceneComponent ActorToAttach;

		// Token: 0x0401326B RID: 78443
		public bool IsReady;

		// Token: 0x0401326C RID: 78444
		public bool IsEnabled;

		// Token: 0x0401326D RID: 78445
		private readonly Vector LastPosition = Vector.Create();

		// Token: 0x0401326E RID: 78446
		private readonly Vector CurPosition = Vector.Create();

		// Token: 0x0401326F RID: 78447
		[Nullable(2)]
		private UTraceSphereElement SphereTrace;
	}
}
