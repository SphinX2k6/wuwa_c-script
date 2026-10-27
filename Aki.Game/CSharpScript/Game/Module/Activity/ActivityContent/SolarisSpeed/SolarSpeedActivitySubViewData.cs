using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060AF RID: 24751
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedActivitySubViewData : ISolarSpeedActivitySubViewData
	{
		// Token: 0x170090B4 RID: 37044
		// (get) Token: 0x0603E945 RID: 256325 RVA: 0x00F20370 File Offset: 0x00F1E570
		// (set) Token: 0x0603E946 RID: 256326 RVA: 0x00F20378 File Offset: 0x00F1E578
		public string RewardTextId { get; set; }

		// Token: 0x170090B5 RID: 37045
		// (get) Token: 0x0603E947 RID: 256327 RVA: 0x00F20381 File Offset: 0x00F1E581
		// (set) Token: 0x0603E948 RID: 256328 RVA: 0x00F20389 File Offset: 0x00F1E589
		public string ButtonTextId { get; set; }

		// Token: 0x170090B6 RID: 37046
		// (get) Token: 0x0603E949 RID: 256329 RVA: 0x00F20392 File Offset: 0x00F1E592
		// (set) Token: 0x0603E94A RID: 256330 RVA: 0x00F2039A File Offset: 0x00F1E59A
		public Func<bool> RewardRedDotStateGetter { get; set; }

		// Token: 0x170090B7 RID: 37047
		// (get) Token: 0x0603E94B RID: 256331 RVA: 0x00F203A3 File Offset: 0x00F1E5A3
		// (set) Token: 0x0603E94C RID: 256332 RVA: 0x00F203AB File Offset: 0x00F1E5AB
		public Func<bool> ConfirmRedDotStateGetter { get; set; }

		// Token: 0x170090B8 RID: 37048
		// (get) Token: 0x0603E94D RID: 256333 RVA: 0x00F203B4 File Offset: 0x00F1E5B4
		// (set) Token: 0x0603E94E RID: 256334 RVA: 0x00F203BC File Offset: 0x00F1E5BC
		public Func<string> RewardProgressCurrentGetter { get; set; }

		// Token: 0x170090B9 RID: 37049
		// (get) Token: 0x0603E94F RID: 256335 RVA: 0x00F203C5 File Offset: 0x00F1E5C5
		// (set) Token: 0x0603E950 RID: 256336 RVA: 0x00F203CD File Offset: 0x00F1E5CD
		public string RewardProgressTextId { get; set; }

		// Token: 0x170090BA RID: 37050
		// (get) Token: 0x0603E951 RID: 256337 RVA: 0x00F203D6 File Offset: 0x00F1E5D6
		// (set) Token: 0x0603E952 RID: 256338 RVA: 0x00F203DE File Offset: 0x00F1E5DE
		public string RewardProgressTotal { get; set; }
	}
}
