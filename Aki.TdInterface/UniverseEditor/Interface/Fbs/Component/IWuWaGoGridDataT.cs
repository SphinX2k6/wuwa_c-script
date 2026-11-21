using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061C4 RID: 25028
	public class IWuWaGoGridDataT
	{
		// Token: 0x1700BAA1 RID: 47777
		// (get) Token: 0x0602A8E1 RID: 174305 RVA: 0x005CDBC2 File Offset: 0x005CBDC2
		// (set) Token: 0x0602A8E2 RID: 174306 RVA: 0x005CDBCA File Offset: 0x005CBDCA
		public EGridShape GridShape { get; set; }

		// Token: 0x1700BAA2 RID: 47778
		// (get) Token: 0x0602A8E3 RID: 174307 RVA: 0x005CDBD3 File Offset: 0x005CBDD3
		// (set) Token: 0x0602A8E4 RID: 174308 RVA: 0x005CDBDB File Offset: 0x005CBDDB
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700BAA3 RID: 47779
		// (get) Token: 0x0602A8E5 RID: 174309 RVA: 0x005CDBE4 File Offset: 0x005CBDE4
		// (set) Token: 0x0602A8E6 RID: 174310 RVA: 0x005CDBEC File Offset: 0x005CBDEC
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700BAA4 RID: 47780
		// (get) Token: 0x0602A8E7 RID: 174311 RVA: 0x005CDBF5 File Offset: 0x005CBDF5
		// (set) Token: 0x0602A8E8 RID: 174312 RVA: 0x005CDBFD File Offset: 0x005CBDFD
		public IWuWaGoGridLinkDataT GridLinkData { get; set; }

		// Token: 0x1700BAA5 RID: 47781
		// (get) Token: 0x0602A8E9 RID: 174313 RVA: 0x005CDC06 File Offset: 0x005CBE06
		// (set) Token: 0x0602A8EA RID: 174314 RVA: 0x005CDC0E File Offset: 0x005CBE0E
		public IVectorInfoT AttachedGridCenter { get; set; }

		// Token: 0x0602A8EB RID: 174315 RVA: 0x005CDC17 File Offset: 0x005CBE17
		public IWuWaGoGridDataT()
		{
			this.GridShape = EGridShape.Vertical;
			this.Position = null;
			this.Rotation = null;
			this.GridLinkData = new IWuWaGoGridLinkDataT();
			this.AttachedGridCenter = null;
		}
	}
}
