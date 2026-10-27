using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F67 RID: 28519
	public class ISendBattleEventsForMonsterSummonConfigT
	{
		// Token: 0x1700D3E3 RID: 54243
		// (get) Token: 0x06032633 RID: 206387 RVA: 0x006CD6BA File Offset: 0x006CB8BA
		// (set) Token: 0x06032634 RID: 206388 RVA: 0x006CD6C2 File Offset: 0x006CB8C2
		public int TagConfigId { get; set; }

		// Token: 0x1700D3E4 RID: 54244
		// (get) Token: 0x06032635 RID: 206389 RVA: 0x006CD6CB File Offset: 0x006CB8CB
		// (set) Token: 0x06032636 RID: 206390 RVA: 0x006CD6D3 File Offset: 0x006CB8D3
		public int DelayTime { get; set; }

		// Token: 0x1700D3E5 RID: 54245
		// (get) Token: 0x06032637 RID: 206391 RVA: 0x006CD6DC File Offset: 0x006CB8DC
		// (set) Token: 0x06032638 RID: 206392 RVA: 0x006CD6E4 File Offset: 0x006CB8E4
		public byte NullMask { get; set; }

		// Token: 0x06032639 RID: 206393 RVA: 0x006CD6ED File Offset: 0x006CB8ED
		public ISendBattleEventsForMonsterSummonConfigT()
		{
			this.TagConfigId = 0;
			this.DelayTime = 0;
			this.NullMask = 0;
		}
	}
}
