using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D60 RID: 28000
	public class IPlotVoiceFadeOutOnInterruptT
	{
		// Token: 0x1700D0CD RID: 53453
		// (get) Token: 0x06031708 RID: 202504 RVA: 0x006B410E File Offset: 0x006B230E
		// (set) Token: 0x06031709 RID: 202505 RVA: 0x006B4116 File Offset: 0x006B2316
		public float FadeDuration { get; set; }

		// Token: 0x1700D0CE RID: 53454
		// (get) Token: 0x0603170A RID: 202506 RVA: 0x006B411F File Offset: 0x006B231F
		// (set) Token: 0x0603170B RID: 202507 RVA: 0x006B4127 File Offset: 0x006B2327
		public EAudioFadeCurveType FadeCurve { get; set; }

		// Token: 0x1700D0CF RID: 53455
		// (get) Token: 0x0603170C RID: 202508 RVA: 0x006B4130 File Offset: 0x006B2330
		// (set) Token: 0x0603170D RID: 202509 RVA: 0x006B4138 File Offset: 0x006B2338
		public byte NullMask { get; set; }

		// Token: 0x0603170E RID: 202510 RVA: 0x006B4141 File Offset: 0x006B2341
		public IPlotVoiceFadeOutOnInterruptT()
		{
			this.FadeDuration = 0f;
			this.FadeCurve = EAudioFadeCurveType.Log3;
			this.NullMask = 0;
		}
	}
}
