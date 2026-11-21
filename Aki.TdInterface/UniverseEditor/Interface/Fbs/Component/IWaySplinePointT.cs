using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006173 RID: 24947
	public class IWaySplinePointT
	{
		// Token: 0x1700B9FF RID: 47615
		// (get) Token: 0x0602A623 RID: 173603 RVA: 0x005C87CC File Offset: 0x005C69CC
		// (set) Token: 0x0602A624 RID: 173604 RVA: 0x005C87D4 File Offset: 0x005C69D4
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700BA00 RID: 47616
		// (get) Token: 0x0602A625 RID: 173605 RVA: 0x005C87DD File Offset: 0x005C69DD
		// (set) Token: 0x0602A626 RID: 173606 RVA: 0x005C87E5 File Offset: 0x005C69E5
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700BA01 RID: 47617
		// (get) Token: 0x0602A627 RID: 173607 RVA: 0x005C87EE File Offset: 0x005C69EE
		// (set) Token: 0x0602A628 RID: 173608 RVA: 0x005C87F6 File Offset: 0x005C69F6
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700BA02 RID: 47618
		// (get) Token: 0x0602A629 RID: 173609 RVA: 0x005C87FF File Offset: 0x005C69FF
		// (set) Token: 0x0602A62A RID: 173610 RVA: 0x005C8807 File Offset: 0x005C6A07
		public ESplineLine LineType { get; set; }

		// Token: 0x1700BA03 RID: 47619
		// (get) Token: 0x0602A62B RID: 173611 RVA: 0x005C8810 File Offset: 0x005C6A10
		// (set) Token: 0x0602A62C RID: 173612 RVA: 0x005C8818 File Offset: 0x005C6A18
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700BA04 RID: 47620
		// (get) Token: 0x0602A62D RID: 173613 RVA: 0x005C8821 File Offset: 0x005C6A21
		// (set) Token: 0x0602A62E RID: 173614 RVA: 0x005C8829 File Offset: 0x005C6A29
		public TWaySplinePointTypeUnion PointType { get; set; }

		// Token: 0x0602A62F RID: 173615 RVA: 0x005C8832 File Offset: 0x005C6A32
		public IWaySplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.PointType = null;
		}
	}
}
