using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F85 RID: 24453
	public class ISpeedCurveMotionT
	{
		// Token: 0x1700B50F RID: 46351
		// (get) Token: 0x060291B9 RID: 168377 RVA: 0x0059D00D File Offset: 0x0059B20D
		// (set) Token: 0x060291BA RID: 168378 RVA: 0x0059D015 File Offset: 0x0059B215
		public string SpeedCurve { get; set; }

		// Token: 0x060291BB RID: 168379 RVA: 0x0059D01E File Offset: 0x0059B21E
		public ISpeedCurveMotionT()
		{
			this.SpeedCurve = null;
		}
	}
}
