using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC8 RID: 28360
	public class IResumeSystemRewardPopupTypeT
	{
		// Token: 0x1700D30F RID: 54031
		// (get) Token: 0x060321F5 RID: 205301 RVA: 0x006C6A7E File Offset: 0x006C4C7E
		// (set) Token: 0x060321F6 RID: 205302 RVA: 0x006C6A86 File Offset: 0x006C4C86
		public ESystemType Type { get; set; }

		// Token: 0x060321F7 RID: 205303 RVA: 0x006C6A8F File Offset: 0x006C4C8F
		public IResumeSystemRewardPopupTypeT()
		{
			this.Type = ESystemType.Shop;
		}
	}
}
