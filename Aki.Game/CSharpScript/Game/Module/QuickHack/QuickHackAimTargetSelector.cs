using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F7B RID: 20347
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackAimTargetSelector : QuickHackTargetSelector
	{
		// Token: 0x060341B8 RID: 213432 RVA: 0x00C3A410 File Offset: 0x00C38610
		public override void Init(int selectRange, int selectScreenRadius)
		{
			base.Init(selectRange, selectScreenRadius);
			UTraceLineElement utraceLineElement = new UTraceLineElement();
			utraceLineElement.WorldContextObject = GlobalData.World;
			utraceLineElement.bIsSingle = false;
			TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>();
			tarray.Add(KuroObjectTypeQuery.WorldStatic);
			tarray.Add(KuroObjectTypeQuery.WorldStaticIgnoreBullet);
			tarray.Add(KuroObjectTypeQuery.PawnMonster);
			tarray.Add(KuroObjectTypeQuery.Pawn);
			utraceLineElement.SetObjectTypesQuery(ref tarray);
			this.LineElement = utraceLineElement;
		}

		// Token: 0x060341B9 RID: 213433 RVA: 0x00C3A492 File Offset: 0x00C38692
		public override void Clear()
		{
			this.LineElement = null;
			this.EntitiesInRange.Clear();
			this.Targets.Clear();
			this.LockTargetInfo = null;
			this.OnScreenTargetInfo = null;
		}

		// Token: 0x060341BA RID: 213434 RVA: 0x00C3A4C0 File Offset: 0x00C386C0
		public override bool UpdateTargetInfo(float delta)
		{
			if (this.LockTargetInfo == null)
			{
				this.LockTargetInfo = new QuickHackLockTargetInfo
				{
					HackType = null,
					Targets = this.Targets
				};
			}
			if (this.OnScreenTargetInfo == null)
			{
				this.OnScreenTargetInfo = new QuickHackOnScreenTargetInfo
				{
					TargetIdToIndexMap = new Dictionary<int, int>(),
					Targets = new List<EntityHandle>(),
					SignedScreenDistSquaredList = new List<double>(),
					DistSquaredList = new List<double>()
				};
			}
			if (this.NeedUpdateCurrentTarget)
			{
				this.NeedUpdateCurrentTarget = false;
				return this.UpdateCurrentTarget();
			}
			if (this.TraceInterval > 0f)
			{
				this.TraceInterval -= delta;
				return false;
			}
			this.UpdatePendingTarget();
			this.NeedUpdateCurrentTarget = true;
			this.TraceInterval = 200f;
			return false;
		}

		// Token: 0x060341BB RID: 213435 RVA: 0x00C3A588 File Offset: 0x00C38788
		private void UpdatePendingTarget()
		{
			QuickHackAimTargetSelector.TraceInfo traceInfo = null;
			EntityHandle pendingLockTarget = null;
			bool flag = true;
			Dictionary<int, bool> dictionary = new Dictionary<int, bool>();
			foreach (QuickHackAimTargetSelector.TraceInfo traceInfo2 in this.AimTrace())
			{
				AActor aactor = (traceInfo2 != null) ? traceInfo2.Actor : null;
				if (aactor == null || !aactor.IsValid())
				{
					flag = false;
				}
				else
				{
					EntityHandle entityByChildActor = CreatureModel.Instance.GetEntityByChildActor(aactor);
					if (entityByChildActor != null)
					{
						int id = entityByChildActor.Id;
						if (!dictionary.ContainsKey(id))
						{
							bool flag2 = this.CheckEntityValid(entityByChildActor);
							dictionary[id] = flag2;
							if (flag2 && (traceInfo == null || traceInfo2.Distance <= traceInfo.Distance))
							{
								traceInfo = traceInfo2;
								pendingLockTarget = entityByChildActor;
							}
						}
					}
				}
			}
			this.PendingLockTarget = pendingLockTarget;
			Dictionary<int, int> targetIdToIndexMap = this.OnScreenTargetInfo.TargetIdToIndexMap;
			List<EntityHandle> targets = this.OnScreenTargetInfo.Targets;
			List<double> signedScreenDistSquaredList = this.OnScreenTargetInfo.SignedScreenDistSquaredList;
			List<double> distSquaredList = this.OnScreenTargetInfo.DistSquaredList;
			targetIdToIndexMap.Clear();
			targets.Clear();
			signedScreenDistSquaredList.Clear();
			distSquaredList.Clear();
			FVectorDouble fvectorDouble = Global.CharacterCameraManager.D_GetCameraLocation();
			this.StartLocation.FromUeVector(fvectorDouble);
			CreatureModel.Instance.GetEntitiesInRangeWithLocation(this.StartLocation, (float)this.SelectRange, this.EntityTypeQuery, this.EntitiesInRange, true);
			double num = double.MaxValue;
			foreach (EntityHandle entityHandle in this.EntitiesInRange)
			{
				int id2 = entityHandle.Id;
				bool flag3;
				if ((dictionary.TryGetValue(id2, out flag3) ? flag3 : this.CheckEntityValid(entityHandle)) && this.CheckEntityRendered(entityHandle))
				{
					FVectorDouble entityLocation = this.GetEntityLocation(entityHandle);
					if (base.ProjectWorldToScreen(entityLocation, this.ScreenPos, 0.1f))
					{
						bool flag4 = this.ScreenPos.X <= 0.0;
						double num2 = this.ScreenPos.SizeSquared();
						this.TempVector.FromUeVector(entityLocation);
						this.TempVector.SubtractionEqual(this.StartLocation);
						double num3 = this.TempVector.SizeSquared();
						int count = targets.Count;
						targetIdToIndexMap[id2] = count;
						targets.Add(entityHandle);
						signedScreenDistSquaredList.Add(flag4 ? (-num2) : num2);
						distSquaredList.Add(num3);
						if (!flag && this.PendingLockTarget == null && num2 <= (double)this.ScreenRadiusSquared && num3 < num)
						{
							num = num3;
							pendingLockTarget = entityHandle;
						}
					}
				}
			}
			this.PendingLockTarget = pendingLockTarget;
		}

		// Token: 0x060341BC RID: 213436 RVA: 0x00C3A86C File Offset: 0x00C38A6C
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		private List<QuickHackAimTargetSelector.TraceInfo> AimTrace()
		{
			List<QuickHackAimTargetSelector.TraceInfo> list = new List<QuickHackAimTargetSelector.TraceInfo>();
			APlayerCameraManager characterCameraManager = Global.CharacterCameraManager;
			if (characterCameraManager == null)
			{
				return list;
			}
			FVectorDouble fvectorDouble = characterCameraManager.D_GetCameraLocation();
			this.CameraLocation.FromUeVector(fvectorDouble);
			int num = (this.SelectRange <= 2000) ? this.SelectRange : 2000;
			Vector tempVector = this.TempVector;
			FVectorDouble fvectorDouble2 = characterCameraManager.D_GetActorForwardVector();
			tempVector.FromUeVector(fvectorDouble2);
			this.TempVector.MultiplyEqual((double)num);
			list.Add(this.LineTrace(this.CameraLocation, Vector.ZeroVectorProxy, this.TempVector));
			FVectorDouble fvectorDouble3 = characterCameraManager.D_GetActorUpVector();
			this.StartOffset.FromUeVector(fvectorDouble3);
			list.Add(this.LineTrace(this.CameraLocation, this.StartOffset, this.TempVector));
			this.StartOffset.MultiplyEqual(-1.0);
			list.Add(this.LineTrace(this.CameraLocation, this.StartOffset, this.TempVector));
			FVectorDouble fvectorDouble4 = characterCameraManager.D_GetActorRightVector();
			this.StartOffset.FromUeVector(fvectorDouble4);
			list.Add(this.LineTrace(this.CameraLocation, this.StartOffset, this.TempVector));
			this.StartOffset.MultiplyEqual(-1.0);
			list.Add(this.LineTrace(this.CameraLocation, this.StartOffset, this.TempVector));
			return list;
		}

		// Token: 0x060341BD RID: 213437 RVA: 0x00C3A9C8 File Offset: 0x00C38BC8
		[return: Nullable(2)]
		private QuickHackAimTargetSelector.TraceInfo LineTrace(Vector start, Vector startOffsetDirect, Vector endOffset)
		{
			this.StartLocation.DeepCopy(startOffsetDirect);
			this.StartLocation.MultiplyEqual(22.0);
			this.StartLocation.AdditionEqual(start);
			this.EndLocation.DeepCopy(this.StartLocation);
			this.EndLocation.AdditionEqual(endOffset);
			UTraceLineElement lineElement = this.LineElement;
			TraceElementCommon.Instance.SetStartLocation(lineElement, this.StartLocation);
			TraceElementCommon.Instance.SetEndLocation(lineElement, this.EndLocation);
			if (!TraceElementCommon.Instance.LineTrace(lineElement, "QuickHackAimTargetSelector"))
			{
				return null;
			}
			UKuroHitResult hitResult = lineElement.HitResult;
			if (!hitResult.bBlockingHit)
			{
				return null;
			}
			TArray<TWeakObjectPtr<AActor>> actors = hitResult.Actors;
			TArray<float> distanceArray = hitResult.DistanceArray;
			int hitCount = hitResult.GetHitCount();
			for (int i = 0; i < hitCount; i++)
			{
				AActor aactor = actors.Get(i).Get();
				if (aactor != null)
				{
					FName? dynamicFName = FNameUtil.GetDynamicFName("IgnoreHackTrace");
					if (dynamicFName == null || !aactor.ActorHasTag(dynamicFName.Value))
					{
						return new QuickHackAimTargetSelector.TraceInfo(aactor, distanceArray.Get(i));
					}
				}
			}
			return null;
		}

		// Token: 0x060341BE RID: 213438 RVA: 0x00C3AAE4 File Offset: 0x00C38CE4
		private bool UpdateCurrentTarget()
		{
			EntityHandle pendingLockTarget = this.PendingLockTarget;
			if (pendingLockTarget == null || !pendingLockTarget.Valid)
			{
				return this.ClearCurrentTarget();
			}
			CreatureDataComponent component = pendingLockTarget.Entity.GetComponent<CreatureDataComponent>();
			if (component.GetRemoveState())
			{
				return this.ClearCurrentTarget();
			}
			if (this.Targets.Count > 0 && this.Targets[0].Id == pendingLockTarget.Id)
			{
				return false;
			}
			EQuickHackTargetType? hackType = null;
			if (component.IsMonster())
			{
				hackType = new EQuickHackTargetType?(EQuickHackTargetType.EnemyMonster);
			}
			else if (component.IsSceneItem())
			{
				hackType = new EQuickHackTargetType?(EQuickHackTargetType.SceneItem);
			}
			if (hackType == null)
			{
				return false;
			}
			this.Targets.Clear();
			this.Targets.Add(pendingLockTarget);
			this.LockTargetInfo.HackType = hackType;
			return true;
		}

		// Token: 0x060341BF RID: 213439 RVA: 0x00C3ABB0 File Offset: 0x00C38DB0
		private bool ClearCurrentTarget()
		{
			if (this.Targets.Count <= 0)
			{
				return false;
			}
			this.Targets.Clear();
			this.LockTargetInfo.HackType = null;
			return true;
		}

		// Token: 0x060341C0 RID: 213440 RVA: 0x00C3ABF0 File Offset: 0x00C38DF0
		public override IQuickHackLockTargetInfo GetLockTargetInfo()
		{
			if (this.LockTargetInfo == null)
			{
				this.LockTargetInfo = new QuickHackLockTargetInfo
				{
					HackType = null,
					Targets = this.Targets
				};
			}
			return this.LockTargetInfo;
		}

		// Token: 0x060341C1 RID: 213441 RVA: 0x00C3AC34 File Offset: 0x00C38E34
		public override IQuickHackOnScreenTargetInfo GetOnScreenTargetInfo()
		{
			if (this.OnScreenTargetInfo == null)
			{
				this.OnScreenTargetInfo = new QuickHackOnScreenTargetInfo
				{
					TargetIdToIndexMap = new Dictionary<int, int>(),
					Targets = new List<EntityHandle>(),
					SignedScreenDistSquaredList = new List<double>(),
					DistSquaredList = new List<double>()
				};
			}
			return this.OnScreenTargetInfo;
		}

		// Token: 0x060341C2 RID: 213442 RVA: 0x00C3AC88 File Offset: 0x00C38E88
		private bool CheckEntityValid(EntityHandle entityHandle)
		{
			if (!entityHandle.IsInit)
			{
				return false;
			}
			WorldEntity entity = entityHandle.Entity;
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component.GetRemoveState())
			{
				return false;
			}
			if (!entity.Active)
			{
				return false;
			}
			if (!component.IsMonster())
			{
				return component.IsSceneItem() && entity.GetComponent<SceneItemQuickHackComponent>() != null && entity.GetComponent<SceneItemActorComponent>() != null;
			}
			BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
			if (component2 != null && component2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身"]))
			{
				return false;
			}
			if (CampUtils.GetCampRelationship(component.GetEntityCamp(), ECamp.Player) != ERelation.Enemy)
			{
				return false;
			}
			BaseDeathComponent component3 = entity.GetComponent<BaseDeathComponent>();
			return component3 == null || !component3.IsDead();
		}

		// Token: 0x060341C3 RID: 213443 RVA: 0x00C3AD38 File Offset: 0x00C38F38
		private bool CheckEntityRendered(EntityHandle entityHandle)
		{
			WorldEntity entity = entityHandle.Entity;
			SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
			if (component != null)
			{
				component.TryRefreshShowActor();
				AActor curLevelPrefabShowActor = component.CurLevelPrefabShowActor;
				return curLevelPrefabShowActor != null && curLevelPrefabShowActor.IsValid() && curLevelPrefabShowActor.WasRecentlyRenderedOnScreen(0.2f);
			}
			BaseActorComponent component2 = entity.GetComponent<BaseActorComponent>();
			bool? flag;
			if (component2 == null)
			{
				flag = null;
			}
			else
			{
				AActor owner = component2.Owner;
				flag = ((owner != null) ? new bool?(owner.WasRecentlyRenderedOnScreen(0.2f)) : null);
			}
			bool? flag2 = flag;
			return flag2.GetValueOrDefault();
		}

		// Token: 0x060341C4 RID: 213444 RVA: 0x00C3ADBC File Offset: 0x00C38FBC
		private FVectorDouble GetEntityLocation(EntityHandle entityHandle)
		{
			SceneItemActorComponent component = entityHandle.Entity.GetComponent<SceneItemActorComponent>();
			if (component != null)
			{
				AActor referenceActor = component.GetReferenceActor("Center");
				if (referenceActor != null)
				{
					return referenceActor.D_K2_GetActorLocation();
				}
			}
			return entityHandle.Entity.GetComponent<BaseActorComponent>().ActorLocation;
		}

		// Token: 0x0401BB48 RID: 113480
		private const int TRACE_INTERVAL = 200;

		// Token: 0x0401BB49 RID: 113481
		private const int TRACE_RADIUS = 22;

		// Token: 0x0401BB4A RID: 113482
		private const int TRACE_DISTANCE_MAX = 2000;

		// Token: 0x0401BB4B RID: 113483
		private const string IGNORE_HACK_TRACE = "IgnoreHackTrace";

		// Token: 0x0401BB4C RID: 113484
		private readonly EEntityTypeQuery EntityTypeQuery = EEntityTypeQuery.NormalEntity | EEntityTypeQuery.NormalEntityAlwaysTick | EEntityTypeQuery.NormalEntityAlwaysTickWhitoutNotRenderedGroup | EEntityTypeQuery.MoveSceneItem | EEntityTypeQuery.PasserbyNPC | EEntityTypeQuery.Boss;

		// Token: 0x0401BB4D RID: 113485
		private readonly List<EntityHandle> EntitiesInRange = new List<EntityHandle>();

		// Token: 0x0401BB4E RID: 113486
		private readonly List<EntityHandle> Targets = new List<EntityHandle>();

		// Token: 0x0401BB4F RID: 113487
		[Nullable(2)]
		private IQuickHackOnScreenTargetInfo OnScreenTargetInfo;

		// Token: 0x0401BB50 RID: 113488
		[Nullable(2)]
		private IQuickHackLockTargetInfo LockTargetInfo;

		// Token: 0x0401BB51 RID: 113489
		[Nullable(2)]
		private UTraceLineElement LineElement;

		// Token: 0x0401BB52 RID: 113490
		private float TraceInterval;

		// Token: 0x0401BB53 RID: 113491
		private bool NeedUpdateCurrentTarget;

		// Token: 0x0401BB54 RID: 113492
		[Nullable(2)]
		private EntityHandle PendingLockTarget;

		// Token: 0x0401BB55 RID: 113493
		private readonly Vector2D ScreenPos = Vector2D.Create();

		// Token: 0x0401BB56 RID: 113494
		private readonly Vector CameraLocation = Vector.Create();

		// Token: 0x0401BB57 RID: 113495
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0401BB58 RID: 113496
		private readonly Vector StartOffset = Vector.Create();

		// Token: 0x0401BB59 RID: 113497
		private readonly Vector EndLocation = Vector.Create();

		// Token: 0x0401BB5A RID: 113498
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0200B098 RID: 45208
		[Nullable(0)]
		private class TraceInfo
		{
			// Token: 0x0604E413 RID: 320531 RVA: 0x014C077E File Offset: 0x014BE97E
			public TraceInfo(AActor actor, float distance)
			{
			}

			// Token: 0x04035976 RID: 219510
			public readonly AActor Actor = actor;

			// Token: 0x04035977 RID: 219511
			public readonly float Distance = distance;
		}
	}
}
