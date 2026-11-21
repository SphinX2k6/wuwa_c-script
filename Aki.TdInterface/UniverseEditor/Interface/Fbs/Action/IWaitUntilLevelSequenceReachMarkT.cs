using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E10 RID: 32272
	public class IWaitUntilLevelSequenceReachMarkT
	{
		// Token: 0x1700F1BB RID: 61883
		// (get) Token: 0x0603A529 RID: 238889 RVA: 0x007DB6B3 File Offset: 0x007D98B3
		// (set) Token: 0x0603A52A RID: 238890 RVA: 0x007DB6BB File Offset: 0x007D98BB
		public int EntityId { get; set; }

		// Token: 0x1700F1BC RID: 61884
		// (get) Token: 0x0603A52B RID: 238891 RVA: 0x007DB6C4 File Offset: 0x007D98C4
		// (set) Token: 0x0603A52C RID: 238892 RVA: 0x007DB6CC File Offset: 0x007D98CC
		public string Mark { get; set; }

		// Token: 0x0603A52D RID: 238893 RVA: 0x007DB6D5 File Offset: 0x007D98D5
		public IWaitUntilLevelSequenceReachMarkT()
		{
			this.EntityId = 0;
			this.Mark = null;
		}
	}
}
