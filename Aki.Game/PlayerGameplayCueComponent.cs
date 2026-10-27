using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02003292 RID: 12946
[NullableContext(1)]
[Nullable(0)]
public class PlayerGameplayCueComponent : BaseGameplayCueComponent
{
	// Token: 0x0601C085 RID: 114821 RVA: 0x007CB370 File Offset: 0x007C9570
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.PlayerId = ((creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0);
		return true;
	}

	// Token: 0x0601C086 RID: 114822 RVA: 0x007CB39C File Offset: 0x007C959C
	protected override bool OnStart()
	{
		base.OnStart();
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return true;
	}

	// Token: 0x0601C087 RID: 114823 RVA: 0x007CB3C2 File Offset: 0x007C95C2
	protected override bool OnEnd()
	{
		base.OnEnd();
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return true;
	}

	// Token: 0x0601C088 RID: 114824 RVA: 0x007CB3E8 File Offset: 0x007C95E8
	[NullableContext(2)]
	protected override EntityHandle GetEntityHandle()
	{
		SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(this.PlayerId);
		long? num;
		if (teamPlayerData == null)
		{
			num = null;
		}
		else
		{
			SceneTeamGroup currentGroup = teamPlayerData.GetCurrentGroup();
			if (currentGroup == null)
			{
				num = null;
			}
			else
			{
				SceneTeamRole currentRole = currentGroup.GetCurrentRole();
				num = ((currentRole != null) ? new long?(currentRole.CreatureDataId) : null);
			}
		}
		long? num2 = num;
		return CreatureModel.Instance.GetEntity(num2.GetValueOrDefault());
	}

	// Token: 0x0601C089 RID: 114825 RVA: 0x007CB458 File Offset: 0x007C9658
	private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		foreach (GameplayCueBase gameplayCueBase in base.GetAllCurrentCueRef())
		{
			if (gameplayCueBase.EntityHandle != newEntityHandle)
			{
				gameplayCueBase.OnChangeRole(newEntityHandle);
			}
		}
	}

	// Token: 0x0601C08A RID: 114826 RVA: 0x007CB4B0 File Offset: 0x007C96B0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PlayerGameplayCueComponent playerGameplayCueComponent = (PlayerGameplayCueComponent)componentTemplate;
		if (base.CanResetComponentProperty("PlayerId"))
		{
			this.PlayerId = playerGameplayCueComponent.PlayerId;
		}
		return true;
	}

	// Token: 0x0400DD93 RID: 56723
	protected int PlayerId;
}
