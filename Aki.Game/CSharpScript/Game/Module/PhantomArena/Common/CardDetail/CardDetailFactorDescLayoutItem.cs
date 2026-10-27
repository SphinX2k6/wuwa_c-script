using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x0200520F RID: 21007
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailFactorDescLayoutItem : UiPanelBase
	{
		// Token: 0x06035BA0 RID: 220064 RVA: 0x00CB862E File Offset: 0x00CB682E
		public CardDetailFactorDescLayoutItem(UUILayoutBase layout, UUIItem templateItem = null)
		{
			this.FactorDescLayout = new GenericLayout<CardDetailFactorDescItem, CardDetailFactorDescItemData>(layout, new Func<CardDetailFactorDescItem>(this.CreateCardFactorDescItem), ((templateItem != null) ? templateItem.GetOwner() : null) as AUIBaseActor, false, true);
		}

		// Token: 0x06035BA1 RID: 220065 RVA: 0x00CB8661 File Offset: 0x00CB6861
		public void Refresh(List<CardDetailFactorDescItemData> factorDataList)
		{
			this.FactorDescLayout.RefreshByData(factorDataList, null, false);
		}

		// Token: 0x06035BA2 RID: 220066 RVA: 0x00CB8671 File Offset: 0x00CB6871
		public void SetLayoutActive(bool active)
		{
			UUIItem rootUiItem = this.FactorDescLayout.GetRootUiItem();
			if (rootUiItem == null)
			{
				return;
			}
			rootUiItem.SetUIActive(active);
		}

		// Token: 0x06035BA3 RID: 220067 RVA: 0x00CB8689 File Offset: 0x00CB6889
		private CardDetailFactorDescItem CreateCardFactorDescItem()
		{
			return new CardDetailFactorDescItem();
		}

		// Token: 0x06035BA4 RID: 220068 RVA: 0x00CB8690 File Offset: 0x00CB6890
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length <= 1)
			{
				return null;
			}
			int displayIndex = int.Parse(configParams[1]);
			GenericLayout<CardDetailFactorDescItem, CardDetailFactorDescItemData> factorDescLayout = this.FactorDescLayout;
			UUIItem uuiitem = (factorDescLayout != null) ? factorDescLayout.GetGridByDisplayIndex(displayIndex) : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0401C7B7 RID: 116663
		private readonly GenericLayout<CardDetailFactorDescItem, CardDetailFactorDescItemData> FactorDescLayout;
	}
}
