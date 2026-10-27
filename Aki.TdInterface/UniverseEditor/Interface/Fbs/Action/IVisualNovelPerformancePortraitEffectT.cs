using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075BA RID: 30138
	public class IVisualNovelPerformancePortraitEffectT
	{
		// Token: 0x1700E4D2 RID: 58578
		// (get) Token: 0x06036E0A RID: 224778 RVA: 0x007731A8 File Offset: 0x007713A8
		// (set) Token: 0x06036E0B RID: 224779 RVA: 0x007731B0 File Offset: 0x007713B0
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E4D3 RID: 58579
		// (get) Token: 0x06036E0C RID: 224780 RVA: 0x007731B9 File Offset: 0x007713B9
		// (set) Token: 0x06036E0D RID: 224781 RVA: 0x007731C1 File Offset: 0x007713C1
		public float StartTime { get; set; }

		// Token: 0x1700E4D4 RID: 58580
		// (get) Token: 0x06036E0E RID: 224782 RVA: 0x007731CA File Offset: 0x007713CA
		// (set) Token: 0x06036E0F RID: 224783 RVA: 0x007731D2 File Offset: 0x007713D2
		public int WhoId { get; set; }

		// Token: 0x1700E4D5 RID: 58581
		// (get) Token: 0x06036E10 RID: 224784 RVA: 0x007731DB File Offset: 0x007713DB
		// (set) Token: 0x06036E11 RID: 224785 RVA: 0x007731E3 File Offset: 0x007713E3
		public EVisualNovelPortraitEffectType EffectType { get; set; }

		// Token: 0x1700E4D6 RID: 58582
		// (get) Token: 0x06036E12 RID: 224786 RVA: 0x007731EC File Offset: 0x007713EC
		// (set) Token: 0x06036E13 RID: 224787 RVA: 0x007731F4 File Offset: 0x007713F4
		public EVisualNovelAmplitude Amplitude { get; set; }

		// Token: 0x1700E4D7 RID: 58583
		// (get) Token: 0x06036E14 RID: 224788 RVA: 0x007731FD File Offset: 0x007713FD
		// (set) Token: 0x06036E15 RID: 224789 RVA: 0x00773205 File Offset: 0x00771405
		public byte NullMask { get; set; }

		// Token: 0x06036E16 RID: 224790 RVA: 0x0077320E File Offset: 0x0077140E
		public IVisualNovelPerformancePortraitEffectT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.WhoId = 0;
			this.EffectType = EVisualNovelPortraitEffectType.Jump;
			this.Amplitude = EVisualNovelAmplitude.Small;
			this.NullMask = 0;
		}
	}
}
