using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061DA RID: 25050
	public class IAxisLockScreenConfigT
	{
		// Token: 0x1700BAC7 RID: 47815
		// (get) Token: 0x0602B2D3 RID: 176851 RVA: 0x005F38EE File Offset: 0x005F1AEE
		// (set) Token: 0x0602B2D4 RID: 176852 RVA: 0x005F38F6 File Offset: 0x005F1AF6
		public float TriggerAngle { get; set; }

		// Token: 0x1700BAC8 RID: 47816
		// (get) Token: 0x0602B2D5 RID: 176853 RVA: 0x005F38FF File Offset: 0x005F1AFF
		// (set) Token: 0x0602B2D6 RID: 176854 RVA: 0x005F3907 File Offset: 0x005F1B07
		public float FadeInTime { get; set; }

		// Token: 0x1700BAC9 RID: 47817
		// (get) Token: 0x0602B2D7 RID: 176855 RVA: 0x005F3910 File Offset: 0x005F1B10
		// (set) Token: 0x0602B2D8 RID: 176856 RVA: 0x005F3918 File Offset: 0x005F1B18
		public float FadeOutTime { get; set; }

		// Token: 0x0602B2D9 RID: 176857 RVA: 0x005F3921 File Offset: 0x005F1B21
		public IAxisLockScreenConfigT()
		{
			this.TriggerAngle = 0f;
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
		}
	}
}
