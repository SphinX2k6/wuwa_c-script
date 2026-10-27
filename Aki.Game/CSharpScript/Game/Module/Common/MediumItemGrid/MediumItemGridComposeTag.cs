using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B62 RID: 23394
	[RequiredMember]
	public class MediumItemGridComposeTag
	{
		// Token: 0x0603B38A RID: 242570 RVA: 0x00E1ED2F File Offset: 0x00E1CF2F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MediumItemGridComposeTag()
		{
		}

		// Token: 0x0401EE11 RID: 126481
		[RequiredMember]
		public bool IsRefreshItem;

		// Token: 0x0401EE12 RID: 126482
		[RequiredMember]
		public bool IsLimitTimeItem;

		// Token: 0x0401EE13 RID: 126483
		[RequiredMember]
		public EMediumItemGridBuffType BuffItem;
	}
}
