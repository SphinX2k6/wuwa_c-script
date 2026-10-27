using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D7 RID: 22743
	public class ISceneItemSequenceEventDataT
	{
		// Token: 0x1700AA54 RID: 43604
		// (get) Token: 0x06026650 RID: 157264 RVA: 0x0054A93E File Offset: 0x00548B3E
		// (set) Token: 0x06026651 RID: 157265 RVA: 0x0054A946 File Offset: 0x00548B46
		public string SeqGuid { get; set; }

		// Token: 0x1700AA55 RID: 43605
		// (get) Token: 0x06026652 RID: 157266 RVA: 0x0054A94F File Offset: 0x00548B4F
		// (set) Token: 0x06026653 RID: 157267 RVA: 0x0054A957 File Offset: 0x00548B57
		public string SeqPath { get; set; }

		// Token: 0x1700AA56 RID: 43606
		// (get) Token: 0x06026654 RID: 157268 RVA: 0x0054A960 File Offset: 0x00548B60
		// (set) Token: 0x06026655 RID: 157269 RVA: 0x0054A968 File Offset: 0x00548B68
		public List<TSceneItemSeqEventCbTypeUnion> EventCallbacks { get; set; }

		// Token: 0x06026656 RID: 157270 RVA: 0x0054A971 File Offset: 0x00548B71
		public ISceneItemSequenceEventDataT()
		{
			this.SeqGuid = null;
			this.SeqPath = null;
			this.EventCallbacks = null;
		}
	}
}
