using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B41 RID: 19265
	[RequiredMember]
	public class MediumItemGridComposeTag
	{
		// Token: 0x060302D6 RID: 197334 RVA: 0x00D6F29B File Offset: 0x00D6D49B
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MediumItemGridComposeTag()
		{
		}

		// Token: 0x040198C0 RID: 104640
		[RequiredMember]
		public bool IsRefreshItem;

		// Token: 0x040198C1 RID: 104641
		[RequiredMember]
		public bool IsLimitTimeItem;

		// Token: 0x040198C2 RID: 104642
		[RequiredMember]
		public EMediumItemGridBuffType BuffItem;
	}
}
