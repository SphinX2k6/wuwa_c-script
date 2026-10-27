using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000324 RID: 804
	public class IEntityMatch_SetValue
	{
		// Token: 0x04000D72 RID: 3442
		public bool? AllCharacter;

		// Token: 0x04000D73 RID: 3443
		public bool? OnlyPlayer;

		// Token: 0x04000D74 RID: 3444
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IEntityCategory> Categories;

		// Token: 0x04000D75 RID: 3445
		[Nullable(2)]
		public List<int> EntityIds;

		// Token: 0x04000D76 RID: 3446
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IEntityState> States;

		// Token: 0x04000D77 RID: 3447
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> PerformanceStates;
	}
}
