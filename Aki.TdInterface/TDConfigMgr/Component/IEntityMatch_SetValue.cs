using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200036B RID: 875
	public class IEntityMatch_SetValue
	{
		// Token: 0x04000E5D RID: 3677
		public bool? AllCharacter;

		// Token: 0x04000E5E RID: 3678
		public bool? OnlyPlayer;

		// Token: 0x04000E5F RID: 3679
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IEntityCategory> Categories;

		// Token: 0x04000E60 RID: 3680
		[Nullable(2)]
		public List<int> EntityIds;

		// Token: 0x04000E61 RID: 3681
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IEntityState> States;

		// Token: 0x04000E62 RID: 3682
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> PerformanceStates;
	}
}
