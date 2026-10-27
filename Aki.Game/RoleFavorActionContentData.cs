using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002847 RID: 10311
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorActionContentData : RoleFavorContentDataBase
{
	// Token: 0x06015430 RID: 87088 RVA: 0x0055F2FB File Offset: 0x0055D4FB
	public RoleFavorActionContentData(int roleId, EFavorActionType favorActionParamType, Motion configData) : base(roleId)
	{
		this.FavorActionParamType = favorActionParamType;
		this.ConfigData = configData;
	}

	// Token: 0x17001C5D RID: 7261
	// (get) Token: 0x06015431 RID: 87089 RVA: 0x0055F319 File Offset: 0x0055D519
	public override int ConfigId
	{
		get
		{
			return this.ConfigData.Id;
		}
	}

	// Token: 0x17001C5E RID: 7262
	// (get) Token: 0x06015432 RID: 87090 RVA: 0x0055F326 File Offset: 0x0055D526
	public override int ConfigConGroupId
	{
		get
		{
			return this.ConfigData.CondGroupId;
		}
	}

	// Token: 0x17001C5F RID: 7263
	// (get) Token: 0x06015433 RID: 87091 RVA: 0x0055F333 File Offset: 0x0055D533
	public override string TitleTextId
	{
		get
		{
			return this.ConfigData.Title;
		}
	}

	// Token: 0x17001C60 RID: 7264
	// (get) Token: 0x06015434 RID: 87092 RVA: 0x0055F340 File Offset: 0x0055D540
	public override string ContentTextId
	{
		get
		{
			return this.ConfigData.Content;
		}
	}

	// Token: 0x06015435 RID: 87093 RVA: 0x0055F34D File Offset: 0x0055D54D
	protected override EFavorContentType GetFavorContentType()
	{
		return EFavorContentType.Action;
	}

	// Token: 0x04009ECC RID: 40652
	public EFavorActionType FavorActionParamType = EFavorActionType.IdleAction;

	// Token: 0x04009ECD RID: 40653
	public Motion ConfigData;
}
