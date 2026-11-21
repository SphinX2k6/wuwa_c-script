using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005101 RID: 20737
	public class IEntityEventConditionT
	{
		// Token: 0x1700949C RID: 38044
		// (get) Token: 0x0602097B RID: 133499 RVA: 0x004850DD File Offset: 0x004832DD
		// (set) Token: 0x0602097C RID: 133500 RVA: 0x004850E5 File Offset: 0x004832E5
		public int EntityId { get; set; }

		// Token: 0x1700949D RID: 38045
		// (get) Token: 0x0602097D RID: 133501 RVA: 0x004850EE File Offset: 0x004832EE
		// (set) Token: 0x0602097E RID: 133502 RVA: 0x004850F6 File Offset: 0x004832F6
		public string State { get; set; }

		// Token: 0x1700949E RID: 38046
		// (get) Token: 0x0602097F RID: 133503 RVA: 0x004850FF File Offset: 0x004832FF
		// (set) Token: 0x06020980 RID: 133504 RVA: 0x00485107 File Offset: 0x00483307
		public bool IsDead { get; set; }

		// Token: 0x1700949F RID: 38047
		// (get) Token: 0x06020981 RID: 133505 RVA: 0x00485110 File Offset: 0x00483310
		// (set) Token: 0x06020982 RID: 133506 RVA: 0x00485118 File Offset: 0x00483318
		public bool IsLocked { get; set; }

		// Token: 0x170094A0 RID: 38048
		// (get) Token: 0x06020983 RID: 133507 RVA: 0x00485121 File Offset: 0x00483321
		// (set) Token: 0x06020984 RID: 133508 RVA: 0x00485129 File Offset: 0x00483329
		public byte NullMask { get; set; }

		// Token: 0x06020985 RID: 133509 RVA: 0x00485132 File Offset: 0x00483332
		public IEntityEventConditionT()
		{
			this.EntityId = 0;
			this.State = null;
			this.IsDead = false;
			this.IsLocked = false;
			this.NullMask = 0;
		}
	}
}
