using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game;
using UnrealEngine;

// Token: 0x02003082 RID: 12418
[NullableContext(2)]
[Nullable(0)]
public class CharacterRoleTransitionComponent : EntityComponent
{
	// Token: 0x0601A884 RID: 108676 RVA: 0x0071A5C5 File Offset: 0x007187C5
	protected override bool OnStart()
	{
		this.CheckLeftTime = 1000.0;
		this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
		return true;
	}

	// Token: 0x0601A885 RID: 108677 RVA: 0x0071A5E8 File Offset: 0x007187E8
	protected override void OnTick(float delta)
	{
		if (!this.OpenChangeRoleState)
		{
			return;
		}
		this.CheckLeftTime -= (double)delta;
		if (this.CheckLeftTime > 0.0)
		{
			return;
		}
		this.CheckLeftTime = 1000.0;
		if (Global.BaseCharacter == null)
		{
			return;
		}
		FVectorDouble actorLocation = Global.BaseCharacter.CharacterActorComponent.ActorLocation;
		FVectorDouble actorLocation2 = this.ActorComp.ActorLocation;
		double num = global::Vector.DistSquared(global::Vector.Create(actorLocation), global::Vector.Create(actorLocation2));
		this.IsInControlArea = (num < this.ControlDistance * this.ControlDistance);
		if (this.ActorComp.IsAutonomousProxy)
		{
			if (this.IsInControlArea)
			{
				return;
			}
			Entity entity = this.ChooseController();
			if (entity == null || !entity.Valid)
			{
				return;
			}
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			this.ChangeControlRole(entity.Id, component.GetPlayerId());
			return;
		}
		else
		{
			if (!this.IsInControlArea)
			{
				return;
			}
			int playerId = CreatureModel.Instance.GetPlayerId();
			this.ChangeControlRole(base.Entity.Id, playerId);
			return;
		}
	}

	// Token: 0x0601A886 RID: 108678 RVA: 0x0071A6F4 File Offset: 0x007188F4
	private Entity ChooseController()
	{
		foreach (EntityHandle entityHandle in CreatureModel.Instance.GetAllEntities())
		{
			if (entityHandle != null && entityHandle.IsInit && entityHandle.Entity.GetComponent<CreatureDataComponent>().GetEntityType() == EEntityType.Player)
			{
				CharacterActorComponent characterActorComponentById = CharacterController.Instance.GetCharacterActorComponentById(entityHandle.Id);
				if (characterActorComponentById != null && characterActorComponentById.Actor != Global.BaseCharacter && characterActorComponentById != this.ActorComp)
				{
					FVectorDouble actorLocation = this.ActorComp.ActorLocation;
					FVectorDouble actorLocation2 = characterActorComponentById.ActorLocation;
					if (UKismetMathLibrary.D_Vector_DistanceSquared(actorLocation, actorLocation2) < this.ControlDistance * this.ControlDistance)
					{
						return entityHandle.Entity;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0601A887 RID: 108679 RVA: 0x0071A7C8 File Offset: 0x007189C8
	private void ChangeControlRole(int entityId, int playerId)
	{
		CreatureController.Instance.ChangeEntityRoleRequest(entityId, playerId);
	}

	// Token: 0x0601A888 RID: 108680 RVA: 0x0071A7D8 File Offset: 0x007189D8
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterRoleTransitionComponent characterRoleTransitionComponent = (CharacterRoleTransitionComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterRoleTransitionComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsInControlArea"))
		{
			this.IsInControlArea = characterRoleTransitionComponent.IsInControlArea;
		}
		if (base.CanResetComponentProperty("CheckLeftTime"))
		{
			this.CheckLeftTime = characterRoleTransitionComponent.CheckLeftTime;
		}
		return true;
	}

	// Token: 0x0400CBC1 RID: 52161
	private const int CHECK_CHANGE_ROLE_TIME = 1000;

	// Token: 0x0400CBC2 RID: 52162
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CBC3 RID: 52163
	private readonly double ControlDistance = 800.0;

	// Token: 0x0400CBC4 RID: 52164
	private bool IsInControlArea;

	// Token: 0x0400CBC5 RID: 52165
	private double CheckLeftTime;

	// Token: 0x0400CBC6 RID: 52166
	private readonly bool OpenChangeRoleState;
}
