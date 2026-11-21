using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EFF RID: 24319
	public class ISearchlightRotateT
	{
		// Token: 0x1700B3D2 RID: 46034
		// (get) Token: 0x06028CD6 RID: 167126 RVA: 0x00593A23 File Offset: 0x00591C23
		// (set) Token: 0x06028CD7 RID: 167127 RVA: 0x00593A2B File Offset: 0x00591C2B
		public EProceduralVisualType Type { get; set; }

		// Token: 0x1700B3D3 RID: 46035
		// (get) Token: 0x06028CD8 RID: 167128 RVA: 0x00593A34 File Offset: 0x00591C34
		// (set) Token: 0x06028CD9 RID: 167129 RVA: 0x00593A3C File Offset: 0x00591C3C
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B3D4 RID: 46036
		// (get) Token: 0x06028CDA RID: 167130 RVA: 0x00593A45 File Offset: 0x00591C45
		// (set) Token: 0x06028CDB RID: 167131 RVA: 0x00593A4D File Offset: 0x00591C4D
		public string RotateNode { get; set; }

		// Token: 0x1700B3D5 RID: 46037
		// (get) Token: 0x06028CDC RID: 167132 RVA: 0x00593A56 File Offset: 0x00591C56
		// (set) Token: 0x06028CDD RID: 167133 RVA: 0x00593A5E File Offset: 0x00591C5E
		public float MaxAngleSpeed { get; set; }

		// Token: 0x1700B3D6 RID: 46038
		// (get) Token: 0x06028CDE RID: 167134 RVA: 0x00593A67 File Offset: 0x00591C67
		// (set) Token: 0x06028CDF RID: 167135 RVA: 0x00593A6F File Offset: 0x00591C6F
		public ESearchlightRotateAxis Axis { get; set; }

		// Token: 0x1700B3D7 RID: 46039
		// (get) Token: 0x06028CE0 RID: 167136 RVA: 0x00593A78 File Offset: 0x00591C78
		// (set) Token: 0x06028CE1 RID: 167137 RVA: 0x00593A80 File Offset: 0x00591C80
		public List<ISnapAngleConfigT> SnapConfigs { get; set; }

		// Token: 0x1700B3D8 RID: 46040
		// (get) Token: 0x06028CE2 RID: 167138 RVA: 0x00593A89 File Offset: 0x00591C89
		// (set) Token: 0x06028CE3 RID: 167139 RVA: 0x00593A91 File Offset: 0x00591C91
		public byte NullMask { get; set; }

		// Token: 0x06028CE4 RID: 167140 RVA: 0x00593A9A File Offset: 0x00591C9A
		public ISearchlightRotateT()
		{
			this.Type = EProceduralVisualType.LookAt;
			this.Condition = null;
			this.RotateNode = null;
			this.MaxAngleSpeed = 0f;
			this.Axis = ESearchlightRotateAxis.Yaw;
			this.SnapConfigs = null;
			this.NullMask = 0;
		}
	}
}
