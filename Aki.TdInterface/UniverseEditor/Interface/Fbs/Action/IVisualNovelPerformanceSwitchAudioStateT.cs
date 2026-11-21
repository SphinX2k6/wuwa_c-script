using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DBF RID: 32191
	public class IVisualNovelPerformanceSwitchAudioStateT
	{
		// Token: 0x1700F129 RID: 61737
		// (get) Token: 0x0603A2C1 RID: 238273 RVA: 0x007D78B7 File Offset: 0x007D5AB7
		// (set) Token: 0x0603A2C2 RID: 238274 RVA: 0x007D78BF File Offset: 0x007D5ABF
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F12A RID: 61738
		// (get) Token: 0x0603A2C3 RID: 238275 RVA: 0x007D78C8 File Offset: 0x007D5AC8
		// (set) Token: 0x0603A2C4 RID: 238276 RVA: 0x007D78D0 File Offset: 0x007D5AD0
		public float StartTime { get; set; }

		// Token: 0x1700F12B RID: 61739
		// (get) Token: 0x0603A2C5 RID: 238277 RVA: 0x007D78D9 File Offset: 0x007D5AD9
		// (set) Token: 0x0603A2C6 RID: 238278 RVA: 0x007D78E1 File Offset: 0x007D5AE1
		public IAudioStateT AudioState { get; set; }

		// Token: 0x1700F12C RID: 61740
		// (get) Token: 0x0603A2C7 RID: 238279 RVA: 0x007D78EA File Offset: 0x007D5AEA
		// (set) Token: 0x0603A2C8 RID: 238280 RVA: 0x007D78F2 File Offset: 0x007D5AF2
		public byte NullMask { get; set; }

		// Token: 0x0603A2C9 RID: 238281 RVA: 0x007D78FB File Offset: 0x007D5AFB
		public IVisualNovelPerformanceSwitchAudioStateT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.AudioState = null;
			this.NullMask = 0;
		}
	}
}
