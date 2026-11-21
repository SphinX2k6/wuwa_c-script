using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006435 RID: 25653
	public class IGravityDirectionSelfRotationT
	{
		// Token: 0x1700BD6C RID: 48492
		// (get) Token: 0x0602B968 RID: 178536 RVA: 0x005EF366 File Offset: 0x005ED566
		// (set) Token: 0x0602B969 RID: 178537 RVA: 0x005EF36E File Offset: 0x005ED56E
		public EGravityDirectionType Type { get; set; }

		// Token: 0x0602B96A RID: 178538 RVA: 0x005EF377 File Offset: 0x005ED577
		public IGravityDirectionSelfRotationT()
		{
			this.Type = EGravityDirectionType.SelfRotation;
		}
	}
}
