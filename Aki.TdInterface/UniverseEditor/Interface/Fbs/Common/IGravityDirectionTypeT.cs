using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006438 RID: 25656
	public class IGravityDirectionTypeT
	{
		// Token: 0x1700BD6F RID: 48495
		// (get) Token: 0x0602B97A RID: 178554 RVA: 0x005EF4DE File Offset: 0x005ED6DE
		// (set) Token: 0x0602B97B RID: 178555 RVA: 0x005EF4E6 File Offset: 0x005ED6E6
		public EGravityDirectionType Type { get; set; }

		// Token: 0x0602B97C RID: 178556 RVA: 0x005EF4EF File Offset: 0x005ED6EF
		public IGravityDirectionTypeT()
		{
			this.Type = EGravityDirectionType.SelfRotation;
		}
	}
}
