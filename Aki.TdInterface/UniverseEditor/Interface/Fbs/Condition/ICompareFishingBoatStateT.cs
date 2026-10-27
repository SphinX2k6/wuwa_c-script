using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BA2 RID: 19362
	public class ICompareFishingBoatStateT
	{
		// Token: 0x17008C89 RID: 35977
		// (get) Token: 0x0601E87C RID: 125052 RVA: 0x00445A7C File Offset: 0x00443C7C
		// (set) Token: 0x0601E87D RID: 125053 RVA: 0x00445A84 File Offset: 0x00443C84
		public ECondition Type { get; set; }

		// Token: 0x17008C8A RID: 35978
		// (get) Token: 0x0601E87E RID: 125054 RVA: 0x00445A8D File Offset: 0x00443C8D
		// (set) Token: 0x0601E87F RID: 125055 RVA: 0x00445A95 File Offset: 0x00443C95
		public bool IsStop { get; set; }

		// Token: 0x17008C8B RID: 35979
		// (get) Token: 0x0601E880 RID: 125056 RVA: 0x00445A9E File Offset: 0x00443C9E
		// (set) Token: 0x0601E881 RID: 125057 RVA: 0x00445AA6 File Offset: 0x00443CA6
		public int FishingPort { get; set; }

		// Token: 0x17008C8C RID: 35980
		// (get) Token: 0x0601E882 RID: 125058 RVA: 0x00445AAF File Offset: 0x00443CAF
		// (set) Token: 0x0601E883 RID: 125059 RVA: 0x00445AB7 File Offset: 0x00443CB7
		public byte NullMask { get; set; }

		// Token: 0x0601E884 RID: 125060 RVA: 0x00445AC0 File Offset: 0x00443CC0
		public ICompareFishingBoatStateT()
		{
			this.Type = ECondition.CompareVar;
			this.IsStop = false;
			this.FishingPort = 0;
			this.NullMask = 0;
		}
	}
}
