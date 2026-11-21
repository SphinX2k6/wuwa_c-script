using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02003D24 RID: 15652
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopData
	{
		// Token: 0x06028121 RID: 164129 RVA: 0x00B38964 File Offset: 0x00B36B64
		public RoleDevelopData(int id)
		{
			this.Id = id;
		}

		// Token: 0x06028122 RID: 164130 RVA: 0x00B38973 File Offset: 0x00B36B73
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x06028123 RID: 164131 RVA: 0x00B3897C File Offset: 0x00B36B7C
		public RoleDevelopRoleBaseData GetDevelopRoleData()
		{
			bool flag = RoleDevelopUtil.IsProspectRole(this.Id);
			ERoleDevelopRoleType eroleDevelopRoleType = flag ? ERoleDevelopRoleType.Prospect : ERoleDevelopRoleType.Normal;
			if (this.DevelopRoleData != null && this.DevelopRoleData.GetRoleType() == eroleDevelopRoleType)
			{
				return this.DevelopRoleData;
			}
			this.DevelopRoleData = (flag ? new RoleDevelopRoleProspectData(this.Id) : new RoleDevelopRoleData(this.Id));
			return this.DevelopRoleData;
		}

		// Token: 0x06028124 RID: 164132 RVA: 0x00B389E4 File Offset: 0x00B36BE4
		public RoleDevelopProjectBaseData GetProjectData()
		{
			bool flag = RoleDevelopUtil.IsProspectRole(this.Id);
			ERoleDevelopRoleType eroleDevelopRoleType = flag ? ERoleDevelopRoleType.Prospect : ERoleDevelopRoleType.Normal;
			if (this.DevelopProjectData != null && this.DevelopProjectData.GetRoleType() == eroleDevelopRoleType)
			{
				return this.DevelopProjectData;
			}
			RoleDevelopRoleBaseData developRoleData = this.GetDevelopRoleData();
			this.DevelopProjectData = (flag ? new RoleDevelopProjectProspectData(this.Id, developRoleData) : new RoleDevelopProjectData(this.Id, developRoleData));
			return this.DevelopProjectData;
		}

		// Token: 0x06028125 RID: 164133 RVA: 0x00B38A54 File Offset: 0x00B36C54
		public ERoleDevelopHotRoleTag GetHotRoleTag()
		{
			if (!RoleDevelopUtil.IsHotRoleDevelopValid(this.Id))
			{
				return ERoleDevelopHotRoleTag.None;
			}
			int typeId = RoleDevConfig.Instance.GetRoleDevProsListConfig(this.Id).TypeId;
			if (typeId == 1 && RoleDevelopUtil.IsRoleInProspectTime(this.Id))
			{
				return ERoleDevelopHotRoleTag.Forecast;
			}
			if (typeId == 2 && RoleDevelopUtil.IsRoleInProspectTime(this.Id))
			{
				return ERoleDevelopHotRoleTag.Rerun;
			}
			if (typeId == 3 && RoleDevelopUtil.IsRoleInProspectTime(this.Id))
			{
				return ERoleDevelopHotRoleTag.Rerun;
			}
			if (RoleDevelopUtil.GetHotRoleGachaId(this.Id, true) != null)
			{
				return ERoleDevelopHotRoleTag.Summon;
			}
			return ERoleDevelopHotRoleTag.None;
		}

		// Token: 0x04015CD8 RID: 89304
		private int Id;

		// Token: 0x04015CD9 RID: 89305
		[Nullable(2)]
		private RoleDevelopRoleBaseData DevelopRoleData;

		// Token: 0x04015CDA RID: 89306
		[Nullable(2)]
		private RoleDevelopProjectBaseData DevelopProjectData;
	}
}
