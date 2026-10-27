using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.View;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02004D5C RID: 19804
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoleDevelopProjectBaseData
	{
		// Token: 0x060332BC RID: 209596 RVA: 0x00BEF9A4 File Offset: 0x00BEDBA4
		public RoleDevelopProjectBaseData(int id, RoleDevelopRoleBaseData developRoleData)
		{
			this.Id = id;
			this.DevelopRoleData = developRoleData;
		}

		// Token: 0x060332BD RID: 209597 RVA: 0x00BEF9BA File Offset: 0x00BEDBBA
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x060332BE RID: 209598 RVA: 0x00BEF9C2 File Offset: 0x00BEDBC2
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

		// Token: 0x060332BF RID: 209599 RVA: 0x00BEF9F8 File Offset: 0x00BEDBF8
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

		// Token: 0x060332C0 RID: 209600 RVA: 0x00BEFA29 File Offset: 0x00BEDC29
		protected bool IsShouldSkipItem(int itemId)
		{
			return itemId == 2;
		}

		// Token: 0x060332C1 RID: 209601 RVA: 0x00BEFA2F File Offset: 0x00BEDC2F
		protected void HandleItemJumpCallback(RoleDevelopItemGroup groupItem)
		{
			RoleDevelopUtil.HandleItemJump(this.Id, groupItem);
		}

		// Token: 0x060332C2 RID: 209602
		public abstract ERoleDevelopRoleType GetRoleType();

		// Token: 0x060332C3 RID: 209603
		public abstract int GetRoleTargetLevel();

		// Token: 0x060332C4 RID: 209604
		public abstract int GetRoleUpgradeExp();

		// Token: 0x060332C5 RID: 209605
		public abstract List<RoleDevelopNeedItem> GetRoleUpgradeNeedItems();

		// Token: 0x060332C6 RID: 209606
		public abstract List<RoleDevelopNeedItem> GetRoleBreachNeedItems();

		// Token: 0x060332C7 RID: 209607
		public abstract List<RoleDevelopNeedItem> GetRoleDevelopNeedItems();

		// Token: 0x060332C8 RID: 209608
		public abstract List<RoleDevelopProjectMaterialItemData> GetRoleDevelopProjectViewItems();

		// Token: 0x060332C9 RID: 209609
		public abstract int GetWeaponType();

		// Token: 0x060332CA RID: 209610
		public abstract int GetWeaponTargetLevel();

		// Token: 0x060332CB RID: 209611
		public abstract int GetWeaponUpgradeExp();

		// Token: 0x060332CC RID: 209612
		public abstract List<RoleDevelopNeedItem> GetWeaponUpgradeNeedItems();

		// Token: 0x060332CD RID: 209613
		public abstract List<RoleDevelopNeedItem> GetWeaponBreachNeedItems();

		// Token: 0x060332CE RID: 209614
		public abstract List<RoleDevelopProjectMaterialItemData> GetWeaponDevelopProjectViewItems();

		// Token: 0x060332CF RID: 209615
		public abstract List<RoleDevelopSkillData> GetSkillDevelopData();

		// Token: 0x060332D0 RID: 209616
		public abstract bool IsSkillPlanFinished();

		// Token: 0x060332D1 RID: 209617
		public abstract List<RoleDevelopNeedItem> GetSkillPlanNeedItems();

		// Token: 0x060332D2 RID: 209618
		public abstract List<RoleDevelopProjectMaterialItemData> GetSkillDevelopProjectViewItems();

		// Token: 0x060332D3 RID: 209619
		public abstract bool IsShowUpgradeHint(ERoleDevelopCategoryType categoryType);

		// Token: 0x060332D4 RID: 209620
		public abstract bool IsShowFinishHint(ERoleDevelopCategoryType categoryType);

		// Token: 0x060332D5 RID: 209621
		public abstract bool IsRoleDevelopFinished();

		// Token: 0x060332D6 RID: 209622
		public abstract bool IsWeaponDevelopFinished();

		// Token: 0x060332D7 RID: 209623
		public abstract bool IsRoleReachTargetLevel();

		// Token: 0x060332D8 RID: 209624
		public abstract bool IsRoleReachBreachLevel();

		// Token: 0x060332D9 RID: 209625
		public abstract bool IsWeaponReachTargetLevel();

		// Token: 0x060332DA RID: 209626
		public abstract bool IsWeaponReachBreachLevel();

		// Token: 0x0401B30A RID: 111370
		protected int Id;

		// Token: 0x0401B30B RID: 111371
		protected RoleDevelopRoleBaseData DevelopRoleData;
	}
}
