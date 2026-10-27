using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003209 RID: 12809
[NullableContext(1)]
[Nullable(0)]
public class InterestActionLookAt : InterestActionBase
{
	// Token: 0x17002636 RID: 9782
	// (get) Token: 0x0601BA29 RID: 113193 RVA: 0x00797B70 File Offset: 0x00795D70
	public override EInterestActionType Type
	{
		get
		{
			return EInterestActionType.LookAt;
		}
	}

	// Token: 0x17002637 RID: 9783
	// (get) Token: 0x0601BA2A RID: 113194 RVA: 0x00797B73 File Offset: 0x00795D73
	public override bool IsExclusive
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0601BA2B RID: 113195 RVA: 0x00797B78 File Offset: 0x00795D78
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

	// Token: 0x0601BA2C RID: 113196 RVA: 0x00797BAC File Offset: 0x00795DAC
	public override void OnLeave(Entity entity, InterestItemBase item)
	{
		CommonNpcPerformComponent component = entity.GetComponent<CommonNpcPerformComponent>();
		if (component == null)
		{
			return;
		}
		component.SightTarget(null, EStareActionType.InterestEvent);
	}

	// Token: 0x0601BA2D RID: 113197 RVA: 0x00797BD4 File Offset: 0x00795DD4
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

	// Token: 0x0601BA2E RID: 113198 RVA: 0x00797C18 File Offset: 0x00795E18
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
