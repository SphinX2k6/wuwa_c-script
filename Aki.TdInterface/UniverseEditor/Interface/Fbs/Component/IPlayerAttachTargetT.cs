using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D50 RID: 23888
	public class IPlayerAttachTargetT
	{
		// Token: 0x1700AFDA RID: 45018
		// (get) Token: 0x06027C35 RID: 162869 RVA: 0x00570CFE File Offset: 0x0056EEFE
		// (set) Token: 0x06027C36 RID: 162870 RVA: 0x00570D06 File Offset: 0x0056EF06
		public EAttachType Type { get; set; }

		// Token: 0x06027C37 RID: 162871 RVA: 0x00570D0F File Offset: 0x0056EF0F
		public IPlayerAttachTargetT()
		{
			this.Type = EAttachType.Actor;
		}
	}
}
