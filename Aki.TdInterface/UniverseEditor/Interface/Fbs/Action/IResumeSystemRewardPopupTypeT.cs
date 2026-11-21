using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200764C RID: 30284
	public class IResumeSystemRewardPopupTypeT
	{
		// Token: 0x1700DE66 RID: 56934
		// (get) Token: 0x06035235 RID: 217653 RVA: 0x007227B2 File Offset: 0x007209B2
		// (set) Token: 0x06035236 RID: 217654 RVA: 0x007227BA File Offset: 0x007209BA
		public ESystemType Type { get; set; }

		// Token: 0x06035237 RID: 217655 RVA: 0x007227C3 File Offset: 0x007209C3
		public IResumeSystemRewardPopupTypeT()
		{
			this.Type = ESystemType.Shop;
		}
	}
}
