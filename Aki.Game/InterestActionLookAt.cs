using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002778 RID: 10104
[NullableContext(1)]
[Nullable(0)]
public class InterestActionLookAt : InterestActionBase
{
	// Token: 0x17002877 RID: 10359
	// (get) Token: 0x060195AE RID: 103854 RVA: 0x007C02CF File Offset: 0x007BE4CF
	public override EInterestActionType Type
	{
		get
		{
			return EInterestActionType.LookAt;
		}
	}

	// Token: 0x17002878 RID: 10360
	// (get) Token: 0x060195AF RID: 103855 RVA: 0x007C02D2 File Offset: 0x007BE4D2
	public override bool IsExclusive
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060195B0 RID: 103856 RVA: 0x007C02D8 File Offset: 0x007BE4D8
	public override void OnEnter(Entity entity, InterestItemBase item)
	{
		CommonNpcPerformComponent component = entity.GetComponent<CommonNpcPerformComponent>();
		if (component == null)
		{
			return;
		}
		OneOf<BaseActorComponent, Vector, AActor>? lookAtTarget = this.GetLookAtTarget(item);
		if (lookAtTarget == null)
		{
			return;
		}
		component.SightTarget(lookAtTarget, EStareActionType.InterestEvent);
	}

	// Token: 0x060195B1 RID: 103857 RVA: 0x007C030C File Offset: 0x007BE50C
	public override void OnLeave(Entity entity, InterestItemBase item)
	{
		CommonNpcPerformComponent component = entity.GetComponent<CommonNpcPerformComponent>();
		if (component == null)
		{
			return;
		}
		component.SightTarget(null, EStareActionType.InterestEvent);
	}

	// Token: 0x060195B2 RID: 103858 RVA: 0x007C0334 File Offset: 0x007BE534
	public override int GetPriority(Entity entity, InterestItemBase item)
	{
		BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
		if (component == null)
		{
			return int.MaxValue;
		}
		if (!item.GetLocation(InterestActionBase.TmpVector1))
		{
			return int.MaxValue;
		}
		return (int)Vector.DistSquared(component.ActorLocationProxy, InterestActionBase.TmpVector1);
	}

	// Token: 0x060195B3 RID: 103859 RVA: 0x007C0378 File Offset: 0x007BE578
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	private OneOf<BaseActorComponent, Vector, AActor>? GetLookAtTarget(InterestItemBase item)
	{
		EInterestItemType type = item.Type;
		if (type == EInterestItemType.Entity)
		{
			Entity entity = ((InterestItemEntity)item).GetEntity();
			return new OneOf<BaseActorComponent, Vector, AActor>?((entity != null) ? entity.GetComponent<BaseActorComponent>() : null);
		}
		if (type == EInterestItemType.Position)
		{
			return new OneOf<BaseActorComponent, Vector, AActor>?(((InterestItemPosition)item).Position);
		}
		return null;
	}
}
