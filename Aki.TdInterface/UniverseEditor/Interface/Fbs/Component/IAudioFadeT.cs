using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005404 RID: 21508
	public class IAudioFadeT
	{
		// Token: 0x1700984E RID: 38990
		// (get) Token: 0x06021A2B RID: 137771 RVA: 0x004A3118 File Offset: 0x004A1318
		// (set) Token: 0x06021A2C RID: 137772 RVA: 0x004A3120 File Offset: 0x004A1320
		public EAudioFadeCurveType FadeCurve { get; set; }

		// Token: 0x1700984F RID: 38991
		// (get) Token: 0x06021A2D RID: 137773 RVA: 0x004A3129 File Offset: 0x004A1329
		// (set) Token: 0x06021A2E RID: 137774 RVA: 0x004A3131 File Offset: 0x004A1331
		public int FadeDuration { get; set; }

		// Token: 0x06021A2F RID: 137775 RVA: 0x004A313A File Offset: 0x004A133A
		public IAudioFadeT()
		{
			this.FadeCurve = EAudioFadeCurveType.Log3;
			this.FadeDuration = 0;
		}
	}
}
