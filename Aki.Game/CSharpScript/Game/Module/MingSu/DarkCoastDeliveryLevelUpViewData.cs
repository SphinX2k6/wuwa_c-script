using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020043AF RID: 17327
	[NullableContext(1)]
	[Nullable(0)]
	public class DarkCoastDeliveryLevelUpViewData
	{
		// Token: 0x0602BC79 RID: 179321 RVA: 0x00C4B35A File Offset: 0x00C4955A
		public DarkCoastDeliveryLevelUpViewData(int preLevel, int curLevel)
		{
			this.PreLevel = preLevel;
			this.CurLevel = curLevel;
		}

		// Token: 0x0602BC7A RID: 179322 RVA: 0x00C4B370 File Offset: 0x00C49570
		public string GetLevelTexture(int level)
		{
			DarkCoastDeliveryData darkCoastDeliveryData = MingSuModel.Instance.GetDragonPoolInstanceById(3) as DarkCoastDeliveryData;
			if (darkCoastDeliveryData == null)
			{
				return string.Empty;
			}
			return darkCoastDeliveryData.GetLevelTexturePath(level);
		}

		// Token: 0x0602BC7B RID: 179323 RVA: 0x00C4B3A0 File Offset: 0x00C495A0
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

		// Token: 0x040179A3 RID: 96675
		public readonly int PreLevel;

		// Token: 0x040179A4 RID: 96676
		public readonly int CurLevel;
	}
}
