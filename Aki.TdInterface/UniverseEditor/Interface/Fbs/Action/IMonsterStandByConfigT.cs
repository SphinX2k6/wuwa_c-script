using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007223 RID: 29219
	public class IMonsterStandByConfigT
	{
		// Token: 0x1700D5DE RID: 54750
		// (get) Token: 0x06032D80 RID: 208256 RVA: 0x006DD7F9 File Offset: 0x006DB9F9
		// (set) Token: 0x06032D81 RID: 208257 RVA: 0x006DD801 File Offset: 0x006DBA01
		public string Tag { get; set; }

		// Token: 0x1700D5DF RID: 54751
		// (get) Token: 0x06032D82 RID: 208258 RVA: 0x006DD80A File Offset: 0x006DBA0A
		// (set) Token: 0x06032D83 RID: 208259 RVA: 0x006DD812 File Offset: 0x006DBA12
		public float Duration { get; set; }

		// Token: 0x1700D5E0 RID: 54752
		// (get) Token: 0x06032D84 RID: 208260 RVA: 0x006DD81B File Offset: 0x006DBA1B
		// (set) Token: 0x06032D85 RID: 208261 RVA: 0x006DD823 File Offset: 0x006DBA23
		public int RepeatTimes { get; set; }

		// Token: 0x1700D5E1 RID: 54753
		// (get) Token: 0x06032D86 RID: 208262 RVA: 0x006DD82C File Offset: 0x006DBA2C
		// (set) Token: 0x06032D87 RID: 208263 RVA: 0x006DD834 File Offset: 0x006DBA34
		public int EmotionId { get; set; }

		// Token: 0x1700D5E2 RID: 54754
		// (get) Token: 0x06032D88 RID: 208264 RVA: 0x006DD83D File Offset: 0x006DBA3D
		// (set) Token: 0x06032D89 RID: 208265 RVA: 0x006DD845 File Offset: 0x006DBA45
		public byte NullMask { get; set; }

		// Token: 0x06032D8A RID: 208266 RVA: 0x006DD84E File Offset: 0x006DBA4E
		public IMonsterStandByConfigT()
		{
			this.Tag = null;
			this.Duration = 0f;
			this.RepeatTimes = 0;
			this.EmotionId = 0;
			this.NullMask = 0;
		}
	}
}
