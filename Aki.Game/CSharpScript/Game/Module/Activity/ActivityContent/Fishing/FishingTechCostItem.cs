using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006628 RID: 26152
	public class FishingTechCostItem : UiPanelBase
	{
		// Token: 0x06041902 RID: 268546 RVA: 0x00FE67C4 File Offset: 0x00FE49C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06041903 RID: 268547 RVA: 0x00FE6830 File Offset: 0x00FE4A30
		public void RefreshCost(int itemId, int costNum, bool setColor = true)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			if (itemConfigData == null)
			{
				return;
			}
			base.SetTextureByPath(itemConfigData.IconSmall, base.GetTexture(2), null, null);
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(itemId, 0);
			string newText;
			if (setColor)
			{
				if (itemCountByConfigId < costNum)
				{
					newText = StringUtils.Format("<color=#c25757>{0}</color>", new string[]
					{
						costNum.ToString()
					});
				}
				else
				{
					newText = StringUtils.Format("<color=#81764c>{0}</color>", new string[]
					{
						costNum.ToString()
					});
				}
			}
			else
			{
				newText = costNum.ToString();
			}
			base.GetText(1).SetText(newText, true);
		}

		// Token: 0x0200C842 RID: 51266
		private class EComponentDefine
		{
			// Token: 0x0403C7EB RID: 247787
			public const int TipsText = 0;

			// Token: 0x0403C7EC RID: 247788
			public const int CostText = 1;

			// Token: 0x0403C7ED RID: 247789
			public const int Texture = 2;
		}
	}
}
