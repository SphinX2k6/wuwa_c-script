using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200433E RID: 17214
	public class ILevelPlayRecallConfigT
	{
		// Token: 0x170075CF RID: 30159
		// (get) Token: 0x060183A3 RID: 99235 RVA: 0x00374107 File Offset: 0x00372307
		// (set) Token: 0x060183A4 RID: 99236 RVA: 0x0037410F File Offset: 0x0037230F
		public int RecallId { get; set; }

		// Token: 0x170075D0 RID: 30160
		// (get) Token: 0x060183A5 RID: 99237 RVA: 0x00374118 File Offset: 0x00372318
		// (set) Token: 0x060183A6 RID: 99238 RVA: 0x00374120 File Offset: 0x00372320
		public List<int> RecallEntityList { get; set; }

		// Token: 0x060183A7 RID: 99239 RVA: 0x00374129 File Offset: 0x00372329
		public ILevelPlayRecallConfigT()
		{
			this.RecallId = 0;
			this.RecallEntityList = null;
		}
	}
}
