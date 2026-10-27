using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02003234 RID: 12852
[NullableContext(1)]
[Nullable(0)]
public class RoleAttributeComponent : CharacterAttributeComponent
{
	// Token: 0x0601BB6E RID: 113518 RVA: 0x007A104D File Offset: 0x0079F24D
	public override void CollectBoundsLockers(EAttributeType attrId, List<IBoundsLocker> output)
	{
		base.CollectBoundsLockers(attrId, output);
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(CreatureModel.Instance.GetPlayerId());
		PlayerAttributeComponent playerAttributeComponent = (playerEntity != null) ? playerEntity.GetComponent<PlayerAttributeComponent>() : null;
		if (playerAttributeComponent == null)
		{
			return;
		}
		playerAttributeComponent.CollectBoundsLockers(attrId, output);
	}

	// Token: 0x0601BB6F RID: 113519 RVA: 0x007A1083 File Offset: 0x0079F283
	public override void CollectModifiers(EAttributeType attrId, List<CharacterAttributeTypes.IModifier> output)
	{
		base.CollectModifiers(attrId, output);
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(CreatureModel.Instance.GetPlayerId());
		PlayerAttributeComponent playerAttributeComponent = (playerEntity != null) ? playerEntity.GetComponent<PlayerAttributeComponent>() : null;
		if (playerAttributeComponent == null)
		{
			return;
		}
		playerAttributeComponent.CollectModifiers(attrId, output);
	}

	// Token: 0x0601BB70 RID: 113520 RVA: 0x007A10B9 File Offset: 0x0079F2B9
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleAttributeComponent roleAttributeComponent = (RoleAttributeComponent)componentTemplate;
		return true;
	}
}
