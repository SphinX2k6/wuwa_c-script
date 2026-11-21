using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200410B RID: 16651
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class DeckBuilderCardInfoViewData
	{
		// Token: 0x0602A069 RID: 172137 RVA: 0x00BE16C0 File Offset: 0x00BDF8C0
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DeckBuilderCardInfoViewData()
		{
		}

		// Token: 0x04016F04 RID: 93956
		[RequiredMember]
		public int CurCardId;

		// Token: 0x04016F05 RID: 93957
		[RequiredMember]
		public bool NeedOutlookTab;

		// Token: 0x04016F06 RID: 93958
		public int? CurCardIndex;

		// Token: 0x04016F07 RID: 93959
		public int? CurrencyId;

		// Token: 0x04016F08 RID: 93960
		public int? SelectedTabIndex;

		// Token: 0x04016F09 RID: 93961
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public DeckBuilderCardItemData[] CardList;

		// Token: 0x04016F0A RID: 93962
		public DeckInfo DeckInfo;

		// Token: 0x04016F0B RID: 93963
		public Action<int, int> AddCardToDeck;

		// Token: 0x04016F0C RID: 93964
		public Action<int, int> RemoveCardFromDeck;
	}
}
