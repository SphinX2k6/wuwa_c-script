using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020027A3 RID: 10147
[NullableContext(1)]
[Nullable(0)]
public class RoleAttributeComponent : CharacterAttributeComponent
{
	// Token: 0x060196F3 RID: 104179 RVA: 0x007C9959 File Offset: 0x007C7B59
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

	// Token: 0x060196F4 RID: 104180 RVA: 0x007C998F File Offset: 0x007C7B8F
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

	// Token: 0x17002882 RID: 10370
	// (get) Token: 0x060196F5 RID: 104181 RVA: 0x007C99C5 File Offset: 0x007C7BC5
	public override bool NeedCreateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002883 RID: 10371
	// (get) Token: 0x060196F6 RID: 104182 RVA: 0x007C99C8 File Offset: 0x007C7BC8
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002884 RID: 10372
	// (get) Token: 0x060196F7 RID: 104183 RVA: 0x007C99CB File Offset: 0x007C7BCB
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002885 RID: 10373
	// (get) Token: 0x060196F8 RID: 104184 RVA: 0x007C99CE File Offset: 0x007C7BCE
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002886 RID: 10374
	// (get) Token: 0x060196F9 RID: 104185 RVA: 0x007C99D1 File Offset: 0x007C7BD1
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002887 RID: 10375
	// (get) Token: 0x060196FA RID: 104186 RVA: 0x007C99D4 File Offset: 0x007C7BD4
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002888 RID: 10376
	// (get) Token: 0x060196FB RID: 104187 RVA: 0x007C99D7 File Offset: 0x007C7BD7
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}
}
