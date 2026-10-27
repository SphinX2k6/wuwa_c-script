using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem.RefCompController;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045E6 RID: 17894
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneObjectAirWallEffect
	{
		// Token: 0x0602E265 RID: 189029 RVA: 0x00AA9584 File Offset: 0x00AA7784
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

		// Token: 0x0602E266 RID: 189030 RVA: 0x00AA9630 File Offset: 0x00AA7830
		protected void GetActorLocation()
		{
			Vector curPosition = this.CurPosition;
			FVectorDouble fvectorDouble = this.ActorToAttach.D_K2_GetComponentLocation();
			curPosition.FromUeVector(fvectorDouble);
		}

		// Token: 0x0602E267 RID: 189031 RVA: 0x00AA9656 File Offset: 0x00AA7856
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

		// Token: 0x0602E268 RID: 189032 RVA: 0x00AA9670 File Offset: 0x00AA7870
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

		// Token: 0x0602E269 RID: 189033 RVA: 0x00AA9699 File Offset: 0x00AA7899
		public void BeforeUnregistered()
		{
			this.IsEnabled = false;
		}

		// Token: 0x0602E26A RID: 189034 RVA: 0x00AA96A4 File Offset: 0x00AA78A4
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

		// Token: 0x04018C29 RID: 101417
		private const string PROFILE_KEY = "SceneObjectAirWallEffect_Update";

		// Token: 0x04018C2A RID: 101418
		private const int RADIUS = 1;

		// Token: 0x04018C2B RID: 101419
		[Nullable(2)]
		public USceneComponent ActorToAttach;

		// Token: 0x04018C2C RID: 101420
		public bool IsReady;

		// Token: 0x04018C2D RID: 101421
		public bool IsEnabled;

		// Token: 0x04018C2E RID: 101422
		private readonly Vector LastPosition = Vector.Create();

		// Token: 0x04018C2F RID: 101423
		private readonly Vector CurPosition = Vector.Create();

		// Token: 0x04018C30 RID: 101424
		[Nullable(2)]
		private UTraceSphereElement SphereTrace;
	}
}
