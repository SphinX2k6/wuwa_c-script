using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007143 RID: 28995
	public class ILiveUiHideConfigT
	{
		// Token: 0x1700D43F RID: 54335
		// (get) Token: 0x060325FA RID: 206330 RVA: 0x006CF64A File Offset: 0x006CD84A
		// (set) Token: 0x060325FB RID: 206331 RVA: 0x006CF652 File Offset: 0x006CD852
		public ELiveUiType Type { get; set; }

		// Token: 0x060325FC RID: 206332 RVA: 0x006CF65B File Offset: 0x006CD85B
		public ILiveUiHideConfigT()
		{
			this.Type = ELiveUiType.Start;
		}
	}
}
