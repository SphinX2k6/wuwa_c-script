using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200739B RID: 29595
	public class IOpenSplineMoveT
	{
		// Token: 0x1700D930 RID: 55600
		// (get) Token: 0x06033B51 RID: 211793 RVA: 0x006F919F File Offset: 0x006F739F
		// (set) Token: 0x06033B52 RID: 211794 RVA: 0x006F91A7 File Offset: 0x006F73A7
		public ESplineMoveConfigType Type { get; set; }

		// Token: 0x1700D931 RID: 55601
		// (get) Token: 0x06033B53 RID: 211795 RVA: 0x006F91B0 File Offset: 0x006F73B0
		// (set) Token: 0x06033B54 RID: 211796 RVA: 0x006F91B8 File Offset: 0x006F73B8
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700D932 RID: 55602
		// (get) Token: 0x06033B55 RID: 211797 RVA: 0x006F91C1 File Offset: 0x006F73C1
		// (set) Token: 0x06033B56 RID: 211798 RVA: 0x006F91C9 File Offset: 0x006F73C9
		public int SplineEntityId { get; set; }

		// Token: 0x1700D933 RID: 55603
		// (get) Token: 0x06033B57 RID: 211799 RVA: 0x006F91D2 File Offset: 0x006F73D2
		// (set) Token: 0x06033B58 RID: 211800 RVA: 0x006F91DA File Offset: 0x006F73DA
		public TSplineMovePatternUnion Pattern { get; set; }

		// Token: 0x06033B59 RID: 211801 RVA: 0x006F91E3 File Offset: 0x006F73E3
		public IOpenSplineMoveT()
		{
			this.Type = ESplineMoveConfigType.Open;
			this.Target = null;
			this.SplineEntityId = 0;
			this.Pattern = null;
		}
	}
}
