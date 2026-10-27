using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E0D RID: 11789
[NullableContext(2)]
[Nullable(0)]
public class BulletHitActorData
{
	// Token: 0x1700224F RID: 8783
	// (get) Token: 0x06018CA6 RID: 101542 RVA: 0x0065A96C File Offset: 0x00658B6C
	public Entity Entity
	{
		get
		{
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle == null)
			{
				return null;
			}
			return entityHandle.Entity;
		}
	}

	// Token: 0x06018CA7 RID: 101543 RVA: 0x0065A97F File Offset: 0x00658B7F
	[NullableContext(1)]
	public void AddComponent(UPrimitiveComponent comp)
	{
		if (this.Components == null)
		{
			this.Components = new List<UPrimitiveComponent>();
		}
		this.Components.Add(comp);
	}

	// Token: 0x06018CA8 RID: 101544 RVA: 0x0065A9A0 File Offset: 0x00658BA0
	public void AddHitResult(UKuroHitResult hitResult, int index)
	{
		if (this.HitResult == null)
		{
			this.HitResult = new BulletHitResult();
		}
		this.HitResult.AppendHitResult(hitResult, index);
	}

	// Token: 0x06018CA9 RID: 101545 RVA: 0x0065A9C2 File Offset: 0x00658BC2
	[NullableContext(1)]
	public void AddHitTempResult(BulletHitTempResult hitTempResult, string boneName)
	{
		if (this.HitResult == null)
		{
			this.HitResult = new BulletHitResult();
		}
		this.HitResult.AppendHitTempResult(hitTempResult, boneName);
	}

	// Token: 0x06018CAA RID: 101546 RVA: 0x0065A9E4 File Offset: 0x00658BE4
	[NullableContext(1)]
	public bool HasComponent(UPrimitiveComponent comp)
	{
		List<UPrimitiveComponent> components = this.Components;
		return components != null && components.Contains(comp);
	}

	// Token: 0x06018CAB RID: 101547 RVA: 0x0065A9F8 File Offset: 0x00658BF8
	public void Clear()
	{
		this.Type = EBulletHitActorType.Ignore;
		this.EntityHandle = null;
		List<UPrimitiveComponent> components = this.Components;
		if (components != null)
		{
			components.Clear();
		}
		this.Components = null;
		this.Actor = null;
		this.IsValidHit = false;
		this.IsContinueHit = false;
		this.FromObstaclesCollision = false;
		this.Priority = 0;
		this.ValidProcessIndex = 0;
		this.HitResult = null;
		this.ConditionResult = null;
	}

	// Token: 0x0400B966 RID: 47462
	public EBulletHitActorType Type;

	// Token: 0x0400B967 RID: 47463
	public EntityHandle EntityHandle;

	// Token: 0x0400B968 RID: 47464
	public int BulletEntityId;

	// Token: 0x0400B969 RID: 47465
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<UPrimitiveComponent> Components;

	// Token: 0x0400B96A RID: 47466
	public AActor Actor;

	// Token: 0x0400B96B RID: 47467
	public bool IsValidHit;

	// Token: 0x0400B96C RID: 47468
	public bool IsContinueHit;

	// Token: 0x0400B96D RID: 47469
	public bool FromObstaclesCollision;

	// Token: 0x0400B96E RID: 47470
	public int Priority;

	// Token: 0x0400B96F RID: 47471
	public int ValidProcessIndex;

	// Token: 0x0400B970 RID: 47472
	public BulletHitResult HitResult;

	// Token: 0x0400B971 RID: 47473
	public BulletConditionResult ConditionResult;
}
