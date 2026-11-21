using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041DC RID: 16860
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailEntryDescLayoutItem : UiPanelBase
	{
		// Token: 0x0602AA93 RID: 174739 RVA: 0x00C05A6F File Offset: 0x00C03C6F
		public CardDetailEntryDescLayoutItem(UUILayoutBase layout, UUIItem templateItem = null)
		{
			this.EntryDescLayout = new GenericLayout<CardDetailEntryDescItem, int>(layout, new Func<CardDetailEntryDescItem>(this.CreateEntryDescItem), ((templateItem != null) ? templateItem.GetOwner() : null) as AUIBaseActor, false, true);
		}

		// Token: 0x0602AA94 RID: 174740 RVA: 0x00C05AA2 File Offset: 0x00C03CA2
		public void Refresh(IReadOnlyList<int> entryIdList)
		{
			this.EntryDescLayout.RefreshByData(entryIdList, null, false);
		}

		// Token: 0x0602AA95 RID: 174741 RVA: 0x00C05AB4 File Offset: 0x00C03CB4
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

		// Token: 0x0602AA96 RID: 174742 RVA: 0x00C05B31 File Offset: 0x00C03D31
		private CardDetailEntryDescItem CreateEntryDescItem()
		{
			return new CardDetailEntryDescItem();
		}

		// Token: 0x040171E8 RID: 94696
		private readonly GenericLayout<CardDetailEntryDescItem, int> EntryDescLayout;
	}
}
