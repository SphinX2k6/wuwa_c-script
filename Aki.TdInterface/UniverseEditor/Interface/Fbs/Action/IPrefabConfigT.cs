using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007502 RID: 29954
	public class IPrefabConfigT
	{
		// Token: 0x1700DC7A RID: 56442
		// (get) Token: 0x0603487C RID: 215164 RVA: 0x007122F0 File Offset: 0x007104F0
		// (set) Token: 0x0603487D RID: 215165 RVA: 0x007122F8 File Offset: 0x007104F8
		public ECreatePrefabType Type { get; set; }

		// Token: 0x1700DC7B RID: 56443
		// (get) Token: 0x0603487E RID: 215166 RVA: 0x00712301 File Offset: 0x00710501
		// (set) Token: 0x0603487F RID: 215167 RVA: 0x00712309 File Offset: 0x00710509
		public int PrefabId { get; set; }

		// Token: 0x06034880 RID: 215168 RVA: 0x00712312 File Offset: 0x00710512
		public IPrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
			this.PrefabId = 0;
		}
	}
}
