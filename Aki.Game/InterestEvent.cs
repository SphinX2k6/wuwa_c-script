using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200277E RID: 10110
[NullableContext(2)]
[Nullable(0)]
public class InterestEvent : IStaticVariableResetter
{
	// Token: 0x060195CB RID: 103883 RVA: 0x007C0613 File Offset: 0x007BE813
	static InterestEvent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InterestEvent.CreateStaticDefaultValue), new Action(InterestEvent.ResetStaticDefaultValue));
	}

	// Token: 0x060195CC RID: 103884 RVA: 0x007C0634 File Offset: 0x007BE834
	[NullableContext(1)]
	public InterestEvent(Entity ownerEntity)
	{
		this.Id = ++InterestEvent.IdGenerator;
		this.OwnerEntity = ownerEntity;
		CommonNpcPerformComponent component = this.OwnerEntity.GetComponent<CommonNpcPerformComponent>();
		this.OwnerController = component.InterestEventController;
	}

	// Token: 0x060195CD RID: 103885 RVA: 0x007C0684 File Offset: 0x007BE884
	public int GetPriority()
	{
		return this.Action.GetPriority(this.OwnerEntity, this.Target);
	}

	// Token: 0x060195CE RID: 103886 RVA: 0x007C06A0 File Offset: 0x007BE8A0
	public bool CheckCondition()
	{
		using (List<InterestConditionBase>.Enumerator enumerator = this.Conditions.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.CheckCondition(this.OwnerEntity, this.Target))
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060195CF RID: 103887 RVA: 0x007C0708 File Offset: 0x007BE908
	public void TryEnterRange()
	{
		if (this.IsEntered)
		{
			return;
		}
		this.IsEntered = true;
		this.OwnerController.RegisterActiveEvent(this);
		InterestActionBase action = this.Action;
		if (action == null)
		{
			return;
		}
		action.OnEnter(this.OwnerEntity, this.Target);
	}

	// Token: 0x060195D0 RID: 103888 RVA: 0x007C0742 File Offset: 0x007BE942
	public void TryLeaveRange()
	{
		if (!this.IsEntered)
		{
			return;
		}
		InterestActionBase action = this.Action;
		if (action != null)
		{
			action.OnLeave(this.OwnerEntity, this.Target);
		}
		this.OwnerController.UnRegisterActiveEvent(this);
		this.IsEntered = false;
	}

	// Token: 0x060195D1 RID: 103889 RVA: 0x007C077D File Offset: 0x007BE97D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060195D2 RID: 103890 RVA: 0x007C077F File Offset: 0x007BE97F
	public static void ResetStaticDefaultValue()
	{
		InterestEvent.IdGenerator = 0;
	}

	// Token: 0x0400DDFA RID: 56826
	public Entity OwnerEntity;

	// Token: 0x0400DDFB RID: 56827
	public NpcInterestEventController OwnerController;

	// Token: 0x0400DDFC RID: 56828
	public int Id;

	// Token: 0x0400DDFD RID: 56829
	public float Radius;

	// Token: 0x0400DDFE RID: 56830
	public InterestItemBase Target;

	// Token: 0x0400DDFF RID: 56831
	[Nullable(1)]
	public List<InterestConditionBase> Conditions = new List<InterestConditionBase>();

	// Token: 0x0400DE00 RID: 56832
	public InterestActionBase Action;

	// Token: 0x0400DE01 RID: 56833
	public bool IsEntered;

	// Token: 0x0400DE02 RID: 56834
	private static int IdGenerator;
}
