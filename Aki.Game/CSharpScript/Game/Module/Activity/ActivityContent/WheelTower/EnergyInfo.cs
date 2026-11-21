using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F03 RID: 20227
	[NullableContext(1)]
	[Nullable(0)]
	public class EnergyInfo
	{
		// Token: 0x170062C7 RID: 25287
		// (get) Token: 0x06032D54 RID: 208212 RVA: 0x00E45629 File Offset: 0x00E43829
		public Dictionary<int, int> RoleEnergyMap { get; } = new Dictionary<int, int>();

		// Token: 0x170062C8 RID: 25288
		// (get) Token: 0x06032D55 RID: 208213 RVA: 0x00E45631 File Offset: 0x00E43831
		public Dictionary<int, int> WeaponEnergyMap { get; } = new Dictionary<int, int>();

		// Token: 0x170062C9 RID: 25289
		// (get) Token: 0x06032D56 RID: 208214 RVA: 0x00E45639 File Offset: 0x00E43839
		public Dictionary<int, int> PhantomEnergyMap { get; } = new Dictionary<int, int>();

		// Token: 0x170062CA RID: 25290
		// (get) Token: 0x06032D57 RID: 208215 RVA: 0x00E45641 File Offset: 0x00E43841
		public Dictionary<int, int> SkillBranchMap { get; } = new Dictionary<int, int>();

		// Token: 0x06032D58 RID: 208216 RVA: 0x00E4564C File Offset: 0x00E4384C
		public int GetRoleEnergy(int roleId)
		{
			int key = WheelTowerModel.Instance.TryGetRealRoleId(roleId);
			int result;
			if (!this.RoleEnergyMap.TryGetValue(key, out result))
			{
				return -1;
			}
			return result;
		}

		// Token: 0x06032D59 RID: 208217 RVA: 0x00E45678 File Offset: 0x00E43878
		public bool IsRoleEnergyEnough(int roleId)
		{
			return this.GetRoleEnergy(roleId) > 0;
		}

		// Token: 0x06032D5A RID: 208218 RVA: 0x00E45684 File Offset: 0x00E43884
		public bool GetWeaponCanUse(int weaponIncId, int roleId)
		{
			int num;
			return !this.WeaponEnergyMap.TryGetValue(weaponIncId, out num) || roleId == num;
		}

		// Token: 0x06032D5B RID: 208219 RVA: 0x00E456A8 File Offset: 0x00E438A8
		public int GetWeaponOccupyRoleId(int weaponIncId, int roleId)
		{
			int num;
			if (!this.WeaponEnergyMap.TryGetValue(weaponIncId, out num) || roleId == num)
			{
				return -1;
			}
			return num;
		}

		// Token: 0x06032D5C RID: 208220 RVA: 0x00E456CC File Offset: 0x00E438CC
		public bool GetPhantomCanUse(int phantomIncId, int roleId)
		{
			int num;
			return !this.PhantomEnergyMap.TryGetValue(phantomIncId, out num) || roleId == num;
		}

		// Token: 0x06032D5D RID: 208221 RVA: 0x00E456F0 File Offset: 0x00E438F0
		public int GetPhantomOccupyRoleId(int phantomIncId, int roleId)
		{
			int num;
			if (!this.PhantomEnergyMap.TryGetValue(phantomIncId, out num) || roleId == num)
			{
				return -1;
			}
			return num;
		}
	}
}
