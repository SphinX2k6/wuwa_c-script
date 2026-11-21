using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E28 RID: 7720
	public class IMoveJigsawItem_SetValue
	{
		// Token: 0x04006357 RID: 25431
		public ESetJigsawItemType Type;

		// Token: 0x04006358 RID: 25432
		public int ItemEntityId;

		// Token: 0x04006359 RID: 25433
		public int FoundationEntityId;

		// Token: 0x0400635A RID: 25434
		public IPieceIndex Destination;
	}
}
