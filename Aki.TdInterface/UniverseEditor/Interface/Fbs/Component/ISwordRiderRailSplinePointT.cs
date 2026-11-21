using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006024 RID: 24612
	public class ISwordRiderRailSplinePointT
	{
		// Token: 0x1700B694 RID: 46740
		// (get) Token: 0x06029827 RID: 170023 RVA: 0x005AA65D File Offset: 0x005A885D
		// (set) Token: 0x06029828 RID: 170024 RVA: 0x005AA665 File Offset: 0x005A8865
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700B695 RID: 46741
		// (get) Token: 0x06029829 RID: 170025 RVA: 0x005AA66E File Offset: 0x005A886E
		// (set) Token: 0x0602982A RID: 170026 RVA: 0x005AA676 File Offset: 0x005A8876
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700B696 RID: 46742
		// (get) Token: 0x0602982B RID: 170027 RVA: 0x005AA67F File Offset: 0x005A887F
		// (set) Token: 0x0602982C RID: 170028 RVA: 0x005AA687 File Offset: 0x005A8887
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700B697 RID: 46743
		// (get) Token: 0x0602982D RID: 170029 RVA: 0x005AA690 File Offset: 0x005A8890
		// (set) Token: 0x0602982E RID: 170030 RVA: 0x005AA698 File Offset: 0x005A8898
		public ESplineLine LineType { get; set; }

		// Token: 0x1700B698 RID: 46744
		// (get) Token: 0x0602982F RID: 170031 RVA: 0x005AA6A1 File Offset: 0x005A88A1
		// (set) Token: 0x06029830 RID: 170032 RVA: 0x005AA6A9 File Offset: 0x005A88A9
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700B699 RID: 46745
		// (get) Token: 0x06029831 RID: 170033 RVA: 0x005AA6B2 File Offset: 0x005A88B2
		// (set) Token: 0x06029832 RID: 170034 RVA: 0x005AA6BA File Offset: 0x005A88BA
		public float Radius { get; set; }

		// Token: 0x1700B69A RID: 46746
		// (get) Token: 0x06029833 RID: 170035 RVA: 0x005AA6C3 File Offset: 0x005A88C3
		// (set) Token: 0x06029834 RID: 170036 RVA: 0x005AA6CB File Offset: 0x005A88CB
		public int HalfAvailableAngle { get; set; }

		// Token: 0x1700B69B RID: 46747
		// (get) Token: 0x06029835 RID: 170037 RVA: 0x005AA6D4 File Offset: 0x005A88D4
		// (set) Token: 0x06029836 RID: 170038 RVA: 0x005AA6DC File Offset: 0x005A88DC
		public byte NullMask { get; set; }

		// Token: 0x06029837 RID: 170039 RVA: 0x005AA6E8 File Offset: 0x005A88E8
		public ISwordRiderRailSplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.Radius = 0f;
			this.HalfAvailableAngle = 0;
			this.NullMask = 0;
		}
	}
}
