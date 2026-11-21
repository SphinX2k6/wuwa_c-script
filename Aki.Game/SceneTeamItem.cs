using System;
using System.Runtime.CompilerServices;

// Token: 0x02001ECE RID: 7886
[NullableContext(2)]
[Nullable(0)]
public class SceneTeamItem
{
	// Token: 0x060137AF RID: 79791 RVA: 0x005AECBC File Offset: 0x005ACEBC
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

	// Token: 0x060137B0 RID: 79792 RVA: 0x005AED38 File Offset: 0x005ACF38
	public void Reset()
	{
		this.CreatureDataId = 0L;
		this.EntityHandleInternal = null;
	}

	// Token: 0x060137B1 RID: 79793 RVA: 0x005AED49 File Offset: 0x005ACF49
	public ETeamGroupType GetGroupType()
	{
		return this.GroupType;
	}

	// Token: 0x060137B2 RID: 79794 RVA: 0x005AED51 File Offset: 0x005ACF51
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x060137B3 RID: 79795 RVA: 0x005AED59 File Offset: 0x005ACF59
	public bool IsMyRole()
	{
		return this.IsMyRoleInternal;
	}

	// Token: 0x060137B4 RID: 79796 RVA: 0x005AED61 File Offset: 0x005ACF61
	public bool IsAutoRole()
	{
		return this.IsAutoRoleInternal;
	}

	// Token: 0x060137B5 RID: 79797 RVA: 0x005AED6C File Offset: 0x005ACF6C
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

	// Token: 0x17001DAF RID: 7599
	// (get) Token: 0x060137B6 RID: 79798 RVA: 0x005AEDB5 File Offset: 0x005ACFB5
	public int GetConfigId
	{
		get
		{
			return this.ConfigId;
		}
	}

	// Token: 0x060137B7 RID: 79799 RVA: 0x005AEDBD File Offset: 0x005ACFBD
	public long GetCreatureDataId()
	{
		return this.CreatureDataId;
	}

	// Token: 0x060137B8 RID: 79800 RVA: 0x005AEDC5 File Offset: 0x005ACFC5
	public void UpdateEntityHandle()
	{
		this.EntityHandleInternal = CreatureModel.Instance.GetEntity(this.CreatureDataId);
	}

	// Token: 0x17001DB0 RID: 7600
	// (get) Token: 0x060137B9 RID: 79801 RVA: 0x005AEDE0 File Offset: 0x005ACFE0
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

	// Token: 0x060137BA RID: 79802 RVA: 0x005AEE3C File Offset: 0x005AD03C
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

	// Token: 0x060137BB RID: 79803 RVA: 0x005AEE74 File Offset: 0x005AD074
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

	// Token: 0x060137BC RID: 79804 RVA: 0x005AEEFC File Offset: 0x005AD0FC
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

	// Token: 0x060137BD RID: 79805 RVA: 0x005AEF43 File Offset: 0x005AD143
	public void SetRemoteIsControl(bool isControl)
	{
		this.RemoteIsControl = isControl;
	}

	// Token: 0x0400A6A8 RID: 42664
	private bool IsMyRoleInternal;

	// Token: 0x0400A6A9 RID: 42665
	private bool IsAutoRoleInternal;

	// Token: 0x0400A6AA RID: 42666
	private ETeamGroupType GroupType;

	// Token: 0x0400A6AB RID: 42667
	private int PlayerId;

	// Token: 0x0400A6AC RID: 42668
	private int ConfigId;

	// Token: 0x0400A6AD RID: 42669
	private long CreatureDataId;

	// Token: 0x0400A6AE RID: 42670
	private EntityHandle EntityHandleInternal;

	// Token: 0x0400A6AF RID: 42671
	private bool RemoteIsControl;
}
