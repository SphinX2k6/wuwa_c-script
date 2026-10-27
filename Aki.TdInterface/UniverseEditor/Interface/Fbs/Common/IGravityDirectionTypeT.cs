using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DFB RID: 24059
	public class IGravityDirectionTypeT
	{
		// Token: 0x1700B409 RID: 46089
		// (get) Token: 0x060292F0 RID: 168688 RVA: 0x005A67AE File Offset: 0x005A49AE
		// (set) Token: 0x060292F1 RID: 168689 RVA: 0x005A67B6 File Offset: 0x005A49B6
		public EGravityDirectionType Type { get; set; }

		// Token: 0x060292F2 RID: 168690 RVA: 0x005A67BF File Offset: 0x005A49BF
		public IGravityDirectionTypeT()
		{
			this.Type = EGravityDirectionType.SelfRotation;
		}
	}
}
