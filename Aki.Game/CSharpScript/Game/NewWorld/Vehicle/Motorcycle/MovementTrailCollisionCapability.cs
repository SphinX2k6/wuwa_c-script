using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x02007030 RID: 28720
	[NullableContext(1)]
	[Nullable(0)]
	public class MovementTrailCollisionCapability : WaterDetectedCapability
	{
		// Token: 0x06045EAD RID: 286381 RVA: 0x01166B80 File Offset: 0x01164D80
		[NullableContext(2)]
		public MovementTrailCollisionCapability(AActor invoker = null, AActor owner = null, UKuroTrailCollisionAsset kuroTrailCollisionAsset = null)
		{
			this.Invoker = invoker;
			this.Owner = owner;
			this.KuroTrailCollisionAsset = kuroTrailCollisionAsset;
		}

		// Token: 0x06045EAE RID: 286382 RVA: 0x01166BD4 File Offset: 0x01164DD4
		public void ResetTrail()
		{
			this.HaveLast = false;
			this.LastPos.Reset();
			this.CurPos.Reset();
			if (this.Segments != null)
			{
				foreach (MovementTrailCollisionCapability.TrailSegment segment in this.Segments)
				{
					this.Recycle(segment);
				}
			}
			HashSet<MovementTrailCollisionCapability.TrailSegment> segments = this.Segments;
			if (segments != null)
			{
				segments.Clear();
			}
			PriorityQueue<MovementTrailCollisionCapability.TrailSegment> segmentsSpawnTimeQueue = this.SegmentsSpawnTimeQueue;
			if (segmentsSpawnTimeQueue == null)
			{
				return;
			}
			segmentsSpawnTimeQueue.Clear();
		}

		// Token: 0x06045EAF RID: 286383 RVA: 0x01166C70 File Offset: 0x01164E70
		public override void Activate()
		{
			UKuroTrailCollisionAsset kuroTrailCollisionAsset = this.KuroTrailCollisionAsset;
			if (kuroTrailCollisionAsset == null || !kuroTrailCollisionAsset.IsValid())
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision 没有配置KuroTrailCollisionAsset", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.BoxPool = new Pool<MovementTrailCollisionCapability.BoxComponentProxy>(this.KuroTrailCollisionAsset.MaxSegments, delegate()
			{
				AActor owner = this.Owner;
				if (owner != null && owner.IsValid())
				{
					UKuroTrailCollisionAsset kuroTrailCollisionAsset2 = this.KuroTrailCollisionAsset;
					if (kuroTrailCollisionAsset2 != null && kuroTrailCollisionAsset2.IsValid())
					{
						UBoxComponent uboxComponent = this.Owner.D_AddComponentByClass(UBoxComponent.StaticClass(), false, MathUtils.Instance.DefaultTransformDouble, false, default(FName)) as UBoxComponent;
						if (uboxComponent == null || !uboxComponent.IsValid())
						{
							return MovementTrailCollisionCapability.EmptyBoxProxy;
						}
						uboxComponent.SetHiddenInGame(true, false);
						this.ApplyCollisionSetup(uboxComponent);
						uboxComponent.K2_DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, false);
						return new MovementTrailCollisionCapability.BoxComponentProxy(uboxComponent);
					}
				}
				return MovementTrailCollisionCapability.EmptyBoxProxy;
			}, delegate(MovementTrailCollisionCapability.BoxComponentProxy boxProxy)
			{
				UBoxComponent boxComponent = boxProxy.BoxComponent;
				if (boxComponent == null || !boxComponent.IsValid())
				{
					return;
				}
				boxProxy.BoxComponent.SetCollisionEnabled(ECollisionEnabled.NoCollision);
			});
			this.Segments = new HashSet<MovementTrailCollisionCapability.TrailSegment>();
			this.SegmentsSpawnTimeQueue = new PriorityQueue<MovementTrailCollisionCapability.TrailSegment>((MovementTrailCollisionCapability.TrailSegment a, MovementTrailCollisionCapability.TrailSegment b) => (int)(a.SpawnTime - b.SpawnTime));
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.TickActive), this.KuroTrailCollisionAsset.StepInterval, 1f, null, null, true);
		}

		// Token: 0x06045EB0 RID: 286384 RVA: 0x01166D57 File Offset: 0x01164F57
		public override void Deactivate()
		{
			this.ResetTrail();
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			}
		}

		// Token: 0x06045EB1 RID: 286385 RVA: 0x01166D78 File Offset: 0x01164F78
		public override bool? ShouldTickActive()
		{
			return new bool?(this.Segments != null && this.Segments.Count > 0);
		}

		// Token: 0x06045EB2 RID: 286386 RVA: 0x01166D98 File Offset: 0x01164F98
		public override void TickActive(float deltaTime)
		{
			this.TrimByTTL((float)Time.Instance.WorldTime);
		}

		// Token: 0x06045EB3 RID: 286387 RVA: 0x01166DAC File Offset: 0x01164FAC
		private void SpawnOrExtendSegment(Vector start, Vector end, Vector normal)
		{
			UKuroTrailCollisionAsset kuroTrailCollisionAsset = this.KuroTrailCollisionAsset;
			if (kuroTrailCollisionAsset == null || !kuroTrailCollisionAsset.IsValid())
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision SpawnOrExtendSegment KuroTrailCollisionAsset 无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.Segments == null || this.BoxPool == null)
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision SpawnOrExtendSegment Segments 或BoxPool 无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (Time.Instance.WorldTime - this.LastTime < (double)this.KuroTrailCollisionAsset.StepInterval)
			{
				return;
			}
			this.LastTime = Time.Instance.WorldTime;
			if (!end.Subtraction(start, Vector.Create()).Normalize(9.99999993922529E-09))
			{
				return;
			}
			if (this.Segments.Count >= this.KuroTrailCollisionAsset.MaxSegments)
			{
				PriorityQueue<MovementTrailCollisionCapability.TrailSegment> segmentsSpawnTimeQueue = this.SegmentsSpawnTimeQueue;
				MovementTrailCollisionCapability.TrailSegment trailSegment = (segmentsSpawnTimeQueue != null) ? segmentsSpawnTimeQueue.Top : null;
				if (trailSegment != null)
				{
					this.Recycle(trailSegment);
				}
			}
			MovementTrailCollisionCapability.BoxComponentProxy boxComponentProxy = this.BoxPool.Get() ?? this.BoxPool.Create();
			bool flag;
			if (boxComponentProxy == null)
			{
				flag = true;
			}
			else
			{
				UBoxComponent boxComponent = boxComponentProxy.BoxComponent;
				flag = !((boxComponent != null) ? new bool?(boxComponent.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return;
			}
			this.UpdateBoxSegment(boxComponentProxy.BoxComponent, start, end, normal);
			this.SpawnSegment(boxComponentProxy, start, end);
			UKismetMaterialLibrary.SetVectorParameterValue(this.Invoker, RenderDataManager.Instance.GetGlobalShaderParameters(), MovementTrailCollisionCapability.iceRiderPositionName, ColorUtils.LinearBlack);
			this.LastPos.DeepCopy(this.CurPos);
		}

		// Token: 0x06045EB4 RID: 286388 RVA: 0x01166F34 File Offset: 0x01165134
		private void UpdateBoxSegment(UBoxComponent box, Vector start, Vector end, Vector normal)
		{
			if (box == null || !box.IsValid())
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision UpdateBoxSegment Box无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			end.Subtraction(start, MathUtils.Instance.CommonTempVector);
			double length = MathUtils.Instance.CommonTempVector.Size();
			if (!MathUtils.Instance.CommonTempVector.Normalize(9.99999993922529E-09))
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision UpdateBoxSegment dir 无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!normal.Normalize(9.99999993922529E-09))
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision UpdateBoxSegment normal 无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			start.Addition(end, MathUtils.Instance.CommonTempVector2);
			MathUtils.Instance.CommonTempVector2.MultiplyEqual(0.5);
			Vector vector = Vector.Create();
			MathUtils.Instance.CommonTempVector.Subtraction(normal.Multiply(MathUtils.Instance.CommonTempVector.DotProduct(normal), Vector.Create()), vector);
			if (!vector.Normalize(9.99999993922529E-09))
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision UpdateBoxSegment 水面法线和移动方向平行", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Vector.CrossProduct(normal, vector, MathUtils.Instance.CommonTempVector);
			FRotator rot = UKismetMathLibrary.MakeRotationFromAxes(vector.ToUeVectorOld(), MathUtils.Instance.CommonTempVector.ToUeVectorOld(), normal.ToUeVectorOld());
			this.UpdateBoxShapeAndCollision(box, MathUtils.Instance.CommonTempVector2.ToUeVector(false), rot, length);
		}

		// Token: 0x06045EB5 RID: 286389 RVA: 0x011670D4 File Offset: 0x011652D4
		private void UpdateBoxShapeAndCollision(UBoxComponent box, FVectorDouble loc, FRotator rot, double length)
		{
			if (box != null && box.IsValid())
			{
				UKuroTrailCollisionAsset kuroTrailCollisionAsset = this.KuroTrailCollisionAsset;
				if (kuroTrailCollisionAsset != null && kuroTrailCollisionAsset.IsValid())
				{
					box.K2_DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, true);
					FHitResult fhitResult = new FHitResult();
					box.D_K2_SetWorldLocation(loc, false, ref fhitResult, false);
					box.K2_SetWorldRotation(rot, false, ref fhitResult, false);
					box.SetBoxExtent(new FVector((float)(0.5 * length + (double)this.KuroTrailCollisionAsset.PaddingAlong), this.KuroTrailCollisionAsset.HalfWidth, this.KuroTrailCollisionAsset.HalfHeight), true);
					box.SetCollisionEnabled(ECollisionEnabled.QueryOnly);
					return;
				}
			}
			Log.Instance.Error(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision UpdateBoxShapeAndCollision Box或者KuroTrailCollisionAsset无效", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06045EB6 RID: 286390 RVA: 0x01167190 File Offset: 0x01165390
		private bool Recycle(MovementTrailCollisionCapability.TrailSegment segment)
		{
			if (SundryModel.Instance.GetModuleDebugLevel("MovementTrailCollision") > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "MovementTrailCollision Recycle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("segment", segment);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			MovementTrailCollisionCapability.BoxComponentProxy box = segment.Box;
			bool flag;
			if (box == null)
			{
				flag = false;
			}
			else
			{
				UBoxComponent boxComponent = box.BoxComponent;
				flag = ((boxComponent != null) ? new bool?(boxComponent.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				segment.Box.BoxComponent.SetCollisionEnabled(ECollisionEnabled.NoCollision);
				Pool<MovementTrailCollisionCapability.BoxComponentProxy> boxPool = this.BoxPool;
				if (boxPool != null)
				{
					boxPool.Put(segment.Box);
				}
			}
			segment.Box = null;
			if (this.Segments == null || this.SegmentsSpawnTimeQueue == null)
			{
				return false;
			}
			bool result = this.Segments.Remove(segment) && this.SegmentsSpawnTimeQueue.Remove(segment);
			if (this.Segments.Count == 0)
			{
				UKismetMaterialLibrary.SetVectorParameterValue(this.Invoker, RenderDataManager.Instance.GetGlobalShaderParameters(), MovementTrailCollisionCapability.iceRiderPositionName, ColorUtils.LinearClear);
			}
			return result;
		}

		// Token: 0x06045EB7 RID: 286391 RVA: 0x01167298 File Offset: 0x01165498
		private unsafe void SpawnSegment(MovementTrailCollisionCapability.BoxComponentProxy box, Vector start, Vector end)
		{
			bool flag;
			if (box == null)
			{
				flag = true;
			}
			else
			{
				UBoxComponent boxComponent = box.BoxComponent;
				flag = !((boxComponent != null) ? new bool?(boxComponent.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision SpawnSegment BoxComponent无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			MovementTrailCollisionCapability.TrailSegment trailSegment = new MovementTrailCollisionCapability.TrailSegment();
			trailSegment.SpawnTime = Time.Instance.WorldTime;
			trailSegment.Start = Vector.Create(start);
			trailSegment.End = Vector.Create(end);
			trailSegment.Box = box;
			HashSet<MovementTrailCollisionCapability.TrailSegment> segments = this.Segments;
			if (segments != null)
			{
				segments.Add(trailSegment);
			}
			PriorityQueue<MovementTrailCollisionCapability.TrailSegment> segmentsSpawnTimeQueue = this.SegmentsSpawnTimeQueue;
			if (segmentsSpawnTimeQueue != null)
			{
				segmentsSpawnTimeQueue.Push(trailSegment);
			}
			if (SundryModel.Instance.GetModuleDebugLevel("MovementTrailCollision") > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "MovementTrailCollision SpawnSegment";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("segment", trailSegment);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("segments", this.Segments);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x06045EB8 RID: 286392 RVA: 0x011673B8 File Offset: 0x011655B8
		private void ApplyCollisionSetup(UBoxComponent box)
		{
			if (box != null && box.IsValid())
			{
				UKuroTrailCollisionAsset kuroTrailCollisionAsset = this.KuroTrailCollisionAsset;
				if (kuroTrailCollisionAsset != null && kuroTrailCollisionAsset.IsValid())
				{
					box.SetMobility(this.KuroTrailCollisionAsset.Mobility);
					box.SetCollisionProfileName(this.KuroTrailCollisionAsset.CollisionProfileName.Name, true);
					box.SetGenerateOverlapEvents(this.KuroTrailCollisionAsset.bGenerateOverlapEvents);
					box.bKuroOverlapNotify = this.KuroTrailCollisionAsset.bKuroOverlapNotify;
					box.bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap = this.KuroTrailCollisionAsset.bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap;
					box.bKuroPassiveCollision = this.KuroTrailCollisionAsset.bKuroPassiveCollision;
					if (this.KuroTrailCollisionAsset.bIgnoreOwner)
					{
						AActor owner = this.Owner;
						if (owner != null && owner.IsValid())
						{
							box.IgnoreActorWhenMoving(this.Owner, true);
						}
					}
					if (this.IgnoreInvoker)
					{
						AActor invoker = this.Invoker;
						if (invoker != null && invoker.IsValid())
						{
							box.IgnoreActorWhenMoving(this.Invoker, true);
						}
					}
					return;
				}
			}
			Log.Instance.Error(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision ApplyCollisionSetup Box或者KuroTrailCollisionAsset无效", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06045EB9 RID: 286393 RVA: 0x011674D4 File Offset: 0x011656D4
		private void TrimByTTL(float nowMilliseconds)
		{
			UKuroTrailCollisionAsset kuroTrailCollisionAsset = this.KuroTrailCollisionAsset;
			if (kuroTrailCollisionAsset == null || !kuroTrailCollisionAsset.IsValid() || this.KuroTrailCollisionAsset.TTLSeconds < 0.0001f)
			{
				return;
			}
			if (this.Segments == null || this.Segments.Count <= 0)
			{
				return;
			}
			AActor invoker = this.Invoker;
			if (invoker != null && invoker.IsValid())
			{
				AActor owner = this.Owner;
				if (owner != null && owner.IsValid())
				{
					EntityHandle entityByActor = ActorUtils.GetEntityByActor(this.Invoker, true);
					if (entityByActor != null && entityByActor.Valid)
					{
						WorldEntity entity = entityByActor.Entity;
						if (entity != null && entity.Valid)
						{
							BaseActorComponent baseActorComponent = entityByActor.Entity.CheckGetComponent<BaseActorComponent>();
							if (baseActorComponent == null)
							{
								return;
							}
							Vector commonTempVector = MathUtils.Instance.CommonTempVector;
							FVectorDouble fvectorDouble = this.Owner.D_K2_GetActorLocation();
							commonTempVector.FromUeVector(fvectorDouble);
							GravityUtils.Instance.ConvertToPlanarVectorForActor(baseActorComponent, MathUtils.Instance.CommonTempVector);
							double num = 2890000.0;
							double num2 = (double)(this.KuroTrailCollisionAsset.StepDistance * this.KuroTrailCollisionAsset.StepDistance);
							List<MovementTrailCollisionCapability.TrailSegment> list = new List<MovementTrailCollisionCapability.TrailSegment>();
							foreach (MovementTrailCollisionCapability.TrailSegment trailSegment in this.Segments)
							{
								MovementTrailCollisionCapability.BoxComponentProxy box = trailSegment.Box;
								bool flag;
								if (box == null)
								{
									flag = true;
								}
								else
								{
									UBoxComponent boxComponent = box.BoxComponent;
									flag = !((boxComponent != null) ? new bool?(boxComponent.IsValid()) : null).GetValueOrDefault();
								}
								if (flag)
								{
									list.Add(trailSegment);
								}
								else
								{
									if (SundryModel.Instance.GetModuleDebugLevel("MovementTrailCollision") > 0)
									{
										Log instance = Log.Instance;
										ELogModule module = ELogModule.Movement;
										ELogAuthor author = ELogAuthor.XDW;
										string message = "MovementTrailCollision TrimByTTL";
										ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("segment", trailSegment);
										instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
										UKismetSystemLibrary.DrawDebugBox(this.Owner, trailSegment.Box.BoxComponent.K2_GetComponentLocation(), trailSegment.Box.BoxComponent.BoxExtent, ColorUtils.LinearGreen, trailSegment.Box.BoxComponent.K2_GetComponentRotation(), 0f, 0f);
									}
									MathUtils.Instance.CommonTempVector2.DeepCopy(trailSegment.End);
									GravityUtils.Instance.ConvertToPlanarVectorForActor(baseActorComponent, MathUtils.Instance.CommonTempVector2);
									double num3 = Vector.DistSquared(MathUtils.Instance.CommonTempVector, MathUtils.Instance.CommonTempVector2);
									if (num3 > num)
									{
										list.Add(trailSegment);
									}
									else if (this.DetectingWater && !this.Invoker.bHidden && num3 < num2)
									{
										trailSegment.SpawnTime = (double)nowMilliseconds;
									}
									else if ((double)nowMilliseconds - trailSegment.SpawnTime > (double)(this.KuroTrailCollisionAsset.TTLSeconds * 1000f))
									{
										list.Add(trailSegment);
									}
								}
							}
							foreach (MovementTrailCollisionCapability.TrailSegment segment in list)
							{
								this.Recycle(segment);
							}
							return;
						}
					}
					return;
				}
			}
		}

		// Token: 0x06045EBA RID: 286394 RVA: 0x0116780C File Offset: 0x01165A0C
		public override void OnWaterDetectedStart()
		{
			this.HaveLast = false;
			this.DetectingWater = true;
			Log.Instance.Info(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision OnWaterDetectedStart", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06045EBB RID: 286395 RVA: 0x01167844 File Offset: 0x01165A44
		public override void OnWaterDetectedEnd()
		{
			if (!this.DetectingWater)
			{
				Log.Instance.Warn(ELogModule.Movement, ELogAuthor.XDW, "检查BroadcastWaterDetectedTick逻辑，未调用Start就开始End", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.DetectingWater = false;
			Log.Instance.Info(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision OnWaterDetectedEnd", default(ReadOnlySpan<ValueTuple<string, object>>));
			UObject invoker = this.Invoker;
			UMaterialParameterCollection globalShaderParameters = RenderDataManager.Instance.GetGlobalShaderParameters();
			FName parameterName = MovementTrailCollisionCapability.iceRiderPositionName;
			FLinearColor flinearColor = (this.Segments == null || this.Segments.Count == 0) ? ColorUtils.LinearClear : ColorUtils.LinearBlack;
			UKismetMaterialLibrary.SetVectorParameterValue(invoker, globalShaderParameters, parameterName, flinearColor);
		}

		// Token: 0x06045EBC RID: 286396 RVA: 0x011678D8 File Offset: 0x01165AD8
		public unsafe void OnWaterDetectedTick(double deltaTime, Vector location, Vector normal)
		{
			if (!this.DetectingWater)
			{
				Log.Instance.Warn(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision 检查BroadcastWaterDetectedTick逻辑，未调用Start就开始Tick", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UKuroTrailCollisionAsset kuroTrailCollisionAsset = this.KuroTrailCollisionAsset;
			if (kuroTrailCollisionAsset == null || !kuroTrailCollisionAsset.IsValid())
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision HandleWaterDetectedTick KuroTrailCollisionAsset无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			AActor invoker = this.Invoker;
			if (invoker == null || !invoker.IsValid())
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision HandleWaterDetectedTick Invoker无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (SundryModel.Instance.GetModuleDebugLevel("MovementTrailCollision") > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "OnWaterDetectedTick";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("location", location);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("normal", normal);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			this.CurPos.DeepCopy(location);
			if (!this.HaveLast)
			{
				this.HaveLast = true;
				this.LastPos.DeepCopy(location);
				Vector inB = Vector.Create(this.Invoker.GetActorForwardVector());
				this.SpawnOrExtendSegment(this.CurPos.Subtraction(inB, Vector.Create()), this.CurPos.Addition(inB, Vector.Create()), normal);
				return;
			}
			double num = Vector.DistSquared(this.CurPos, this.LastPos);
			if (this.KuroTrailCollisionAsset.TeleportDistance > 0.0001f && num > (double)(this.KuroTrailCollisionAsset.TeleportDistance * this.KuroTrailCollisionAsset.TeleportDistance))
			{
				this.ResetTrail();
				return;
			}
			if (this.KuroTrailCollisionAsset.StepDistance > 0.0001f && num < (double)(this.KuroTrailCollisionAsset.StepDistance * this.KuroTrailCollisionAsset.StepDistance))
			{
				return;
			}
			this.SpawnOrExtendSegment(this.LastPos, this.CurPos, normal);
		}

		// Token: 0x06045EBD RID: 286397 RVA: 0x01167AC5 File Offset: 0x01165CC5
		public override void OnWaterDetectedTick(float deltaTime, Vector impactPoint, Vector impactNormal)
		{
			this.OnWaterDetectedTick((double)deltaTime, impactPoint, impactNormal);
		}

		// Token: 0x040248F7 RID: 149751
		private const int MAX_DISTANCE = 1700;

		// Token: 0x040248F8 RID: 149752
		private const string DEBUG_KEY = "MovementTrailCollision";

		// Token: 0x040248F9 RID: 149753
		[StaticVariableRuleIgnore]
		public static FName iceRiderPositionName = FNameUtil.GetDynamicFName("IceRiderPosition").Value;

		// Token: 0x040248FA RID: 149754
		[Nullable(2)]
		public AActor Invoker;

		// Token: 0x040248FB RID: 149755
		[Nullable(2)]
		public AActor Owner;

		// Token: 0x040248FC RID: 149756
		[Nullable(2)]
		public UKuroTrailCollisionAsset KuroTrailCollisionAsset;

		// Token: 0x040248FD RID: 149757
		public bool IgnoreInvoker = true;

		// Token: 0x040248FE RID: 149758
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private HashSet<MovementTrailCollisionCapability.TrailSegment> Segments;

		// Token: 0x040248FF RID: 149759
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private PriorityQueue<MovementTrailCollisionCapability.TrailSegment> SegmentsSpawnTimeQueue;

		// Token: 0x04024900 RID: 149760
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Pool<MovementTrailCollisionCapability.BoxComponentProxy> BoxPool;

		// Token: 0x04024901 RID: 149761
		private bool HaveLast;

		// Token: 0x04024902 RID: 149762
		private bool DetectingWater;

		// Token: 0x04024903 RID: 149763
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x04024904 RID: 149764
		private readonly Vector CurPos = Vector.Create();

		// Token: 0x04024905 RID: 149765
		private readonly Vector LastPos = Vector.Create();

		// Token: 0x04024906 RID: 149766
		[StaticVariableRuleIgnore]
		private static readonly MovementTrailCollisionCapability.BoxComponentProxy EmptyBoxProxy = new MovementTrailCollisionCapability.BoxComponentProxy(null);

		// Token: 0x04024907 RID: 149767
		private double LastTime = -1.0;

		// Token: 0x0200CE21 RID: 52769
		[NullableContext(2)]
		[Nullable(0)]
		protected class BoxComponentProxy
		{
			// Token: 0x06051DE0 RID: 335328 RVA: 0x0163F3AA File Offset: 0x0163D5AA
			public BoxComponentProxy(UBoxComponent boxComponent = null)
			{
				this.BoxComponent = boxComponent;
			}

			// Token: 0x0403E161 RID: 254305
			public UBoxComponent BoxComponent;
		}

		// Token: 0x0200CE22 RID: 52770
		[Nullable(0)]
		protected class TrailSegment
		{
			// Token: 0x0403E162 RID: 254306
			[Nullable(2)]
			public MovementTrailCollisionCapability.BoxComponentProxy Box;

			// Token: 0x0403E163 RID: 254307
			public double SpawnTime;

			// Token: 0x0403E164 RID: 254308
			public Vector Start = Vector.ZeroVectorProxy;

			// Token: 0x0403E165 RID: 254309
			public Vector End = Vector.ZeroVectorProxy;
		}
	}
}
