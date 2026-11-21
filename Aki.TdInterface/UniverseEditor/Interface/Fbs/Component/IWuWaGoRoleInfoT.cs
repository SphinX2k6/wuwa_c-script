using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061EA RID: 25066
	public class IWuWaGoRoleInfoT
	{
		// Token: 0x1700BAEB RID: 47851
		// (get) Token: 0x0602AA41 RID: 174657 RVA: 0x005D0824 File Offset: 0x005CEA24
		// (set) Token: 0x0602AA42 RID: 174658 RVA: 0x005D082C File Offset: 0x005CEA2C
		public EWuWaGoRoleType RoleType { get; set; }

		// Token: 0x1700BAEC RID: 47852
		// (get) Token: 0x0602AA43 RID: 174659 RVA: 0x005D0835 File Offset: 0x005CEA35
		// (set) Token: 0x0602AA44 RID: 174660 RVA: 0x005D083D File Offset: 0x005CEA3D
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700BAED RID: 47853
		// (get) Token: 0x0602AA45 RID: 174661 RVA: 0x005D0846 File Offset: 0x005CEA46
		// (set) Token: 0x0602AA46 RID: 174662 RVA: 0x005D084E File Offset: 0x005CEA4E
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x0602AA47 RID: 174663 RVA: 0x005D0857 File Offset: 0x005CEA57
		public IWuWaGoRoleInfoT()
		{
			this.RoleType = EWuWaGoRoleType.AircraftSoldiers;
			this.Position = null;
			this.Rotation = null;
		}
	}
}
