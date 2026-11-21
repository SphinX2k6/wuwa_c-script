using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F0B RID: 24331
	public class ISequenceTrackControlT
	{
		// Token: 0x1700B3F8 RID: 46072
		// (get) Token: 0x06028D6C RID: 167276 RVA: 0x00594DA2 File Offset: 0x00592FA2
		// (set) Token: 0x06028D6D RID: 167277 RVA: 0x00594DAA File Offset: 0x00592FAA
		public ETrackControlMode Type { get; set; }

		// Token: 0x1700B3F9 RID: 46073
		// (get) Token: 0x06028D6E RID: 167278 RVA: 0x00594DB3 File Offset: 0x00592FB3
		// (set) Token: 0x06028D6F RID: 167279 RVA: 0x00594DBB File Offset: 0x00592FBB
		public string Sequence { get; set; }

		// Token: 0x1700B3FA RID: 46074
		// (get) Token: 0x06028D70 RID: 167280 RVA: 0x00594DC4 File Offset: 0x00592FC4
		// (set) Token: 0x06028D71 RID: 167281 RVA: 0x00594DCC File Offset: 0x00592FCC
		public List<ISequenceTrackControlPointT> ControlPoints { get; set; }

		// Token: 0x06028D72 RID: 167282 RVA: 0x00594DD5 File Offset: 0x00592FD5
		public ISequenceTrackControlT()
		{
			this.Type = ETrackControlMode.Sequence;
			this.Sequence = null;
			this.ControlPoints = null;
		}
	}
}
