using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010DC RID: 4316
	[NullableContext(2)]
	[Nullable(0)]
	public class IHandInItems_SetValue
	{
		// Token: 0x0400393A RID: 14650
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IHandInItem> Items;

		// Token: 0x0400393B RID: 14651
		public IHandInGroup GroupConfig;

		// Token: 0x0400393C RID: 14652
		public string TidTitleText;

		// Token: 0x0400393D RID: 14653
		[Nullable(0)]
		public string TidDescText;

		// Token: 0x0400393E RID: 14654
		public bool RepeatItems;

		// Token: 0x0400393F RID: 14655
		public string EdTidTitleText;

		// Token: 0x04003940 RID: 14656
		public string EdTidDescText;
	}
}
