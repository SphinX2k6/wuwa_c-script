using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020027B6 RID: 10166
[NullableContext(2)]
[Nullable(0)]
public class RoleInheritComponent : EntityComponent
{
	// Token: 0x0601981F RID: 104479 RVA: 0x007D1219 File Offset: 0x007CF419
	protected override bool OnStart()
	{
		this.CreatureDataComponent = base.Entity.GetComponent<CreatureDataComponent>();
		this.BuffComponent = base.Entity.CheckGetComponent<CharacterBuffComponent>();
		return true;
	}

	// Token: 0x06019820 RID: 104480 RVA: 0x007D1240 File Offset: 0x007CF440
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

	// Token: 0x06019821 RID: 104481 RVA: 0x007D133C File Offset: 0x007CF53C
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

	// Token: 0x06019822 RID: 104482 RVA: 0x007D148C File Offset: 0x007CF68C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleInheritComponent roleInheritComponent = (RoleInheritComponent)componentTemplate;
		if (roleInheritComponent.CreatureDataComponent == null)
		{
			this.CreatureDataComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComponent), "CreatureDataComponent"))
		{
			return false;
		}
		if (roleInheritComponent.BuffComponent == null)
		{
			this.BuffComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComponent), "BuffComponent"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170028B3 RID: 10419
	// (get) Token: 0x06019823 RID: 104483 RVA: 0x007D1502 File Offset: 0x007CF702
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DF79 RID: 57209
	private CreatureDataComponent CreatureDataComponent;

	// Token: 0x0400DF7A RID: 57210
	private CharacterBuffComponent BuffComponent;
}
