using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB8 RID: 27576
	public class IDartPlayableRoleInteractTypeT
	{
		// Token: 0x1700CA51 RID: 51793
		// (get) Token: 0x0602F772 RID: 194418 RVA: 0x006795A0 File Offset: 0x006777A0
		// (set) Token: 0x0602F773 RID: 194419 RVA: 0x006795A8 File Offset: 0x006777A8
		public EDartInteractType Type { get; set; }

		// Token: 0x1700CA52 RID: 51794
		// (get) Token: 0x0602F774 RID: 194420 RVA: 0x006795B1 File Offset: 0x006777B1
		// (set) Token: 0x0602F775 RID: 194421 RVA: 0x006795B9 File Offset: 0x006777B9
		public int CompetitorId { get; set; }

		// Token: 0x1700CA53 RID: 51795
		// (get) Token: 0x0602F776 RID: 194422 RVA: 0x006795C2 File Offset: 0x006777C2
		// (set) Token: 0x0602F777 RID: 194423 RVA: 0x006795CA File Offset: 0x006777CA
		public int TargetEntityId { get; set; }

		// Token: 0x1700CA54 RID: 51796
		// (get) Token: 0x0602F778 RID: 194424 RVA: 0x006795D3 File Offset: 0x006777D3
		// (set) Token: 0x0602F779 RID: 194425 RVA: 0x006795DB File Offset: 0x006777DB
		public byte NullMask { get; set; }

		// Token: 0x0602F77A RID: 194426 RVA: 0x006795E4 File Offset: 0x006777E4
		public IDartPlayableRoleInteractTypeT()
		{
			this.Type = EDartInteractType.Machine;
			this.CompetitorId = 0;
			this.TargetEntityId = 0;
			this.NullMask = 0;
		}
	}
}
