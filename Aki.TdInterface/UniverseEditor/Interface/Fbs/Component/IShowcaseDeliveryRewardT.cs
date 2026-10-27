using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200590C RID: 22796
	public class IShowcaseDeliveryRewardT
	{
		// Token: 0x1700AAE0 RID: 43744
		// (get) Token: 0x06026870 RID: 157808 RVA: 0x0054EBFC File Offset: 0x0054CDFC
		// (set) Token: 0x06026871 RID: 157809 RVA: 0x0054EC04 File Offset: 0x0054CE04
		public int AchievedDollCount { get; set; }

		// Token: 0x1700AAE1 RID: 43745
		// (get) Token: 0x06026872 RID: 157810 RVA: 0x0054EC0D File Offset: 0x0054CE0D
		// (set) Token: 0x06026873 RID: 157811 RVA: 0x0054EC15 File Offset: 0x0054CE15
		public int DropId { get; set; }

		// Token: 0x06026874 RID: 157812 RVA: 0x0054EC1E File Offset: 0x0054CE1E
		public IShowcaseDeliveryRewardT()
		{
			this.AchievedDollCount = 0;
			this.DropId = 0;
		}
	}
}
