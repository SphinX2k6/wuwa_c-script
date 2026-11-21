using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DBA RID: 7610
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorExperienceClassifyData : RoleFavorClassifyDataBase
{
	// Token: 0x06012DFC RID: 77308 RVA: 0x00589B9E File Offset: 0x00587D9E
	public RoleFavorExperienceClassifyData(string titleTableId, int roleId, EFavorExperienceType experienceType) : base(titleTableId, roleId)
	{
		this.ExperienceType = experienceType;
	}

	// Token: 0x06012DFD RID: 77309 RVA: 0x00589BB6 File Offset: 0x00587DB6
	protected override EFavorTabType GetFavorTabType()
	{
		return EFavorTabType.Experience;
	}

	// Token: 0x06012DFE RID: 77310 RVA: 0x00589BB9 File Offset: 0x00587DB9
	protected override void InitContentDataList()
	{
		if (this.ExperienceType == EFavorExperienceType.File)
		{
			this.InitRoleInfoContentData();
			return;
		}
		this.InitRoleStoryContentData();
	}

	// Token: 0x06012DFF RID: 77311 RVA: 0x00589BD1 File Offset: 0x00587DD1
	private void InitRoleInfoContentData()
	{
		this.ContentDataList.Clear();
		this.ContentDataList.Add(this.CreateRoleInfoContentData(EFavorExperienceSubType.RoleBaseInfo));
		this.ContentDataList.Add(this.CreateRoleInfoContentData(EFavorExperienceSubType.RolePowerFile));
	}

	// Token: 0x06012E00 RID: 77312 RVA: 0x00589C04 File Offset: 0x00587E04
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

	// Token: 0x06012E01 RID: 77313 RVA: 0x00589C60 File Offset: 0x00587E60
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

	// Token: 0x06012E02 RID: 77314 RVA: 0x00589CA2 File Offset: 0x00587EA2
	private RoleFavorStoryContentData CreateRoleStoryContentData(FavorStory config)
	{
		return new RoleFavorStoryContentData(this.RoleId, config);
	}

	// Token: 0x0400A2A9 RID: 41641
	private readonly EFavorExperienceType ExperienceType = EFavorExperienceType.File;
}
