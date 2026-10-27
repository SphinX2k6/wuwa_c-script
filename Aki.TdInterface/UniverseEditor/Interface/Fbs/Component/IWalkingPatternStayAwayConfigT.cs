using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B4B RID: 23371
	public class IWalkingPatternStayAwayConfigT
	{
		// Token: 0x1700B078 RID: 45176
		// (get) Token: 0x06027F6B RID: 163691 RVA: 0x0057E9D6 File Offset: 0x0057CBD6
		// (set) Token: 0x06027F6C RID: 163692 RVA: 0x0057E9DE File Offset: 0x0057CBDE
		public int SplineDistance { get; set; }

		// Token: 0x1700B079 RID: 45177
		// (get) Token: 0x06027F6D RID: 163693 RVA: 0x0057E9E7 File Offset: 0x0057CBE7
		// (set) Token: 0x06027F6E RID: 163694 RVA: 0x0057E9EF File Offset: 0x0057CBEF
		public int StayAwayTime { get; set; }

		// Token: 0x1700B07A RID: 45178
		// (get) Token: 0x06027F6F RID: 163695 RVA: 0x0057E9F8 File Offset: 0x0057CBF8
		// (set) Token: 0x06027F70 RID: 163696 RVA: 0x0057EA00 File Offset: 0x0057CC00
		public byte NullMask { get; set; }

		// Token: 0x06027F71 RID: 163697 RVA: 0x0057EA09 File Offset: 0x0057CC09
		public IWalkingPatternStayAwayConfigT()
		{
			this.SplineDistance = 0;
			this.StayAwayTime = 0;
			this.NullMask = 0;
		}
	}
}
