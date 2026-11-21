using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006848 RID: 26696
	public class IAxisLockScreenConfigT
	{
		// Token: 0x1700C44A RID: 50250
		// (get) Token: 0x0602DA1A RID: 186906 RVA: 0x0063E362 File Offset: 0x0063C562
		// (set) Token: 0x0602DA1B RID: 186907 RVA: 0x0063E36A File Offset: 0x0063C56A
		public float TriggerAngle { get; set; }

		// Token: 0x1700C44B RID: 50251
		// (get) Token: 0x0602DA1C RID: 186908 RVA: 0x0063E373 File Offset: 0x0063C573
		// (set) Token: 0x0602DA1D RID: 186909 RVA: 0x0063E37B File Offset: 0x0063C57B
		public float FadeInTime { get; set; }

		// Token: 0x1700C44C RID: 50252
		// (get) Token: 0x0602DA1E RID: 186910 RVA: 0x0063E384 File Offset: 0x0063C584
		// (set) Token: 0x0602DA1F RID: 186911 RVA: 0x0063E38C File Offset: 0x0063C58C
		public float FadeOutTime { get; set; }

		// Token: 0x0602DA20 RID: 186912 RVA: 0x0063E395 File Offset: 0x0063C595
		public IAxisLockScreenConfigT()
		{
			this.TriggerAngle = 0f;
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
		}
	}
}
