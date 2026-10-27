using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD4 RID: 23508
	public class IWuWaGoRoleInfoT
	{
		// Token: 0x1700B1A3 RID: 45475
		// (get) Token: 0x0602847D RID: 164989 RVA: 0x00588D94 File Offset: 0x00586F94
		// (set) Token: 0x0602847E RID: 164990 RVA: 0x00588D9C File Offset: 0x00586F9C
		public EWuWaGoRoleType RoleType { get; set; }

		// Token: 0x1700B1A4 RID: 45476
		// (get) Token: 0x0602847F RID: 164991 RVA: 0x00588DA5 File Offset: 0x00586FA5
		// (set) Token: 0x06028480 RID: 164992 RVA: 0x00588DAD File Offset: 0x00586FAD
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700B1A5 RID: 45477
		// (get) Token: 0x06028481 RID: 164993 RVA: 0x00588DB6 File Offset: 0x00586FB6
		// (set) Token: 0x06028482 RID: 164994 RVA: 0x00588DBE File Offset: 0x00586FBE
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x06028483 RID: 164995 RVA: 0x00588DC7 File Offset: 0x00586FC7
		public IWuWaGoRoleInfoT()
		{
			this.RoleType = EWuWaGoRoleType.AircraftSoldiers;
			this.Position = null;
			this.Rotation = null;
		}
	}
}
