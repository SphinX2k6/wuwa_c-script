using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020041A8 RID: 16808
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class DeckBuilderCardItemData : CardInfoBase
	{
		// Token: 0x0602A8F2 RID: 174322 RVA: 0x00C0195C File Offset: 0x00BFFB5C
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DeckBuilderCardItemData()
		{
		}

		// Token: 0x04017188 RID: 94600
		[RequiredMember]
		public DeckInfo DeckInfo;

		// Token: 0x04017189 RID: 94601
		[RequiredMember]
		public bool Disabled;

		// Token: 0x0401718A RID: 94602
		[RequiredMember]
		public bool IsAllInDeck;

		// Token: 0x0401718B RID: 94603
		[RequiredMember]
		public int LeftCount;

		// Token: 0x0401718C RID: 94604
		[RequiredMember]
		public int MaxCount;

		// Token: 0x0401718D RID: 94605
		[RequiredMember]
		public Action<int, int> AddCardToDeck;

		// Token: 0x0401718E RID: 94606
		[RequiredMember]
		public Action<int> OpenCardInfoView;
	}
}
