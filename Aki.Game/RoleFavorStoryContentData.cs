using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DC1 RID: 7617
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorStoryContentData : RoleFavorContentDataBase
{
	// Token: 0x06012E28 RID: 77352 RVA: 0x0058A009 File Offset: 0x00588209
	public RoleFavorStoryContentData(int roleId, FavorStory configData) : base(roleId)
	{
		this.ConfigData = configData;
	}

	// Token: 0x17001CB1 RID: 7345
	// (get) Token: 0x06012E29 RID: 77353 RVA: 0x0058A020 File Offset: 0x00588220
	public override int ConfigId
	{
		get
		{
			return this.ConfigData.Id;
		}
	}

	// Token: 0x17001CB2 RID: 7346
	// (get) Token: 0x06012E2A RID: 77354 RVA: 0x0058A02D File Offset: 0x0058822D
	public override int ConfigConGroupId
	{
		get
		{
			return this.ConfigData.CondGroupId;
		}
	}

	// Token: 0x17001CB3 RID: 7347
	// (get) Token: 0x06012E2B RID: 77355 RVA: 0x0058A03A File Offset: 0x0058823A
	public override string TitleTextId
	{
		get
		{
			return this.ConfigData.Title;
		}
	}

	// Token: 0x17001CB4 RID: 7348
	// (get) Token: 0x06012E2C RID: 77356 RVA: 0x0058A047 File Offset: 0x00588247
	public override string ContentTextId
	{
		get
		{
			return this.ConfigData.Content;
		}
	}

	// Token: 0x06012E2D RID: 77357 RVA: 0x0058A054 File Offset: 0x00588254
	protected override EFavorContentType GetFavorContentType()
	{
		return EFavorContentType.ExperienceStory;
	}

	// Token: 0x0400A2B3 RID: 41651
	public FavorStory ConfigData;

	// Token: 0x0400A2B4 RID: 41652
	public EFavorExperienceSubType FavorExperienceSubType = EFavorExperienceSubType.RoleStory;
}
