using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E0A RID: 11786
[NullableContext(1)]
[Nullable(0)]
public class BulletCollisionInfo
{
	// Token: 0x1700224D RID: 8781
	// (get) Token: 0x06018C98 RID: 101528 RVA: 0x0065A190 File Offset: 0x00658390
	public FTransformDouble CollisionTransform
	{
		get
		{
			if (this.CollisionComponent == null)
			{
				return MathUtils.Instance.DefaultTransformDouble;
			}
			return this.CollisionComponent.D_K2_GetComponentToWorld();
		}
	}

	// Token: 0x06018C99 RID: 101529 RVA: 0x0065A1B0 File Offset: 0x006583B0
	public void RecordPreResolvedDamageId(long damageId, long preResolvedDamageId)
	{
		this.PreResolvedDamageIdMap[damageId] = preResolvedDamageId;
	}

	// Token: 0x06018C9A RID: 101530 RVA: 0x0065A1C0 File Offset: 0x006583C0
	public void SetDamageIdByOriginal(long damageId)
	{
		long damageId2;
		if (this.PreResolvedDamageIdMap.TryGetValue(damageId, out damageId2))
		{
			this.DamageId = damageId2;
			this.IsCurrentDamageIdPreResolvedInternal = true;
			return;
		}
		this.DamageId = damageId;
		this.IsCurrentDamageIdPreResolvedInternal = false;
	}

	// Token: 0x1700224E RID: 8782
	// (get) Token: 0x06018C9B RID: 101531 RVA: 0x0065A1FA File Offset: 0x006583FA
	public bool IsCurrentDamageIdPreResolved
	{
		get
		{
			return this.IsCurrentDamageIdPreResolvedInternal;
		}
	}

	// Token: 0x06018C9C RID: 101532 RVA: 0x0065A204 File Offset: 0x00658404
	public void AddHitActorData(AActor otherActor, BulletHitActorData hitActorData)
	{
		if (this.IsInProcessHit)
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "处理子弹碰撞期间不允许修改碰撞数组", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.MapHitActorData.ContainsKey(otherActor))
		{
			return;
		}
		this.MapHitActorData.Add(otherActor, hitActorData);
		this.ArrayHitActorData.Add(hitActorData);
	}

	// Token: 0x06018C9D RID: 101533 RVA: 0x0065A260 File Offset: 0x00658460
	public void ClearHitActorData()
	{
		if (this.IsInProcessHit)
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "处理子弹碰撞期间不允许修改碰撞数组", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		foreach (BulletHitActorData obj in this.ArrayHitActorData)
		{
			BulletPool.RecycleBulletHitActorData(obj);
		}
		this.MapHitActorData.Clear();
		this.ArrayHitActorData.Clear();
		this.HasSearchedHitActorsCurFrame = false;
	}

	// Token: 0x06018C9E RID: 101534 RVA: 0x0065A2F4 File Offset: 0x006584F4
	public void ClearLastHitActorData()
	{
		if (this.IsInProcessHit)
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "处理子弹碰撞期间不允许修改碰撞数组", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		foreach (BulletHitActorData obj in this.LastArrayHitActorData)
		{
			BulletPool.RecycleBulletHitActorData(obj);
		}
		this.LastMapHitActorData.Clear();
		this.LastArrayHitActorData.Clear();
	}

	// Token: 0x06018C9F RID: 101535 RVA: 0x0065A380 File Offset: 0x00658580
	public void UpdateLastHitActorData()
	{
		if (this.IsInProcessHit)
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "处理子弹碰撞期间不允许修改碰撞数组", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		List<BulletHitActorData> lastArrayHitActorData = this.LastArrayHitActorData;
		this.LastArrayHitActorData = this.ArrayHitActorData;
		this.ArrayHitActorData = lastArrayHitActorData;
		Dictionary<AActor, BulletHitActorData> lastMapHitActorData = this.LastMapHitActorData;
		this.LastMapHitActorData = this.MapHitActorData;
		this.MapHitActorData = lastMapHitActorData;
		this.ClearHitActorData();
	}

	// Token: 0x06018CA0 RID: 101536 RVA: 0x0065A3EC File Offset: 0x006585EC
	[return: Nullable(2)]
	public Entity GetFirstVictim(EBulletHitActorType[] types)
	{
		foreach (BulletHitActorData bulletHitActorData in (this.IsInProcessHit ? this.ArrayHitActorData : this.LastArrayHitActorData))
		{
			if (bulletHitActorData.IsValidHit && types.Contains(bulletHitActorData.Type) && bulletHitActorData != null)
			{
				EntityHandle entityHandle = bulletHitActorData.EntityHandle;
				if (((entityHandle != null) ? new bool?(entityHandle.Valid) : null).GetValueOrDefault())
				{
					return bulletHitActorData.Entity;
				}
			}
		}
		return null;
	}

	// Token: 0x06018CA1 RID: 101537 RVA: 0x0065A498 File Offset: 0x00658698
	public void Clear()
	{
		if (this.IsInProcessHit)
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "处理子弹碰撞期间不允许修改碰撞数组", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		foreach (BulletHitActorData obj in this.ArrayHitActorData)
		{
			BulletPool.RecycleBulletHitActorData(obj);
		}
		foreach (BulletHitActorData obj2 in this.LastArrayHitActorData)
		{
			BulletPool.RecycleBulletHitActorData(obj2);
		}
		foreach (BulletConditionResult obj3 in this.MapBulletConditionResult.Values)
		{
			BulletPool.RecycleBulletConditionResult(obj3);
		}
		this.MapBulletConditionResult.Clear();
		this.MapHitActorData.Clear();
		this.ArrayHitActorData.Clear();
		this.LastMapHitActorData.Clear();
		this.LastArrayHitActorData.Clear();
		this.ArrayHitActor.Clear();
		this.ActorCollisionEnable = false;
		this.CollisionComponent = null;
		this.RegionDetectComponent = null;
		this.RegionComponent = null;
		this.HasObstaclesCollision = false;
		this.NeedHitObstacles = false;
		this.IsInProcessHit = false;
		this.IsProcessOpen = false;
		this.HasSearchedHitActorsCurFrame = false;
		this.ObjectsHitCurrent.Clear();
		this.SceneItemPartsHitCurrent.Clear();
		this.SceneItemPartHitEntityId = null;
		this.StopHit = false;
		this.HaveCharacterInBullet = false;
		this.CharacterEntityMap.Clear();
		this.BulletEntityMap.Clear();
		this.HitTimeScaleEntityMap.Clear();
		this.HitObstaclesCurFrame = false;
		this.IsPassDelay = false;
		this.AllowedEnergy = false;
		this.AllowedAddEnergyBuff = false;
		this.ActiveDelayMs = 0f;
		this.ActiveLengthMs = 0f;
		this.IntervalMs = 0f;
		this.LastStageInterval = 0;
		this.StageInterval = 0;
		this.IsStartup = false;
		this.CenterLocalLocation.Reset();
		this.FinalScale.Reset();
		this.LastFramePosition.Reset();
		BulletTraceElementPool.RecycleTraceBoxElement(this.UpdateTraceBox);
		this.UpdateTraceBox = null;
		BulletTraceElementPool.RecycleTraceSphereElement(this.UpdateTraceSphere);
		this.UpdateTraceSphere = null;
		BulletTraceElementPool.RecycleTraceLineElement(this.UpdateTraceLine);
		this.UpdateTraceLine = null;
		BulletTraceElementPool.RecycleTraceSphereElement(this.ObstaclesTraceElement);
		this.ObstaclesTraceElement = null;
		this.IgnoreChannels.Clear();
		this.IgnoreQueries.Clear();
		this.DamageId = 0L;
		this.PreResolvedDamageIdMap.Clear();
		this.IsCurrentDamageIdPreResolvedInternal = false;
	}

	// Token: 0x0400B91E RID: 47390
	private const int PRIORITY_OBSTACLE = 1000;

	// Token: 0x0400B91F RID: 47391
	private const int PRIORITY_SCENEITEM = 2000;

	// Token: 0x0400B920 RID: 47392
	private const int PRIORITY_CHARACTER = 3000;

	// Token: 0x0400B921 RID: 47393
	private const int PRIORITY_NPC = 4000;

	// Token: 0x0400B922 RID: 47394
	private const int PRIORITY_ANIMAL = 5000;

	// Token: 0x0400B923 RID: 47395
	private const int PRIORITY_BULLET = 6000;

	// Token: 0x0400B924 RID: 47396
	[StaticVariableRuleIgnore]
	public static readonly int?[] BulletHitPriorityList = new int?[]
	{
		null,
		new int?(3000),
		new int?(6000),
		new int?(2000),
		new int?(1000),
		new int?(4000),
		new int?(5000)
	};

	// Token: 0x0400B925 RID: 47397
	public bool ActorCollisionEnable;

	// Token: 0x0400B926 RID: 47398
	[Nullable(2)]
	public UPrimitiveComponent CollisionComponent;

	// Token: 0x0400B927 RID: 47399
	[Nullable(2)]
	public UKuroRegionDetectComponent RegionDetectComponent;

	// Token: 0x0400B928 RID: 47400
	[Nullable(2)]
	public UKuroRegionShapeComponent RegionComponent;

	// Token: 0x0400B929 RID: 47401
	public bool HasObstaclesCollision;

	// Token: 0x0400B92A RID: 47402
	public bool NeedHitObstacles;

	// Token: 0x0400B92B RID: 47403
	public readonly Dictionary<AActor, BulletConditionResult> MapBulletConditionResult = new Dictionary<AActor, BulletConditionResult>();

	// Token: 0x0400B92C RID: 47404
	public Dictionary<AActor, BulletHitActorData> MapHitActorData = new Dictionary<AActor, BulletHitActorData>();

	// Token: 0x0400B92D RID: 47405
	public List<BulletHitActorData> ArrayHitActorData = new List<BulletHitActorData>();

	// Token: 0x0400B92E RID: 47406
	public Dictionary<AActor, BulletHitActorData> LastMapHitActorData = new Dictionary<AActor, BulletHitActorData>();

	// Token: 0x0400B92F RID: 47407
	public List<BulletHitActorData> LastArrayHitActorData = new List<BulletHitActorData>();

	// Token: 0x0400B930 RID: 47408
	public readonly List<AActor> ArrayHitActor = new List<AActor>();

	// Token: 0x0400B931 RID: 47409
	public bool IsInProcessHit;

	// Token: 0x0400B932 RID: 47410
	public bool HasSearchedHitActorsCurFrame;

	// Token: 0x0400B933 RID: 47411
	public readonly Dictionary<int, int> ObjectsHitCurrent = new Dictionary<int, int>();

	// Token: 0x0400B934 RID: 47412
	public int? SceneItemPartHitEntityId;

	// Token: 0x0400B935 RID: 47413
	public readonly HashSet<string> SceneItemPartsHitCurrent = new HashSet<string>();

	// Token: 0x0400B936 RID: 47414
	public bool StopHit;

	// Token: 0x0400B937 RID: 47415
	public bool HaveCharacterInBullet;

	// Token: 0x0400B938 RID: 47416
	public readonly Dictionary<Entity, int> CharacterEntityMap = new Dictionary<Entity, int>();

	// Token: 0x0400B939 RID: 47417
	public readonly Dictionary<Entity, int> BulletEntityMap = new Dictionary<Entity, int>();

	// Token: 0x0400B93A RID: 47418
	public readonly Dictionary<int, int> HitTimeScaleEntityMap = new Dictionary<int, int>();

	// Token: 0x0400B93B RID: 47419
	public bool HitObstaclesCurFrame;

	// Token: 0x0400B93C RID: 47420
	public bool IsPassDelay;

	// Token: 0x0400B93D RID: 47421
	public bool AllowedEnergy;

	// Token: 0x0400B93E RID: 47422
	public bool AllowedAddEnergyBuff;

	// Token: 0x0400B93F RID: 47423
	public float ActiveDelayMs;

	// Token: 0x0400B940 RID: 47424
	public float ActiveLengthMs;

	// Token: 0x0400B941 RID: 47425
	public float IntervalMs;

	// Token: 0x0400B942 RID: 47426
	public bool IsProcessOpen;

	// Token: 0x0400B943 RID: 47427
	public int LastStageInterval;

	// Token: 0x0400B944 RID: 47428
	public int StageInterval;

	// Token: 0x0400B945 RID: 47429
	public bool IsStartup;

	// Token: 0x0400B946 RID: 47430
	public readonly Vector CenterLocalLocation = Vector.Create();

	// Token: 0x0400B947 RID: 47431
	public readonly Vector FinalScale = Vector.Create();

	// Token: 0x0400B948 RID: 47432
	public readonly Vector LastFramePosition = Vector.Create();

	// Token: 0x0400B949 RID: 47433
	[Nullable(2)]
	public UTraceBoxElement UpdateTraceBox;

	// Token: 0x0400B94A RID: 47434
	[Nullable(2)]
	public UTraceSphereElement UpdateTraceSphere;

	// Token: 0x0400B94B RID: 47435
	[Nullable(2)]
	public UTraceLineElement UpdateTraceLine;

	// Token: 0x0400B94C RID: 47436
	[Nullable(2)]
	public UTraceSphereElement ObstaclesTraceElement;

	// Token: 0x0400B94D RID: 47437
	public readonly HashSet<ECollisionChannel> IgnoreChannels = new HashSet<ECollisionChannel>();

	// Token: 0x0400B94E RID: 47438
	public readonly HashSet<EObjectTypeQuery> IgnoreQueries = new HashSet<EObjectTypeQuery>();

	// Token: 0x0400B94F RID: 47439
	public long DamageId;

	// Token: 0x0400B950 RID: 47440
	private readonly Dictionary<long, long> PreResolvedDamageIdMap = new Dictionary<long, long>();

	// Token: 0x0400B951 RID: 47441
	private bool IsCurrentDamageIdPreResolvedInternal;

	// Token: 0x0400B952 RID: 47442
	public FName BeHitEffect = FNameUtil.NONE;

	// Token: 0x0400B953 RID: 47443
	public FName WeaknessBeHitEffect = FNameUtil.NONE;
}
