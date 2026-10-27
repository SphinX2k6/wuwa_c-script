using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C31 RID: 7217
	public class IMoveJigsawItem_SetValue
	{
		// Token: 0x04005E20 RID: 24096
		public ESetJigsawItemType Type;

		// Token: 0x04005E21 RID: 24097
		public int ItemEntityId;

		// Token: 0x04005E22 RID: 24098
		public int FoundationEntityId;

		// Token: 0x04005E23 RID: 24099
		[Nullable(1)]
		public IPieceIndex Destination;
	}
}
