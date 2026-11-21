using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DB1 RID: 7601
[NullableContext(1)]
[Nullable(0)]
public class RoleDevWeaponSubRecommendItemDataBase
{
	// Token: 0x06012D89 RID: 77193 RVA: 0x00587CDE File Offset: 0x00585EDE
	public void InitByWeaponId(int weaponId, int roleId)
	{
		this.RoleIdInternal = roleId;
		this.WeaponIdInternal = weaponId;
	}

	// Token: 0x17001C8D RID: 7309
	// (get) Token: 0x06012D8A RID: 77194 RVA: 0x00587CEE File Offset: 0x00585EEE
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C8E RID: 7310
	// (get) Token: 0x06012D8B RID: 77195 RVA: 0x00587CF6 File Offset: 0x00585EF6
	public int WeaponId
	{
		get
		{
			return this.WeaponIdInternal;
		}
	}

	// Token: 0x17001C8F RID: 7311
	// (get) Token: 0x06012D8C RID: 77196 RVA: 0x00587CFE File Offset: 0x00585EFE
	public bool HasRole
	{
		get
		{
			return RoleModel.Instance.GetRoleInstanceById(this.RoleId) != null;
		}
	}

	// Token: 0x17001C90 RID: 7312
	// (get) Token: 0x06012D8D RID: 77197 RVA: 0x00587D14 File Offset: 0x00585F14
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

	// Token: 0x17001C91 RID: 7313
	// (get) Token: 0x06012D8E RID: 77198 RVA: 0x00587D50 File Offset: 0x00585F50
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

	// Token: 0x17001C92 RID: 7314
	// (get) Token: 0x06012D8F RID: 77199 RVA: 0x00587D88 File Offset: 0x00585F88
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

	// Token: 0x17001C93 RID: 7315
	// (get) Token: 0x06012D90 RID: 77200 RVA: 0x00587DB4 File Offset: 0x00585FB4
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

	// Token: 0x17001C94 RID: 7316
	// (get) Token: 0x06012D91 RID: 77201 RVA: 0x00587DFC File Offset: 0x00585FFC
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

	// Token: 0x17001C95 RID: 7317
	// (get) Token: 0x06012D92 RID: 77202 RVA: 0x00587E48 File Offset: 0x00586048
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

	// Token: 0x17001C96 RID: 7318
	// (get) Token: 0x06012D93 RID: 77203 RVA: 0x00587E8A File Offset: 0x0058608A
	public bool IsObtained
	{
		get
		{
			return InventoryModel.Instance.GetItemCountByConfigId(this.WeaponId, 0) > 0;
		}
	}

	// Token: 0x0400A289 RID: 41609
	protected int RoleIdInternal;

	// Token: 0x0400A28A RID: 41610
	protected int WeaponIdInternal;
}
