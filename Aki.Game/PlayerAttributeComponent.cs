using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02003290 RID: 12944
public class PlayerAttributeComponent : BaseAttributeComponent
{
	// Token: 0x0601C04D RID: 114765 RVA: 0x007C9DF0 File Offset: 0x007C7FF0
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.PlayerId = ((creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0);
		return true;
	}

	// Token: 0x0601C04E RID: 114766 RVA: 0x007C9E1C File Offset: 0x007C801C
	public override void UpdateCurrentValue(EAttributeType attrId)
	{
		base.UpdateCurrentValue(attrId);
		foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItemsByPlayer(this.PlayerId))
		{
			EntityHandle entity = CreatureModel.Instance.GetEntity(sceneTeamItem.GetCreatureDataId());
			if (entity != null)
			{
				WorldEntity entity2 = entity.Entity;
				if (entity2 != null)
				{
					BaseAttributeComponent component = entity2.GetComponent<BaseAttributeComponent>();
					if (component != null)
					{
						component.UpdateCurrentValue(attrId);
					}
				}
			}
		}
	}

	// Token: 0x0601C04F RID: 114767 RVA: 0x007C9EAC File Offset: 0x007C80AC
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PlayerAttributeComponent playerAttributeComponent = (PlayerAttributeComponent)componentTemplate;
		if (base.CanResetComponentProperty("PlayerId"))
		{
			this.PlayerId = playerAttributeComponent.PlayerId;
		}
		return true;
	}

	// Token: 0x0400DD87 RID: 56711
	private int PlayerId;
}
