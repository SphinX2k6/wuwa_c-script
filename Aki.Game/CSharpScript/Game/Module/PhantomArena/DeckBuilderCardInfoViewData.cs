using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200513B RID: 20795
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class DeckBuilderCardInfoViewData
	{
		// Token: 0x06035170 RID: 217456 RVA: 0x00C942AC File Offset: 0x00C924AC
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DeckBuilderCardInfoViewData()
		{
		}

		// Token: 0x0401C4CF RID: 115919
		[RequiredMember]
		public int CurCardId;

		// Token: 0x0401C4D0 RID: 115920
		[RequiredMember]
		public bool NeedOutlookTab;

		// Token: 0x0401C4D1 RID: 115921
		public int? CurCardIndex;

		// Token: 0x0401C4D2 RID: 115922
		public int? CurrencyId;

		// Token: 0x0401C4D3 RID: 115923
		public int? SelectedTabIndex;

		// Token: 0x0401C4D4 RID: 115924
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public DeckBuilderCardItemData[] CardList;

		// Token: 0x0401C4D5 RID: 115925
		public DeckInfo DeckInfo;

		// Token: 0x0401C4D6 RID: 115926
		public Action<int, int> AddCardToDeck;

		// Token: 0x0401C4D7 RID: 115927
		public Action<int, int> RemoveCardFromDeck;
	}
}
