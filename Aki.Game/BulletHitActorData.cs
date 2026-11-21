using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002369 RID: 9065
[NullableContext(2)]
[Nullable(0)]
public class BulletHitActorData
{
	// Token: 0x170022B7 RID: 8887
	// (get) Token: 0x06016567 RID: 91495 RVA: 0x00680B40 File Offset: 0x0067ED40
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

	// Token: 0x06016568 RID: 91496 RVA: 0x00680B53 File Offset: 0x0067ED53
	[NullableContext(1)]
	public void AddComponent(UPrimitiveComponent comp)
	{
		if (this.Components == null)
		{
			this.Components = new List<UPrimitiveComponent>();
		}
		this.Components.Add(comp);
	}

	// Token: 0x06016569 RID: 91497 RVA: 0x00680B74 File Offset: 0x0067ED74
	public void AddHitResult(UKuroHitResult hitResult, int index)
	{
		if (this.HitResult == null)
		{
			this.HitResult = new BulletHitResult();
		}
		this.HitResult.AppendHitResult(hitResult, index);
	}

	// Token: 0x0601656A RID: 91498 RVA: 0x00680B96 File Offset: 0x0067ED96
	[NullableContext(1)]
	public void AddHitTempResult(BulletHitTempResult hitTempResult, string boneName)
	{
		if (this.HitResult == null)
		{
			this.HitResult = new BulletHitResult();
		}
		this.HitResult.AppendHitTempResult(hitTempResult, boneName);
	}

	// Token: 0x0601656B RID: 91499 RVA: 0x00680BB8 File Offset: 0x0067EDB8
	[NullableContext(1)]
	public bool HasComponent(UPrimitiveComponent comp)
	{
		List<UPrimitiveComponent> components = this.Components;
		return components != null && components.Contains(comp);
	}

	// Token: 0x0601656C RID: 91500 RVA: 0x00680BCC File Offset: 0x0067EDCC
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

	// Token: 0x0400BCF4 RID: 48372
	public EBulletHitActorType Type;

	// Token: 0x0400BCF5 RID: 48373
	public EntityHandle EntityHandle;

	// Token: 0x0400BCF6 RID: 48374
	public int BulletEntityId;

	// Token: 0x0400BCF7 RID: 48375
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<UPrimitiveComponent> Components;

	// Token: 0x0400BCF8 RID: 48376
	public AActor Actor;

	// Token: 0x0400BCF9 RID: 48377
	public bool IsValidHit;

	// Token: 0x0400BCFA RID: 48378
	public bool IsContinueHit;

	// Token: 0x0400BCFB RID: 48379
	public bool FromObstaclesCollision;

	// Token: 0x0400BCFC RID: 48380
	public int Priority;

	// Token: 0x0400BCFD RID: 48381
	public int ValidProcessIndex;

	// Token: 0x0400BCFE RID: 48382
	public BulletHitResult HitResult;

	// Token: 0x0400BCFF RID: 48383
	public BulletConditionResult ConditionResult;
}
