using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200283F RID: 10303
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorExperienceClassifyData : RoleFavorClassifyDataBase
{
	// Token: 0x060153FE RID: 87038 RVA: 0x0055EE42 File Offset: 0x0055D042
	public RoleFavorExperienceClassifyData(string titleTableId, int roleId, EFavorExperienceType experienceType) : base(titleTableId, roleId)
	{
		this.ExperienceType = experienceType;
	}

	// Token: 0x060153FF RID: 87039 RVA: 0x0055EE5A File Offset: 0x0055D05A
	protected override EFavorTabType GetFavorTabType()
	{
		return EFavorTabType.Experience;
	}

	// Token: 0x06015400 RID: 87040 RVA: 0x0055EE5D File Offset: 0x0055D05D
	protected override void InitContentDataList()
	{
		if (this.ExperienceType == EFavorExperienceType.File)
		{
			this.InitRoleInfoContentData();
			return;
		}
		this.InitRoleStoryContentData();
	}

	// Token: 0x06015401 RID: 87041 RVA: 0x0055EE75 File Offset: 0x0055D075
	private void InitRoleInfoContentData()
	{
		this.ContentDataList.Clear();
		this.ContentDataList.Add(this.CreateRoleInfoContentData(EFavorExperienceSubType.RoleBaseInfo));
		this.ContentDataList.Add(this.CreateRoleInfoContentData(EFavorExperienceSubType.RolePowerFile));
	}

	// Token: 0x06015402 RID: 87042 RVA: 0x0055EEA8 File Offset: 0x0055D0A8
	private void InitRoleStoryContentData()
	{
		this.ContentDataList.Clear();
		IReadOnlyList<FavorStory> favorStoryConfig = RoleFavorConfig.Instance.GetFavorStoryConfig(this.RoleId);
		if (favorStoryConfig == null)
		{
			return;
		}
		int count = favorStoryConfig.Count;
		for (int i = 0; i < count; i++)
		{
			FavorStory config = favorStoryConfig[i];
			this.ContentDataList.Add(this.CreateRoleStoryContentData(config));
		}
	}

	// Token: 0x06015403 RID: 87043 RVA: 0x0055EF04 File Offset: 0x0055D104
	private RoleFavorRoleInfoContentData CreateRoleInfoContentData(EFavorExperienceSubType favorRoleInfoType)
	{
		int roleId = this.RoleId;
		FavorRoleInfo? favorRoleInfoConfig = RoleFavorConfig.Instance.GetFavorRoleInfoConfig(roleId);
		if (favorRoleInfoConfig == null)
		{
			throw new Exception("GetFavorRoleInfoConfig failed");
		}
		return new RoleFavorRoleInfoContentData(roleId, favorRoleInfoType, favorRoleInfoConfig.Value);
	}

	// Token: 0x06015404 RID: 87044 RVA: 0x0055EF46 File Offset: 0x0055D146
	private RoleFavorStoryContentData CreateRoleStoryContentData(FavorStory config)
	{
		return new RoleFavorStoryContentData(this.RoleId, config);
	}

	// Token: 0x04009EC0 RID: 40640
	private readonly EFavorExperienceType ExperienceType = EFavorExperienceType.File;
}
