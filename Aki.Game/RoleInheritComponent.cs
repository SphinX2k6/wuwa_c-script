using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02003247 RID: 12871
[NullableContext(2)]
[Nullable(0)]
public class RoleInheritComponent : EntityComponent
{
	// Token: 0x0601BC6B RID: 113771 RVA: 0x007A8B35 File Offset: 0x007A6D35
	protected override bool OnStart()
	{
		this.CreatureDataComponent = base.Entity.GetComponent<CreatureDataComponent>();
		this.BuffComponent = base.Entity.CheckGetComponent<CharacterBuffComponent>();
		return true;
	}

	// Token: 0x0601BC6C RID: 113772 RVA: 0x007A8B5C File Offset: 0x007A6D5C
	public static void StateInherit(RoleInheritComponent last, RoleInheritComponent newly, ERoleInheritType inheritType, bool skill)
	{
		if (last != null && newly != null)
		{
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.ZQR, "换人进入StateInherit", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (!last.CreatureDataComponent.GetRemoveState())
			{
				last.BuffComponent.TriggerEvents(EBuffTriggerType.ForGoDown, newly.BuffComponent, new Partial_RequirementPayload());
				newly.BuffComponent.TriggerEvents(EBuffTriggerType.ForGoBattle, last.BuffComponent, new Partial_RequirementPayload());
				RoleInheritComponent.InheritBuffs(last, newly);
			}
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.ZQR, "换人进入RoleOnStateInherit", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem instance = EventSystem.Instance;
			object entity = newly.Entity;
			EEventName name = EEventName.RoleOnStateInherit;
			Entity entity2 = last.Entity;
			bool p;
			if (inheritType != ERoleInheritType.QTE && !skill)
			{
				BaseTagComponent component = newly.Entity.GetComponent<BaseTagComponent>();
				p = (component != null && component.HasAnyTag(new int[]
				{
					GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台不受控制"],
					GameplayTagDefine.EGameplayTagId["角色.Common.切人不隐藏"]
				}));
			}
			else
			{
				p = true;
			}
			instance.EmitWithTarget<Entity, bool>(entity, name, entity2, p);
		}
	}

	// Token: 0x0601BC6D RID: 113773 RVA: 0x007A8C58 File Offset: 0x007A6E58
	[NullableContext(1)]
	private static void InheritBuffs(RoleInheritComponent last, RoleInheritComponent newly)
	{
		foreach (IActiveBuff activeBuff in last.BuffComponent.GetAllBuffs())
		{
			int stackCount = activeBuff.StackCount;
			if (stackCount > 0)
			{
				int handle = activeBuff.Handle;
				long? instigatorId = activeBuff.InstigatorId;
				BuffDefinition config = activeBuff.Config;
				if (config.FormationPolicy == EBuffFormationPolicy.InheritedWhenChangeRole || config.FormationPolicy == EBuffFormationPolicy.InheritedWhenChangeRoleAndRemoveSelf)
				{
					float num = activeBuff.GetRemainDuration();
					if (activeBuff.Duration > 0f && num <= 0f)
					{
						num = 0.0001f;
					}
					newly.BuffComponent.AddBuff(activeBuff.Id, new AddBuffParam
					{
						Level = new int?(activeBuff.Level),
						ServerId = new int?(activeBuff.ServerId),
						InstigatorId = instigatorId.GetValueOrDefault(),
						OuterStackCount = new int?(stackCount),
						Duration = new float?(num),
						IsIterable = new bool?(false),
						PreMessageId = activeBuff.MessageId,
						Reason = "因为状态继承导致的buff添加"
					});
					if (config.FormationPolicy == EBuffFormationPolicy.InheritedWhenChangeRoleAndRemoveSelf)
					{
						last.BuffComponent.RemoveBuffByHandle(handle, -1, "因为状态继承导致的移除", null, null, null);
					}
				}
			}
		}
	}

	// Token: 0x0601BC6E RID: 113774 RVA: 0x007A8DA8 File Offset: 0x007A6FA8
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleInheritComponent roleInheritComponent = (RoleInheritComponent)componentTemplate;
		if (base.CanResetComponentProperty("CreatureDataComponent"))
		{
			if (roleInheritComponent.CreatureDataComponent == null)
			{
				this.CreatureDataComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComponent), "CreatureDataComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BuffComponent"))
		{
			if (roleInheritComponent.BuffComponent == null)
			{
				this.BuffComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterBuffComponent>(this.BuffComponent), "BuffComponent"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400DADA RID: 56026
	private CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400DADB RID: 56027
	private CharacterBuffComponent BuffComponent;
}
