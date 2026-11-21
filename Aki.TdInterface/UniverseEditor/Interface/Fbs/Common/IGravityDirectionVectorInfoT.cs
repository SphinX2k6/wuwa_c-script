using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200643E RID: 25662
	public class IGravityDirectionVectorInfoT
	{
		// Token: 0x1700BD75 RID: 48501
		// (get) Token: 0x0602B9A0 RID: 178592 RVA: 0x005EF8EB File Offset: 0x005EDAEB
		// (set) Token: 0x0602B9A1 RID: 178593 RVA: 0x005EF8F3 File Offset: 0x005EDAF3
		public EGravityDirectionType Type { get; set; }

		// Token: 0x1700BD76 RID: 48502
		// (get) Token: 0x0602B9A2 RID: 178594 RVA: 0x005EF8FC File Offset: 0x005EDAFC
		// (set) Token: 0x0602B9A3 RID: 178595 RVA: 0x005EF904 File Offset: 0x005EDB04
		public IVectorInfoT Direction { get; set; }

		// Token: 0x0602B9A4 RID: 178596 RVA: 0x005EF90D File Offset: 0x005EDB0D
		public IGravityDirectionVectorInfoT()
		{
			this.Type = EGravityDirectionType.SelfRotation;
			this.Direction = null;
		}
	}
}
