using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079F0 RID: 31216
	public class ISubScreenModeInitT
	{
		// Token: 0x1700E4D2 RID: 58578
		// (get) Token: 0x06037018 RID: 225304 RVA: 0x0075A81F File Offset: 0x00758A1F
		// (set) Token: 0x06037019 RID: 225305 RVA: 0x0075A827 File Offset: 0x00758A27
		public ESubScreenOperationType Type { get; set; }

		// Token: 0x1700E4D3 RID: 58579
		// (get) Token: 0x0603701A RID: 225306 RVA: 0x0075A830 File Offset: 0x00758A30
		// (set) Token: 0x0603701B RID: 225307 RVA: 0x0075A838 File Offset: 0x00758A38
		public List<TSubScreenInitDataUnion> InitConfigs { get; set; }

		// Token: 0x0603701C RID: 225308 RVA: 0x0075A841 File Offset: 0x00758A41
		public ISubScreenModeInitT()
		{
			this.Type = ESubScreenOperationType.Init;
			this.InitConfigs = null;
		}
	}
}
