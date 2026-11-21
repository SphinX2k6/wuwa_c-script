using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007152 RID: 29010
	public class ILiveUnloadDanmakuConfigT
	{
		// Token: 0x1700D44F RID: 54351
		// (get) Token: 0x06032656 RID: 206422 RVA: 0x006CFE04 File Offset: 0x006CE004
		// (set) Token: 0x06032657 RID: 206423 RVA: 0x006CFE0C File Offset: 0x006CE00C
		public ELiveDanmakuOperationType Type { get; set; }

		// Token: 0x1700D450 RID: 54352
		// (get) Token: 0x06032658 RID: 206424 RVA: 0x006CFE15 File Offset: 0x006CE015
		// (set) Token: 0x06032659 RID: 206425 RVA: 0x006CFE1D File Offset: 0x006CE01D
		public ELiveDanmakuClearType ClearType { get; set; }

		// Token: 0x0603265A RID: 206426 RVA: 0x006CFE26 File Offset: 0x006CE026
		public ILiveUnloadDanmakuConfigT()
		{
			this.Type = ELiveDanmakuOperationType.Load;
			this.ClearType = ELiveDanmakuClearType.FinishCurrent;
		}
	}
}
