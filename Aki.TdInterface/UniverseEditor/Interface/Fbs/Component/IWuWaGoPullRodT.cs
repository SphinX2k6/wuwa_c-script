using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061E7 RID: 25063
	public class IWuWaGoPullRodT
	{
		// Token: 0x1700BAE5 RID: 47845
		// (get) Token: 0x0602AA29 RID: 174633 RVA: 0x005D04CF File Offset: 0x005CE6CF
		// (set) Token: 0x0602AA2A RID: 174634 RVA: 0x005D04D7 File Offset: 0x005CE6D7
		public EWuWaGoEntityType Type { get; set; }

		// Token: 0x1700BAE6 RID: 47846
		// (get) Token: 0x0602AA2B RID: 174635 RVA: 0x005D04E0 File Offset: 0x005CE6E0
		// (set) Token: 0x0602AA2C RID: 174636 RVA: 0x005D04E8 File Offset: 0x005CE6E8
		public List<IWuWaGoInteractStateActionT> InteractConfig { get; set; }

		// Token: 0x0602AA2D RID: 174637 RVA: 0x005D04F1 File Offset: 0x005CE6F1
		public IWuWaGoPullRodT()
		{
			this.Type = EWuWaGoEntityType.LevelCenter;
			this.InteractConfig = null;
		}
	}
}
