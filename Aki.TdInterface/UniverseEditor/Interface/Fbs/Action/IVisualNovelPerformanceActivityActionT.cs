using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007596 RID: 30102
	public class IVisualNovelPerformanceActivityActionT
	{
		// Token: 0x1700E441 RID: 58433
		// (get) Token: 0x06036C26 RID: 224294 RVA: 0x0076EEAB File Offset: 0x0076D0AB
		// (set) Token: 0x06036C27 RID: 224295 RVA: 0x0076EEB3 File Offset: 0x0076D0B3
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E442 RID: 58434
		// (get) Token: 0x06036C28 RID: 224296 RVA: 0x0076EEBC File Offset: 0x0076D0BC
		// (set) Token: 0x06036C29 RID: 224297 RVA: 0x0076EEC4 File Offset: 0x0076D0C4
		public float StartTime { get; set; }

		// Token: 0x1700E443 RID: 58435
		// (get) Token: 0x06036C2A RID: 224298 RVA: 0x0076EECD File Offset: 0x0076D0CD
		// (set) Token: 0x06036C2B RID: 224299 RVA: 0x0076EED5 File Offset: 0x0076D0D5
		public IVisualNovelActivityActionSolarSchoolT ActivityActionConfig { get; set; }

		// Token: 0x1700E444 RID: 58436
		// (get) Token: 0x06036C2C RID: 224300 RVA: 0x0076EEDE File Offset: 0x0076D0DE
		// (set) Token: 0x06036C2D RID: 224301 RVA: 0x0076EEE6 File Offset: 0x0076D0E6
		public byte NullMask { get; set; }

		// Token: 0x06036C2E RID: 224302 RVA: 0x0076EEEF File Offset: 0x0076D0EF
		public IVisualNovelPerformanceActivityActionT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.ActivityActionConfig = null;
			this.NullMask = 0;
		}
	}
}
