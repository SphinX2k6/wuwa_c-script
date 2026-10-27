using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using UnrealEngine;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x020044BB RID: 17595
	[NullableContext(1)]
	[Nullable(0)]
	public class ChairMonitor
	{
		// Token: 0x0602D596 RID: 185750 RVA: 0x00A3A084 File Offset: 0x00A38284
		public ChairMonitor(Entity chairEntity, ChairFollowerConfig chairConfig, IPlayerFollowerChairHandler chairHandler, int transactionVersion)
		{
			this.ChairEntity = chairEntity;
			this.ChairHandler = chairHandler;
			this.TransactionVersion = transactionVersion;
			this.OverlapDuration = chairConfig.OverlapDuration;
			if (chairConfig.EnableOverlapCheck)
			{
				this.CreateOverlapBox(chairConfig);
			}
			if (chairConfig.EnableTickGroundCheck)
			{
				this.StartTickGroundCheck(chairConfig);
			}
			this.StartDistanceCheck(chairConfig);
			this.StartPlayerMoveCheck(chairConfig);
		}

		// Token: 0x0602D597 RID: 185751 RVA: 0x00A3A0FC File Offset: 0x00A382FC
		public void Dispose()
		{
			this.StopTickGroundCheck();
			this.StopDistanceCheck();
			this.StopPlayerMoveCheck();
			this.ClearOverlapOccupants();
			UBoxComponent overlapBox = this.OverlapBox;
			if (overlapBox != null && overlapBox.IsValid())
			{
				this.OverlapBox.OnComponentBeginOverlap.Remove(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>(this.OnComponentBeginOverlap));
				this.OverlapBox.OnComponentEndOverlap.Remove(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>(this.OnComponentEndOverlap));
				this.OverlapBox.K2_DestroyComponent(this.OverlapBox);
			}
			this.OverlapBox = null;
			this.GroundEvaluator.Dispose();
		}

		// Token: 0x0602D598 RID: 185752 RVA: 0x00A3A190 File Offset: 0x00A38390
		private void CreateOverlapBox(ChairFollowerConfig chairConfig)
		{
			BaseActorComponent component = this.ChairEntity.GetComponent<BaseActorComponent>();
			AActor aactor = (component != null) ? component.Owner : null;
			if (aactor == null || !aactor.IsValid())
			{
				return;
			}
			UBoxComponent box = aactor.D_AddComponentByClass(UBoxComponent.StaticClass(), false, MathUtils.Instance.DefaultTransformDouble, false, default(FName)) as UBoxComponent;
			UBoxComponent box2 = box;
			if (box2 == null || !box2.IsValid())
			{
				Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[ChairMonitor] 创建 overlap 检测 Box 失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			box.SetHiddenInGame(true, false);
			box.SetMobility(EComponentMobility.Movable);
			box.SetCollisionProfileName(chairConfig.OverlapProfileName, false);
			box.SetGenerateOverlapEvents(true);
			box.IgnoreActorWhenMoving(aactor, true);
			box.D_SetBoxExtent(new FVectorDouble((double)chairConfig.BoxHalfSizeX, (double)chairConfig.BoxHalfSizeY, (double)chairConfig.BoxHalfSizeZ), true);
			box.D_K2_SetRelativeLocation(new FVectorDouble(0.0, 0.0, (double)chairConfig.BoxCenterOffsetZ), false, ref WorldGlobal.SweepHitResult, false);
			box.OnComponentBeginOverlap.Add(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>(this.OnComponentBeginOverlap));
			box.OnComponentEndOverlap.Add(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>(this.OnComponentEndOverlap));
			this.OverlapBox = box;
			TimerSystem.Instance.Next(delegate(float _)
			{
				if (!this.ChairEntity.Valid || this.OverlapBox != box || !box.IsValid())
				{
					return;
				}
				TArray<UPrimitiveComponent> tarray = new TArray<UPrimitiveComponent>();
				TArray<int> tarray2 = new TArray<int>();
				UKuroCollisionLibrary.GetOverlappingComponents(box, ref tarray, ref tarray2);
				if (tarray == null)
				{
					return;
				}
				for (int i = 0; i < tarray.Num(); i++)
				{
					UPrimitiveComponent uprimitiveComponent = tarray.Get(i);
					AActor aactor2 = (uprimitiveComponent != null) ? uprimitiveComponent.GetOwner() : null;
					bool flag = this.IsOccupantOverlap(aactor2);
					this.LogOccupantOverlapInfo("InitialOverlap", aactor2, uprimitiveComponent, flag);
					if (flag && aactor2 != null)
					{
						this.OnOccupantBegin(aactor2);
					}
				}
			}, null, null);
		}

		// Token: 0x0602D599 RID: 185753 RVA: 0x00A3A330 File Offset: 0x00A38530
		[NullableContext(2)]
		private void OnComponentBeginOverlap(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex, bool bFromSweep, [Nullable(1)] FHitResult sweepResult)
		{
			bool flag = this.IsOccupantOverlap(otherActor);
			this.LogOccupantOverlapInfo("BeginOverlap", otherActor, otherComp, flag);
			if (!flag || otherActor == null)
			{
				return;
			}
			this.OnOccupantBegin(otherActor);
		}

		// Token: 0x0602D59A RID: 185754 RVA: 0x00A3A361 File Offset: 0x00A38561
		[NullableContext(2)]
		private void OnComponentEndOverlap(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex)
		{
			if (!this.ChairEntity.Valid || otherActor == null)
			{
				return;
			}
			this.LogOccupantOverlapInfo("EndOverlap", otherActor, otherComp, this.IsOccupantOverlap(otherActor));
			this.OnOccupantEnd(otherActor);
		}

		// Token: 0x0602D59B RID: 185755 RVA: 0x00A3A390 File Offset: 0x00A38590
		private unsafe void OnOccupantBegin(AActor actor)
		{
			if (this.OverlapOccupants.ContainsKey(actor))
			{
				return;
			}
			if (this.OverlapOccupants.Count >= 10)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[ChairMonitor] 占用空间非玩家 Actor 数量超过上限, 不再创建驻留计时器";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Max", 10);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", actor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ActorName", actor.GetName());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			if (this.OverlapDuration <= 0f)
			{
				this.OverlapOccupants[actor] = null;
				this.ChairHandler.SetChairSpaceOccupied(this.ChairEntity, true, actor, actor);
				this.ChairHandler.ExitSitDownDueToOverlap();
				return;
			}
			TimerHandle timerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				if (!this.OverlapOccupants.ContainsKey(actor))
				{
					return;
				}
				if (!this.IsActorStillOverlapping(actor))
				{
					this.RemoveOccupant(actor);
					this.ChairHandler.SetChairSpaceOccupied(this.ChairEntity, this.HasConfirmedOccupant(), actor, this.GetConfirmedOccupant());
					return;
				}
				this.OverlapOccupants[actor] = null;
				this.ChairHandler.SetChairSpaceOccupied(this.ChairEntity, true, actor, actor);
				this.ChairHandler.ExitSitDownDueToOverlap();
			}, this.OverlapDuration, null, null, true, 1f);
			if (timerHandle == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "[ChairMonitor] 驻留过滤定时器创建失败, 该 Actor 退化为立即判定占用";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("OverlapDuration", this.OverlapDuration);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.OverlapOccupants[actor] = null;
				this.ChairHandler.SetChairSpaceOccupied(this.ChairEntity, true, actor, actor);
				this.ChairHandler.ExitSitDownDueToOverlap();
				return;
			}
			this.OverlapOccupants[actor] = timerHandle;
		}

		// Token: 0x0602D59C RID: 185756 RVA: 0x00A3A548 File Offset: 0x00A38748
		private void OnOccupantEnd(AActor actor)
		{
			if (!this.OverlapOccupants.ContainsKey(actor))
			{
				return;
			}
			if (this.IsActorStillOverlapping(actor))
			{
				return;
			}
			this.RemoveOccupant(actor);
			this.ChairHandler.SetChairSpaceOccupied(this.ChairEntity, this.HasConfirmedOccupant(), actor, this.GetConfirmedOccupant());
		}

		// Token: 0x0602D59D RID: 185757 RVA: 0x00A3A588 File Offset: 0x00A38788
		private void RemoveOccupant(AActor actor)
		{
			TimerHandle timerHandle;
			if (!this.OverlapOccupants.TryGetValue(actor, out timerHandle))
			{
				return;
			}
			if (timerHandle != null)
			{
				TimerSystem.Instance.Remove(timerHandle);
			}
			this.OverlapOccupants.Remove(actor);
		}

		// Token: 0x0602D59E RID: 185758 RVA: 0x00A3A5C2 File Offset: 0x00A387C2
		private bool HasConfirmedOccupant()
		{
			return this.OverlapOccupants.Any((KeyValuePair<AActor, TimerHandle> occupant) => occupant.Value == null);
		}

		// Token: 0x0602D59F RID: 185759 RVA: 0x00A3A5F0 File Offset: 0x00A387F0
		[NullableContext(2)]
		private AActor GetConfirmedOccupant()
		{
			return this.OverlapOccupants.Where(delegate(KeyValuePair<AActor, TimerHandle> occupant)
			{
				KeyValuePair<AActor, TimerHandle> keyValuePair = occupant;
				return keyValuePair.Value == null;
			}).Select(delegate(KeyValuePair<AActor, TimerHandle> occupant)
			{
				KeyValuePair<AActor, TimerHandle> keyValuePair = occupant;
				return keyValuePair.Key;
			}).FirstOrDefault<AActor>();
		}

		// Token: 0x0602D5A0 RID: 185760 RVA: 0x00A3A650 File Offset: 0x00A38850
		private void ClearOverlapOccupants()
		{
			foreach (KeyValuePair<AActor, TimerHandle> keyValuePair in this.OverlapOccupants)
			{
				if (keyValuePair.Value != null)
				{
					TimerSystem.Instance.Remove(keyValuePair.Value);
				}
			}
			this.OverlapOccupants.Clear();
		}

		// Token: 0x0602D5A1 RID: 185761 RVA: 0x00A3A6C4 File Offset: 0x00A388C4
		[NullableContext(2)]
		private bool IsOccupantOverlap(AActor otherActor)
		{
			if (otherActor == null || !this.ChairEntity.Valid)
			{
				return false;
			}
			if (this.IsChairOwnActor(otherActor))
			{
				return false;
			}
			Entity entity = ChairMonitor.ExtractEntity(otherActor);
			if (entity == null || !entity.Valid)
			{
				return true;
			}
			if (entity == this.ChairEntity)
			{
				return false;
			}
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			return component == null || (!component.IsRole() && !component.IsPlayer());
		}

		// Token: 0x0602D5A2 RID: 185762 RVA: 0x00A3A72C File Offset: 0x00A3892C
		[NullableContext(2)]
		private unsafe void LogOccupantOverlapInfo([Nullable(1)] string phase, AActor otherActor, UPrimitiveComponent otherComp, bool isOccupant)
		{
			if (otherActor == null)
			{
				return;
			}
			ValueTuple<List<string>, List<string>, List<string>> valueTuple = ChairMonitor.CollectCollisionChannels(otherComp);
			string item = ChairMonitor.DescribeCollisionShape(otherComp);
			FBoxSphereBounds fboxSphereBounds = (otherComp != null) ? otherComp.D_GetComponentBounds() : default(FBoxSphereBounds);
			UBoxComponent overlapBox = this.OverlapBox;
			UBoxComponent uboxComponent = (overlapBox != null && overlapBox.IsValid()) ? this.OverlapBox : null;
			ValueTuple<List<string>, List<string>, List<string>> valueTuple2 = ChairMonitor.CollectCollisionChannels(uboxComponent);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[ChairMonitor] 椅子占用空间 overlap";
			<>y__InlineArray24<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray24<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Phase", phase);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsOccupant", isOccupant);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ChairId", this.ChairEntity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Actor", otherActor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("ActorName", otherActor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("ActorClass", otherActor.GetClass().GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("Component", otherComp);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("ComponentName", (otherComp != null) ? otherComp.GetName() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("Shape", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("Bounds", fboxSphereBounds);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 10) = new ValueTuple<string, object>("BoundsBoxExtent", fboxSphereBounds.BoxExtent);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 11) = new ValueTuple<string, object>("BoundsSphereRadius", fboxSphereBounds.SphereRadius);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 12) = new ValueTuple<string, object>("CollisionEnabled", (otherComp != null) ? otherComp.GetCollisionEnabled() : ECollisionEnabled.NoCollision);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 13) = new ValueTuple<string, object>("CollisionObjectType", (otherComp != null) ? otherComp.GetCollisionObjectType() : ECollisionChannel.ECC_MAX);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 14) = new ValueTuple<string, object>("BlockChannels", string.Join(",", valueTuple.Item1));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 15) = new ValueTuple<string, object>("OverlapChannels", string.Join(",", valueTuple.Item2));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 16) = new ValueTuple<string, object>("IgnoreChannels", string.Join(",", valueTuple.Item3));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 17) = new ValueTuple<string, object>("Box", uboxComponent);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 18) = new ValueTuple<string, object>("BoxName", (uboxComponent != null) ? uboxComponent.GetName() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 19) = new ValueTuple<string, object>("BoxCollisionEnabled", (uboxComponent != null) ? uboxComponent.GetCollisionEnabled() : ECollisionEnabled.NoCollision);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 20) = new ValueTuple<string, object>("BoxCollisionObjectType", (uboxComponent != null) ? uboxComponent.GetCollisionObjectType() : ECollisionChannel.ECC_MAX);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 21) = new ValueTuple<string, object>("BoxBlockChannels", string.Join(",", valueTuple2.Item1));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 22) = new ValueTuple<string, object>("BoxOverlapChannels", string.Join(",", valueTuple2.Item2));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 23) = new ValueTuple<string, object>("BoxIgnoreChannels", string.Join(",", valueTuple2.Item3));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray24<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 24));
		}

		// Token: 0x0602D5A3 RID: 185763 RVA: 0x00A3AB04 File Offset: 0x00A38D04
		[NullableContext(2)]
		[return: TupleElementNames(new string[]
		{
			"Block",
			"Overlap",
			"Ignore"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1,
			1,
			1
		})]
		private static ValueTuple<List<string>, List<string>, List<string>> CollectCollisionChannels(UPrimitiveComponent comp)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			if (comp == null)
			{
				return new ValueTuple<List<string>, List<string>, List<string>>(list, list2, list3);
			}
			for (int i = 0; i < 33; i++)
			{
				ECollisionChannel ecollisionChannel = (ECollisionChannel)i;
				string item = Enum.GetName<ECollisionChannel>(ecollisionChannel) ?? i.ToString();
				switch (comp.GetCollisionResponseToChannel(ecollisionChannel))
				{
				case ECollisionResponse.ECR_Ignore:
					list3.Add(item);
					break;
				case ECollisionResponse.ECR_Overlap:
					list2.Add(item);
					break;
				case ECollisionResponse.ECR_Block:
					list.Add(item);
					break;
				}
			}
			return new ValueTuple<List<string>, List<string>, List<string>>(list, list2, list3);
		}

		// Token: 0x0602D5A4 RID: 185764 RVA: 0x00A3AB9C File Offset: 0x00A38D9C
		private static string DescribeCollisionShape([Nullable(2)] UPrimitiveComponent comp)
		{
			UCapsuleComponent ucapsuleComponent = comp as UCapsuleComponent;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (ucapsuleComponent != null)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Capsule(HalfHeight=");
				defaultInterpolatedStringHandler.AppendFormatted<float>(ucapsuleComponent.GetScaledCapsuleHalfHeight());
				defaultInterpolatedStringHandler.AppendLiteral(",Radius=");
				defaultInterpolatedStringHandler.AppendFormatted<float>(ucapsuleComponent.GetScaledCapsuleRadius());
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			UBoxComponent uboxComponent = comp as UBoxComponent;
			if (uboxComponent != null)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Box(Extent=");
				defaultInterpolatedStringHandler.AppendFormatted<FVector>(uboxComponent.GetScaledBoxExtent());
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			USphereComponent usphereComponent = comp as USphereComponent;
			if (usphereComponent == null)
			{
				return "None";
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Sphere(Radius=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(usphereComponent.GetScaledSphereRadius());
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602D5A5 RID: 185765 RVA: 0x00A3AC94 File Offset: 0x00A38E94
		private bool IsActorStillOverlapping(AActor actor)
		{
			UBoxComponent overlapBox = this.OverlapBox;
			if (overlapBox == null || !overlapBox.IsValid())
			{
				return false;
			}
			TArray<AActor> tarray = new TArray<AActor>();
			overlapBox.GetOverlappingActors(ref tarray, default(TSubclassOf<AActor>));
			if (tarray == null)
			{
				return false;
			}
			for (int i = 0; i < tarray.Num(); i++)
			{
				if (tarray.Get(i) == actor)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602D5A6 RID: 185766 RVA: 0x00A3ACF0 File Offset: 0x00A38EF0
		[return: Nullable(2)]
		private static Entity ExtractEntity(AActor actor)
		{
			AActor myRoleTriggerOrUndefined = RoleTriggerController.Instance.GetMyRoleTriggerOrUndefined();
			if (myRoleTriggerOrUndefined != null && actor == myRoleTriggerOrUndefined)
			{
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				if (baseCharacter == null || !baseCharacter.IsValid())
				{
					return null;
				}
				EntityHandle entityById = CreatureModel.Instance.GetEntityById(Global.BaseCharacter.EntityId);
				if (entityById == null)
				{
					return null;
				}
				return entityById.Entity;
			}
			else
			{
				EntityHandle entityByChildActor = CreatureModel.Instance.GetEntityByChildActor(actor);
				if (entityByChildActor == null)
				{
					return null;
				}
				return entityByChildActor.Entity;
			}
		}

		// Token: 0x0602D5A7 RID: 185767 RVA: 0x00A3AD5C File Offset: 0x00A38F5C
		private bool IsChairOwnActor(AActor actor)
		{
			BaseActorComponent component = this.ChairEntity.GetComponent<BaseActorComponent>();
			AActor aactor = (component != null) ? component.Owner : null;
			if (aactor == null || !aactor.IsValid())
			{
				return false;
			}
			if (actor == aactor)
			{
				return true;
			}
			for (AActor attachParentActor = actor.GetAttachParentActor(); attachParentActor != null; attachParentActor = attachParentActor.GetAttachParentActor())
			{
				if (attachParentActor == aactor)
				{
					return true;
				}
			}
			SceneItemActorComponent component2 = this.ChairEntity.GetComponent<SceneItemActorComponent>();
			TArray<AActor> tarray = (component2 != null) ? component2.GetAllActorsInSceneInteractionLevel() : null;
			if (tarray == null)
			{
				return false;
			}
			for (int i = 0; i < tarray.Num(); i++)
			{
				if (tarray.Get(i) == actor)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602D5A8 RID: 185768 RVA: 0x00A3ADF0 File Offset: 0x00A38FF0
		private void StartTickGroundCheck(ChairFollowerConfig chairConfig)
		{
			if (chairConfig.TickGroundCheckIntervalMs <= 0f)
			{
				return;
			}
			this.TickGroundCheckTimer = TimerSystem.Instance.Forever(delegate(float _)
			{
				if (!this.ChairEntity.Valid || this.TickGroundCheckFailed)
				{
					return;
				}
				string text = this.GroundEvaluator.EvaluateTickGroundCheck(this.ChairEntity, chairConfig);
				if (text == null)
				{
					return;
				}
				this.TickGroundCheckFailed = true;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "[ChairMonitor] Tick 地检失败, 召回椅子";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("FailReason", text);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.ChairHandler.RecallChairDueToTickGroundCheck();
			}, chairConfig.TickGroundCheckIntervalMs, 1f, null, null, true);
			if (this.TickGroundCheckTimer == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[ChairMonitor] Tick 地检定时器创建失败, 检测未启用";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IntervalMs", chairConfig.TickGroundCheckIntervalMs);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0602D5A9 RID: 185769 RVA: 0x00A3AE91 File Offset: 0x00A39091
		private void StopTickGroundCheck()
		{
			if (this.TickGroundCheckTimer != null)
			{
				TimerSystem.Instance.Remove(this.TickGroundCheckTimer);
				this.TickGroundCheckTimer = null;
			}
			this.TickGroundCheckFailed = false;
		}

		// Token: 0x0602D5AA RID: 185770 RVA: 0x00A3AEBC File Offset: 0x00A390BC
		private void StartDistanceCheck(ChairFollowerConfig chairConfig)
		{
			this.DistanceTimer = TimerSystem.Instance.Forever(delegate(float _)
			{
				if (!this.ChairEntity.Valid)
				{
					return;
				}
				this.CheckDistance(chairConfig);
			}, 500f, 1f, null, null, true);
		}

		// Token: 0x0602D5AB RID: 185771 RVA: 0x00A3AF06 File Offset: 0x00A39106
		private void StopDistanceCheck()
		{
			this.ClearHideDelayTimer();
			if (this.DistanceTimer == null)
			{
				return;
			}
			TimerSystem.Instance.Remove(this.DistanceTimer);
			this.DistanceTimer = null;
		}

		// Token: 0x0602D5AC RID: 185772 RVA: 0x00A3AF30 File Offset: 0x00A39130
		private void CheckDistance(ChairFollowerConfig chairConfig)
		{
			BaseActorComponent component = this.ChairEntity.GetComponent<BaseActorComponent>();
			SceneTeamModel instance = SceneTeamModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance.GetCurrentEntity;
				worldEntity = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			BaseActorComponent baseActorComponent = (worldEntity2 != null) ? worldEntity2.GetComponent<BaseActorComponent>() : null;
			if (component == null || baseActorComponent == null)
			{
				return;
			}
			double distSquared = Vector.DistSquared(component.ActorLocationProxy, baseActorComponent.ActorLocationProxy);
			bool flag = distSquared <= (double)chairConfig.HideDistanceSquared;
			CharacterActionComponent characterActionComponent = (worldEntity2 != null) ? worldEntity2.GetComponent<CharacterActionComponent>() : null;
			bool flag2 = characterActionComponent != null && characterActionComponent.IsSitDown && characterActionComponent.Chair == this.ChairEntity;
			if (flag || flag2)
			{
				this.ClearHideDelayTimer();
				return;
			}
			if (this.HideDelayTimer != null)
			{
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[ChairMonitor] 离开范围, 启动隐藏计时";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Distance", (float)Math.Sqrt(distSquared));
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.HideDelayTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.HideDelayTimer = null;
				if (!this.ChairEntity.Valid)
				{
					return;
				}
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.CK;
				string message2 = "[ChairMonitor] 离开范围计时结束, 隐藏椅子";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Distance", (float)Math.Sqrt(distSquared));
				instance3.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.ChairHandler.HideChairDueToLeaveRange(this.ChairEntity, this.TransactionVersion);
			}, chairConfig.HideDelayMs, null, null, true, 1f);
		}

		// Token: 0x0602D5AD RID: 185773 RVA: 0x00A3B056 File Offset: 0x00A39256
		private void ClearHideDelayTimer()
		{
			if (this.HideDelayTimer == null)
			{
				return;
			}
			TimerSystem.Instance.Remove(this.HideDelayTimer);
			this.HideDelayTimer = null;
		}

		// Token: 0x0602D5AE RID: 185774 RVA: 0x00A3B07C File Offset: 0x00A3927C
		private void StartPlayerMoveCheck(ChairFollowerConfig chairConfig)
		{
			if (!chairConfig.EnableTickCheckPlayerMovement)
			{
				return;
			}
			if (chairConfig.TickPlayerMoveCheckIntervalMs <= 0f)
			{
				return;
			}
			this.PlayerMoveCheckTimer = TimerSystem.Instance.Forever(delegate(float _)
			{
				if (!this.ChairEntity.Valid)
				{
					return;
				}
				this.CheckPlayerMovement(chairConfig);
			}, chairConfig.TickPlayerMoveCheckIntervalMs, 1f, null, null, true);
			if (this.PlayerMoveCheckTimer == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[ChairMonitor] 玩家位移检测定时器创建失败, 检测未启用";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IntervalMs", chairConfig.TickPlayerMoveCheckIntervalMs);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0602D5AF RID: 185775 RVA: 0x00A3B12B File Offset: 0x00A3932B
		private void StopPlayerMoveCheck()
		{
			this.SitBaselineLocation = null;
			if (this.PlayerMoveCheckTimer == null)
			{
				return;
			}
			TimerSystem.Instance.Remove(this.PlayerMoveCheckTimer);
			this.PlayerMoveCheckTimer = null;
		}

		// Token: 0x0602D5B0 RID: 185776 RVA: 0x00A3B158 File Offset: 0x00A39358
		private void CheckPlayerMovement(ChairFollowerConfig chairConfig)
		{
			SceneTeamModel instance = SceneTeamModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance.GetCurrentEntity;
				worldEntity = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			BaseActorComponent baseActorComponent = (worldEntity2 != null) ? worldEntity2.GetComponent<BaseActorComponent>() : null;
			if (baseActorComponent == null)
			{
				return;
			}
			CharacterActionComponent characterActionComponent = (worldEntity2 != null) ? worldEntity2.GetComponent<CharacterActionComponent>() : null;
			if (characterActionComponent == null || !characterActionComponent.IsSitDown || characterActionComponent.Chair != this.ChairEntity)
			{
				this.SitBaselineLocation = null;
				return;
			}
			Vector sitBaselineLocation = this.SitBaselineLocation;
			if (sitBaselineLocation == null)
			{
				this.SitBaselineLocation = Vector.Create(baseActorComponent.ActorLocationProxy);
				return;
			}
			double num = Vector.DistSquared(sitBaselineLocation, baseActorComponent.ActorLocationProxy);
			if (num <= (double)chairConfig.PlayerMoveCheckLengthSquared)
			{
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[ChairMonitor] 玩家坐下位移超过阈值, 退出坐下";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Distance", (float)Math.Sqrt(num));
			instance2.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.SitBaselineLocation = null;
			this.ChairHandler.ExitSitDownDueToPlayerMove();
		}

		// Token: 0x040183DC RID: 99292
		private const int DISTANCE_CHECK_INTERVAL_MS = 500;

		// Token: 0x040183DD RID: 99293
		private const int MAX_OVERLAP_OCCUPANT_COUNT = 10;

		// Token: 0x040183DE RID: 99294
		private readonly Entity ChairEntity;

		// Token: 0x040183DF RID: 99295
		private readonly IPlayerFollowerChairHandler ChairHandler;

		// Token: 0x040183E0 RID: 99296
		private readonly ChairSummonEvaluator GroundEvaluator = new ChairSummonEvaluator();

		// Token: 0x040183E1 RID: 99297
		private readonly float OverlapDuration;

		// Token: 0x040183E2 RID: 99298
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		private readonly Dictionary<AActor, TimerHandle> OverlapOccupants = new Dictionary<AActor, TimerHandle>();

		// Token: 0x040183E3 RID: 99299
		private readonly int TransactionVersion;

		// Token: 0x040183E4 RID: 99300
		[Nullable(2)]
		private TimerHandle DistanceTimer;

		// Token: 0x040183E5 RID: 99301
		[Nullable(2)]
		private TimerHandle HideDelayTimer;

		// Token: 0x040183E6 RID: 99302
		[Nullable(2)]
		private UBoxComponent OverlapBox;

		// Token: 0x040183E7 RID: 99303
		[Nullable(2)]
		private TimerHandle PlayerMoveCheckTimer;

		// Token: 0x040183E8 RID: 99304
		[Nullable(2)]
		private Vector SitBaselineLocation;

		// Token: 0x040183E9 RID: 99305
		private bool TickGroundCheckFailed;

		// Token: 0x040183EA RID: 99306
		[Nullable(2)]
		private TimerHandle TickGroundCheckTimer;
	}
}
