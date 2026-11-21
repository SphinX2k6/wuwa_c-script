using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E72 RID: 24178
	public class IResurrectionComponentT
	{
		// Token: 0x1700B265 RID: 45669
		// (get) Token: 0x06028741 RID: 165697 RVA: 0x005883DC File Offset: 0x005865DC
		// (set) Token: 0x06028742 RID: 165698 RVA: 0x005883E4 File Offset: 0x005865E4
		public bool Disabled { get; set; }

		// Token: 0x1700B266 RID: 45670
		// (get) Token: 0x06028743 RID: 165699 RVA: 0x005883ED File Offset: 0x005865ED
		// (set) Token: 0x06028744 RID: 165700 RVA: 0x005883F5 File Offset: 0x005865F5
		public IPosAT TeleportPos { get; set; }

		// Token: 0x1700B267 RID: 45671
		// (get) Token: 0x06028745 RID: 165701 RVA: 0x005883FE File Offset: 0x005865FE
		// (set) Token: 0x06028746 RID: 165702 RVA: 0x00588406 File Offset: 0x00586606
		public TTriggerShapeUnion TriggerShape { get; set; }

		// Token: 0x1700B268 RID: 45672
		// (get) Token: 0x06028747 RID: 165703 RVA: 0x0058840F File Offset: 0x0058660F
		// (set) Token: 0x06028748 RID: 165704 RVA: 0x00588417 File Offset: 0x00586617
		public EReviveType ReviveId { get; set; }

		// Token: 0x1700B269 RID: 45673
		// (get) Token: 0x06028749 RID: 165705 RVA: 0x00588420 File Offset: 0x00586620
		// (set) Token: 0x0602874A RID: 165706 RVA: 0x00588428 File Offset: 0x00586628
		public IGravityFlipTeleportConfigT GravityConfig { get; set; }

		// Token: 0x1700B26A RID: 45674
		// (get) Token: 0x0602874B RID: 165707 RVA: 0x00588431 File Offset: 0x00586631
		// (set) Token: 0x0602874C RID: 165708 RVA: 0x00588439 File Offset: 0x00586639
		public byte NullMask { get; set; }

		// Token: 0x0602874D RID: 165709 RVA: 0x00588442 File Offset: 0x00586642
		public IResurrectionComponentT()
		{
			this.Disabled = false;
			this.TeleportPos = null;
			this.TriggerShape = null;
			this.ReviveId = EReviveType.None;
			this.GravityConfig = null;
			this.NullMask = 0;
		}
	}
}
