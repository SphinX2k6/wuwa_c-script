using System;
using System.Runtime.CompilerServices;

// Token: 0x0200277D RID: 10109
[NullableContext(1)]
[Nullable(0)]
public class InterestConditionAngle : InterestConditionBase
{
	// Token: 0x1700287D RID: 10365
	// (get) Token: 0x060195C7 RID: 103879 RVA: 0x007C0535 File Offset: 0x007BE735
	public override EInterestConditionType Type
	{
		get
		{
			return EInterestConditionType.Angle;
		}
	}

	// Token: 0x060195C8 RID: 103880 RVA: 0x007C0538 File Offset: 0x007BE738
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

	// Token: 0x060195C9 RID: 103881 RVA: 0x007C05C0 File Offset: 0x007BE7C0
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

	// Token: 0x0400DDF9 RID: 56825
	public float MaxAngle;
}
