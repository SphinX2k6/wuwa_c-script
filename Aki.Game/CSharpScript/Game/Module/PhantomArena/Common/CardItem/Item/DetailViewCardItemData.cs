using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020051DA RID: 20954
	[RequiredMember]
	public class DetailViewCardItemData : CardInfoBase
	{
		// Token: 0x06035A07 RID: 219655 RVA: 0x00CB4781 File Offset: 0x00CB2981
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DetailViewCardItemData()
		{
		}

		// Token: 0x0401C75E RID: 116574
		[RequiredMember]
		public bool IsLock;
	}
}
