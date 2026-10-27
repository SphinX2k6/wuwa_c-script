using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002836 RID: 10294
[NullableContext(1)]
[Nullable(0)]
public class RoleDevWeaponSubRecommendItemDataBase
{
	// Token: 0x0601538B RID: 86923 RVA: 0x0055CF82 File Offset: 0x0055B182
	public void InitByWeaponId(int weaponId, int roleId)
	{
		this.RoleIdInternal = roleId;
		this.WeaponIdInternal = weaponId;
	}

	// Token: 0x17001C35 RID: 7221
	// (get) Token: 0x0601538C RID: 86924 RVA: 0x0055CF92 File Offset: 0x0055B192
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C36 RID: 7222
	// (get) Token: 0x0601538D RID: 86925 RVA: 0x0055CF9A File Offset: 0x0055B19A
	public int WeaponId
	{
		get
		{
			return this.WeaponIdInternal;
		}
	}

	// Token: 0x17001C37 RID: 7223
	// (get) Token: 0x0601538E RID: 86926 RVA: 0x0055CFA2 File Offset: 0x0055B1A2
	public bool HasRole
	{
		get
		{
			return RoleModel.Instance.GetRoleInstanceById(this.RoleId) != null;
		}
	}

	// Token: 0x17001C38 RID: 7224
	// (get) Token: 0x0601538F RID: 86927 RVA: 0x0055CFB8 File Offset: 0x0055B1B8
	public string WeaponName
	{
		get
		{
			WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(this.WeaponIdInternal);
			if (weaponConfigByItemId == null)
			{
				return "";
			}
			return weaponConfigByItemId.Value.WeaponName;
		}
	}

	// Token: 0x17001C39 RID: 7225
	// (get) Token: 0x06015390 RID: 86928 RVA: 0x0055CFF4 File Offset: 0x0055B1F4
	public int WeaponQuality
	{
		get
		{
			WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(this.WeaponIdInternal);
			if (weaponConfigByItemId == null)
			{
				return 0;
			}
			return weaponConfigByItemId.Value.QualityId;
		}
	}

	// Token: 0x17001C3A RID: 7226
	// (get) Token: 0x06015391 RID: 86929 RVA: 0x0055D02C File Offset: 0x0055B22C
	public RoleDevWeaponJumpGroup? WeaponJumpGroupConfig
	{
		get
		{
			RoleDevConfig instance = RoleDevConfig.Instance;
			if (instance == null)
			{
				return null;
			}
			return instance.GetWeaponJumpGroupConfigByWeaponId(this.WeaponIdInternal);
		}
	}

	// Token: 0x17001C3B RID: 7227
	// (get) Token: 0x06015392 RID: 86930 RVA: 0x0055D058 File Offset: 0x0055B258
	public bool IsCall
	{
		get
		{
			RoleDevWeaponJumpGroup? weaponJumpGroupConfig = this.WeaponJumpGroupConfig;
			if (weaponJumpGroupConfig == null)
			{
				return false;
			}
			int jumpType = weaponJumpGroupConfig.Value.JumpType;
			return (jumpType == 1 || jumpType == 2) && RoleDevUtils.GetRoleGachaIds(this.WeaponIdInternal).Length != 0;
		}
	}

	// Token: 0x17001C3C RID: 7228
	// (get) Token: 0x06015393 RID: 86931 RVA: 0x0055D0A0 File Offset: 0x0055B2A0
	public int GachaId
	{
		get
		{
			RoleDevWeaponJumpGroup? weaponJumpGroupConfig = this.WeaponJumpGroupConfig;
			if (weaponJumpGroupConfig == null)
			{
				return 0;
			}
			int jumpType = weaponJumpGroupConfig.Value.JumpType;
			if (jumpType == 1 || jumpType == 2)
			{
				int[] roleGachaIds = RoleDevUtils.GetRoleGachaIds(this.WeaponIdInternal);
				if (roleGachaIds.Length != 0)
				{
					return roleGachaIds[0];
				}
			}
			return 0;
		}
	}

	// Token: 0x17001C3D RID: 7229
	// (get) Token: 0x06015394 RID: 86932 RVA: 0x0055D0EC File Offset: 0x0055B2EC
	public bool IsEquipped
	{
		get
		{
			if (!this.HasRole)
			{
				return false;
			}
			int? weaponIdByRoleDataId = WeaponModel.Instance.GetWeaponIdByRoleDataId(this.RoleId);
			return weaponIdByRoleDataId != null && weaponIdByRoleDataId.Value == this.WeaponId;
		}
	}

	// Token: 0x17001C3E RID: 7230
	// (get) Token: 0x06015395 RID: 86933 RVA: 0x0055D12E File Offset: 0x0055B32E
	public bool IsObtained
	{
		get
		{
			return InventoryModel.Instance.GetItemCountByConfigId(this.WeaponId, 0) > 0;
		}
	}

	// Token: 0x04009EA0 RID: 40608
	protected int RoleIdInternal;

	// Token: 0x04009EA1 RID: 40609
	protected int WeaponIdInternal;
}
