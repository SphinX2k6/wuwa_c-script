using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x020061B1 RID: 25009
	[NullableContext(1)]
	[Nullable(0)]
	public class MovementTrailCollisionCapability : WaterDetectedCapability
	{
		// Token: 0x0603C08F RID: 245903 RVA: 0x011109CC File Offset: 0x0110EBCC
		[NullableContext(2)]
		public MovementTrailCollisionCapability(AActor invoker = null, AActor owner = null, UKuroTrailCollisionAsset kuroTrailCollisionAsset = null)
		{
			this.Invoker = invoker;
			this.Owner = owner;
			this.KuroTrailCollisionAsset = kuroTrailCollisionAsset;
		}

		// Token: 0x0603C090 RID: 245904 RVA: 0x01110A20 File Offset: 0x0110EC20
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

		// Token: 0x0603C091 RID: 245905 RVA: 0x01110ABC File Offset: 0x0110ECBC
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

		// Token: 0x0603C092 RID: 245906 RVA: 0x01110BA3 File Offset: 0x0110EDA3
		public override void Deactivate()
		{
			this.ResetTrail();
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			}
		}

		// Token: 0x0603C093 RID: 245907 RVA: 0x01110BC4 File Offset: 0x0110EDC4
		public override bool? ShouldTickActive()
		{
			return new bool?(this.Segments != null && this.Segments.Count > 0);
		}

		// Token: 0x0603C094 RID: 245908 RVA: 0x01110BE4 File Offset: 0x0110EDE4
		public override void TickActive(float deltaTime)
		{
			this.TrimByTTL((float)Time.Instance.WorldTime);
		}

		// Token: 0x0603C095 RID: 245909 RVA: 0x01110BF8 File Offset: 0x0110EDF8
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

		// Token: 0x0603C096 RID: 245910 RVA: 0x01110D80 File Offset: 0x0110EF80
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

		// Token: 0x0603C097 RID: 245911 RVA: 0x01110F20 File Offset: 0x0110F120
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

		// Token: 0x0603C098 RID: 245912 RVA: 0x01110FDC File Offset: 0x0110F1DC
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

		// Token: 0x0603C099 RID: 245913 RVA: 0x011110E4 File Offset: 0x0110F2E4
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

		// Token: 0x0603C09A RID: 245914 RVA: 0x01111204 File Offset: 0x0110F404
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

		// Token: 0x0603C09B RID: 245915 RVA: 0x01111320 File Offset: 0x0110F520
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

		// Token: 0x0603C09C RID: 245916 RVA: 0x01111658 File Offset: 0x0110F858
		public override void OnWaterDetectedStart()
		{
			this.HaveLast = false;
			this.DetectingWater = true;
			Log.Instance.Info(ELogModule.Movement, ELogAuthor.XDW, "MovementTrailCollision OnWaterDetectedStart", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603C09D RID: 245917 RVA: 0x01111690 File Offset: 0x0110F890
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

		// Token: 0x0603C09E RID: 245918 RVA: 0x01111724 File Offset: 0x0110F924
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

		// Token: 0x0603C09F RID: 245919 RVA: 0x01111911 File Offset: 0x0110FB11
		public override void OnWaterDetectedTick(float deltaTime, Vector impactPoint, Vector impactNormal)
		{
			this.OnWaterDetectedTick((double)deltaTime, impactPoint, impactNormal);
		}

		// Token: 0x0401FBAD RID: 129965
		private const int MAX_DISTANCE = 1700;

		// Token: 0x0401FBAE RID: 129966
		private const string DEBUG_KEY = "MovementTrailCollision";

		// Token: 0x0401FBAF RID: 129967
		[StaticVariableRuleIgnore]
		public static FName iceRiderPositionName = FNameUtil.GetDynamicFName("IceRiderPosition").Value;

		// Token: 0x0401FBB0 RID: 129968
		[Nullable(2)]
		public AActor Invoker;

		// Token: 0x0401FBB1 RID: 129969
		[Nullable(2)]
		public AActor Owner;

		// Token: 0x0401FBB2 RID: 129970
		[Nullable(2)]
		public UKuroTrailCollisionAsset KuroTrailCollisionAsset;

		// Token: 0x0401FBB3 RID: 129971
		public bool IgnoreInvoker = true;

		// Token: 0x0401FBB4 RID: 129972
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private HashSet<MovementTrailCollisionCapability.TrailSegment> Segments;

		// Token: 0x0401FBB5 RID: 129973
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private PriorityQueue<MovementTrailCollisionCapability.TrailSegment> SegmentsSpawnTimeQueue;

		// Token: 0x0401FBB6 RID: 129974
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Pool<MovementTrailCollisionCapability.BoxComponentProxy> BoxPool;

		// Token: 0x0401FBB7 RID: 129975
		private bool HaveLast;

		// Token: 0x0401FBB8 RID: 129976
		private bool DetectingWater;

		// Token: 0x0401FBB9 RID: 129977
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0401FBBA RID: 129978
		private readonly Vector CurPos = Vector.Create();

		// Token: 0x0401FBBB RID: 129979
		private readonly Vector LastPos = Vector.Create();

		// Token: 0x0401FBBC RID: 129980
		[StaticVariableRuleIgnore]
		private static readonly MovementTrailCollisionCapability.BoxComponentProxy EmptyBoxProxy = new MovementTrailCollisionCapability.BoxComponentProxy(null);

		// Token: 0x0401FBBD RID: 129981
		private double LastTime = -1.0;

		// Token: 0x0200BA12 RID: 47634
		[NullableContext(2)]
		[Nullable(0)]
		protected class BoxComponentProxy
		{
			// Token: 0x06048649 RID: 296521 RVA: 0x016146CA File Offset: 0x016128CA
			public BoxComponentProxy(UBoxComponent boxComponent = null)
			{
				this.BoxComponent = boxComponent;
			}

			// Token: 0x0403958C RID: 234892
			public UBoxComponent BoxComponent;
		}

		// Token: 0x0200BA13 RID: 47635
		[Nullable(0)]
		protected class TrailSegment
		{
			// Token: 0x0403958D RID: 234893
			[Nullable(2)]
			public MovementTrailCollisionCapability.BoxComponentProxy Box;

			// Token: 0x0403958E RID: 234894
			public double SpawnTime;

			// Token: 0x0403958F RID: 234895
			public Vector Start = Vector.ZeroVectorProxy;

			// Token: 0x04039590 RID: 234896
			public Vector End = Vector.ZeroVectorProxy;
		}
	}
}
