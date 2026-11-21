using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061B8 RID: 25016
	public class IWuWaGoEndGridT
	{
		// Token: 0x1700BA8F RID: 47759
		// (get) Token: 0x0602A877 RID: 174199 RVA: 0x005CCF1C File Offset: 0x005CB11C
		// (set) Token: 0x0602A878 RID: 174200 RVA: 0x005CCF24 File Offset: 0x005CB124
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700BA90 RID: 47760
		// (get) Token: 0x0602A879 RID: 174201 RVA: 0x005CCF2D File Offset: 0x005CB12D
		// (set) Token: 0x0602A87A RID: 174202 RVA: 0x005CCF35 File Offset: 0x005CB135
		public IWuWaGoGridLinkDataT LinkData { get; set; }

		// Token: 0x0602A87B RID: 174203 RVA: 0x005CCF3E File Offset: 0x005CB13E
		public IWuWaGoEndGridT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LinkData = new IWuWaGoGridLinkDataT();
		}
	}
}
