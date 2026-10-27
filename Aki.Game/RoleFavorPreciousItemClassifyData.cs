using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002842 RID: 10306
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorPreciousItemClassifyData : RoleFavorClassifyDataBase
{
	// Token: 0x0601540D RID: 87053 RVA: 0x0055F0D8 File Offset: 0x0055D2D8
	public RoleFavorPreciousItemClassifyData(string titleTableId, int roleId) : base(titleTableId, roleId)
	{
	}

	// Token: 0x0601540E RID: 87054 RVA: 0x0055F0E2 File Offset: 0x0055D2E2
	protected override EFavorTabType GetFavorTabType()
	{
		return EFavorTabType.PreciousItem;
	}

	// Token: 0x0601540F RID: 87055 RVA: 0x0055F0E8 File Offset: 0x0055D2E8
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

	// Token: 0x06015410 RID: 87056 RVA: 0x0055F142 File Offset: 0x0055D342
	private RoleFavorPreciousItemContentData CreatePreciousItemContentData(FavorGoods config)
	{
		return new RoleFavorPreciousItemContentData(this.RoleId, config);
	}
}
