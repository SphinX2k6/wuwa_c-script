using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02004D5B RID: 19803
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopData
	{
		// Token: 0x060332B7 RID: 209591 RVA: 0x00BEF830 File Offset: 0x00BEDA30
		public RoleDevelopData(int id)
		{
			this.Id = id;
		}

		// Token: 0x060332B8 RID: 209592 RVA: 0x00BEF83F File Offset: 0x00BEDA3F
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x060332B9 RID: 209593 RVA: 0x00BEF848 File Offset: 0x00BEDA48
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

		// Token: 0x060332BA RID: 209594 RVA: 0x00BEF8B0 File Offset: 0x00BEDAB0
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

		// Token: 0x060332BB RID: 209595 RVA: 0x00BEF920 File Offset: 0x00BEDB20
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

		// Token: 0x0401B307 RID: 111367
		private int Id;

		// Token: 0x0401B308 RID: 111368
		[Nullable(2)]
		private RoleDevelopRoleBaseData DevelopRoleData;

		// Token: 0x0401B309 RID: 111369
		[Nullable(2)]
		private RoleDevelopProjectBaseData DevelopProjectData;
	}
}
