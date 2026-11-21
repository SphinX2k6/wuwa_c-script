using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EE4 RID: 24292
	public class ISceneItemSequenceEventDataT
	{
		// Token: 0x1700B384 RID: 45956
		// (get) Token: 0x06028BB2 RID: 166834 RVA: 0x0059148A File Offset: 0x0058F68A
		// (set) Token: 0x06028BB3 RID: 166835 RVA: 0x00591492 File Offset: 0x0058F692
		public string SeqGuid { get; set; }

		// Token: 0x1700B385 RID: 45957
		// (get) Token: 0x06028BB4 RID: 166836 RVA: 0x0059149B File Offset: 0x0058F69B
		// (set) Token: 0x06028BB5 RID: 166837 RVA: 0x005914A3 File Offset: 0x0058F6A3
		public string SeqPath { get; set; }

		// Token: 0x1700B386 RID: 45958
		// (get) Token: 0x06028BB6 RID: 166838 RVA: 0x005914AC File Offset: 0x0058F6AC
		// (set) Token: 0x06028BB7 RID: 166839 RVA: 0x005914B4 File Offset: 0x0058F6B4
		public List<TSceneItemSeqEventCbTypeUnion> EventCallbacks { get; set; }

		// Token: 0x06028BB8 RID: 166840 RVA: 0x005914BD File Offset: 0x0058F6BD
		public ISceneItemSequenceEventDataT()
		{
			this.SeqGuid = null;
			this.SeqPath = null;
			this.EventCallbacks = null;
		}
	}
}
