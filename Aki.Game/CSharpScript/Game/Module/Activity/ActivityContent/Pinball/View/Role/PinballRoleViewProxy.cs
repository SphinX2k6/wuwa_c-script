using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006319 RID: 25369
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleViewProxy : IPinballRoleAttributeTabViewProxy, IPinballRoleWeaponTabViewProxy
	{
		// Token: 0x0603FD3A RID: 261434 RVA: 0x00F7110C File Offset: 0x00F6F30C
		public void SetActivityData(PinballActivityData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x0603FD3B RID: 261435 RVA: 0x00F71118 File Offset: 0x00F6F318
		[NullableContext(2)]
		public void BuildRoleDataList(List<int> formationRoleIds)
		{
			this.RoleDataList = new List<PinballRoleDataBase>();
			if (this.ActivityData == null)
			{
				return;
			}
			int id = this.ActivityData.Id;
			foreach (PinballRoleConfig pinballRoleConfig in PinballConfig.Instance.GetPinballRoleConfigListByActivityId(id))
			{
				if (!pinballRoleConfig.IsTrail)
				{
					PinballRoleData roleData = this.ActivityData.GetRoleData(pinballRoleConfig.Id);
					if (roleData != null)
					{
						this.RoleDataList.Add(roleData);
					}
					else
					{
						PinballLockedRoleData pinballLockedRoleData = new PinballLockedRoleData(pinballRoleConfig.Id);
						pinballLockedRoleData.SetLevel(1);
						this.RoleDataList.Add(pinballLockedRoleData);
					}
				}
			}
			this.RoleDataList.Sort(delegate(PinballRoleDataBase a, PinballRoleDataBase b)
			{
				if (formationRoleIds != null && formationRoleIds.Count > 0)
				{
					int num = formationRoleIds.IndexOf(a.GetId());
					int num2 = formationRoleIds.IndexOf(b.GetId());
					bool flag = num >= 0;
					bool flag2 = num2 >= 0;
					if (flag != flag2)
					{
						if (!flag)
						{
							return 1;
						}
						return -1;
					}
					else if (flag && flag2)
					{
						return num - num2;
					}
				}
				bool flag3 = a.IsLocked();
				bool flag4 = b.IsLocked();
				if (flag3 != flag4)
				{
					if (!flag3)
					{
						return -1;
					}
					return 1;
				}
				else
				{
					int level = a.GetLevel();
					int level2 = b.GetLevel();
					if (level != level2)
					{
						return level2 - level;
					}
					return a.GetId() - b.GetId();
				}
			});
		}

		// Token: 0x0603FD3C RID: 261436 RVA: 0x00F711FC File Offset: 0x00F6F3FC
		public void SetRoleSelectedDataByIndex(int index)
		{
			if (this.SelectedRoleIndex == index || index < 0 || index >= this.RoleDataList.Count)
			{
				return;
			}
			this.SelectedRoleIndex = index;
			this.SelectedRoleId = this.RoleDataList[index].GetId();
		}

		// Token: 0x0603FD3D RID: 261437 RVA: 0x00F71238 File Offset: 0x00F6F438
		public void SetSelectedRoleDataById(int roleId)
		{
			if (this.SelectedRoleId == roleId)
			{
				return;
			}
			this.SelectedRoleId = roleId;
			this.SelectedRoleIndex = this.RoleDataList.FindIndex((PinballRoleDataBase data) => data.GetId() == roleId);
		}

		// Token: 0x0603FD3E RID: 261438 RVA: 0x00F7128A File Offset: 0x00F6F48A
		public int GetSelectedRoleId()
		{
			return this.SelectedRoleId;
		}

		// Token: 0x0603FD3F RID: 261439 RVA: 0x00F71292 File Offset: 0x00F6F492
		public int GetSelectedRoleIndex()
		{
			return this.SelectedRoleIndex;
		}

		// Token: 0x0603FD40 RID: 261440 RVA: 0x00F7129A File Offset: 0x00F6F49A
		public List<PinballRoleDataBase> GetRoleDataList()
		{
			return this.RoleDataList;
		}

		// Token: 0x0603FD41 RID: 261441 RVA: 0x00F712A2 File Offset: 0x00F6F4A2
		public PinballActivityData GetActivityData()
		{
			return this.ActivityData;
		}

		// Token: 0x0603FD42 RID: 261442 RVA: 0x00F712AA File Offset: 0x00F6F4AA
		public PinballRoleDataBase GetRoleData()
		{
			return this.RoleDataList[this.SelectedRoleIndex];
		}

		// Token: 0x040214E1 RID: 136417
		[Nullable(2)]
		private PinballActivityData ActivityData;

		// Token: 0x040214E2 RID: 136418
		private int SelectedRoleId;

		// Token: 0x040214E3 RID: 136419
		private int SelectedRoleIndex;

		// Token: 0x040214E4 RID: 136420
		private List<PinballRoleDataBase> RoleDataList;
	}
}
