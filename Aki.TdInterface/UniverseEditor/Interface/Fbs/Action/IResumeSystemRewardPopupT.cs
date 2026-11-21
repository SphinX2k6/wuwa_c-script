using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007649 RID: 30281
	public class IResumeSystemRewardPopupT
	{
		// Token: 0x1700DE63 RID: 56931
		// (get) Token: 0x06035223 RID: 217635 RVA: 0x00722625 File Offset: 0x00720825
		// (set) Token: 0x06035224 RID: 217636 RVA: 0x0072262D File Offset: 0x0072082D
		public IResumeGiantDeliveryRewardPopupT SystemType { get; set; }

		// Token: 0x06035225 RID: 217637 RVA: 0x00722636 File Offset: 0x00720836
		public IResumeSystemRewardPopupT()
		{
			this.SystemType = null;
		}
	}
}
