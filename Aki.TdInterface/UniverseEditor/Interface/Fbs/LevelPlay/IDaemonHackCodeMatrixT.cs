using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048BB RID: 18619
	public class IDaemonHackCodeMatrixT
	{
		// Token: 0x17008188 RID: 33160
		// (get) Token: 0x0601B869 RID: 112745 RVA: 0x003E4B6B File Offset: 0x003E2D6B
		// (set) Token: 0x0601B86A RID: 112746 RVA: 0x003E4B73 File Offset: 0x003E2D73
		public int MatrixSize { get; set; }

		// Token: 0x17008189 RID: 33161
		// (get) Token: 0x0601B86B RID: 112747 RVA: 0x003E4B7C File Offset: 0x003E2D7C
		// (set) Token: 0x0601B86C RID: 112748 RVA: 0x003E4B84 File Offset: 0x003E2D84
		public List<IDaemonHackPresetCodeT> PresetCodes { get; set; }

		// Token: 0x0601B86D RID: 112749 RVA: 0x003E4B8D File Offset: 0x003E2D8D
		public IDaemonHackCodeMatrixT()
		{
			this.MatrixSize = 0;
			this.PresetCodes = null;
		}
	}
}
