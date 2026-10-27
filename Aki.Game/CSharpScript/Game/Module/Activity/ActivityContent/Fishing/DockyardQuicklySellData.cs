using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200658F RID: 25999
	public class DockyardQuicklySellData
	{
		// Token: 0x060412EA RID: 266986 RVA: 0x00FCD0B0 File Offset: 0x00FCB2B0
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

		// Token: 0x04021F2C RID: 139052
		[Nullable(1)]
		public readonly List<List<int>> PosDataDoublyList = new List<List<int>>();
	}
}
