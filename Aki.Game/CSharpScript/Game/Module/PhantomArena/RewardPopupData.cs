using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040FA RID: 16634
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class RewardPopupData
	{
		// Token: 0x0602A058 RID: 172120 RVA: 0x00BE1626 File Offset: 0x00BDF826
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RewardPopupData()
		{
		}

		// Token: 0x04016ECB RID: 93899
		[RequiredMember]
		public List<RewardTuple> RewardLists;

		// Token: 0x04016ECC RID: 93900
		[RequiredMember]
		public UUIItem MountItem;

		// Token: 0x04016ECD RID: 93901
		public FVector? PosBias;
	}
}
