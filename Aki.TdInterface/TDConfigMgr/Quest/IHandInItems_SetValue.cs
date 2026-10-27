using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FB2 RID: 4018
	[NullableContext(2)]
	[Nullable(0)]
	public class IHandInItems_SetValue
	{
		// Token: 0x04003608 RID: 13832
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IHandInItem> Items;

		// Token: 0x04003609 RID: 13833
		public IHandInGroup GroupConfig;

		// Token: 0x0400360A RID: 13834
		public string TidTitleText;

		// Token: 0x0400360B RID: 13835
		[Nullable(1)]
		public string TidDescText;

		// Token: 0x0400360C RID: 13836
		public bool RepeatItems;

		// Token: 0x0400360D RID: 13837
		public string EdTidTitleText;

		// Token: 0x0400360E RID: 13838
		public string EdTidDescText;
	}
}
