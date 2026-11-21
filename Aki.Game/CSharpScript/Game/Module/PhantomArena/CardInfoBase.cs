using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040EF RID: 16623
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class CardInfoBase : CardFilterInfo
	{
		// Token: 0x0602A04D RID: 172109 RVA: 0x00BE15CE File Offset: 0x00BDF7CE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardInfoBase()
		{
		}

		// Token: 0x04016EAB RID: 93867
		[RequiredMember]
		public int Attack;

		// Token: 0x04016EAC RID: 93868
		[RequiredMember]
		public int Life;

		// Token: 0x04016EAD RID: 93869
		[RequiredMember]
		public bool OutlookUnlocked;

		// Token: 0x04016EAE RID: 93870
		[RequiredMember]
		public ECardFaceType CardFaceType;

		// Token: 0x04016EAF RID: 93871
		public string CardFaceTexturePath;

		// Token: 0x04016EB0 RID: 93872
		public CardSpineData CardSpineData;

		// Token: 0x04016EB1 RID: 93873
		[RequiredMember]
		public ECardType CardType;
	}
}
