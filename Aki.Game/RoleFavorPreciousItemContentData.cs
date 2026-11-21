using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DC3 RID: 7619
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorPreciousItemContentData : RoleFavorContentDataBase
{
	// Token: 0x06012E34 RID: 77364 RVA: 0x0058A0AC File Offset: 0x005882AC
	public RoleFavorPreciousItemContentData(int roleId, FavorGoods configData) : base(roleId)
	{
		this.ConfigData = configData;
	}

	// Token: 0x17001CB9 RID: 7353
	// (get) Token: 0x06012E35 RID: 77365 RVA: 0x0058A0BC File Offset: 0x005882BC
	public override int ConfigId
	{
		get
		{
			return this.ConfigData.Id;
		}
	}

	// Token: 0x17001CBA RID: 7354
	// (get) Token: 0x06012E36 RID: 77366 RVA: 0x0058A0C9 File Offset: 0x005882C9
	public override int ConfigConGroupId
	{
		get
		{
			return this.ConfigData.CondGroupId;
		}
	}

	// Token: 0x17001CBB RID: 7355
	// (get) Token: 0x06012E37 RID: 77367 RVA: 0x0058A0D6 File Offset: 0x005882D6
	public override string TitleTextId
	{
		get
		{
			return this.ConfigData.Title;
		}
	}

	// Token: 0x17001CBC RID: 7356
	// (get) Token: 0x06012E38 RID: 77368 RVA: 0x0058A0E3 File Offset: 0x005882E3
	public override string ContentTextId
	{
		get
		{
			return this.ConfigData.Content;
		}
	}

	// Token: 0x06012E39 RID: 77369 RVA: 0x0058A0F0 File Offset: 0x005882F0
	protected override EFavorContentType GetFavorContentType()
	{
		return EFavorContentType.PreciousItem;
	}

	// Token: 0x0400A2B7 RID: 41655
	public FavorGoods ConfigData;
}
