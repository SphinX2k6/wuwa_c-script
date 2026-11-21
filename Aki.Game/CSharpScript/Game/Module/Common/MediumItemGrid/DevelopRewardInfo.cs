using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B46 RID: 19270
	[RequiredMember]
	public class DevelopRewardInfo
	{
		// Token: 0x060302DA RID: 197338 RVA: 0x00D6F2BB File Offset: 0x00D6D4BB
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DevelopRewardInfo()
		{
		}

		// Token: 0x040198CF RID: 104655
		public bool? IsUnlock;

		// Token: 0x040198D0 RID: 104656
		[RequiredMember]
		public int DevelopRewardLevel;

		// Token: 0x040198D1 RID: 104657
		[RequiredMember]
		public int UnlockLevel;
	}
}
