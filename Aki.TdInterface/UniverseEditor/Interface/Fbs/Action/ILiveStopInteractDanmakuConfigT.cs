using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007137 RID: 28983
	public class ILiveStopInteractDanmakuConfigT
	{
		// Token: 0x1700D431 RID: 54321
		// (get) Token: 0x060325A8 RID: 206248 RVA: 0x006CEEE8 File Offset: 0x006CD0E8
		// (set) Token: 0x060325A9 RID: 206249 RVA: 0x006CEEF0 File Offset: 0x006CD0F0
		public ELiveDanmakuOperationType Type { get; set; }

		// Token: 0x1700D432 RID: 54322
		// (get) Token: 0x060325AA RID: 206250 RVA: 0x006CEEF9 File Offset: 0x006CD0F9
		// (set) Token: 0x060325AB RID: 206251 RVA: 0x006CEF01 File Offset: 0x006CD101
		public ELiveDanmakuClearType ClearType { get; set; }

		// Token: 0x060325AC RID: 206252 RVA: 0x006CEF0A File Offset: 0x006CD10A
		public ILiveStopInteractDanmakuConfigT()
		{
			this.Type = ELiveDanmakuOperationType.Load;
			this.ClearType = ELiveDanmakuClearType.FinishCurrent;
		}
	}
}
