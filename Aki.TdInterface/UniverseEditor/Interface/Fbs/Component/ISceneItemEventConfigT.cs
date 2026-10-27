using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058BF RID: 22719
	public class ISceneItemEventConfigT
	{
		// Token: 0x1700AA1C RID: 43548
		// (get) Token: 0x06026568 RID: 157032 RVA: 0x00548A9A File Offset: 0x00546C9A
		// (set) Token: 0x06026569 RID: 157033 RVA: 0x00548AA2 File Offset: 0x00546CA2
		public string EntityStateTagName { get; set; }

		// Token: 0x1700AA1D RID: 43549
		// (get) Token: 0x0602656A RID: 157034 RVA: 0x00548AAB File Offset: 0x00546CAB
		// (set) Token: 0x0602656B RID: 157035 RVA: 0x00548AB3 File Offset: 0x00546CB3
		public List<ISceneItemSequenceEventDataT> SequenceEvents { get; set; }

		// Token: 0x1700AA1E RID: 43550
		// (get) Token: 0x0602656C RID: 157036 RVA: 0x00548ABC File Offset: 0x00546CBC
		// (set) Token: 0x0602656D RID: 157037 RVA: 0x00548AC4 File Offset: 0x00546CC4
		public byte NullMask { get; set; }

		// Token: 0x0602656E RID: 157038 RVA: 0x00548ACD File Offset: 0x00546CCD
		public ISceneItemEventConfigT()
		{
			this.EntityStateTagName = null;
			this.SequenceEvents = null;
			this.NullMask = 0;
		}
	}
}
