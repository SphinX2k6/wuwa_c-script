using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070EB RID: 28907
	public enum ILiveDanmakuOperation_Union : byte
	{
		// Token: 0x040120B4 RID: 73908
		NONE,
		// Token: 0x040120B5 RID: 73909
		ILiveDanmakuOperation,
		// Token: 0x040120B6 RID: 73910
		ILiveLoadDanmakuConfig,
		// Token: 0x040120B7 RID: 73911
		ILiveUnloadDanmakuConfig,
		// Token: 0x040120B8 RID: 73912
		ILiveStartInteractDanmakuConfig,
		// Token: 0x040120B9 RID: 73913
		ILiveStopInteractDanmakuConfig
	}
}
