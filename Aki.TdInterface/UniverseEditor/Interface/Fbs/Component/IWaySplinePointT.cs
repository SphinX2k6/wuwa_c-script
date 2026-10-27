using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B5D RID: 23389
	public class IWaySplinePointT
	{
		// Token: 0x1700B0B7 RID: 45239
		// (get) Token: 0x0602805F RID: 163935 RVA: 0x00580D3C File Offset: 0x0057EF3C
		// (set) Token: 0x06028060 RID: 163936 RVA: 0x00580D44 File Offset: 0x0057EF44
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700B0B8 RID: 45240
		// (get) Token: 0x06028061 RID: 163937 RVA: 0x00580D4D File Offset: 0x0057EF4D
		// (set) Token: 0x06028062 RID: 163938 RVA: 0x00580D55 File Offset: 0x0057EF55
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700B0B9 RID: 45241
		// (get) Token: 0x06028063 RID: 163939 RVA: 0x00580D5E File Offset: 0x0057EF5E
		// (set) Token: 0x06028064 RID: 163940 RVA: 0x00580D66 File Offset: 0x0057EF66
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700B0BA RID: 45242
		// (get) Token: 0x06028065 RID: 163941 RVA: 0x00580D6F File Offset: 0x0057EF6F
		// (set) Token: 0x06028066 RID: 163942 RVA: 0x00580D77 File Offset: 0x0057EF77
		public ESplineLine LineType { get; set; }

		// Token: 0x1700B0BB RID: 45243
		// (get) Token: 0x06028067 RID: 163943 RVA: 0x00580D80 File Offset: 0x0057EF80
		// (set) Token: 0x06028068 RID: 163944 RVA: 0x00580D88 File Offset: 0x0057EF88
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700B0BC RID: 45244
		// (get) Token: 0x06028069 RID: 163945 RVA: 0x00580D91 File Offset: 0x0057EF91
		// (set) Token: 0x0602806A RID: 163946 RVA: 0x00580D99 File Offset: 0x0057EF99
		public TWaySplinePointTypeUnion PointType { get; set; }

		// Token: 0x0602806B RID: 163947 RVA: 0x00580DA2 File Offset: 0x0057EFA2
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
