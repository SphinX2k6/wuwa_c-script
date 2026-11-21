using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200550D RID: 21773
	public class DockyardQuicklySellData
	{
		// Token: 0x06035FAF RID: 221103 RVA: 0x00F140C4 File Offset: 0x00F122C4
		public DockyardQuicklySellData(int shapeId)
		{
			FishingGridItemShape fishingShapeConfig = FishingConfig.Instance.GetFishingShapeConfig(shapeId);
			for (int i = 0; i < fishingShapeConfig.FillStateLength; i++)
			{
				this.PosDataDoublyList.Add(new List<int>());
				foreach (int item in fishingShapeConfig.FillState(i).Value.GetArrayIntArray())
				{
					this.PosDataDoublyList[i].Add(item);
				}
			}
		}

		// Token: 0x0401C85D RID: 116829
		[Nullable(1)]
		public readonly List<List<int>> PosDataDoublyList = new List<List<int>>();
	}
}
