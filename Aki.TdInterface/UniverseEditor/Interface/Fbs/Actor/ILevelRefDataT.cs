using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x0200653E RID: 25918
	public class ILevelRefDataT
	{
		// Token: 0x1700BF33 RID: 48947
		// (get) Token: 0x0602C2F2 RID: 180978 RVA: 0x006046D8 File Offset: 0x006028D8
		// (set) Token: 0x0602C2F3 RID: 180979 RVA: 0x006046E0 File Offset: 0x006028E0
		public string LevelPath { get; set; }

		// Token: 0x1700BF34 RID: 48948
		// (get) Token: 0x0602C2F4 RID: 180980 RVA: 0x006046E9 File Offset: 0x006028E9
		// (set) Token: 0x0602C2F5 RID: 180981 RVA: 0x006046F1 File Offset: 0x006028F1
		public List<IStreamingGroupT> StreamingGroups { get; set; }

		// Token: 0x0602C2F6 RID: 180982 RVA: 0x006046FA File Offset: 0x006028FA
		public ILevelRefDataT()
		{
			this.LevelPath = null;
			this.StreamingGroups = null;
		}
	}
}
