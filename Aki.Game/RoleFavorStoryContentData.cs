using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002846 RID: 10310
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorStoryContentData : RoleFavorContentDataBase
{
	// Token: 0x0601542A RID: 87082 RVA: 0x0055F2AD File Offset: 0x0055D4AD
	public RoleFavorStoryContentData(int roleId, FavorStory configData) : base(roleId)
	{
		this.ConfigData = configData;
	}

	// Token: 0x17001C59 RID: 7257
	// (get) Token: 0x0601542B RID: 87083 RVA: 0x0055F2C4 File Offset: 0x0055D4C4
	public override int ConfigId
	{
		get
		{
			return this.ConfigData.Id;
		}
	}

	// Token: 0x17001C5A RID: 7258
	// (get) Token: 0x0601542C RID: 87084 RVA: 0x0055F2D1 File Offset: 0x0055D4D1
	public override int ConfigConGroupId
	{
		get
		{
			return this.ConfigData.CondGroupId;
		}
	}

	// Token: 0x17001C5B RID: 7259
	// (get) Token: 0x0601542D RID: 87085 RVA: 0x0055F2DE File Offset: 0x0055D4DE
	public override string TitleTextId
	{
		get
		{
			return this.ConfigData.Title;
		}
	}

	// Token: 0x17001C5C RID: 7260
	// (get) Token: 0x0601542E RID: 87086 RVA: 0x0055F2EB File Offset: 0x0055D4EB
	public override string ContentTextId
	{
		get
		{
			return this.ConfigData.Content;
		}
	}

	// Token: 0x0601542F RID: 87087 RVA: 0x0055F2F8 File Offset: 0x0055D4F8
	protected override EFavorContentType GetFavorContentType()
	{
		return EFavorContentType.ExperienceStory;
	}

	// Token: 0x04009ECA RID: 40650
	public FavorStory ConfigData;

	// Token: 0x04009ECB RID: 40651
	public EFavorExperienceSubType FavorExperienceSubType = EFavorExperienceSubType.RoleStory;
}
