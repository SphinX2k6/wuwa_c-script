using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002801 RID: 10241
public class PlayerAttributeComponent : BaseAttributeComponent
{
	// Token: 0x06019C62 RID: 105570 RVA: 0x007F1050 File Offset: 0x007EF250
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.PlayerId = ((creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0);
		return true;
	}

	// Token: 0x06019C63 RID: 105571 RVA: 0x007F107C File Offset: 0x007EF27C
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

	// Token: 0x06019C64 RID: 105572 RVA: 0x007F110C File Offset: 0x007EF30C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PlayerAttributeComponent playerAttributeComponent = (PlayerAttributeComponent)componentTemplate;
		this.PlayerId = playerAttributeComponent.PlayerId;
		return true;
	}

	// Token: 0x1700297F RID: 10623
	// (get) Token: 0x06019C65 RID: 105573 RVA: 0x007F1138 File Offset: 0x007EF338
	public override bool NeedCreateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002980 RID: 10624
	// (get) Token: 0x06019C66 RID: 105574 RVA: 0x007F113B File Offset: 0x007EF33B
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002981 RID: 10625
	// (get) Token: 0x06019C67 RID: 105575 RVA: 0x007F113E File Offset: 0x007EF33E
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E22E RID: 57902
	private int PlayerId;
}
