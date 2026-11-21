using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DB9 RID: 32185
	public class IVisualNovelPerformanceSendAudioEventT
	{
		// Token: 0x1700F114 RID: 61716
		// (get) Token: 0x0603A27F RID: 238207 RVA: 0x007D70ED File Offset: 0x007D52ED
		// (set) Token: 0x0603A280 RID: 238208 RVA: 0x007D70F5 File Offset: 0x007D52F5
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F115 RID: 61717
		// (get) Token: 0x0603A281 RID: 238209 RVA: 0x007D70FE File Offset: 0x007D52FE
		// (set) Token: 0x0603A282 RID: 238210 RVA: 0x007D7106 File Offset: 0x007D5306
		public float StartTime { get; set; }

		// Token: 0x1700F116 RID: 61718
		// (get) Token: 0x0603A283 RID: 238211 RVA: 0x007D710F File Offset: 0x007D530F
		// (set) Token: 0x0603A284 RID: 238212 RVA: 0x007D7117 File Offset: 0x007D5317
		public string AudioEvent { get; set; }

		// Token: 0x1700F117 RID: 61719
		// (get) Token: 0x0603A285 RID: 238213 RVA: 0x007D7120 File Offset: 0x007D5320
		// (set) Token: 0x0603A286 RID: 238214 RVA: 0x007D7128 File Offset: 0x007D5328
		public float EndFadeOutTime { get; set; }

		// Token: 0x1700F118 RID: 61720
		// (get) Token: 0x0603A287 RID: 238215 RVA: 0x007D7131 File Offset: 0x007D5331
		// (set) Token: 0x0603A288 RID: 238216 RVA: 0x007D7139 File Offset: 0x007D5339
		public bool IsNotCountTimeAndNotInterrupted { get; set; }

		// Token: 0x1700F119 RID: 61721
		// (get) Token: 0x0603A289 RID: 238217 RVA: 0x007D7142 File Offset: 0x007D5342
		// (set) Token: 0x0603A28A RID: 238218 RVA: 0x007D714A File Offset: 0x007D534A
		public bool SkipOnUltraFastForward { get; set; }

		// Token: 0x1700F11A RID: 61722
		// (get) Token: 0x0603A28B RID: 238219 RVA: 0x007D7153 File Offset: 0x007D5353
		// (set) Token: 0x0603A28C RID: 238220 RVA: 0x007D715B File Offset: 0x007D535B
		public byte NullMask { get; set; }

		// Token: 0x0603A28D RID: 238221 RVA: 0x007D7164 File Offset: 0x007D5364
		public IVisualNovelPerformanceSendAudioEventT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.AudioEvent = null;
			this.EndFadeOutTime = 0f;
			this.IsNotCountTimeAndNotInterrupted = false;
			this.SkipOnUltraFastForward = false;
			this.NullMask = 0;
		}
	}
}
