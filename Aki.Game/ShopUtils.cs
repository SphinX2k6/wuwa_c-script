using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F6E RID: 8046
public class ShopUtils
{
	// Token: 0x06013E61 RID: 81505 RVA: 0x005CCCF0 File Offset: 0x005CAEF0
	public static int GetResource(int id)
	{
		if (id == 1)
		{
			int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.Experience);
			if (numberPropById == null)
			{
				return 0;
			}
			return numberPropById.Value;
		}
		else if (id == 2)
		{
			int? numberPropById2 = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.MoneyGold);
			if (numberPropById2 == null)
			{
				return 0;
			}
			return numberPropById2.Value;
		}
		else
		{
			if (id != 3)
			{
				return InventoryModel.Instance.GetItemCountByConfigId(id, 0);
			}
			int? numberPropById3 = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.MoneyDiamond);
			if (numberPropById3 == null)
			{
				return 0;
			}
			return numberPropById3.Value;
		}
	}

	// Token: 0x06013E62 RID: 81506 RVA: 0x005CCD74 File Offset: 0x005CAF74
	[NullableContext(1)]
	public static string FormatTime(int seconds)
	{
		int num = seconds / 86400;
		int num2 = seconds % 86400 / 3600;
		int num3 = seconds % 3600 / 60;
		int num4 = seconds % 60;
		if (num > 0)
		{
			return StringUtils.Format(TextConfig.Instance.GetTextById("ShopTimeStr1"), new string[]
			{
				num.ToString(),
				num2.ToString()
			});
		}
		if (num2 > 0)
		{
			return StringUtils.Format(TextConfig.Instance.GetTextById("ShopTimeStr2"), new string[]
			{
				num2.ToString(),
				num3.ToString()
			});
		}
		if (num3 > 0)
		{
			return StringUtils.Format(TextConfig.Instance.GetTextById("ShopTimeStr3"), new string[]
			{
				num3.ToString()
			});
		}
		return StringUtils.Format(TextConfig.Instance.GetTextById("ShopTimeStr4"), new string[]
		{
			num4.ToString()
		});
	}

	// Token: 0x0400A997 RID: 43415
	private const int EXP_ID = 1;

	// Token: 0x0400A998 RID: 43416
	private const int GOLD_ID = 2;

	// Token: 0x0400A999 RID: 43417
	private const int DIAMOND_ID = 3;
}
