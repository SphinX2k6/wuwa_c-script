using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F1C RID: 24348
	[NullableContext(1)]
	[Nullable(0)]
	public class EnergyInfo
	{
		// Token: 0x17008EF5 RID: 36597
		// (get) Token: 0x0603DDB9 RID: 253369 RVA: 0x00EF3921 File Offset: 0x00EF1B21
		public Dictionary<int, int> RoleEnergyMap { get; } = new Dictionary<int, int>();

		// Token: 0x17008EF6 RID: 36598
		// (get) Token: 0x0603DDBA RID: 253370 RVA: 0x00EF3929 File Offset: 0x00EF1B29
		public Dictionary<int, int> WeaponEnergyMap { get; } = new Dictionary<int, int>();

		// Token: 0x17008EF7 RID: 36599
		// (get) Token: 0x0603DDBB RID: 253371 RVA: 0x00EF3931 File Offset: 0x00EF1B31
		public Dictionary<int, int> PhantomEnergyMap { get; } = new Dictionary<int, int>();

		// Token: 0x17008EF8 RID: 36600
		// (get) Token: 0x0603DDBC RID: 253372 RVA: 0x00EF3939 File Offset: 0x00EF1B39
		public Dictionary<int, int> SkillBranchMap { get; } = new Dictionary<int, int>();

		// Token: 0x0603DDBD RID: 253373 RVA: 0x00EF3944 File Offset: 0x00EF1B44
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

		// Token: 0x0603DDBE RID: 253374 RVA: 0x00EF3970 File Offset: 0x00EF1B70
		public bool IsRoleEnergyEnough(int roleId)
		{
			return this.GetRoleEnergy(roleId) > 0;
		}

		// Token: 0x0603DDBF RID: 253375 RVA: 0x00EF397C File Offset: 0x00EF1B7C
		public bool GetWeaponCanUse(int weaponIncId, int roleId)
		{
			int num;
			return !this.WeaponEnergyMap.TryGetValue(weaponIncId, out num) || roleId == num;
		}

		// Token: 0x0603DDC0 RID: 253376 RVA: 0x00EF39A0 File Offset: 0x00EF1BA0
		public int GetWeaponOccupyRoleId(int weaponIncId, int roleId)
		{
			int num;
			if (!this.WeaponEnergyMap.TryGetValue(weaponIncId, out num) || roleId == num)
			{
				return -1;
			}
			return num;
		}

		// Token: 0x0603DDC1 RID: 253377 RVA: 0x00EF39C4 File Offset: 0x00EF1BC4
		public bool GetPhantomCanUse(int phantomIncId, int roleId)
		{
			int num;
			return !this.PhantomEnergyMap.TryGetValue(phantomIncId, out num) || roleId == num;
		}

		// Token: 0x0603DDC2 RID: 253378 RVA: 0x00EF39E8 File Offset: 0x00EF1BE8
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
