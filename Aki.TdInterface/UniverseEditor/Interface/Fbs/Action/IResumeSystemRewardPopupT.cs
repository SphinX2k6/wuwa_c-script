using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC5 RID: 28357
	public class IResumeSystemRewardPopupT
	{
		// Token: 0x1700D30C RID: 54028
		// (get) Token: 0x060321E3 RID: 205283 RVA: 0x006C68F1 File Offset: 0x006C4AF1
		// (set) Token: 0x060321E4 RID: 205284 RVA: 0x006C68F9 File Offset: 0x006C4AF9
		public IResumeGiantDeliveryRewardPopupT SystemType { get; set; }

		// Token: 0x060321E5 RID: 205285 RVA: 0x006C6902 File Offset: 0x006C4B02
		public IResumeSystemRewardPopupT()
		{
			this.SystemType = null;
		}
	}
}
