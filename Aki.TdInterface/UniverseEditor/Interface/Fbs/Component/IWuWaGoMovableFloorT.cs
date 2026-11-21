using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061DE RID: 25054
	public class IWuWaGoMovableFloorT
	{
		// Token: 0x1700BAD0 RID: 47824
		// (get) Token: 0x0602A9C7 RID: 174535 RVA: 0x005CF74B File Offset: 0x005CD94B
		// (set) Token: 0x0602A9C8 RID: 174536 RVA: 0x005CF753 File Offset: 0x005CD953
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700BAD1 RID: 47825
		// (get) Token: 0x0602A9C9 RID: 174537 RVA: 0x005CF75C File Offset: 0x005CD95C
		// (set) Token: 0x0602A9CA RID: 174538 RVA: 0x005CF764 File Offset: 0x005CD964
		public IWuWaGoGridLinkDataT LinkData { get; set; }

		// Token: 0x1700BAD2 RID: 47826
		// (get) Token: 0x0602A9CB RID: 174539 RVA: 0x005CF76D File Offset: 0x005CD96D
		// (set) Token: 0x0602A9CC RID: 174540 RVA: 0x005CF775 File Offset: 0x005CD975
		public IWuWaGoGridLinkDataT GearLinkData { get; set; }

		// Token: 0x1700BAD3 RID: 47827
		// (get) Token: 0x0602A9CD RID: 174541 RVA: 0x005CF77E File Offset: 0x005CD97E
		// (set) Token: 0x0602A9CE RID: 174542 RVA: 0x005CF786 File Offset: 0x005CD986
		public List<IWuWaGoMovableGridStatePosT> MoveData { get; set; }

		// Token: 0x0602A9CF RID: 174543 RVA: 0x005CF78F File Offset: 0x005CD98F
		public IWuWaGoMovableFloorT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LinkData = new IWuWaGoGridLinkDataT();
			this.GearLinkData = new IWuWaGoGridLinkDataT();
			this.MoveData = null;
		}
	}
}
