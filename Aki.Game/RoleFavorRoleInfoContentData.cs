using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DC0 RID: 7616
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorRoleInfoContentData : RoleFavorContentDataBase
{
	// Token: 0x06012E22 RID: 77346 RVA: 0x00589FC0 File Offset: 0x005881C0
	public RoleFavorRoleInfoContentData(int roleId, EFavorExperienceSubType favorExperienceSubType, FavorRoleInfo configData) : base(roleId)
	{
		this.FavorExperienceSubType = favorExperienceSubType;
		this.ConfigData = configData;
	}

	// Token: 0x17001CAD RID: 7341
	// (get) Token: 0x06012E23 RID: 77347 RVA: 0x00589FDE File Offset: 0x005881DE
	public override int ConfigId
	{
		get
		{
			return this.ConfigData.Id;
		}
	}

	// Token: 0x17001CAE RID: 7342
	// (get) Token: 0x06012E24 RID: 77348 RVA: 0x00589FEB File Offset: 0x005881EB
	public override int ConfigConGroupId
	{
		get
		{
			return this.ConfigData.CondGroupId;
		}
	}

	// Token: 0x17001CAF RID: 7343
	// (get) Token: 0x06012E25 RID: 77349 RVA: 0x00589FF8 File Offset: 0x005881F8
	public override string TitleTextId
	{
		get
		{
			return "";
		}
	}

	// Token: 0x17001CB0 RID: 7344
	// (get) Token: 0x06012E26 RID: 77350 RVA: 0x00589FFF File Offset: 0x005881FF
	public override string ContentTextId
	{
		get
		{
			return "";
		}
	}

	// Token: 0x06012E27 RID: 77351 RVA: 0x0058A006 File Offset: 0x00588206
	protected override EFavorContentType GetFavorContentType()
	{
		return EFavorContentType.ExperienceFile;
	}

	// Token: 0x0400A2B1 RID: 41649
	public FavorRoleInfo ConfigData;

	// Token: 0x0400A2B2 RID: 41650
	public EFavorExperienceSubType FavorExperienceSubType = EFavorExperienceSubType.RoleBaseInfo;
}
