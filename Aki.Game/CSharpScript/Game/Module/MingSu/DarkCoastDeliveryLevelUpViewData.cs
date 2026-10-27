using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020053CC RID: 21452
	[NullableContext(1)]
	[Nullable(0)]
	public class DarkCoastDeliveryLevelUpViewData
	{
		// Token: 0x06036D33 RID: 224563 RVA: 0x00CFC2B2 File Offset: 0x00CFA4B2
		public DarkCoastDeliveryLevelUpViewData(int preLevel, int curLevel)
		{
			this.PreLevel = preLevel;
			this.CurLevel = curLevel;
		}

		// Token: 0x06036D34 RID: 224564 RVA: 0x00CFC2C8 File Offset: 0x00CFA4C8
		public string GetLevelTexture(int level)
		{
			DarkCoastDeliveryData darkCoastDeliveryData = MingSuModel.Instance.GetDragonPoolInstanceById(3) as DarkCoastDeliveryData;
			if (darkCoastDeliveryData == null)
			{
				return string.Empty;
			}
			return darkCoastDeliveryData.GetLevelTexturePath(level);
		}

		// Token: 0x06036D35 RID: 224565 RVA: 0x00CFC2F8 File Offset: 0x00CFA4F8
		public List<DarkCoastDeliveryLevelData> GetLevelDataList()
		{
			DarkCoastDeliveryData darkCoastDeliveryData = MingSuModel.Instance.GetDragonPoolInstanceById(3) as DarkCoastDeliveryData;
			if (darkCoastDeliveryData == null)
			{
				return new List<DarkCoastDeliveryLevelData>();
			}
			List<DarkCoastDeliveryLevelData> list = new List<DarkCoastDeliveryLevelData>();
			for (int i = this.PreLevel + 1; i <= this.CurLevel; i++)
			{
				DarkCoastDeliveryLevelData levelData = darkCoastDeliveryData.GetLevelData(i);
				if (levelData != null)
				{
					list.Add(levelData);
				}
			}
			return list;
		}

		// Token: 0x0401CF0B RID: 118539
		public readonly int PreLevel;

		// Token: 0x0401CF0C RID: 118540
		public readonly int CurLevel;
	}
}
