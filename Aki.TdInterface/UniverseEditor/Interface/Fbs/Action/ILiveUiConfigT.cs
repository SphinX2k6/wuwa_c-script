using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200713A RID: 28986
	public class ILiveUiConfigT
	{
		// Token: 0x1700D435 RID: 54325
		// (get) Token: 0x060325BC RID: 206268 RVA: 0x006CF086 File Offset: 0x006CD286
		// (set) Token: 0x060325BD RID: 206269 RVA: 0x006CF08E File Offset: 0x006CD28E
		public ELiveUiType Type { get; set; }

		// Token: 0x060325BE RID: 206270 RVA: 0x006CF097 File Offset: 0x006CD297
		public ILiveUiConfigT()
		{
			this.Type = ELiveUiType.Start;
		}
	}
}
