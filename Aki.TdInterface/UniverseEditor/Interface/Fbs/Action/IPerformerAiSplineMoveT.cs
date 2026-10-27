using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C8E RID: 27790
	public class IPerformerAiSplineMoveT
	{
		// Token: 0x1700CEF2 RID: 52978
		// (get) Token: 0x06030F89 RID: 200585 RVA: 0x006A6094 File Offset: 0x006A4294
		// (set) Token: 0x06030F8A RID: 200586 RVA: 0x006A609C File Offset: 0x006A429C
		public int SplineEntityId { get; set; }

		// Token: 0x1700CEF3 RID: 52979
		// (get) Token: 0x06030F8B RID: 200587 RVA: 0x006A60A5 File Offset: 0x006A42A5
		// (set) Token: 0x06030F8C RID: 200588 RVA: 0x006A60AD File Offset: 0x006A42AD
		public byte NullMask { get; set; }

		// Token: 0x06030F8D RID: 200589 RVA: 0x006A60B6 File Offset: 0x006A42B6
		public IPerformerAiSplineMoveT()
		{
			this.SplineEntityId = 0;
			this.NullMask = 0;
		}
	}
}
