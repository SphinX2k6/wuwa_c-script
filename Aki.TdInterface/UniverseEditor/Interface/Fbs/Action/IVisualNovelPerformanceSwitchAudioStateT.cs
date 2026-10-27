using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C6 RID: 30150
	public class IVisualNovelPerformanceSwitchAudioStateT
	{
		// Token: 0x1700E4FC RID: 58620
		// (get) Token: 0x06036E92 RID: 224914 RVA: 0x0077412F File Offset: 0x0077232F
		// (set) Token: 0x06036E93 RID: 224915 RVA: 0x00774137 File Offset: 0x00772337
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E4FD RID: 58621
		// (get) Token: 0x06036E94 RID: 224916 RVA: 0x00774140 File Offset: 0x00772340
		// (set) Token: 0x06036E95 RID: 224917 RVA: 0x00774148 File Offset: 0x00772348
		public float StartTime { get; set; }

		// Token: 0x1700E4FE RID: 58622
		// (get) Token: 0x06036E96 RID: 224918 RVA: 0x00774151 File Offset: 0x00772351
		// (set) Token: 0x06036E97 RID: 224919 RVA: 0x00774159 File Offset: 0x00772359
		public IAudioStateT AudioState { get; set; }

		// Token: 0x1700E4FF RID: 58623
		// (get) Token: 0x06036E98 RID: 224920 RVA: 0x00774162 File Offset: 0x00772362
		// (set) Token: 0x06036E99 RID: 224921 RVA: 0x0077416A File Offset: 0x0077236A
		public byte NullMask { get; set; }

		// Token: 0x06036E9A RID: 224922 RVA: 0x00774173 File Offset: 0x00772373
		public IVisualNovelPerformanceSwitchAudioStateT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.AudioState = null;
			this.NullMask = 0;
		}
	}
}
