using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200759C RID: 30108
	public class IVisualNovelPerformanceBaseT
	{
		// Token: 0x1700E458 RID: 58456
		// (get) Token: 0x06036C70 RID: 224368 RVA: 0x0076F90E File Offset: 0x0076DB0E
		// (set) Token: 0x06036C71 RID: 224369 RVA: 0x0076F916 File Offset: 0x0076DB16
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E459 RID: 58457
		// (get) Token: 0x06036C72 RID: 224370 RVA: 0x0076F91F File Offset: 0x0076DB1F
		// (set) Token: 0x06036C73 RID: 224371 RVA: 0x0076F927 File Offset: 0x0076DB27
		public float StartTime { get; set; }

		// Token: 0x1700E45A RID: 58458
		// (get) Token: 0x06036C74 RID: 224372 RVA: 0x0076F930 File Offset: 0x0076DB30
		// (set) Token: 0x06036C75 RID: 224373 RVA: 0x0076F938 File Offset: 0x0076DB38
		public byte NullMask { get; set; }

		// Token: 0x06036C76 RID: 224374 RVA: 0x0076F941 File Offset: 0x0076DB41
		public IVisualNovelPerformanceBaseT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.NullMask = 0;
		}
	}
}
