using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002848 RID: 10312
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorPreciousItemContentData : RoleFavorContentDataBase
{
	// Token: 0x06015436 RID: 87094 RVA: 0x0055F350 File Offset: 0x0055D550
	public RoleFavorPreciousItemContentData(int roleId, FavorGoods configData) : base(roleId)
	{
		this.ConfigData = configData;
	}

	// Token: 0x17001C61 RID: 7265
	// (get) Token: 0x06015437 RID: 87095 RVA: 0x0055F360 File Offset: 0x0055D560
	public override int ConfigId
	{
		get
		{
			return this.ConfigData.Id;
		}
	}

	// Token: 0x17001C62 RID: 7266
	// (get) Token: 0x06015438 RID: 87096 RVA: 0x0055F36D File Offset: 0x0055D56D
	public override int ConfigConGroupId
	{
		get
		{
			return this.ConfigData.CondGroupId;
		}
	}

	// Token: 0x17001C63 RID: 7267
	// (get) Token: 0x06015439 RID: 87097 RVA: 0x0055F37A File Offset: 0x0055D57A
	public override string TitleTextId
	{
		get
		{
			return this.ConfigData.Title;
		}
	}

	// Token: 0x17001C64 RID: 7268
	// (get) Token: 0x0601543A RID: 87098 RVA: 0x0055F387 File Offset: 0x0055D587
	public override string ContentTextId
	{
		get
		{
			return this.ConfigData.Content;
		}
	}

	// Token: 0x0601543B RID: 87099 RVA: 0x0055F394 File Offset: 0x0055D594
	protected override EFavorContentType GetFavorContentType()
	{
		return EFavorContentType.PreciousItem;
	}

	// Token: 0x04009ECE RID: 40654
	public FavorGoods ConfigData;
}
