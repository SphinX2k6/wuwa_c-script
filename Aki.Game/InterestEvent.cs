using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200320F RID: 12815
[NullableContext(2)]
[Nullable(0)]
public class InterestEvent : IStaticVariableResetter
{
	// Token: 0x0601BA46 RID: 113222 RVA: 0x00797EA7 File Offset: 0x007960A7
	static InterestEvent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InterestEvent.CreateStaticDefaultValue), new Action(InterestEvent.ResetStaticDefaultValue));
	}

	// Token: 0x0601BA47 RID: 113223 RVA: 0x00797EC8 File Offset: 0x007960C8
	[NullableContext(1)]
	public InterestEvent(Entity ownerEntity)
	{
		this.Id = ++InterestEvent.IdGenerator;
		this.OwnerEntity = ownerEntity;
		CommonNpcPerformComponent component = this.OwnerEntity.GetComponent<CommonNpcPerformComponent>();
		this.OwnerController = component.InterestEventController;
	}

	// Token: 0x0601BA48 RID: 113224 RVA: 0x00797F18 File Offset: 0x00796118
	public int GetPriority()
	{
		return this.Action.GetPriority(this.OwnerEntity, this.Target);
	}

	// Token: 0x0601BA49 RID: 113225 RVA: 0x00797F34 File Offset: 0x00796134
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

	// Token: 0x0601BA4A RID: 113226 RVA: 0x00797F9C File Offset: 0x0079619C
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

	// Token: 0x0601BA4B RID: 113227 RVA: 0x00797FD6 File Offset: 0x007961D6
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

	// Token: 0x0601BA4C RID: 113228 RVA: 0x00798011 File Offset: 0x00796211
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601BA4D RID: 113229 RVA: 0x00798013 File Offset: 0x00796213
	public static void ResetStaticDefaultValue()
	{
		InterestEvent.IdGenerator = 0;
	}

	// Token: 0x0400D95B RID: 55643
	public Entity OwnerEntity;

	// Token: 0x0400D95C RID: 55644
	public NpcInterestEventController OwnerController;

	// Token: 0x0400D95D RID: 55645
	public int Id;

	// Token: 0x0400D95E RID: 55646
	public float Radius;

	// Token: 0x0400D95F RID: 55647
	public InterestItemBase Target;

	// Token: 0x0400D960 RID: 55648
	[Nullable(1)]
	public List<InterestConditionBase> Conditions = new List<InterestConditionBase>();

	// Token: 0x0400D961 RID: 55649
	public InterestActionBase Action;

	// Token: 0x0400D962 RID: 55650
	public bool IsEntered;

	// Token: 0x0400D963 RID: 55651
	private static int IdGenerator;
}
