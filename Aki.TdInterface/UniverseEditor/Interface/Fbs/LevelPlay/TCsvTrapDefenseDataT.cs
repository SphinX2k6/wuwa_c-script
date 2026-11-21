using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A59 RID: 19033
	public class TCsvTrapDefenseDataT
	{
		// Token: 0x17008590 RID: 34192
		// (get) Token: 0x0601C9CA RID: 117194 RVA: 0x00409ADB File Offset: 0x00407CDB
		// (set) Token: 0x0601C9CB RID: 117195 RVA: 0x00409AE3 File Offset: 0x00407CE3
		public int Id { get; set; }

		// Token: 0x17008591 RID: 34193
		// (get) Token: 0x0601C9CC RID: 117196 RVA: 0x00409AEC File Offset: 0x00407CEC
		// (set) Token: 0x0601C9CD RID: 117197 RVA: 0x00409AF4 File Offset: 0x00407CF4
		public List<ITrapDefenseBatchT> Batches { get; set; }

		// Token: 0x0601C9CE RID: 117198 RVA: 0x00409AFD File Offset: 0x00407CFD
		public TCsvTrapDefenseDataT()
		{
			this.Id = 0;
			this.Batches = null;
		}
	}
}
