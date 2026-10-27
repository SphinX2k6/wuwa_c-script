using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200512D RID: 20781
	[RequiredMember]
	public class BadgeGroupCollectCountData
	{
		// Token: 0x06035162 RID: 217442 RVA: 0x00C9422A File Offset: 0x00C9242A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BadgeGroupCollectCountData()
		{
		}

		// Token: 0x0401C49D RID: 115869
		[RequiredMember]
		public int Now;

		// Token: 0x0401C49E RID: 115870
		[RequiredMember]
		public int Need;

		// Token: 0x0401C49F RID: 115871
		[RequiredMember]
		public int All;
	}
}
