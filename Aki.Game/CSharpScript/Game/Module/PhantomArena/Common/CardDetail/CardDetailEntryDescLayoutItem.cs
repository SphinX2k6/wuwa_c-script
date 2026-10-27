using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x0200520C RID: 21004
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailEntryDescLayoutItem : UiPanelBase
	{
		// Token: 0x06035B98 RID: 220056 RVA: 0x00CB8433 File Offset: 0x00CB6633
		public CardDetailEntryDescLayoutItem(UUILayoutBase layout, UUIItem templateItem = null)
		{
			this.EntryDescLayout = new GenericLayout<CardDetailEntryDescItem, int>(layout, new Func<CardDetailEntryDescItem>(this.CreateEntryDescItem), ((templateItem != null) ? templateItem.GetOwner() : null) as AUIBaseActor, false, true);
		}

		// Token: 0x06035B99 RID: 220057 RVA: 0x00CB8466 File Offset: 0x00CB6666
		public void Refresh(List<int> entryIdList)
		{
			this.EntryDescLayout.RefreshByData(entryIdList, null, false);
		}

		// Token: 0x06035B9A RID: 220058 RVA: 0x00CB8478 File Offset: 0x00CB6678
		public unsafe void RefreshByCardConfig(PhantomBattleCard config)
		{
			List<int> list = new List<int>();
			list.AddRange(config.GetEntryIdListBytes());
			Span<int> cardFactorIdBytes = config.GetCardFactorIdBytes();
			for (int i = 0; i < cardFactorIdBytes.Length; i++)
			{
				int factorConfigId = *cardFactorIdBytes[i];
				int entryId = PhantomArenaConfig.Instance.GetPhantomBattleFactorConfig(factorConfigId).EntryId;
				if (entryId > 0 && !list.Contains(entryId))
				{
					list.Add(entryId);
				}
			}
			this.Refresh(list);
		}

		// Token: 0x06035B9B RID: 220059 RVA: 0x00CB84F5 File Offset: 0x00CB66F5
		private CardDetailEntryDescItem CreateEntryDescItem()
		{
			return new CardDetailEntryDescItem();
		}

		// Token: 0x0401C7B3 RID: 116659
		private readonly GenericLayout<CardDetailEntryDescItem, int> EntryDescLayout;
	}
}
