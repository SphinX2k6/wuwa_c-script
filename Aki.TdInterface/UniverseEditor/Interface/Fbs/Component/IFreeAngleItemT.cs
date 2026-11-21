using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200583F RID: 22591
	public class IFreeAngleItemT
	{
		// Token: 0x1700A39B RID: 41883
		// (get) Token: 0x06024959 RID: 149849 RVA: 0x00506D20 File Offset: 0x00504F20
		// (set) Token: 0x0602495A RID: 149850 RVA: 0x00506D28 File Offset: 0x00504F28
		public int InitAngle { get; set; }

		// Token: 0x1700A39C RID: 41884
		// (get) Token: 0x0602495B RID: 149851 RVA: 0x00506D31 File Offset: 0x00504F31
		// (set) Token: 0x0602495C RID: 149852 RVA: 0x00506D39 File Offset: 0x00504F39
		public int TargetAngle { get; set; }

		// Token: 0x0602495D RID: 149853 RVA: 0x00506D42 File Offset: 0x00504F42
		public IFreeAngleItemT()
		{
			this.InitAngle = 0;
			this.TargetAngle = 0;
		}
	}
}
