using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC8 RID: 23496
	public class IWuWaGoMovableFloorT
	{
		// Token: 0x1700B188 RID: 45448
		// (get) Token: 0x06028403 RID: 164867 RVA: 0x00587CBB File Offset: 0x00585EBB
		// (set) Token: 0x06028404 RID: 164868 RVA: 0x00587CC3 File Offset: 0x00585EC3
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700B189 RID: 45449
		// (get) Token: 0x06028405 RID: 164869 RVA: 0x00587CCC File Offset: 0x00585ECC
		// (set) Token: 0x06028406 RID: 164870 RVA: 0x00587CD4 File Offset: 0x00585ED4
		public IWuWaGoGridLinkDataT LinkData { get; set; }

		// Token: 0x1700B18A RID: 45450
		// (get) Token: 0x06028407 RID: 164871 RVA: 0x00587CDD File Offset: 0x00585EDD
		// (set) Token: 0x06028408 RID: 164872 RVA: 0x00587CE5 File Offset: 0x00585EE5
		public IWuWaGoGridLinkDataT GearLinkData { get; set; }

		// Token: 0x1700B18B RID: 45451
		// (get) Token: 0x06028409 RID: 164873 RVA: 0x00587CEE File Offset: 0x00585EEE
		// (set) Token: 0x0602840A RID: 164874 RVA: 0x00587CF6 File Offset: 0x00585EF6
		public List<IWuWaGoMovableGridStatePosT> MoveData { get; set; }

		// Token: 0x0602840B RID: 164875 RVA: 0x00587CFF File Offset: 0x00585EFF
		public IWuWaGoMovableFloorT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.LinkData = new IWuWaGoGridLinkDataT();
			this.GearLinkData = new IWuWaGoGridLinkDataT();
			this.MoveData = null;
		}
	}
}
