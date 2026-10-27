using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A30 RID: 27184
	public class ILinearOverRangeCameraShakeT
	{
		// Token: 0x1700C9A2 RID: 51618
		// (get) Token: 0x0602F92C RID: 194860 RVA: 0x00679CEC File Offset: 0x00677EEC
		// (set) Token: 0x0602F92D RID: 194861 RVA: 0x00679CF4 File Offset: 0x00677EF4
		public ECameraShakeType Type { get; set; }

		// Token: 0x1700C9A3 RID: 51619
		// (get) Token: 0x0602F92E RID: 194862 RVA: 0x00679CFD File Offset: 0x00677EFD
		// (set) Token: 0x0602F92F RID: 194863 RVA: 0x00679D05 File Offset: 0x00677F05
		public int CenterEntityId { get; set; }

		// Token: 0x1700C9A4 RID: 51620
		// (get) Token: 0x0602F930 RID: 194864 RVA: 0x00679D0E File Offset: 0x00677F0E
		// (set) Token: 0x0602F931 RID: 194865 RVA: 0x00679D16 File Offset: 0x00677F16
		public int MinRange { get; set; }

		// Token: 0x1700C9A5 RID: 51621
		// (get) Token: 0x0602F932 RID: 194866 RVA: 0x00679D1F File Offset: 0x00677F1F
		// (set) Token: 0x0602F933 RID: 194867 RVA: 0x00679D27 File Offset: 0x00677F27
		public int MaxRange { get; set; }

		// Token: 0x0602F934 RID: 194868 RVA: 0x00679D30 File Offset: 0x00677F30
		public ILinearOverRangeCameraShakeT()
		{
			this.Type = ECameraShakeType.Constant;
			this.CenterEntityId = 0;
			this.MinRange = 0;
			this.MaxRange = 0;
		}
	}
}
