using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Gameplay.RollBlock;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.ItemLogic
{
	// Token: 0x02005C0E RID: 23566
	[NullableContext(1)]
	[Nullable(0)]
	public class RbLightBeamItemLogic : RbItemLogicBase
	{
		// Token: 0x06039DEF RID: 237039 RVA: 0x01044C94 File Offset: 0x01042E94
		public RbLightBeamItemLogic(RbItemComponent owner) : base(owner)
		{
		}

		// Token: 0x06039DF0 RID: 237040 RVA: 0x01044D20 File Offset: 0x01042F20
		public override void Start([Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<RbBreakableObstaclePbType, RbLaserEmitterPbType> info)
		{
			this.OriginLocation = new FVectorDouble?(this.Owner.ActorTransform.GetLocation());
			this.RangeComp = this.Owner.Entity.GetComponent<RangeComponent>();
			RbLaserEmitterPbType asT = info.AsT2;
			this.UpdatePoints(asT.LaserPoints);
			if (this.RelativePoints.Num() > 1)
			{
				this.UpdateRange();
				this.UpdateEffectByTrace();
			}
			this.StartOverlap();
			EventSystem.Instance.AddWithTarget(this.Owner.Entity, EEventName.OnSceneItemLockPropChange, new Action<bool>(this.OnSceneItemLockPropChange));
		}

		// Token: 0x06039DF1 RID: 237041 RVA: 0x01044DC0 File Offset: 0x01042FC0
		public override void End()
		{
			this.StopAllEffect();
			this.RelativePoints.Empty(true);
			this.AbsolutePoints.Empty(true);
			this.TraceElement = null;
			this.StopOverlap();
			EventSystem.Instance.RemoveWithTarget(this.Owner.Entity, EEventName.OnSceneItemLockPropChange, new Action<bool>(this.OnSceneItemLockPropChange));
		}

		// Token: 0x06039DF2 RID: 237042 RVA: 0x01044E1F File Offset: 0x0104301F
		public override void OnStateChange(int stateId)
		{
			if (stateId == GameplayTagDefine.EGameplayTagId["关卡.Common.状态.销毁"])
			{
				this.StopAllEffect();
				this.StopOverlap();
				this.RelativePoints.Empty(true);
				this.AbsolutePoints.Empty(true);
				this.TraceElement = null;
			}
		}

		// Token: 0x06039DF3 RID: 237043 RVA: 0x01044E60 File Offset: 0x01043060
		public override void OnRbItemUpdate([Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<RbBreakableObstaclePbType, RbLaserEmitterPbType> info)
		{
			RbLaserEmitterPbType asT = info.AsT2;
			bool flag = this.UpdatePoints(asT.LaserPoints);
			this.IgnoreOverlap = true;
			if (this.RelativePoints.Num() > 1)
			{
				if (flag)
				{
					this.UpdateRange();
				}
				this.UpdateEffectByTrace();
				this.UpdateStartEffect();
			}
			this.IgnoreOverlap = false;
		}

		// Token: 0x06039DF4 RID: 237044 RVA: 0x01044EB4 File Offset: 0x010430B4
		private bool UpdatePoints(IList<Aki.Protocol.Vector> points)
		{
			if (points.Count > 0)
			{
				global::Vector vector = global::Vector.Create(points[0]);
				global::Vector vector2 = global::Vector.Create(points[points.Count - 1]);
				if (this.AbsolutePoints.Num() > 0)
				{
					global::Vector inB = global::Vector.Create(this.AbsoluteOriginPoint.Get(0));
					global::Vector inB2 = global::Vector.Create(this.AbsoluteOriginPoint.Get(this.AbsoluteOriginPoint.Num() - 1));
					if (vector.Equals(inB, 9.999999747378752E-05) && vector2.Equals(inB2, 9.999999747378752E-05))
					{
						return false;
					}
				}
				this.RelativePoints.Empty(true);
				this.AbsolutePoints.Empty(true);
				this.AbsoluteOriginPoint.Empty(true);
				this.RelativePoints.Add(new FVectorDouble(vector.X - this.OriginLocation.Value.X, vector.Y - this.OriginLocation.Value.Y, vector.Z - this.OriginLocation.Value.Z));
				FVectorDouble value = new FVectorDouble(vector.X, vector.Y, vector.Z);
				this.AbsolutePoints.Add(value);
				this.AbsoluteOriginPoint.Add(value);
				if (!vector.Equals(vector2, 9.999999747378752E-05))
				{
					this.RelativePoints.Add(new FVectorDouble(vector2.X - this.OriginLocation.Value.X, vector2.Y - this.OriginLocation.Value.Y, vector2.Z - this.OriginLocation.Value.Z));
					FVectorDouble value2 = new FVectorDouble(vector2.X, vector2.Y, vector2.Z);
					this.AbsolutePoints.Add(value2);
					this.AbsoluteOriginPoint.Add(value2);
				}
				return true;
			}
			return false;
		}

		// Token: 0x06039DF5 RID: 237045 RVA: 0x010450A8 File Offset: 0x010432A8
		private void UpdateEffectByTrace()
		{
			this.ExecuteTrace();
			FVectorDouble fvectorDouble = this.AbsolutePoints.Get(this.AbsolutePoints.Num() - 1);
			if (this.ImpactPoint.Equals(fvectorDouble, 9.999999747378752E-05) && this.EffectHandle != null)
			{
				return;
			}
			this.AbsolutePoints.Set(this.AbsolutePoints.Num() - 1, this.ImpactPoint);
			TArray<FVectorDouble> relativePoints = this.RelativePoints;
			int index = this.RelativePoints.Num() - 1;
			fvectorDouble = this.OriginLocation.Value;
			FVectorDouble fvectorDouble2 = this.ImpactPoint - fvectorDouble;
			relativePoints.Set(index, fvectorDouble2);
			this.UpdateLightBeam();
		}

		// Token: 0x06039DF6 RID: 237046 RVA: 0x01045154 File Offset: 0x01043354
		private void UpdateRange()
		{
			FVectorDouble fvectorDouble = this.AbsolutePoints.Get(0);
			FVectorDouble fvectorDouble2 = this.AbsolutePoints.Get(this.AbsolutePoints.Num() - 1);
			global::Vector centerOfPoints = MathUtils.Instance.GetCenterOfPoints(new global::Vector[]
			{
				global::Vector.Create(fvectorDouble),
				global::Vector.Create(fvectorDouble2)
			});
			FTransformDouble actorTransform = this.Owner.ActorComp.ActorTransform;
			FVectorDouble fvectorDouble3 = centerOfPoints.ToUeVector(false);
			FVectorDouble location = actorTransform.InverseTransformPosition(fvectorDouble3);
			fvectorDouble3 = fvectorDouble - fvectorDouble2;
			double num = fvectorDouble3.Size();
			this.BoxExtent.X = num * 0.5;
			this.RangeComp.UpdateBoxRange(location, this.BoxExtent.ToUeVector(false));
		}

		// Token: 0x06039DF7 RID: 237047 RVA: 0x0104521C File Offset: 0x0104341C
		private void ExecuteTrace()
		{
			this.InitTraceElement(this.AbsoluteOriginPoint.Get(0), this.AbsoluteOriginPoint.Get(this.AbsoluteOriginPoint.Num() - 1));
			TraceElementCommon.Instance.BoxTrace(this.TraceElement, "[RbLightBeamItemLogic.UpdateLightBeam]");
			UKuroHitResult hitResult = this.TraceElement.HitResult;
			if (hitResult != null && hitResult.bBlockingHit && hitResult.Actors.Get(0).IsValid(false, false))
			{
				this.ImpactPoint.X = (double)hitResult.ImpactPointX_Array.Get(0);
				this.ImpactPoint.Y = (double)hitResult.ImpactPointY_Array.Get(0);
				this.ImpactPoint.Z = (double)hitResult.ImpactPointZ_Array.Get(0);
				return;
			}
			int index = this.AbsoluteOriginPoint.Num() - 1;
			this.ImpactPoint.X = this.AbsoluteOriginPoint.Get(index).X;
			this.ImpactPoint.Y = this.AbsoluteOriginPoint.Get(index).Y;
			this.ImpactPoint.Z = this.AbsoluteOriginPoint.Get(index).Z;
		}

		// Token: 0x06039DF8 RID: 237048 RVA: 0x01045344 File Offset: 0x01043544
		private void UpdateStartEffect()
		{
			if (this.StartEffectHandle != null)
			{
				return;
			}
			if (this.RelativePoints.Num() == 0)
			{
				return;
			}
			BP_RollBlockGameplaySetting_C gameplaySetting = RollBlockController.Instance.GameplaySetting;
			string text = (gameplaySetting != null) ? gameplaySetting.LightBeamStartEffect.ToAssetPathName() : null;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			FTransformDouble value = new FTransformDouble();
			FVectorDouble fvectorDouble = this.AbsolutePoints.Get(0);
			FVectorDouble fvectorDouble2 = this.AbsolutePoints.Get(this.AbsolutePoints.Num() - 1);
			global::Vector vector = global::Vector.Create(fvectorDouble2 - fvectorDouble);
			vector.Normalize(9.99999993922529E-09);
			float inYaw = (float)MathUtils.Instance.GetAngleByVectorDot(global::Vector.LeftVectorProxy, vector);
			FRotator frotator = new FRotator(0f, inYaw, 0f);
			FVectorDouble fvectorDouble3 = vector.ToUeVector(false);
			FVectorDouble fvectorDouble4 = fvectorDouble3 * 50.0;
			FVectorDouble fvectorDouble5 = fvectorDouble + fvectorDouble4;
			value.SetTranslation(fvectorDouble5);
			FQuat fquat = frotator.Quaternion();
			value.SetRotation(fquat);
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(value);
			int num = instance.SpawnEffect(world, ftransformDouble, text, "[RbLightBeamItemLogic] HitEffect]", new EffectContext(new int?(this.Owner.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false);
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(num);
			AActor owner = this.Owner.ActorComp.Owner;
			FName? fname = null;
			effectActor.K2_AttachToActor(owner, fname, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false);
			this.StartEffectHandle = new int?(num);
		}

		// Token: 0x06039DF9 RID: 237049 RVA: 0x010454D8 File Offset: 0x010436D8
		private unsafe void UpdateLightBeam()
		{
			this.StopBeamEffect();
			TArray<FVectorDouble> relativePoints = this.RelativePoints;
			if (relativePoints != null && relativePoints.Num() == 0)
			{
				return;
			}
			BP_RollBlockGameplaySetting_C gameplaySetting = RollBlockController.Instance.GameplaySetting;
			string text = (gameplaySetting != null) ? gameplaySetting.LightBeamEffect.ToAssetPathName() : null;
			global::Vector location = this.Location;
			FVectorDouble fvectorDouble = this.OriginLocation.Value;
			location.FromUeVector(fvectorDouble);
			if (!string.IsNullOrEmpty(text))
			{
				IGuideEffectSpline guideEffectSpline = GameSplineUtils.GenerateGuideEffect(this.Location, this.RelativePoints, text);
				if (guideEffectSpline == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RollBlock;
					ELogAuthor author = ELogAuthor.FJH;
					string message = "[RbLightBeamItemLogic] GenerateGuideEffect failed";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.Owner.CreatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EffectPath", text);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				this.EffectHandle = new int?(guideEffectSpline.EffectHandle);
				USplineComponent splineComp = guideEffectSpline.SplineComp;
				if (splineComp != null)
				{
					int numberOfSplinePoints = splineComp.GetNumberOfSplinePoints();
					for (int i = 0; i < numberOfSplinePoints; i++)
					{
						splineComp.SetSplinePointType(i, ESplinePointType.Linear, false);
					}
					splineComp.UpdateSpline();
				}
			}
			FVectorDouble fvectorDouble2 = this.AbsoluteOriginPoint.Get(this.AbsoluteOriginPoint.Num() - 1);
			FVectorDouble fvectorDouble3 = this.AbsolutePoints.Get(this.AbsolutePoints.Num() - 1);
			FTransformDouble value = new FTransformDouble();
			string text2;
			if (fvectorDouble2.Equals(fvectorDouble3, 9.999999747378752E-05))
			{
				BP_RollBlockGameplaySetting_C gameplaySetting2 = RollBlockController.Instance.GameplaySetting;
				text2 = ((gameplaySetting2 != null) ? gameplaySetting2.LightBeamHitWallEffect.ToAssetPathName() : null);
				FVectorDouble fvectorDouble4 = this.AbsolutePoints.Get(0);
				global::Vector vector = global::Vector.Create(fvectorDouble4 - fvectorDouble3);
				vector.Normalize(9.99999993922529E-09);
				float inYaw = (float)MathUtils.Instance.GetAngleByVectorDot(global::Vector.RightVectorProxy, vector);
				FRotator frotator = new FRotator(0f, inYaw, 0f);
				FQuat fquat = frotator.Quaternion();
				value.SetRotation(fquat);
			}
			else
			{
				BP_RollBlockGameplaySetting_C gameplaySetting3 = RollBlockController.Instance.GameplaySetting;
				text2 = ((gameplaySetting3 != null) ? gameplaySetting3.LightBeamHitEffect.ToAssetPathName() : null);
			}
			if (!string.IsNullOrEmpty(text2))
			{
				fvectorDouble = this.AbsolutePoints.Get(this.AbsolutePoints.Num() - 1);
				value.SetTranslation(fvectorDouble);
				EffectSystem instance2 = EffectSystem.Instance;
				UObject world = GlobalData.World;
				FTransformDouble? ftransformDouble = new FTransformDouble?(value);
				int num = instance2.SpawnEffect(world, ftransformDouble, text2, "[RbLightBeamItemLogic] HitEffect]", new EffectContext(new int?(this.Owner.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false);
				OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(num);
				AActor owner = this.Owner.ActorComp.Owner;
				FName? fname = null;
				effectActor.K2_AttachToActor(owner, fname, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false);
				this.HitEffectHandle = new int?(num);
			}
		}

		// Token: 0x06039DFA RID: 237050 RVA: 0x010457C0 File Offset: 0x010439C0
		private void InitTraceElement(FVectorDouble traceStartPoint, FVectorDouble traceEndPoint)
		{
			if (this.TraceElement == null)
			{
				this.TraceElement = new UTraceBoxElement();
				this.TraceElement.bIgnoreSelf = true;
				this.TraceElement.bIsSingle = true;
				this.TraceElement.ActorsToIgnore.Empty(true);
				TArray<AActor> sceneInteractionAllActorsInLevel = SceneInteractionManager.Get().GetSceneInteractionAllActorsInLevel(this.Owner.ActorComp.GetSceneInteractionLevelHandleId());
				for (int i = 0; i < sceneInteractionAllActorsInLevel.Num(); i++)
				{
					this.TraceElement.ActorsToIgnore.Add(sceneInteractionAllActorsInLevel.Get(i));
				}
				this.TraceElement.SetBoxHalfSize(5f, 5f, 5f);
				TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>();
				tarray.Add(KuroObjectTypeQuery.WorldStatic);
				tarray.Add(KuroObjectTypeQuery.WorldDynamic);
				this.TraceElement.SetObjectTypesQuery(ref tarray);
				this.TraceElement.WorldContextObject = this.Owner.ActorComp.Owner;
			}
			this.TraceElement.SetStartLocation(traceStartPoint.X, traceStartPoint.Y, traceStartPoint.Z);
			this.TraceElement.SetEndLocation(traceEndPoint.X, traceEndPoint.Y, traceEndPoint.Z);
		}

		// Token: 0x06039DFB RID: 237051 RVA: 0x010458F4 File Offset: 0x01043AF4
		private void OnActorOverlapCallback(bool isEnter, AActor actor)
		{
			if (this.IgnoreOverlap)
			{
				return;
			}
			EntityHandle entityHandle = this.ExtractEntity(actor);
			if (entityHandle != null && entityHandle.Id == this.Owner.Entity.Id)
			{
				return;
			}
			this.UpdateEffectByTrace();
		}

		// Token: 0x06039DFC RID: 237052 RVA: 0x01045934 File Offset: 0x01043B34
		[NullableContext(2)]
		private EntityHandle ExtractEntity(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return null;
			}
			return CreatureModel.Instance.GetEntityByChildActor(actor);
		}

		// Token: 0x06039DFD RID: 237053 RVA: 0x0104594E File Offset: 0x01043B4E
		private void OnSceneItemLockPropChange(bool isLock)
		{
			if (isLock)
			{
				this.StopAllEffect();
				this.RelativePoints.Empty(true);
				this.AbsolutePoints.Empty(true);
				this.StopOverlap();
				return;
			}
			this.UpdateEffectByTrace();
			this.StartOverlap();
		}

		// Token: 0x06039DFE RID: 237054 RVA: 0x01045984 File Offset: 0x01043B84
		private void StartOverlap()
		{
			if (!EventSystem.Instance.HasWithTarget(this.Owner.Entity, EEventName.OnActorInOutRangeLocal, new Action<bool, AActor>(this.OnActorOverlapCallback)))
			{
				EventSystem.Instance.AddWithTarget(this.Owner.Entity, EEventName.OnActorInOutRangeLocal, new Action<bool, AActor>(this.OnActorOverlapCallback));
			}
		}

		// Token: 0x06039DFF RID: 237055 RVA: 0x010459E0 File Offset: 0x01043BE0
		private void StopOverlap()
		{
			if (EventSystem.Instance.HasWithTarget(this.Owner.Entity, EEventName.OnActorInOutRangeLocal, new Action<bool, AActor>(this.OnActorOverlapCallback)))
			{
				EventSystem.Instance.RemoveWithTarget(this.Owner.Entity, EEventName.OnActorInOutRangeLocal, new Action<bool, AActor>(this.OnActorOverlapCallback));
			}
		}

		// Token: 0x06039E00 RID: 237056 RVA: 0x01045A3C File Offset: 0x01043C3C
		private void StopAllEffect()
		{
			this.StopBeamEffect();
			if (this.StartEffectHandle != null)
			{
				EffectSystem.Instance.StopEffectById(this.StartEffectHandle.Value, "RbLightBeamItemLogic StopAllEffect", true, null);
				this.StartEffectHandle = null;
			}
		}

		// Token: 0x06039E01 RID: 237057 RVA: 0x01045A90 File Offset: 0x01043C90
		private void StopBeamEffect()
		{
			if (this.EffectHandle != null)
			{
				EffectSystem.Instance.StopEffectById(this.EffectHandle.Value, "RbLightBeamItemLogic StopBeamEffect", true, null);
				this.EffectHandle = null;
			}
			if (this.HitEffectHandle != null)
			{
				EffectSystem.Instance.StopEffectById(this.HitEffectHandle.Value, "RbLightBeamItemLogic StopBeamEffect", true, null);
				this.HitEffectHandle = null;
			}
		}

		// Token: 0x0401E94E RID: 125262
		private const int LIGHT_BEAM_BOX_EXTENT_WIDTH = 5;

		// Token: 0x0401E94F RID: 125263
		private const int LIGHT_BEAM_BOX_EXTENT_HEIGHT = 5;

		// Token: 0x0401E950 RID: 125264
		private FVectorDouble? OriginLocation;

		// Token: 0x0401E951 RID: 125265
		private int? EffectHandle;

		// Token: 0x0401E952 RID: 125266
		private int? HitEffectHandle;

		// Token: 0x0401E953 RID: 125267
		private int? StartEffectHandle;

		// Token: 0x0401E954 RID: 125268
		private readonly TArray<FVectorDouble> RelativePoints = new TArray<FVectorDouble>();

		// Token: 0x0401E955 RID: 125269
		private readonly global::Vector Location = global::Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401E956 RID: 125270
		[Nullable(2)]
		private UTraceBoxElement TraceElement;

		// Token: 0x0401E957 RID: 125271
		[Nullable(2)]
		private RangeComponent RangeComp;

		// Token: 0x0401E958 RID: 125272
		private readonly global::Vector BoxExtent = global::Vector.Create(0.0, 5.0, 5.0);

		// Token: 0x0401E959 RID: 125273
		private readonly TArray<FVectorDouble> AbsolutePoints = new TArray<FVectorDouble>();

		// Token: 0x0401E95A RID: 125274
		private readonly TArray<FVectorDouble> AbsoluteOriginPoint = new TArray<FVectorDouble>();

		// Token: 0x0401E95B RID: 125275
		private FVectorDouble ImpactPoint = new FVectorDouble();

		// Token: 0x0401E95C RID: 125276
		private bool IgnoreOverlap;
	}
}
