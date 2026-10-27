using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053AE RID: 21422
	public class IHoldConfigT
	{
		// Token: 0x17009D67 RID: 40295
		// (get) Token: 0x06023184 RID: 143748 RVA: 0x004DBC2F File Offset: 0x004D9E2F
		// (set) Token: 0x06023185 RID: 143749 RVA: 0x004DBC37 File Offset: 0x004D9E37
		public int HoldSwingFreq { get; set; }

		// Token: 0x17009D68 RID: 40296
		// (get) Token: 0x06023186 RID: 143750 RVA: 0x004DBC40 File Offset: 0x004D9E40
		// (set) Token: 0x06023187 RID: 143751 RVA: 0x004DBC48 File Offset: 0x004D9E48
		public int HoldAngularVelocity { get; set; }

		// Token: 0x17009D69 RID: 40297
		// (get) Token: 0x06023188 RID: 143752 RVA: 0x004DBC51 File Offset: 0x004D9E51
		// (set) Token: 0x06023189 RID: 143753 RVA: 0x004DBC59 File Offset: 0x004D9E59
		public IVectorInfoT HoldRotation { get; set; }

		// Token: 0x17009D6A RID: 40298
		// (get) Token: 0x0602318A RID: 143754 RVA: 0x004DBC62 File Offset: 0x004D9E62
		// (set) Token: 0x0602318B RID: 143755 RVA: 0x004DBC6A File Offset: 0x004D9E6A
		public IVectorInfoT HoldOffset { get; set; }

		// Token: 0x17009D6B RID: 40299
		// (get) Token: 0x0602318C RID: 143756 RVA: 0x004DBC73 File Offset: 0x004D9E73
		// (set) Token: 0x0602318D RID: 143757 RVA: 0x004DBC7B File Offset: 0x004D9E7B
		public IVectorInfoT SecondaryOffset { get; set; }

		// Token: 0x17009D6C RID: 40300
		// (get) Token: 0x0602318E RID: 143758 RVA: 0x004DBC84 File Offset: 0x004D9E84
		// (set) Token: 0x0602318F RID: 143759 RVA: 0x004DBC8C File Offset: 0x004D9E8C
		public int HoldSwingRange { get; set; }

		// Token: 0x17009D6D RID: 40301
		// (get) Token: 0x06023190 RID: 143760 RVA: 0x004DBC95 File Offset: 0x004D9E95
		// (set) Token: 0x06023191 RID: 143761 RVA: 0x004DBC9D File Offset: 0x004D9E9D
		public string HoldCameraShake { get; set; }

		// Token: 0x17009D6E RID: 40302
		// (get) Token: 0x06023192 RID: 143762 RVA: 0x004DBCA6 File Offset: 0x004D9EA6
		// (set) Token: 0x06023193 RID: 143763 RVA: 0x004DBCAE File Offset: 0x004D9EAE
		public string HoldCameraStateTag { get; set; }

		// Token: 0x06023194 RID: 143764 RVA: 0x004DBCB7 File Offset: 0x004D9EB7
		public IHoldConfigT()
		{
			this.HoldSwingFreq = 0;
			this.HoldAngularVelocity = 0;
			this.HoldRotation = null;
			this.HoldOffset = null;
			this.SecondaryOffset = null;
			this.HoldSwingRange = 0;
			this.HoldCameraShake = null;
			this.HoldCameraStateTag = null;
		}
	}
}
