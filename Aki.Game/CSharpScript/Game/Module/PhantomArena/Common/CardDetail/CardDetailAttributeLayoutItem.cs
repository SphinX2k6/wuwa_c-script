using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041D7 RID: 16855
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailAttributeLayoutItem : UiPanelBase
	{
		// Token: 0x0602AA80 RID: 174720 RVA: 0x00C058D0 File Offset: 0x00C03AD0
		public CardDetailAttributeLayoutItem(UUILayoutBase layout, UUIItem templateItem = null)
		{
			this.AttributeLayout = new GenericLayout<CardDetailAttributeItem, CardDetailAttributeItemData>(layout, new Func<CardDetailAttributeItem>(this.CreateCardDetailAttributeItem), ((templateItem != null) ? templateItem.GetOwner() : null) as AUIBaseActor, false, true);
		}

		// Token: 0x0602AA81 RID: 174721 RVA: 0x00C05903 File Offset: 0x00C03B03
		public void Refresh(List<CardDetailAttributeItemData> dataList)
		{
			this.AttributeLayout.RefreshByData(dataList, null, false);
		}

		// Token: 0x0602AA82 RID: 174722 RVA: 0x00C05913 File Offset: 0x00C03B13
		public void SetLayoutActive(bool active)
		{
			UUIItem rootUiItem = this.AttributeLayout.GetRootUiItem();
			if (rootUiItem == null)
			{
				return;
			}
			rootUiItem.SetUIActive(active);
		}

		// Token: 0x0602AA83 RID: 174723 RVA: 0x00C0592B File Offset: 0x00C03B2B
		private CardDetailAttributeItem CreateCardDetailAttributeItem()
		{
			return new CardDetailAttributeItem();
		}

		// Token: 0x040171E5 RID: 94693
		private readonly GenericLayout<CardDetailAttributeItem, CardDetailAttributeItemData> AttributeLayout;
	}
}
