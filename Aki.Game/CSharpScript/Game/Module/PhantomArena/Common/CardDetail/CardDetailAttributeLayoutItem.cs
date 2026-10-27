using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005207 RID: 20999
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailAttributeLayoutItem : UiPanelBase
	{
		// Token: 0x06035B85 RID: 220037 RVA: 0x00CB8294 File Offset: 0x00CB6494
		public CardDetailAttributeLayoutItem(UUILayoutBase layout, UUIItem templateItem = null)
		{
			this.AttributeLayout = new GenericLayout<CardDetailAttributeItem, CardDetailAttributeItemData>(layout, new Func<CardDetailAttributeItem>(this.CreateCardDetailAttributeItem), ((templateItem != null) ? templateItem.GetOwner() : null) as AUIBaseActor, false, true);
		}

		// Token: 0x06035B86 RID: 220038 RVA: 0x00CB82C7 File Offset: 0x00CB64C7
		public void Refresh(List<CardDetailAttributeItemData> dataList)
		{
			this.AttributeLayout.RefreshByData(dataList, null, false);
		}

		// Token: 0x06035B87 RID: 220039 RVA: 0x00CB82D7 File Offset: 0x00CB64D7
		public void SetLayoutActive(bool active)
		{
			UUIItem rootUiItem = this.AttributeLayout.GetRootUiItem();
			if (rootUiItem == null)
			{
				return;
			}
			rootUiItem.SetUIActive(active);
		}

		// Token: 0x06035B88 RID: 220040 RVA: 0x00CB82EF File Offset: 0x00CB64EF
		private CardDetailAttributeItem CreateCardDetailAttributeItem()
		{
			return new CardDetailAttributeItem();
		}

		// Token: 0x0401C7B0 RID: 116656
		private readonly GenericLayout<CardDetailAttributeItem, CardDetailAttributeItemData> AttributeLayout;
	}
}
