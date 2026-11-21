using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02006541 RID: 25921
	public class ILevelRefListT
	{
		// Token: 0x1700BF37 RID: 48951
		// (get) Token: 0x0602C30C RID: 181004 RVA: 0x00604A21 File Offset: 0x00602C21
		// (set) Token: 0x0602C30D RID: 181005 RVA: 0x00604A29 File Offset: 0x00602C29
		public List<ILevelRefDataT> LevelRefList { get; set; }

		// Token: 0x0602C30E RID: 181006 RVA: 0x00604A32 File Offset: 0x00602C32
		public ILevelRefListT()
		{
			this.LevelRefList = null;
		}
	}
}
