using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005357 RID: 21335
	public class IGroupFinishSilenceT
	{
		// Token: 0x17009CBF RID: 40127
		// (get) Token: 0x06022E6C RID: 142956 RVA: 0x004D5917 File Offset: 0x004D3B17
		// (set) Token: 0x06022E6D RID: 142957 RVA: 0x004D591F File Offset: 0x004D3B1F
		public EGroupFinishConfig Type { get; set; }

		// Token: 0x17009CC0 RID: 40128
		// (get) Token: 0x06022E6E RID: 142958 RVA: 0x004D5928 File Offset: 0x004D3B28
		// (set) Token: 0x06022E6F RID: 142959 RVA: 0x004D5930 File Offset: 0x004D3B30
		public IEntityStateT SwitchSpecifiedStatus { get; set; }

		// Token: 0x06022E70 RID: 142960 RVA: 0x004D5939 File Offset: 0x004D3B39
		public IGroupFinishSilenceT()
		{
			this.Type = EGroupFinishConfig.Silence;
			this.SwitchSpecifiedStatus = null;
		}
	}
}
