using System;
using System.Runtime.CompilerServices;

// Token: 0x02002953 RID: 10579
[NullableContext(2)]
[Nullable(0)]
public class SceneTeamItem
{
	// Token: 0x06015DAB RID: 89515 RVA: 0x00583CBC File Offset: 0x00581EBC
	[NullableContext(1)]
	public static SceneTeamItem Create(ETeamGroupType groupType, int playerId, int configId, long creatureDataId)
	{
		SceneTeamItem sceneTeamItem = new SceneTeamItem();
		sceneTeamItem.GroupType = groupType;
		sceneTeamItem.IsMyRoleInternal = (playerId == CreatureModel.Instance.GetPlayerId());
		sceneTeamItem.PlayerId = playerId;
		sceneTeamItem.ConfigId = configId;
		sceneTeamItem.CreatureDataId = creatureDataId;
		sceneTeamItem.UpdateEntityHandle();
		EntityHandle entityHandleInternal = sceneTeamItem.EntityHandleInternal;
		object obj;
		if (entityHandleInternal == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = entityHandleInternal.Entity;
			obj = ((entity != null) ? entity.GetComponent<CreatureDataComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null && obj2.IsAutoRole())
		{
			sceneTeamItem.IsAutoRoleInternal = true;
		}
		return sceneTeamItem;
	}

	// Token: 0x06015DAC RID: 89516 RVA: 0x00583D38 File Offset: 0x00581F38
	public void Reset()
	{
		this.CreatureDataId = 0L;
		this.EntityHandleInternal = null;
	}

	// Token: 0x06015DAD RID: 89517 RVA: 0x00583D49 File Offset: 0x00581F49
	public ETeamGroupType GetGroupType()
	{
		return this.GroupType;
	}

	// Token: 0x06015DAE RID: 89518 RVA: 0x00583D51 File Offset: 0x00581F51
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x06015DAF RID: 89519 RVA: 0x00583D59 File Offset: 0x00581F59
	public bool IsMyRole()
	{
		return this.IsMyRoleInternal;
	}

	// Token: 0x06015DB0 RID: 89520 RVA: 0x00583D61 File Offset: 0x00581F61
	public bool IsAutoRole()
	{
		return this.IsAutoRoleInternal;
	}

	// Token: 0x06015DB1 RID: 89521 RVA: 0x00583D6C File Offset: 0x00581F6C
	public bool IsControl()
	{
		if (!this.IsMyRoleInternal)
		{
			return this.RemoteIsControl;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null && this.EntityHandle != null)
		{
			int id = getCurrentEntity.Id;
			int id2 = this.EntityHandle.Id;
			return id == id2;
		}
		return false;
	}

	// Token: 0x17001D56 RID: 7510
	// (get) Token: 0x06015DB2 RID: 89522 RVA: 0x00583DB5 File Offset: 0x00581FB5
	public int GetConfigId
	{
		get
		{
			return this.ConfigId;
		}
	}

	// Token: 0x06015DB3 RID: 89523 RVA: 0x00583DBD File Offset: 0x00581FBD
	public long GetCreatureDataId()
	{
		return this.CreatureDataId;
	}

	// Token: 0x06015DB4 RID: 89524 RVA: 0x00583DC5 File Offset: 0x00581FC5
	public void UpdateEntityHandle()
	{
		this.EntityHandleInternal = CreatureModel.Instance.GetEntity(this.CreatureDataId);
	}

	// Token: 0x17001D57 RID: 7511
	// (get) Token: 0x06015DB5 RID: 89525 RVA: 0x00583DE0 File Offset: 0x00581FE0
	public EntityHandle EntityHandle
	{
		get
		{
			if (this.EntityHandleInternal == null || !this.EntityHandleInternal.Valid)
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(this.CreatureDataId);
				if (entity == null || !entity.Valid)
				{
					return null;
				}
				this.EntityHandleInternal = entity;
			}
			if (!this.EntityHandleInternal.IsInit)
			{
				return null;
			}
			return this.EntityHandleInternal;
		}
	}

	// Token: 0x06015DB6 RID: 89526 RVA: 0x00583E3C File Offset: 0x0058203C
	public bool IsDead()
	{
		EntityHandle entityHandle = this.EntityHandle;
		WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
		if (worldEntity == null)
		{
			return true;
		}
		BaseDeathComponent component = worldEntity.GetComponent<BaseDeathComponent>();
		return component == null || component.IsDead();
	}

	// Token: 0x06015DB7 RID: 89527 RVA: 0x00583E74 File Offset: 0x00582074
	public EGoBattleResultType CanGoBattle()
	{
		EntityHandle entityHandle = this.EntityHandle;
		WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
		if (worldEntity == null)
		{
			return EGoBattleResultType.NoEntity;
		}
		CreatureDataComponent component = worldEntity.GetComponent<CreatureDataComponent>();
		if (component != null && component.GetRemoveState())
		{
			return EGoBattleResultType.EntityRemoving;
		}
		BaseDeathComponent component2 = worldEntity.GetComponent<BaseDeathComponent>();
		if (component2 == null || component2.IsDead())
		{
			return EGoBattleResultType.IsDead;
		}
		BaseTagComponent baseTagComponent = worldEntity.CheckGetComponent<BaseTagComponent>();
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中"]) && !baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["GameplayEvent.幻象.变身.允许切回"]))
		{
			return EGoBattleResultType.InPhantom;
		}
		return EGoBattleResultType.Success;
	}

	// Token: 0x06015DB8 RID: 89528 RVA: 0x00583EFC File Offset: 0x005820FC
	public bool CanControl(bool skipCheckDead = false)
	{
		EntityHandle entityHandle = this.EntityHandle;
		WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
		if (worldEntity == null)
		{
			return false;
		}
		if (!skipCheckDead)
		{
			BaseDeathComponent component = worldEntity.GetComponent<BaseDeathComponent>();
			if (component == null || component.IsDead())
			{
				return false;
			}
		}
		return !this.IsAutoRoleInternal;
	}

	// Token: 0x06015DB9 RID: 89529 RVA: 0x00583F43 File Offset: 0x00582143
	public void SetRemoteIsControl(bool isControl)
	{
		this.RemoteIsControl = isControl;
	}

	// Token: 0x0400A2BE RID: 41662
	private bool IsMyRoleInternal;

	// Token: 0x0400A2BF RID: 41663
	private bool IsAutoRoleInternal;

	// Token: 0x0400A2C0 RID: 41664
	private ETeamGroupType GroupType;

	// Token: 0x0400A2C1 RID: 41665
	private int PlayerId;

	// Token: 0x0400A2C2 RID: 41666
	private int ConfigId;

	// Token: 0x0400A2C3 RID: 41667
	private long CreatureDataId;

	// Token: 0x0400A2C4 RID: 41668
	private EntityHandle EntityHandleInternal;

	// Token: 0x0400A2C5 RID: 41669
	private bool RemoteIsControl;
}
