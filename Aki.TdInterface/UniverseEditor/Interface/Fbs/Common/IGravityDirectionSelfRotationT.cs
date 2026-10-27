using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DF8 RID: 24056
	public class IGravityDirectionSelfRotationT
	{
		// Token: 0x1700B406 RID: 46086
		// (get) Token: 0x060292DE RID: 168670 RVA: 0x005A6636 File Offset: 0x005A4836
		// (set) Token: 0x060292DF RID: 168671 RVA: 0x005A663E File Offset: 0x005A483E
		public EGravityDirectionType Type { get; set; }

		// Token: 0x060292E0 RID: 168672 RVA: 0x005A6647 File Offset: 0x005A4847
		public IGravityDirectionSelfRotationT()
		{
			this.Type = EGravityDirectionType.SelfRotation;
		}
	}
}
