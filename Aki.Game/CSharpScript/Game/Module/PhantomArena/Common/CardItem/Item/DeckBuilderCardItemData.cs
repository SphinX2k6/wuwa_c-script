using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020051D8 RID: 20952
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class DeckBuilderCardItemData : CardInfoBase
	{
		// Token: 0x060359F7 RID: 219639 RVA: 0x00CB4320 File Offset: 0x00CB2520
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DeckBuilderCardItemData()
		{
		}

		// Token: 0x0401C753 RID: 116563
		[RequiredMember]
		public DeckInfo DeckInfo;

		// Token: 0x0401C754 RID: 116564
		[RequiredMember]
		public bool Disabled;

		// Token: 0x0401C755 RID: 116565
		[RequiredMember]
		public bool IsAllInDeck;

		// Token: 0x0401C756 RID: 116566
		[RequiredMember]
		public int LeftCount;

		// Token: 0x0401C757 RID: 116567
		[RequiredMember]
		public int MaxCount;

		// Token: 0x0401C758 RID: 116568
		[RequiredMember]
		public Action<int, int> AddCardToDeck;

		// Token: 0x0401C759 RID: 116569
		[RequiredMember]
		public Action<int> OpenCardInfoView;
	}
}
