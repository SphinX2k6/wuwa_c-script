using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004453 RID: 17491
	public class IDaemonHackCodeMatrixT
	{
		// Token: 0x17007B49 RID: 31561
		// (get) Token: 0x0601A098 RID: 106648 RVA: 0x003B895F File Offset: 0x003B6B5F
		// (set) Token: 0x0601A099 RID: 106649 RVA: 0x003B8967 File Offset: 0x003B6B67
		public int MatrixSize { get; set; }

		// Token: 0x17007B4A RID: 31562
		// (get) Token: 0x0601A09A RID: 106650 RVA: 0x003B8970 File Offset: 0x003B6B70
		// (set) Token: 0x0601A09B RID: 106651 RVA: 0x003B8978 File Offset: 0x003B6B78
		public List<IDaemonHackPresetCodeT> PresetCodes { get; set; }

		// Token: 0x0601A09C RID: 106652 RVA: 0x003B8981 File Offset: 0x003B6B81
		public IDaemonHackCodeMatrixT()
		{
			this.MatrixSize = 0;
			this.PresetCodes = null;
		}
	}
}
