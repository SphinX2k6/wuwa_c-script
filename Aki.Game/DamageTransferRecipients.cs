using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002485 RID: 9349
[NullableContext(1)]
[Nullable(0)]
public class DamageTransferRecipients : BuffEffect
{
	// Token: 0x060174CE RID: 95438 RVA: 0x006DA13C File Offset: 0x006D833C
	public DamageTransferRecipients(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060174CF RID: 95439 RVA: 0x006DA158 File Offset: 0x006D8358
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length <= 2 || string.IsNullOrEmpty(extraEffectParameters_[2]))
		{
			this.ToughAppliers = Array.Empty<Entity>();
			return;
		}
		List<Entity> list = new List<Entity>();
		string[] array = extraEffectParameters_[2].Split('#', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			EDamageTransferType edamageTransferType = (EDamageTransferType)int.Parse(array[i]);
			Entity entityByApplierType = this.GetEntityByApplierType(edamageTransferType);
			this.SetTargetIsOwnerFlag(edamageTransferType);
			if (entityByApplierType != null)
			{
				list.Add(entityByApplierType);
			}
		}
		this.ToughAppliers = list.ToArray();
	}

	// Token: 0x060174D0 RID: 95440 RVA: 0x006DA1E0 File Offset: 0x006D83E0
	[NullableContext(2)]
	private Entity GetEntityByApplierType(EDamageTransferType applierType)
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		bool flag;
		if (exactOwnerEntity == null)
		{
			flag = false;
		}
		else
		{
			BaseBuffComponent component = exactOwnerEntity.GetComponent<BaseBuffComponent>();
			flag = ((component != null) ? new bool?(component.IsTeamBuffComponent()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			if (applierType != EDamageTransferType.Instigator)
			{
				return null;
			}
			EntityHandle instigatorEntity = base.InstigatorEntity;
			if (instigatorEntity == null)
			{
				return null;
			}
			return instigatorEntity.Entity;
		}
		else if (applierType != EDamageTransferType.Instigator)
		{
			if (applierType == EDamageTransferType.Owner)
			{
				return base.OwnerEntity;
			}
			return null;
		}
		else
		{
			EntityHandle instigatorEntity2 = base.InstigatorEntity;
			if (instigatorEntity2 == null)
			{
				return null;
			}
			return instigatorEntity2.Entity;
		}
	}

	// Token: 0x060174D1 RID: 95441 RVA: 0x006DA25E File Offset: 0x006D845E
	private void SetTargetIsOwnerFlag(EDamageTransferType applierType)
	{
		if (applierType == EDamageTransferType.Owner)
		{
			this.TargetIsOwner = true;
		}
	}

	// Token: 0x060174D2 RID: 95442 RVA: 0x006DA26B File Offset: 0x006D846B
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return this.ToughAppliers;
	}

	// Token: 0x060174D3 RID: 95443 RVA: 0x006DA274 File Offset: 0x006D8474
	public override string GetDebugEffectString()
	{
		string text = string.Empty;
		for (int i = 0; i < this.ToughAppliers.Length; i++)
		{
			if (i > 0)
			{
				text += ",";
			}
			string str = text;
			Entity entity = this.ToughAppliers[i];
			text = str + ((entity != null) ? entity.ToString() : null);
		}
		return "获取伤害结算属性传递对象列表：客户端逻辑-韧性" + text + " ";
	}

	// Token: 0x060174D4 RID: 95444 RVA: 0x006DA2D8 File Offset: 0x006D84D8
	public static HashSet<Entity> ApplyEffects(Entity owner)
	{
		bool flag = false;
		HashSet<Entity> hashSet = new HashSet<Entity>();
		CharacterBuffComponent component = owner.GetComponent<CharacterBuffComponent>();
		ExtraEffectManager extraEffectManager = (component != null) ? component.BuffEffectManager : null;
		if (extraEffectManager != null)
		{
			foreach (DamageTransferRecipients damageTransferRecipients in extraEffectManager.FilterById<DamageTransferRecipients>(EExtraEffectId.DamageTransferRecipients, null))
			{
				if (damageTransferRecipients.Check(new Partial_RequirementPayload(), component))
				{
					Entity[] array = damageTransferRecipients.Execute(Array.Empty<object>()) as Entity[];
					if (array != null)
					{
						for (int i = 0; i < array.Length; i++)
						{
							hashSet.Add(array[i]);
						}
					}
				}
				flag = true;
			}
		}
		if (flag)
		{
			return hashSet;
		}
		if (component != null && component.IsRoleBuffComponent())
		{
			RoleBuffComponent roleBuffComponent = component as RoleBuffComponent;
			if (roleBuffComponent != null && roleBuffComponent.HasBuffAuthority())
			{
				PlayerBuffComponent formationBuffComp = roleBuffComponent.GetFormationBuffComp();
				if (((formationBuffComp != null) ? formationBuffComp.BuffEffectManager : null) != null)
				{
					foreach (DamageTransferRecipients damageTransferRecipients2 in formationBuffComp.BuffEffectManager.FilterById<DamageTransferRecipients>(EExtraEffectId.DamageTransferRecipients, null))
					{
						if (damageTransferRecipients2.TargetIsOwner)
						{
							hashSet.Add(owner);
						}
						if (damageTransferRecipients2.Check(new Partial_RequirementPayload(), component))
						{
							Entity[] array2 = damageTransferRecipients2.Execute(Array.Empty<object>()) as Entity[];
							if (array2 != null)
							{
								for (int j = 0; j < array2.Length; j++)
								{
									hashSet.Add(array2[j]);
								}
							}
						}
					}
				}
			}
		}
		return hashSet;
	}

	// Token: 0x0400C5A0 RID: 50592
	private Entity[] ToughAppliers = Array.Empty<Entity>();

	// Token: 0x0400C5A1 RID: 50593
	private bool TargetIsOwner;
}
