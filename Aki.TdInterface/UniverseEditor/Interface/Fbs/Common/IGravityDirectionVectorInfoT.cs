using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E01 RID: 24065
	public class IGravityDirectionVectorInfoT
	{
		// Token: 0x1700B40F RID: 46095
		// (get) Token: 0x06029316 RID: 168726 RVA: 0x005A6BBB File Offset: 0x005A4DBB
		// (set) Token: 0x06029317 RID: 168727 RVA: 0x005A6BC3 File Offset: 0x005A4DC3
		public EGravityDirectionType Type { get; set; }

		// Token: 0x1700B410 RID: 46096
		// (get) Token: 0x06029318 RID: 168728 RVA: 0x005A6BCC File Offset: 0x005A4DCC
		// (set) Token: 0x06029319 RID: 168729 RVA: 0x005A6BD4 File Offset: 0x005A4DD4
		public IVectorInfoT Direction { get; set; }

		// Token: 0x0602931A RID: 168730 RVA: 0x005A6BDD File Offset: 0x005A4DDD
		public IGravityDirectionVectorInfoT()
		{
			this.Type = EGravityDirectionType.SelfRotation;
			this.Direction = null;
		}
	}
}
