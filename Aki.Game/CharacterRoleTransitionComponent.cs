using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game;
using UnrealEngine;

// Token: 0x020025D9 RID: 9689
[NullableContext(2)]
[Nullable(0)]
public class CharacterRoleTransitionComponent : EntityComponent
{
	// Token: 0x06018265 RID: 98917 RVA: 0x00740A7C File Offset: 0x0073EC7C
	protected override bool OnStart()
	{
		this.CheckLeftTime = 1000.0;
		this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
		return true;
	}

	// Token: 0x06018266 RID: 98918 RVA: 0x00740AA0 File Offset: 0x0073ECA0
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

	// Token: 0x06018267 RID: 98919 RVA: 0x00740BAC File Offset: 0x0073EDAC
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

	// Token: 0x06018268 RID: 98920 RVA: 0x00740C80 File Offset: 0x0073EE80
	private void ChangeControlRole(int entityId, int playerId)
	{
		CreatureController.Instance.ChangeEntityRoleRequest(entityId, playerId);
	}

	// Token: 0x06018269 RID: 98921 RVA: 0x00740C90 File Offset: 0x0073EE90
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterRoleTransitionComponent characterRoleTransitionComponent = (CharacterRoleTransitionComponent)componentTemplate;
		if (characterRoleTransitionComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		this.IsInControlArea = characterRoleTransitionComponent.IsInControlArea;
		this.CheckLeftTime = characterRoleTransitionComponent.CheckLeftTime;
		return true;
	}

	// Token: 0x170025DD RID: 9693
	// (get) Token: 0x0601826A RID: 98922 RVA: 0x00740CF3 File Offset: 0x0073EEF3
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025DE RID: 9694
	// (get) Token: 0x0601826B RID: 98923 RVA: 0x00740CF6 File Offset: 0x0073EEF6
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CFA4 RID: 53156
	private const int CHECK_CHANGE_ROLE_TIME = 1000;

	// Token: 0x0400CFA5 RID: 53157
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CFA6 RID: 53158
	private readonly double ControlDistance = 800.0;

	// Token: 0x0400CFA7 RID: 53159
	private bool IsInControlArea;

	// Token: 0x0400CFA8 RID: 53160
	private double CheckLeftTime;

	// Token: 0x0400CFA9 RID: 53161
	private readonly bool OpenChangeRoleState;
}
