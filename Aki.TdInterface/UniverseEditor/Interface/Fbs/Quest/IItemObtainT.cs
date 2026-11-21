using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F9 RID: 17145
	public class IItemObtainT
	{
		// Token: 0x17007565 RID: 30053
		// (get) Token: 0x06018159 RID: 98649 RVA: 0x0036FA65 File Offset: 0x0036DC65
		// (set) Token: 0x0601815A RID: 98650 RVA: 0x0036FA6D File Offset: 0x0036DC6D
		public EShowUiType Type { get; set; }

		// Token: 0x17007566 RID: 30054
		// (get) Token: 0x0601815B RID: 98651 RVA: 0x0036FA76 File Offset: 0x0036DC76
		// (set) Token: 0x0601815C RID: 98652 RVA: 0x0036FA7E File Offset: 0x0036DC7E
		public List<int> ItemIds { get; set; }

		// Token: 0x17007567 RID: 30055
		// (get) Token: 0x0601815D RID: 98653 RVA: 0x0036FA87 File Offset: 0x0036DC87
		// (set) Token: 0x0601815E RID: 98654 RVA: 0x0036FA8F File Offset: 0x0036DC8F
		public byte NullMask { get; set; }

		// Token: 0x0601815F RID: 98655 RVA: 0x0036FA98 File Offset: 0x0036DC98
		public IItemObtainT()
		{
			this.Type = EShowUiType.All;
			this.ItemIds = null;
			this.NullMask = 0;
		}
	}
}
