using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DC2 RID: 7618
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorActionContentData : RoleFavorContentDataBase
{
	// Token: 0x06012E2E RID: 77358 RVA: 0x0058A057 File Offset: 0x00588257
	public RoleFavorActionContentData(int roleId, EFavorActionType favorActionParamType, Motion configData) : base(roleId)
	{
		this.FavorActionParamType = favorActionParamType;
		this.ConfigData = configData;
	}

	// Token: 0x17001CB5 RID: 7349
	// (get) Token: 0x06012E2F RID: 77359 RVA: 0x0058A075 File Offset: 0x00588275
	public override int ConfigId
	{
		get
		{
			return this.ConfigData.Id;
		}
	}

	// Token: 0x17001CB6 RID: 7350
	// (get) Token: 0x06012E30 RID: 77360 RVA: 0x0058A082 File Offset: 0x00588282
	public override int ConfigConGroupId
	{
		get
		{
			return this.ConfigData.CondGroupId;
		}
	}

	// Token: 0x17001CB7 RID: 7351
	// (get) Token: 0x06012E31 RID: 77361 RVA: 0x0058A08F File Offset: 0x0058828F
	public override string TitleTextId
	{
		get
		{
			return this.ConfigData.Title;
		}
	}

	// Token: 0x17001CB8 RID: 7352
	// (get) Token: 0x06012E32 RID: 77362 RVA: 0x0058A09C File Offset: 0x0058829C
	public override string ContentTextId
	{
		get
		{
			return this.ConfigData.Content;
		}
	}

	// Token: 0x06012E33 RID: 77363 RVA: 0x0058A0A9 File Offset: 0x005882A9
	protected override EFavorContentType GetFavorContentType()
	{
		return EFavorContentType.Action;
	}

	// Token: 0x0400A2B5 RID: 41653
	public EFavorActionType FavorActionParamType = EFavorActionType.IdleAction;

	// Token: 0x0400A2B6 RID: 41654
	public Motion ConfigData;
}
