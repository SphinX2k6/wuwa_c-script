using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007658 RID: 30296
	public class IRoadNetworkNavigationTargetT
	{
		// Token: 0x1700DE79 RID: 56953
		// (get) Token: 0x06035287 RID: 217735 RVA: 0x00722F3E File Offset: 0x0072113E
		// (set) Token: 0x06035288 RID: 217736 RVA: 0x00722F46 File Offset: 0x00721146
		public ERoadNetworkNavigationTarget Type { get; set; }

		// Token: 0x06035289 RID: 217737 RVA: 0x00722F4F File Offset: 0x0072114F
		public IRoadNetworkNavigationTargetT()
		{
			this.Type = ERoadNetworkNavigationTarget.SceneItem;
		}
	}
}
