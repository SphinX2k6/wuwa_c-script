using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F21 RID: 32545
	public enum TLiveDanmakuOperation : byte
	{
		// Token: 0x0401386A RID: 79978
		NONE,
		// Token: 0x0401386B RID: 79979
		ILiveLoadDanmakuConfig,
		// Token: 0x0401386C RID: 79980
		ILiveStartInteractDanmakuConfig,
		// Token: 0x0401386D RID: 79981
		ILiveStopInteractDanmakuConfig,
		// Token: 0x0401386E RID: 79982
		ILiveUnloadDanmakuConfig
	}
}
