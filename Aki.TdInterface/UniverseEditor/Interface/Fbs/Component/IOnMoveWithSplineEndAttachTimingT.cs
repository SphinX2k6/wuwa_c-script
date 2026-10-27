using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A2 RID: 22178
	public class IOnMoveWithSplineEndAttachTimingT
	{
		// Token: 0x1700A4EF RID: 42223
		// (get) Token: 0x06025040 RID: 151616 RVA: 0x0051C96C File Offset: 0x0051AB6C
		// (set) Token: 0x06025041 RID: 151617 RVA: 0x0051C974 File Offset: 0x0051AB74
		public EAttachTimingType Type { get; set; }

		// Token: 0x1700A4F0 RID: 42224
		// (get) Token: 0x06025042 RID: 151618 RVA: 0x0051C97D File Offset: 0x0051AB7D
		// (set) Token: 0x06025043 RID: 151619 RVA: 0x0051C985 File Offset: 0x0051AB85
		public int SplineEntityId { get; set; }

		// Token: 0x06025044 RID: 151620 RVA: 0x0051C98E File Offset: 0x0051AB8E
		public IOnMoveWithSplineEndAttachTimingT()
		{
			this.Type = EAttachTimingType.Default;
			this.SplineEntityId = 0;
		}
	}
}
