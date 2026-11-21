using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02005297 RID: 21143
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleViewProxy : IPinballRoleAttributeTabViewProxy, IPinballRoleWeaponTabViewProxy
	{
		// Token: 0x060349FB RID: 215547 RVA: 0x00EB8068 File Offset: 0x00EB6268
		public void SetActivityData(PinballActivityData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x060349FC RID: 215548 RVA: 0x00EB8074 File Offset: 0x00EB6274
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

		// Token: 0x060349FD RID: 215549 RVA: 0x00EB8158 File Offset: 0x00EB6358
		public void SetRoleSelectedDataByIndex(int index)
		{
			if (this.SelectedRoleIndex == index || index < 0 || index >= this.RoleDataList.Count)
			{
				return;
			}
			this.SelectedRoleIndex = index;
			this.SelectedRoleId = this.RoleDataList[index].GetId();
		}

		// Token: 0x060349FE RID: 215550 RVA: 0x00EB8194 File Offset: 0x00EB6394
		public void SetSelectedRoleDataById(int roleId)
		{
			if (this.SelectedRoleId == roleId)
			{
				return;
			}
			this.SelectedRoleId = roleId;
			this.SelectedRoleIndex = this.RoleDataList.FindIndex((PinballRoleDataBase data) => data.GetId() == roleId);
		}

		// Token: 0x060349FF RID: 215551 RVA: 0x00EB81E6 File Offset: 0x00EB63E6
		public int GetSelectedRoleId()
		{
			return this.SelectedRoleId;
		}

		// Token: 0x06034A00 RID: 215552 RVA: 0x00EB81EE File Offset: 0x00EB63EE
		public int GetSelectedRoleIndex()
		{
			return this.SelectedRoleIndex;
		}

		// Token: 0x06034A01 RID: 215553 RVA: 0x00EB81F6 File Offset: 0x00EB63F6
		public List<PinballRoleDataBase> GetRoleDataList()
		{
			return this.RoleDataList;
		}

		// Token: 0x06034A02 RID: 215554 RVA: 0x00EB81FE File Offset: 0x00EB63FE
		public PinballActivityData GetActivityData()
		{
			return this.ActivityData;
		}

		// Token: 0x06034A03 RID: 215555 RVA: 0x00EB8206 File Offset: 0x00EB6406
		public PinballRoleDataBase GetRoleData()
		{
			return this.RoleDataList[this.SelectedRoleIndex];
		}

		// Token: 0x0401BE10 RID: 114192
		[Nullable(2)]
		private PinballActivityData ActivityData;

		// Token: 0x0401BE11 RID: 114193
		private int SelectedRoleId;

		// Token: 0x0401BE12 RID: 114194
		private int SelectedRoleIndex;

		// Token: 0x0401BE13 RID: 114195
		private List<PinballRoleDataBase> RoleDataList;
	}
}
