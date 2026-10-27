using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005978 RID: 22904
	public class ISpeedCurveMotionT
	{
		// Token: 0x1700ABDB RID: 43995
		// (get) Token: 0x06026C4F RID: 158799 RVA: 0x005563A1 File Offset: 0x005545A1
		// (set) Token: 0x06026C50 RID: 158800 RVA: 0x005563A9 File Offset: 0x005545A9
		public string SpeedCurve { get; set; }

		// Token: 0x06026C51 RID: 158801 RVA: 0x005563B2 File Offset: 0x005545B2
		public ISpeedCurveMotionT()
		{
			this.SpeedCurve = null;
		}
	}
}
