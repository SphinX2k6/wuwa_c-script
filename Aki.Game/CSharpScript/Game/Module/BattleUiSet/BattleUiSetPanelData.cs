using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUiSet
{
	// Token: 0x02004E47 RID: 20039
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiSetPanelData
	{
		// Token: 0x06032661 RID: 206433 RVA: 0x00E22548 File Offset: 0x00E20748
		public BattleUiSetPanelData(int panelIndex, IReadOnlyList<BattleUiSetPanelItemData> panelItemDataList)
		{
			this.PanelIndex = panelIndex;
			foreach (BattleUiSetPanelItemData battleUiSetPanelItemData in panelItemDataList)
			{
				int panelItemIndex = battleUiSetPanelItemData.PanelItemIndex;
				if (panelItemIndex == -1)
				{
					this.IsOnlyPanelEdit = true;
					this.ItemDataMap.Clear();
					this.ItemDataMap[panelItemIndex] = battleUiSetPanelItemData;
					break;
				}
				this.ItemDataMap[panelItemIndex] = battleUiSetPanelItemData;
			}
		}

		// Token: 0x06032662 RID: 206434 RVA: 0x00E225DC File Offset: 0x00E207DC
		[NullableContext(2)]
		public BattleUiSetPanelItemData GetPanelItemData(int index)
		{
			return this.ItemDataMap.GetValueOrDefault(index);
		}

		// Token: 0x06032663 RID: 206435 RVA: 0x00E225EA File Offset: 0x00E207EA
		public IReadOnlyDictionary<int, BattleUiSetPanelItemData> GetPanelItemDataMap()
		{
			return this.ItemDataMap;
		}

		// Token: 0x0401ABA1 RID: 109473
		public readonly int PanelIndex;

		// Token: 0x0401ABA2 RID: 109474
		private readonly Dictionary<int, BattleUiSetPanelItemData> ItemDataMap = new Dictionary<int, BattleUiSetPanelItemData>();

		// Token: 0x0401ABA3 RID: 109475
		public readonly bool IsOnlyPanelEdit;
	}
}
