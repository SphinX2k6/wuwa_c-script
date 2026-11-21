using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F44 RID: 16196
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackAimTargetSelector : QuickHackTargetSelector
	{
		// Token: 0x06029026 RID: 167974 RVA: 0x00B83BBC File Offset: 0x00B81DBC
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

		// Token: 0x06029027 RID: 167975 RVA: 0x00B83C3E File Offset: 0x00B81E3E
		public override void Clear()
		{
			this.LineElement = null;
			this.EntitiesInRange.Clear();
			this.Targets.Clear();
			this.LockTargetInfo = null;
			this.OnScreenTargetInfo = null;
		}

		// Token: 0x06029028 RID: 167976 RVA: 0x00B83C6C File Offset: 0x00B81E6C
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

		// Token: 0x06029029 RID: 167977 RVA: 0x00B83D34 File Offset: 0x00B81F34
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

		// Token: 0x0602902A RID: 167978 RVA: 0x00B84018 File Offset: 0x00B82218
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

		// Token: 0x0602902B RID: 167979 RVA: 0x00B84174 File Offset: 0x00B82374
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

		// Token: 0x0602902C RID: 167980 RVA: 0x00B84290 File Offset: 0x00B82490
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

		// Token: 0x0602902D RID: 167981 RVA: 0x00B8435C File Offset: 0x00B8255C
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

		// Token: 0x0602902E RID: 167982 RVA: 0x00B8439C File Offset: 0x00B8259C
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

		// Token: 0x0602902F RID: 167983 RVA: 0x00B843E0 File Offset: 0x00B825E0
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

		// Token: 0x06029030 RID: 167984 RVA: 0x00B84434 File Offset: 0x00B82634
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

		// Token: 0x06029031 RID: 167985 RVA: 0x00B844E4 File Offset: 0x00B826E4
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

		// Token: 0x06029032 RID: 167986 RVA: 0x00B84568 File Offset: 0x00B82768
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

		// Token: 0x0401651D RID: 91421
		private const int TRACE_INTERVAL = 200;

		// Token: 0x0401651E RID: 91422
		private const int TRACE_RADIUS = 22;

		// Token: 0x0401651F RID: 91423
		private const int TRACE_DISTANCE_MAX = 2000;

		// Token: 0x04016520 RID: 91424
		private const string IGNORE_HACK_TRACE = "IgnoreHackTrace";

		// Token: 0x04016521 RID: 91425
		private readonly EEntityTypeQuery EntityTypeQuery = EEntityTypeQuery.NormalEntity | EEntityTypeQuery.NormalEntityAlwaysTick | EEntityTypeQuery.NormalEntityAlwaysTickWhitoutNotRenderedGroup | EEntityTypeQuery.MoveSceneItem | EEntityTypeQuery.PasserbyNPC | EEntityTypeQuery.Boss;

		// Token: 0x04016522 RID: 91426
		private readonly List<EntityHandle> EntitiesInRange = new List<EntityHandle>();

		// Token: 0x04016523 RID: 91427
		private readonly List<EntityHandle> Targets = new List<EntityHandle>();

		// Token: 0x04016524 RID: 91428
		[Nullable(2)]
		private IQuickHackOnScreenTargetInfo OnScreenTargetInfo;

		// Token: 0x04016525 RID: 91429
		[Nullable(2)]
		private IQuickHackLockTargetInfo LockTargetInfo;

		// Token: 0x04016526 RID: 91430
		[Nullable(2)]
		private UTraceLineElement LineElement;

		// Token: 0x04016527 RID: 91431
		private float TraceInterval;

		// Token: 0x04016528 RID: 91432
		private bool NeedUpdateCurrentTarget;

		// Token: 0x04016529 RID: 91433
		[Nullable(2)]
		private EntityHandle PendingLockTarget;

		// Token: 0x0401652A RID: 91434
		private readonly Vector2D ScreenPos = Vector2D.Create();

		// Token: 0x0401652B RID: 91435
		private readonly Vector CameraLocation = Vector.Create();

		// Token: 0x0401652C RID: 91436
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0401652D RID: 91437
		private readonly Vector StartOffset = Vector.Create();

		// Token: 0x0401652E RID: 91438
		private readonly Vector EndLocation = Vector.Create();

		// Token: 0x0401652F RID: 91439
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x02009AC8 RID: 39624
		[Nullable(0)]
		private class TraceInfo
		{
			// Token: 0x06044A03 RID: 281091 RVA: 0x01479896 File Offset: 0x01477A96
			public TraceInfo(AActor actor, float distance)
			{
			}

			// Token: 0x040303A1 RID: 197537
			public readonly AActor Actor = actor;

			// Token: 0x040303A2 RID: 197538
			public readonly float Distance = distance;
		}
	}
}
