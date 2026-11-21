using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041DF RID: 16863
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailFactorDescLayoutItem : UiPanelBase
	{
		// Token: 0x0602AA9B RID: 174747 RVA: 0x00C05C6F File Offset: 0x00C03E6F
		public CardDetailFactorDescLayoutItem(UUILayoutBase layout, UUIItem templateItem = null)
		{
			this.FactorDescLayout = new GenericLayout<CardDetailFactorDescItem, CardDetailFactorDescItemData>(layout, new Func<CardDetailFactorDescItem>(this.CreateCardFactorDescItem), ((templateItem != null) ? templateItem.GetOwner() : null) as AUIBaseActor, false, true);
		}

		// Token: 0x0602AA9C RID: 174748 RVA: 0x00C05CA2 File Offset: 0x00C03EA2
		public void Refresh(List<CardDetailFactorDescItemData> factorDataList)
		{
			this.FactorDescLayout.RefreshByData(factorDataList, null, false);
		}

		// Token: 0x0602AA9D RID: 174749 RVA: 0x00C05CB2 File Offset: 0x00C03EB2
		public void SetLayoutActive(bool active)
		{
			UUIItem rootUiItem = this.FactorDescLayout.GetRootUiItem();
			if (rootUiItem == null)
			{
				return;
			}
			rootUiItem.SetUIActive(active);
		}

		// Token: 0x0602AA9E RID: 174750 RVA: 0x00C05CCA File Offset: 0x00C03ECA
		private CardDetailFactorDescItem CreateCardFactorDescItem()
		{
			return new CardDetailFactorDescItem();
		}

		// Token: 0x0602AA9F RID: 174751 RVA: 0x00C05CD4 File Offset: 0x00C03ED4
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

		// Token: 0x040171EC RID: 94700
		private readonly GenericLayout<CardDetailFactorDescItem, CardDetailFactorDescItemData> FactorDescLayout;
	}
}
