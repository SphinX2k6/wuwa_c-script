using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005612 RID: 22034
	public class INoRenderPortalModeT
	{
		// Token: 0x1700A30F RID: 41743
		// (get) Token: 0x06024921 RID: 149793 RVA: 0x0050BD74 File Offset: 0x00509F74
		// (set) Token: 0x06024922 RID: 149794 RVA: 0x0050BD7C File Offset: 0x00509F7C
		public ENoRenderPortalType Type { get; set; }

		// Token: 0x1700A310 RID: 41744
		// (get) Token: 0x06024923 RID: 149795 RVA: 0x0050BD85 File Offset: 0x00509F85
		// (set) Token: 0x06024924 RID: 149796 RVA: 0x0050BD8D File Offset: 0x00509F8D
		public EPortalModel PortalModel { get; set; }

		// Token: 0x06024925 RID: 149797 RVA: 0x0050BD96 File Offset: 0x00509F96
		public INoRenderPortalModeT()
		{
			this.Type = ENoRenderPortalType.Static;
			this.PortalModel = EPortalModel.A;
		}
	}
}
