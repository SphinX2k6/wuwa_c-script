using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020055A6 RID: 21926
	public class FishingTechCostItem : UiPanelBase
	{
		// Token: 0x060365C7 RID: 222663 RVA: 0x00F2D878 File Offset: 0x00F2BA78
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

		// Token: 0x060365C8 RID: 222664 RVA: 0x00F2D8E4 File Offset: 0x00F2BAE4
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

		// Token: 0x0200B224 RID: 45604
		private class EComponentDefine
		{
			// Token: 0x04037130 RID: 225584
			public const int TipsText = 0;

			// Token: 0x04037131 RID: 225585
			public const int CostText = 1;

			// Token: 0x04037132 RID: 225586
			public const int Texture = 2;
		}
	}
}
