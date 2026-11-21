using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061F0 RID: 25072
	public class IWuWaGoSpikeTrapT
	{
		// Token: 0x1700BAFB RID: 47867
		// (get) Token: 0x0602AA87 RID: 174727 RVA: 0x005D11F8 File Offset: 0x005CF3F8
		// (set) Token: 0x0602AA88 RID: 174728 RVA: 0x005D1200 File Offset: 0x005CF400
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700BAFC RID: 47868
		// (get) Token: 0x0602AA89 RID: 174729 RVA: 0x005D1209 File Offset: 0x005CF409
		// (set) Token: 0x0602AA8A RID: 174730 RVA: 0x005D1211 File Offset: 0x005CF411
		public IWuWaGoGridLinkDataT LinkData { get; set; }

		// Token: 0x0602AA8B RID: 174731 RVA: 0x005D121A File Offset: 0x005CF41A
		public IWuWaGoSpikeTrapT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LinkData = new IWuWaGoGridLinkDataT();
		}
	}
}
