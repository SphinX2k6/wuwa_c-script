using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005611 RID: 22033
	public class IDollGrabStageAudioStateT
	{
		// Token: 0x17009E04 RID: 40452
		// (get) Token: 0x06023231 RID: 143921 RVA: 0x004D6236 File Offset: 0x004D4436
		// (set) Token: 0x06023232 RID: 143922 RVA: 0x004D623E File Offset: 0x004D443E
		public string Group { get; set; }

		// Token: 0x17009E05 RID: 40453
		// (get) Token: 0x06023233 RID: 143923 RVA: 0x004D6247 File Offset: 0x004D4447
		// (set) Token: 0x06023234 RID: 143924 RVA: 0x004D624F File Offset: 0x004D444F
		public string State { get; set; }

		// Token: 0x06023235 RID: 143925 RVA: 0x004D6258 File Offset: 0x004D4458
		public IDollGrabStageAudioStateT()
		{
			this.Group = null;
			this.State = null;
		}
	}
}
