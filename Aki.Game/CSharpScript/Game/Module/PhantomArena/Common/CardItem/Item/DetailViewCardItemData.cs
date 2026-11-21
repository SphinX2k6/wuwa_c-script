using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020041AA RID: 16810
	[RequiredMember]
	public class DetailViewCardItemData : CardInfoBase
	{
		// Token: 0x0602A902 RID: 174338 RVA: 0x00C01DBD File Offset: 0x00BFFFBD
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DetailViewCardItemData()
		{
		}

		// Token: 0x04017193 RID: 94611
		[RequiredMember]
		public bool IsLock;
	}
}
