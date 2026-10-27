using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200512B RID: 20779
	[RequiredMember]
	public class CollectBadgeGroupData
	{
		// Token: 0x06035160 RID: 217440 RVA: 0x00C9421A File Offset: 0x00C9241A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CollectBadgeGroupData()
		{
		}

		// Token: 0x0401C499 RID: 115865
		[RequiredMember]
		public int GroupId;

		// Token: 0x0401C49A RID: 115866
		[Nullable(1)]
		[RequiredMember]
		public List<int> BadgeIdList;
	}
}
