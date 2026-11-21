using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002366 RID: 9062
[NullableContext(1)]
[Nullable(0)]
public class BulletCollisionInfo
{
	// Token: 0x170022B5 RID: 8885
	// (get) Token: 0x06016559 RID: 91481 RVA: 0x00680364 File Offset: 0x0067E564
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

	// Token: 0x0601655A RID: 91482 RVA: 0x00680384 File Offset: 0x0067E584
	public void RecordPreResolvedDamageId(long damageId, long preResolvedDamageId)
	{
		this.PreResolvedDamageIdMap[damageId] = preResolvedDamageId;
	}

	// Token: 0x0601655B RID: 91483 RVA: 0x00680394 File Offset: 0x0067E594
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

	// Token: 0x170022B6 RID: 8886
	// (get) Token: 0x0601655C RID: 91484 RVA: 0x006803CE File Offset: 0x0067E5CE
	public bool IsCurrentDamageIdPreResolved
	{
		get
		{
			return this.IsCurrentDamageIdPreResolvedInternal;
		}
	}

	// Token: 0x0601655D RID: 91485 RVA: 0x006803D8 File Offset: 0x0067E5D8
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

	// Token: 0x0601655E RID: 91486 RVA: 0x00680434 File Offset: 0x0067E634
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

	// Token: 0x0601655F RID: 91487 RVA: 0x006804C8 File Offset: 0x0067E6C8
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

	// Token: 0x06016560 RID: 91488 RVA: 0x00680554 File Offset: 0x0067E754
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

	// Token: 0x06016561 RID: 91489 RVA: 0x006805C0 File Offset: 0x0067E7C0
	[return: Nullable(2)]
	public Entity GetFirstVictim(EBulletHitActorType[] types)
	{
		foreach (BulletHitActorData bulletHitActorData in (this.IsInProcessHit ? this.ArrayHitActorData : this.LastArrayHitActorData))
		{
			if (bulletHitActorData.IsValidHit && Array.IndexOf<EBulletHitActorType>(types, bulletHitActorData.Type) >= 0 && bulletHitActorData != null)
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

	// Token: 0x06016562 RID: 91490 RVA: 0x0068066C File Offset: 0x0067E86C
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

	// Token: 0x0400BCAC RID: 48300
	private const int PRIORITY_OBSTACLE = 1000;

	// Token: 0x0400BCAD RID: 48301
	private const int PRIORITY_SCENEITEM = 2000;

	// Token: 0x0400BCAE RID: 48302
	private const int PRIORITY_CHARACTER = 3000;

	// Token: 0x0400BCAF RID: 48303
	private const int PRIORITY_NPC = 4000;

	// Token: 0x0400BCB0 RID: 48304
	private const int PRIORITY_ANIMAL = 5000;

	// Token: 0x0400BCB1 RID: 48305
	private const int PRIORITY_BULLET = 6000;

	// Token: 0x0400BCB2 RID: 48306
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

	// Token: 0x0400BCB3 RID: 48307
	public bool ActorCollisionEnable;

	// Token: 0x0400BCB4 RID: 48308
	[Nullable(2)]
	public UPrimitiveComponent CollisionComponent;

	// Token: 0x0400BCB5 RID: 48309
	[Nullable(2)]
	public UKuroRegionDetectComponent RegionDetectComponent;

	// Token: 0x0400BCB6 RID: 48310
	[Nullable(2)]
	public UKuroRegionShapeComponent RegionComponent;

	// Token: 0x0400BCB7 RID: 48311
	public bool HasObstaclesCollision;

	// Token: 0x0400BCB8 RID: 48312
	public bool NeedHitObstacles;

	// Token: 0x0400BCB9 RID: 48313
	public readonly Dictionary<AActor, BulletConditionResult> MapBulletConditionResult = new Dictionary<AActor, BulletConditionResult>();

	// Token: 0x0400BCBA RID: 48314
	public Dictionary<AActor, BulletHitActorData> MapHitActorData = new Dictionary<AActor, BulletHitActorData>();

	// Token: 0x0400BCBB RID: 48315
	public List<BulletHitActorData> ArrayHitActorData = new List<BulletHitActorData>();

	// Token: 0x0400BCBC RID: 48316
	public Dictionary<AActor, BulletHitActorData> LastMapHitActorData = new Dictionary<AActor, BulletHitActorData>();

	// Token: 0x0400BCBD RID: 48317
	public List<BulletHitActorData> LastArrayHitActorData = new List<BulletHitActorData>();

	// Token: 0x0400BCBE RID: 48318
	public readonly List<AActor> ArrayHitActor = new List<AActor>();

	// Token: 0x0400BCBF RID: 48319
	public bool IsInProcessHit;

	// Token: 0x0400BCC0 RID: 48320
	public bool HasSearchedHitActorsCurFrame;

	// Token: 0x0400BCC1 RID: 48321
	public readonly Dictionary<int, int> ObjectsHitCurrent = new Dictionary<int, int>();

	// Token: 0x0400BCC2 RID: 48322
	public int? SceneItemPartHitEntityId;

	// Token: 0x0400BCC3 RID: 48323
	public readonly HashSet<string> SceneItemPartsHitCurrent = new HashSet<string>();

	// Token: 0x0400BCC4 RID: 48324
	public bool StopHit;

	// Token: 0x0400BCC5 RID: 48325
	public bool HaveCharacterInBullet;

	// Token: 0x0400BCC6 RID: 48326
	public readonly Dictionary<Entity, int> CharacterEntityMap = new Dictionary<Entity, int>();

	// Token: 0x0400BCC7 RID: 48327
	public readonly Dictionary<Entity, int> BulletEntityMap = new Dictionary<Entity, int>();

	// Token: 0x0400BCC8 RID: 48328
	public readonly Dictionary<int, int> HitTimeScaleEntityMap = new Dictionary<int, int>();

	// Token: 0x0400BCC9 RID: 48329
	public bool HitObstaclesCurFrame;

	// Token: 0x0400BCCA RID: 48330
	public bool IsPassDelay;

	// Token: 0x0400BCCB RID: 48331
	public bool AllowedEnergy;

	// Token: 0x0400BCCC RID: 48332
	public bool AllowedAddEnergyBuff;

	// Token: 0x0400BCCD RID: 48333
	public float ActiveDelayMs;

	// Token: 0x0400BCCE RID: 48334
	public float ActiveLengthMs;

	// Token: 0x0400BCCF RID: 48335
	public float IntervalMs;

	// Token: 0x0400BCD0 RID: 48336
	public bool IsProcessOpen;

	// Token: 0x0400BCD1 RID: 48337
	public int LastStageInterval;

	// Token: 0x0400BCD2 RID: 48338
	public int StageInterval;

	// Token: 0x0400BCD3 RID: 48339
	public bool IsStartup;

	// Token: 0x0400BCD4 RID: 48340
	public readonly Vector CenterLocalLocation = Vector.Create();

	// Token: 0x0400BCD5 RID: 48341
	public readonly Vector FinalScale = Vector.Create();

	// Token: 0x0400BCD6 RID: 48342
	public readonly Vector LastFramePosition = Vector.Create();

	// Token: 0x0400BCD7 RID: 48343
	[Nullable(2)]
	public UTraceBoxElement UpdateTraceBox;

	// Token: 0x0400BCD8 RID: 48344
	[Nullable(2)]
	public UTraceSphereElement UpdateTraceSphere;

	// Token: 0x0400BCD9 RID: 48345
	[Nullable(2)]
	public UTraceLineElement UpdateTraceLine;

	// Token: 0x0400BCDA RID: 48346
	[Nullable(2)]
	public UTraceSphereElement ObstaclesTraceElement;

	// Token: 0x0400BCDB RID: 48347
	public readonly HashSet<ECollisionChannel> IgnoreChannels = new HashSet<ECollisionChannel>();

	// Token: 0x0400BCDC RID: 48348
	public readonly HashSet<EObjectTypeQuery> IgnoreQueries = new HashSet<EObjectTypeQuery>();

	// Token: 0x0400BCDD RID: 48349
	public long DamageId;

	// Token: 0x0400BCDE RID: 48350
	private readonly Dictionary<long, long> PreResolvedDamageIdMap = new Dictionary<long, long>();

	// Token: 0x0400BCDF RID: 48351
	private bool IsCurrentDamageIdPreResolvedInternal;

	// Token: 0x0400BCE0 RID: 48352
	public FName BeHitEffect = FNameUtil.NONE;

	// Token: 0x0400BCE1 RID: 48353
	public FName WeaknessBeHitEffect = FNameUtil.NONE;
}
