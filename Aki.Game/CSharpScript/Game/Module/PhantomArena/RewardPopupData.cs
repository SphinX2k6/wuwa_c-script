using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200512A RID: 20778
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class RewardPopupData
	{
		// Token: 0x0603515F RID: 217439 RVA: 0x00C94212 File Offset: 0x00C92412
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RewardPopupData()
		{
		}

		// Token: 0x0401C496 RID: 115862
		[RequiredMember]
		public List<RewardTuple> RewardLists;

		// Token: 0x0401C497 RID: 115863
		[RequiredMember]
		public UUIItem MountItem;

		// Token: 0x0401C498 RID: 115864
		public FVector? PosBias;
	}
}
