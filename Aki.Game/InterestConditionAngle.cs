using System;
using System.Runtime.CompilerServices;

// Token: 0x0200320E RID: 12814
[NullableContext(1)]
[Nullable(0)]
public class InterestConditionAngle : InterestConditionBase
{
	// Token: 0x1700263C RID: 9788
	// (get) Token: 0x0601BA42 RID: 113218 RVA: 0x00797DD5 File Offset: 0x00795FD5
	public override EInterestConditionType Type
	{
		get
		{
			return EInterestConditionType.Angle;
		}
	}

	// Token: 0x0601BA43 RID: 113219 RVA: 0x00797DD8 File Offset: 0x00795FD8
	public override bool CheckCondition(Entity entity, InterestItemBase item)
	{
		BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
		if (component == null)
		{
			return false;
		}
		Vector location = this.GetLocation(item);
		if (location == null)
		{
			return false;
		}
		location.Subtraction(component.ActorLocationProxy, InterestConditionBase.TmpVector1);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(component, InterestConditionBase.TmpVector1);
		InterestConditionBase.TmpVector1.Normalize(9.99999993922529E-09);
		return MathUtils.Instance.GetAngleByVectorDot(InterestConditionBase.TmpVector1, component.ActorForwardProxy) < (double)this.MaxAngle;
	}

	// Token: 0x0601BA44 RID: 113220 RVA: 0x00797E54 File Offset: 0x00796054
	[return: Nullable(2)]
	private Vector GetLocation(InterestItemBase item)
	{
		EInterestItemType type = item.Type;
		if (type != EInterestItemType.Entity)
		{
			if (type == EInterestItemType.Position)
			{
				return ((InterestItemPosition)item).Position;
			}
			return null;
		}
		else
		{
			Entity entity = ((InterestItemEntity)item).GetEntity();
			BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
			if (baseActorComponent == null)
			{
				return null;
			}
			return baseActorComponent.ActorLocationProxy;
		}
	}

	// Token: 0x0400D95A RID: 55642
	public float MaxAngle;
}
