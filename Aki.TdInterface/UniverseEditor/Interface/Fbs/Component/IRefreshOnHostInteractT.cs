using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005830 RID: 22576
	public class IRefreshOnHostInteractT
	{
		// Token: 0x1700A8A6 RID: 43174
		// (get) Token: 0x06025F93 RID: 155539 RVA: 0x0053C44E File Offset: 0x0053A64E
		// (set) Token: 0x06025F94 RID: 155540 RVA: 0x0053C456 File Offset: 0x0053A656
		public ERewardDropType Type { get; set; }

		// Token: 0x06025F95 RID: 155541 RVA: 0x0053C45F File Offset: 0x0053A65F
		public IRefreshOnHostInteractT()
		{
			this.Type = ERewardDropType.Death;
		}
	}
}
