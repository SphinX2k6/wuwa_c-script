using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DBC RID: 32188
	public class IVisualNovelPerformanceStopScreenEffectT
	{
		// Token: 0x1700F120 RID: 61728
		// (get) Token: 0x0603A2A3 RID: 238243 RVA: 0x007D7507 File Offset: 0x007D5707
		// (set) Token: 0x0603A2A4 RID: 238244 RVA: 0x007D750F File Offset: 0x007D570F
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F121 RID: 61729
		// (get) Token: 0x0603A2A5 RID: 238245 RVA: 0x007D7518 File Offset: 0x007D5718
		// (set) Token: 0x0603A2A6 RID: 238246 RVA: 0x007D7520 File Offset: 0x007D5720
		public float StartTime { get; set; }

		// Token: 0x1700F122 RID: 61730
		// (get) Token: 0x0603A2A7 RID: 238247 RVA: 0x007D7529 File Offset: 0x007D5729
		// (set) Token: 0x0603A2A8 RID: 238248 RVA: 0x007D7531 File Offset: 0x007D5731
		public IVisualNovelStopScreenEffectPersistentT EffectConfig { get; set; }

		// Token: 0x1700F123 RID: 61731
		// (get) Token: 0x0603A2A9 RID: 238249 RVA: 0x007D753A File Offset: 0x007D573A
		// (set) Token: 0x0603A2AA RID: 238250 RVA: 0x007D7542 File Offset: 0x007D5742
		public byte NullMask { get; set; }

		// Token: 0x0603A2AB RID: 238251 RVA: 0x007D754B File Offset: 0x007D574B
		public IVisualNovelPerformanceStopScreenEffectT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.EffectConfig = null;
			this.NullMask = 0;
		}
	}
}
