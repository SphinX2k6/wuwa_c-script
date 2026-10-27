using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BDA RID: 23514
	public class IWuWaGoSpikeTrapT
	{
		// Token: 0x1700B1B3 RID: 45491
		// (get) Token: 0x060284C3 RID: 165059 RVA: 0x00589768 File Offset: 0x00587968
		// (set) Token: 0x060284C4 RID: 165060 RVA: 0x00589770 File Offset: 0x00587970
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700B1B4 RID: 45492
		// (get) Token: 0x060284C5 RID: 165061 RVA: 0x00589779 File Offset: 0x00587979
		// (set) Token: 0x060284C6 RID: 165062 RVA: 0x00589781 File Offset: 0x00587981
		public IWuWaGoGridLinkDataT LinkData { get; set; }

		// Token: 0x060284C7 RID: 165063 RVA: 0x0058978A File Offset: 0x0058798A
		public IWuWaGoSpikeTrapT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LinkData = new IWuWaGoGridLinkDataT();
		}
	}
}
