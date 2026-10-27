using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002845 RID: 10309
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorRoleInfoContentData : RoleFavorContentDataBase
{
	// Token: 0x06015424 RID: 87076 RVA: 0x0055F264 File Offset: 0x0055D464
	public RoleFavorRoleInfoContentData(int roleId, EFavorExperienceSubType favorExperienceSubType, FavorRoleInfo configData) : base(roleId)
	{
		this.FavorExperienceSubType = favorExperienceSubType;
		this.ConfigData = configData;
	}

	// Token: 0x17001C55 RID: 7253
	// (get) Token: 0x06015425 RID: 87077 RVA: 0x0055F282 File Offset: 0x0055D482
	public override int ConfigId
	{
		get
		{
			return this.ConfigData.Id;
		}
	}

	// Token: 0x17001C56 RID: 7254
	// (get) Token: 0x06015426 RID: 87078 RVA: 0x0055F28F File Offset: 0x0055D48F
	public override int ConfigConGroupId
	{
		get
		{
			return this.ConfigData.CondGroupId;
		}
	}

	// Token: 0x17001C57 RID: 7255
	// (get) Token: 0x06015427 RID: 87079 RVA: 0x0055F29C File Offset: 0x0055D49C
	public override string TitleTextId
	{
		get
		{
			return "";
		}
	}

	// Token: 0x17001C58 RID: 7256
	// (get) Token: 0x06015428 RID: 87080 RVA: 0x0055F2A3 File Offset: 0x0055D4A3
	public override string ContentTextId
	{
		get
		{
			return "";
		}
	}

	// Token: 0x06015429 RID: 87081 RVA: 0x0055F2AA File Offset: 0x0055D4AA
	protected override EFavorContentType GetFavorContentType()
	{
		return EFavorContentType.ExperienceFile;
	}

	// Token: 0x04009EC8 RID: 40648
	public FavorRoleInfo ConfigData;

	// Token: 0x04009EC9 RID: 40649
	public EFavorExperienceSubType FavorExperienceSubType = EFavorExperienceSubType.RoleBaseInfo;
}
