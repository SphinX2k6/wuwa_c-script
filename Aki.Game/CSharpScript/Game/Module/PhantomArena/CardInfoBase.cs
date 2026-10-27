using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200511F RID: 20767
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class CardInfoBase : CardFilterInfo
	{
		// Token: 0x06035154 RID: 217428 RVA: 0x00C941BA File Offset: 0x00C923BA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardInfoBase()
		{
		}

		// Token: 0x0401C476 RID: 115830
		[RequiredMember]
		public int Attack;

		// Token: 0x0401C477 RID: 115831
		[RequiredMember]
		public int Life;

		// Token: 0x0401C478 RID: 115832
		[RequiredMember]
		public bool OutlookUnlocked;

		// Token: 0x0401C479 RID: 115833
		[RequiredMember]
		public ECardFaceType CardFaceType;

		// Token: 0x0401C47A RID: 115834
		public string CardFaceTexturePath;

		// Token: 0x0401C47B RID: 115835
		public CardSpineData CardSpineData;

		// Token: 0x0401C47C RID: 115836
		[RequiredMember]
		public ECardType CardType;
	}
}
