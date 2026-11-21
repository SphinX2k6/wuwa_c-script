using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.View;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02003D25 RID: 15653
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoleDevelopProjectBaseData
	{
		// Token: 0x06028126 RID: 164134 RVA: 0x00B38AD8 File Offset: 0x00B36CD8
		public RoleDevelopProjectBaseData(int id, RoleDevelopRoleBaseData developRoleData)
		{
			this.Id = id;
			this.DevelopRoleData = developRoleData;
		}

		// Token: 0x06028127 RID: 164135 RVA: 0x00B38AEE File Offset: 0x00B36CEE
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x06028128 RID: 164136 RVA: 0x00B38AF6 File Offset: 0x00B36CF6
		protected List<ISelectedData> GetSortedRoleExpItemList()
		{
			List<ISelectedData> list = new List<ISelectedData>(RoleModel.Instance.GetExpItemInInventory());
			list.Sort(delegate(ISelectedData a, ISelectedData b)
			{
				ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.ItemId);
				ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(b.ItemId);
				return ((itemConfigData != null) ? itemConfigData.QualityId : 0) - ((itemConfigData2 != null) ? itemConfigData2.QualityId : 0);
			});
			return list;
		}

		// Token: 0x06028129 RID: 164137 RVA: 0x00B38B2C File Offset: 0x00B36D2C
		protected List<ISelectedData> GetSortedWeaponExpItemList()
		{
			List<ISelectedData> expItemInInventory = WeaponModel.Instance.GetExpItemInInventory();
			expItemInInventory.Sort(delegate(ISelectedData a, ISelectedData b)
			{
				ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.ItemId);
				ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(b.ItemId);
				return ((itemConfigData != null) ? itemConfigData.QualityId : 0) - ((itemConfigData2 != null) ? itemConfigData2.QualityId : 0);
			});
			return expItemInInventory;
		}

		// Token: 0x0602812A RID: 164138 RVA: 0x00B38B5D File Offset: 0x00B36D5D
		protected bool IsShouldSkipItem(int itemId)
		{
			return itemId == 2;
		}

		// Token: 0x0602812B RID: 164139 RVA: 0x00B38B63 File Offset: 0x00B36D63
		protected void HandleItemJumpCallback(RoleDevelopItemGroup groupItem)
		{
			RoleDevelopUtil.HandleItemJump(this.Id, groupItem);
		}

		// Token: 0x0602812C RID: 164140
		public abstract ERoleDevelopRoleType GetRoleType();

		// Token: 0x0602812D RID: 164141
		public abstract int GetRoleTargetLevel();

		// Token: 0x0602812E RID: 164142
		public abstract int GetRoleUpgradeExp();

		// Token: 0x0602812F RID: 164143
		public abstract List<RoleDevelopNeedItem> GetRoleUpgradeNeedItems();

		// Token: 0x06028130 RID: 164144
		public abstract List<RoleDevelopNeedItem> GetRoleBreachNeedItems();

		// Token: 0x06028131 RID: 164145
		public abstract List<RoleDevelopNeedItem> GetRoleDevelopNeedItems();

		// Token: 0x06028132 RID: 164146
		public abstract List<RoleDevelopProjectMaterialItemData> GetRoleDevelopProjectViewItems();

		// Token: 0x06028133 RID: 164147
		public abstract int GetWeaponType();

		// Token: 0x06028134 RID: 164148
		public abstract int GetWeaponTargetLevel();

		// Token: 0x06028135 RID: 164149
		public abstract int GetWeaponUpgradeExp();

		// Token: 0x06028136 RID: 164150
		public abstract List<RoleDevelopNeedItem> GetWeaponUpgradeNeedItems();

		// Token: 0x06028137 RID: 164151
		public abstract List<RoleDevelopNeedItem> GetWeaponBreachNeedItems();

		// Token: 0x06028138 RID: 164152
		public abstract List<RoleDevelopProjectMaterialItemData> GetWeaponDevelopProjectViewItems();

		// Token: 0x06028139 RID: 164153
		public abstract List<RoleDevelopSkillData> GetSkillDevelopData();

		// Token: 0x0602813A RID: 164154
		public abstract bool IsSkillPlanFinished();

		// Token: 0x0602813B RID: 164155
		public abstract List<RoleDevelopNeedItem> GetSkillPlanNeedItems();

		// Token: 0x0602813C RID: 164156
		public abstract List<RoleDevelopProjectMaterialItemData> GetSkillDevelopProjectViewItems();

		// Token: 0x0602813D RID: 164157
		public abstract bool IsShowUpgradeHint(ERoleDevelopCategoryType categoryType);

		// Token: 0x0602813E RID: 164158
		public abstract bool IsShowFinishHint(ERoleDevelopCategoryType categoryType);

		// Token: 0x0602813F RID: 164159
		public abstract bool IsShowCanImproveHint(ERoleDevelopCategoryType categoryType);

		// Token: 0x06028140 RID: 164160
		public abstract bool IsRoleDevelopFinished();

		// Token: 0x06028141 RID: 164161
		public abstract bool IsWeaponDevelopFinished();

		// Token: 0x06028142 RID: 164162
		public abstract bool IsRoleReachTargetLevel();

		// Token: 0x06028143 RID: 164163
		public abstract bool IsRoleReachBreachLevel();

		// Token: 0x06028144 RID: 164164
		public abstract bool IsWeaponReachTargetLevel();

		// Token: 0x06028145 RID: 164165
		public abstract bool IsWeaponReachBreachLevel();

		// Token: 0x04015CDB RID: 89307
		protected int Id;

		// Token: 0x04015CDC RID: 89308
		protected RoleDevelopRoleBaseData DevelopRoleData;
	}
}
