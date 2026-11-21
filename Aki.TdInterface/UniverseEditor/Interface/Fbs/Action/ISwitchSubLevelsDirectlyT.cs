using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A44 RID: 31300
	public class ISwitchSubLevelsDirectlyT
	{
		// Token: 0x1700E556 RID: 58710
		// (get) Token: 0x0603729E RID: 225950 RVA: 0x0075E9AA File Offset: 0x0075CBAA
		// (set) Token: 0x0603729F RID: 225951 RVA: 0x0075E9B2 File Offset: 0x0075CBB2
		public ESwitchSubLevelsType Type { get; set; }

		// Token: 0x1700E557 RID: 58711
		// (get) Token: 0x060372A0 RID: 225952 RVA: 0x0075E9BB File Offset: 0x0075CBBB
		// (set) Token: 0x060372A1 RID: 225953 RVA: 0x0075E9C3 File Offset: 0x0075CBC3
		public List<string> LoadLevels { get; set; }

		// Token: 0x1700E558 RID: 58712
		// (get) Token: 0x060372A2 RID: 225954 RVA: 0x0075E9CC File Offset: 0x0075CBCC
		// (set) Token: 0x060372A3 RID: 225955 RVA: 0x0075E9D4 File Offset: 0x0075CBD4
		public List<string> UnloadLevels { get; set; }

		// Token: 0x1700E559 RID: 58713
		// (get) Token: 0x060372A4 RID: 225956 RVA: 0x0075E9DD File Offset: 0x0075CBDD
		// (set) Token: 0x060372A5 RID: 225957 RVA: 0x0075E9E5 File Offset: 0x0075CBE5
		public int TeleportEntityId { get; set; }

		// Token: 0x1700E55A RID: 58714
		// (get) Token: 0x060372A6 RID: 225958 RVA: 0x0075E9EE File Offset: 0x0075CBEE
		// (set) Token: 0x060372A7 RID: 225959 RVA: 0x0075E9F6 File Offset: 0x0075CBF6
		public bool IsWaitForSwitchComplete { get; set; }

		// Token: 0x1700E55B RID: 58715
		// (get) Token: 0x060372A8 RID: 225960 RVA: 0x0075E9FF File Offset: 0x0075CBFF
		// (set) Token: 0x060372A9 RID: 225961 RVA: 0x0075EA07 File Offset: 0x0075CC07
		public byte NullMask { get; set; }

		// Token: 0x060372AA RID: 225962 RVA: 0x0075EA10 File Offset: 0x0075CC10
		public ISwitchSubLevelsDirectlyT()
		{
			this.Type = ESwitchSubLevelsType.Directly;
			this.LoadLevels = null;
			this.UnloadLevels = null;
			this.TeleportEntityId = 0;
			this.IsWaitForSwitchComplete = false;
			this.NullMask = 0;
		}
	}
}
