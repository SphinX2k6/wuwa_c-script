using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CF5 RID: 19701
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffItemPool
	{
		// Token: 0x060315A6 RID: 202150 RVA: 0x00DCA324 File Offset: 0x00DC8524
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

		// Token: 0x060315A7 RID: 202151 RVA: 0x00DCA3CC File Offset: 0x00DC85CC
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

		// Token: 0x060315A8 RID: 202152 RVA: 0x00DCA410 File Offset: 0x00DC8610
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

		// Token: 0x060315A9 RID: 202153 RVA: 0x00DCA44C File Offset: 0x00DC864C
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

		// Token: 0x060315AA RID: 202154 RVA: 0x00DCA49E File Offset: 0x00DC869E
		[return: Nullable(2)]
		private BuffItemBase NewCustomStyleBuffItem(USceneComponent parentItem, GameplayCue cueConfig)
		{
			if (cueConfig.ParametersLength > 0 && int.Parse(cueConfig.Parameters(0)) == 0)
			{
				return this.NewQuickHackBuffItem(parentItem);
			}
			return null;
		}

		// Token: 0x060315AB RID: 202155 RVA: 0x00DCA4C4 File Offset: 0x00DC86C4
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

		// Token: 0x0401A239 RID: 107065
		private readonly List<BuffItem> CommonBuffItemList = new List<BuffItem>();

		// Token: 0x0401A23A RID: 107066
		private readonly List<QuickHackBuffItem> QuickHackBuffItemList = new List<QuickHackBuffItem>();
	}
}
