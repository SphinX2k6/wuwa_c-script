using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DBD RID: 7613
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorPreciousItemClassifyData : RoleFavorClassifyDataBase
{
	// Token: 0x06012E0B RID: 77323 RVA: 0x00589E34 File Offset: 0x00588034
	public RoleFavorPreciousItemClassifyData(string titleTableId, int roleId) : base(titleTableId, roleId)
	{
	}

	// Token: 0x06012E0C RID: 77324 RVA: 0x00589E3E File Offset: 0x0058803E
	protected override EFavorTabType GetFavorTabType()
	{
		return EFavorTabType.PreciousItem;
	}

	// Token: 0x06012E0D RID: 77325 RVA: 0x00589E44 File Offset: 0x00588044
	protected override void InitContentDataList()
	{
		this.ContentDataList.Clear();
		IReadOnlyList<FavorGoods> favorGoodsConfig = RoleFavorConfig.Instance.GetFavorGoodsConfig(this.RoleId);
		if (favorGoodsConfig == null)
		{
			return;
		}
		int count = favorGoodsConfig.Count;
		for (int i = 0; i < count; i++)
		{
			FavorGoods config = favorGoodsConfig[i];
			this.ContentDataList.Add(this.CreatePreciousItemContentData(config));
		}
	}

	// Token: 0x06012E0E RID: 77326 RVA: 0x00589E9E File Offset: 0x0058809E
	private RoleFavorPreciousItemContentData CreatePreciousItemContentData(FavorGoods config)
	{
		return new RoleFavorPreciousItemContentData(this.RoleId, config);
	}
}
