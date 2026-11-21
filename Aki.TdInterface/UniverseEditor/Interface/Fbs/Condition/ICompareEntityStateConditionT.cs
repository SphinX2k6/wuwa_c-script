using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005086 RID: 20614
	public class ICompareEntityStateConditionT
	{
		// Token: 0x17009392 RID: 37778
		// (get) Token: 0x060203F0 RID: 132080 RVA: 0x00478037 File Offset: 0x00476237
		// (set) Token: 0x060203F1 RID: 132081 RVA: 0x0047803F File Offset: 0x0047623F
		public ECondition Type { get; set; }

		// Token: 0x17009393 RID: 37779
		// (get) Token: 0x060203F2 RID: 132082 RVA: 0x00478048 File Offset: 0x00476248
		// (set) Token: 0x060203F3 RID: 132083 RVA: 0x00478050 File Offset: 0x00476250
		public int EntityId { get; set; }

		// Token: 0x17009394 RID: 37780
		// (get) Token: 0x060203F4 RID: 132084 RVA: 0x00478059 File Offset: 0x00476259
		// (set) Token: 0x060203F5 RID: 132085 RVA: 0x00478061 File Offset: 0x00476261
		public ECompare Compare { get; set; }

		// Token: 0x17009395 RID: 37781
		// (get) Token: 0x060203F6 RID: 132086 RVA: 0x0047806A File Offset: 0x0047626A
		// (set) Token: 0x060203F7 RID: 132087 RVA: 0x00478072 File Offset: 0x00476272
		public string State { get; set; }

		// Token: 0x060203F8 RID: 132088 RVA: 0x0047807B File Offset: 0x0047627B
		public ICompareEntityStateConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.Compare = ECompare.Eq;
			this.State = null;
		}
	}
}
