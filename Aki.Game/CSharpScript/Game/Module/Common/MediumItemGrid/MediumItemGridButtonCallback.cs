using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B65 RID: 23397
	[RequiredMember]
	public class MediumItemGridButtonCallback
	{
		// Token: 0x0603B38C RID: 242572 RVA: 0x00E1ED3F File Offset: 0x00E1CF3F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MediumItemGridButtonCallback()
		{
		}

		// Token: 0x0401EE1C RID: 126492
		[Nullable(1)]
		[RequiredMember]
		public MediumItemGrid MediumItemGrid;

		// Token: 0x0401EE1D RID: 126493
		[Nullable(2)]
		public object Data;
	}
}
