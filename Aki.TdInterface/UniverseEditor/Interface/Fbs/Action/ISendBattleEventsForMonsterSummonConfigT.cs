using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200772A RID: 30506
	public class ISendBattleEventsForMonsterSummonConfigT
	{
		// Token: 0x1700DFAF RID: 57263
		// (get) Token: 0x06035871 RID: 219249 RVA: 0x0072CEFA File Offset: 0x0072B0FA
		// (set) Token: 0x06035872 RID: 219250 RVA: 0x0072CF02 File Offset: 0x0072B102
		public int TagConfigId { get; set; }

		// Token: 0x1700DFB0 RID: 57264
		// (get) Token: 0x06035873 RID: 219251 RVA: 0x0072CF0B File Offset: 0x0072B10B
		// (set) Token: 0x06035874 RID: 219252 RVA: 0x0072CF13 File Offset: 0x0072B113
		public int DelayTime { get; set; }

		// Token: 0x1700DFB1 RID: 57265
		// (get) Token: 0x06035875 RID: 219253 RVA: 0x0072CF1C File Offset: 0x0072B11C
		// (set) Token: 0x06035876 RID: 219254 RVA: 0x0072CF24 File Offset: 0x0072B124
		public byte NullMask { get; set; }

		// Token: 0x06035877 RID: 219255 RVA: 0x0072CF2D File Offset: 0x0072B12D
		public ISendBattleEventsForMonsterSummonConfigT()
		{
			this.TagConfigId = 0;
			this.DelayTime = 0;
			this.NullMask = 0;
		}
	}
}
