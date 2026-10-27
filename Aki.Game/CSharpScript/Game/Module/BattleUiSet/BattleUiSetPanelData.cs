using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUiSet
{
	// Token: 0x02005E62 RID: 24162
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiSetPanelData
	{
		// Token: 0x0603D6D1 RID: 251601 RVA: 0x00ED0FD8 File Offset: 0x00ECF1D8
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

		// Token: 0x0603D6D2 RID: 251602 RVA: 0x00ED106C File Offset: 0x00ECF26C
		[NullableContext(2)]
		public BattleUiSetPanelItemData GetPanelItemData(int index)
		{
			return this.ItemDataMap.GetValueOrDefault(index);
		}

		// Token: 0x0603D6D3 RID: 251603 RVA: 0x00ED107A File Offset: 0x00ECF27A
		public IReadOnlyDictionary<int, BattleUiSetPanelItemData> GetPanelItemDataMap()
		{
			return this.ItemDataMap;
		}

		// Token: 0x040200DA RID: 131290
		public readonly int PanelIndex;

		// Token: 0x040200DB RID: 131291
		private readonly Dictionary<int, BattleUiSetPanelItemData> ItemDataMap = new Dictionary<int, BattleUiSetPanelItemData>();

		// Token: 0x040200DC RID: 131292
		public readonly bool IsOnlyPanelEdit;
	}
}
