using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040FB RID: 16635
	[RequiredMember]
	public class CollectBadgeGroupData
	{
		// Token: 0x0602A059 RID: 172121 RVA: 0x00BE162E File Offset: 0x00BDF82E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CollectBadgeGroupData()
		{
		}

		// Token: 0x04016ECE RID: 93902
		[RequiredMember]
		public int GroupId;

		// Token: 0x04016ECF RID: 93903
		[Nullable(1)]
		[RequiredMember]
		public List<int> BadgeIdList;
	}
}
