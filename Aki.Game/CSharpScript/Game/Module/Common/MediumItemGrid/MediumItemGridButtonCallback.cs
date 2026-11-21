using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B44 RID: 19268
	[RequiredMember]
	public class MediumItemGridButtonCallback
	{
		// Token: 0x060302D8 RID: 197336 RVA: 0x00D6F2AB File Offset: 0x00D6D4AB
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MediumItemGridButtonCallback()
		{
		}

		// Token: 0x040198CB RID: 104651
		[Nullable(1)]
		[RequiredMember]
		public MediumItemGrid MediumItemGrid;

		// Token: 0x040198CC RID: 104652
		[Nullable(2)]
		public object Data;
	}
}
