using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D13 RID: 23827
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffItemPool
	{
		// Token: 0x0603C64D RID: 247373 RVA: 0x00E79CA4 File Offset: 0x00E77EA4
		public void Clear()
		{
			foreach (BuffItem buffItem in this.CommonBuffItemList)
			{
				buffItem.DestroyCompatible();
			}
			this.CommonBuffItemList.Clear();
			foreach (QuickHackBuffItem quickHackBuffItem in this.QuickHackBuffItemList)
			{
				quickHackBuffItem.DestroyCompatible();
			}
			this.QuickHackBuffItemList.Clear();
		}

		// Token: 0x0603C64E RID: 247374 RVA: 0x00E79D4C File Offset: 0x00E77F4C
		public BuffItemBase GetBuffItem(USceneComponent parentItem, GameplayCue? cueConfig)
		{
			if (cueConfig != null && cueConfig.Value.CueType == 37)
			{
				BuffItemBase buffItemBase = this.NewCustomStyleBuffItem(parentItem, cueConfig.Value);
				if (buffItemBase != null)
				{
					return buffItemBase;
				}
			}
			return this.NewCommonBuffItem(parentItem);
		}

		// Token: 0x0603C64F RID: 247375 RVA: 0x00E79D90 File Offset: 0x00E77F90
		public void RecycleBuffItem(BuffItemBase buffItem)
		{
			BuffItem buffItem2 = buffItem as BuffItem;
			if (buffItem2 != null)
			{
				this.CommonBuffItemList.Add(buffItem2);
				return;
			}
			QuickHackBuffItem quickHackBuffItem = buffItem as QuickHackBuffItem;
			if (quickHackBuffItem != null)
			{
				this.QuickHackBuffItemList.Add(quickHackBuffItem);
			}
		}

		// Token: 0x0603C650 RID: 247376 RVA: 0x00E79DCC File Offset: 0x00E77FCC
		private BuffItem NewCommonBuffItem(USceneComponent parentItem)
		{
			if (this.CommonBuffItemList.Count > 0)
			{
				BuffItem result = this.CommonBuffItemList[this.CommonBuffItemList.Count - 1];
				this.CommonBuffItemList.RemoveAt(this.CommonBuffItemList.Count - 1);
				return result;
			}
			return new BuffItem(parentItem);
		}

		// Token: 0x0603C651 RID: 247377 RVA: 0x00E79E1E File Offset: 0x00E7801E
		[return: Nullable(2)]
		private BuffItemBase NewCustomStyleBuffItem(USceneComponent parentItem, GameplayCue cueConfig)
		{
			if (cueConfig.ParametersLength > 0 && int.Parse(cueConfig.Parameters(0)) == 0)
			{
				return this.NewQuickHackBuffItem(parentItem);
			}
			return null;
		}

		// Token: 0x0603C652 RID: 247378 RVA: 0x00E79E44 File Offset: 0x00E78044
		private QuickHackBuffItem NewQuickHackBuffItem(USceneComponent parentItem)
		{
			if (this.QuickHackBuffItemList.Count > 0)
			{
				QuickHackBuffItem result = this.QuickHackBuffItemList[this.QuickHackBuffItemList.Count - 1];
				this.QuickHackBuffItemList.RemoveAt(this.QuickHackBuffItemList.Count - 1);
				return result;
			}
			return new QuickHackBuffItem(parentItem);
		}

		// Token: 0x0401F780 RID: 128896
		private readonly List<BuffItem> CommonBuffItemList = new List<BuffItem>();

		// Token: 0x0401F781 RID: 128897
		private readonly List<QuickHackBuffItem> QuickHackBuffItemList = new List<QuickHackBuffItem>();
	}
}
