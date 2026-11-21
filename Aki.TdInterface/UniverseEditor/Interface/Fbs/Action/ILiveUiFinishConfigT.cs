using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007140 RID: 28992
	public class ILiveUiFinishConfigT
	{
		// Token: 0x1700D43B RID: 54331
		// (get) Token: 0x060325E6 RID: 206310 RVA: 0x006CF4AC File Offset: 0x006CD6AC
		// (set) Token: 0x060325E7 RID: 206311 RVA: 0x006CF4B4 File Offset: 0x006CD6B4
		public ELiveUiType Type { get; set; }

		// Token: 0x1700D43C RID: 54332
		// (get) Token: 0x060325E8 RID: 206312 RVA: 0x006CF4BD File Offset: 0x006CD6BD
		// (set) Token: 0x060325E9 RID: 206313 RVA: 0x006CF4C5 File Offset: 0x006CD6C5
		public int SettlementId { get; set; }

		// Token: 0x060325EA RID: 206314 RVA: 0x006CF4CE File Offset: 0x006CD6CE
		public ILiveUiFinishConfigT()
		{
			this.Type = ELiveUiType.Start;
			this.SettlementId = 0;
		}
	}
}
