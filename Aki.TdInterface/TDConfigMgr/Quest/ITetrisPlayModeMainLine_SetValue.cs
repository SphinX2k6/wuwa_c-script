using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001197 RID: 4503
	public class ITetrisPlayModeMainLine_SetValue
	{
		// Token: 0x04003D5B RID: 15707
		public ETetrisPlayMode Type;

		// Token: 0x04003D5C RID: 15708
		public int EntityId;

		// Token: 0x04003D5D RID: 15709
		[Nullable(1)]
		public string EntityState;

		// Token: 0x04003D5E RID: 15710
		public int? FieldHeight;
	}
}
