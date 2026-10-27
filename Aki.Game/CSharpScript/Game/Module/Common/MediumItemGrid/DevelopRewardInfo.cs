using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B67 RID: 23399
	[RequiredMember]
	public class DevelopRewardInfo
	{
		// Token: 0x0603B38E RID: 242574 RVA: 0x00E1ED4F File Offset: 0x00E1CF4F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DevelopRewardInfo()
		{
		}

		// Token: 0x0401EE20 RID: 126496
		public bool? IsUnlock;

		// Token: 0x0401EE21 RID: 126497
		[RequiredMember]
		public int DevelopRewardLevel;

		// Token: 0x0401EE22 RID: 126498
		[RequiredMember]
		public int UnlockLevel;
	}
}
