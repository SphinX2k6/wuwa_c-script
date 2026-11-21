using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007787 RID: 30599
	public class ISetBattleTagConfigT
	{
		// Token: 0x1700E03B RID: 57403
		// (get) Token: 0x06035B64 RID: 220004 RVA: 0x0073285C File Offset: 0x00730A5C
		// (set) Token: 0x06035B65 RID: 220005 RVA: 0x00732864 File Offset: 0x00730A64
		public int EntityId { get; set; }

		// Token: 0x1700E03C RID: 57404
		// (get) Token: 0x06035B66 RID: 220006 RVA: 0x0073286D File Offset: 0x00730A6D
		// (set) Token: 0x06035B67 RID: 220007 RVA: 0x00732875 File Offset: 0x00730A75
		public int TagConfigId { get; set; }

		// Token: 0x1700E03D RID: 57405
		// (get) Token: 0x06035B68 RID: 220008 RVA: 0x0073287E File Offset: 0x00730A7E
		// (set) Token: 0x06035B69 RID: 220009 RVA: 0x00732886 File Offset: 0x00730A86
		public int DelayTime { get; set; }

		// Token: 0x1700E03E RID: 57406
		// (get) Token: 0x06035B6A RID: 220010 RVA: 0x0073288F File Offset: 0x00730A8F
		// (set) Token: 0x06035B6B RID: 220011 RVA: 0x00732897 File Offset: 0x00730A97
		public byte NullMask { get; set; }

		// Token: 0x06035B6C RID: 220012 RVA: 0x007328A0 File Offset: 0x00730AA0
		public ISetBattleTagConfigT()
		{
			this.EntityId = 0;
			this.TagConfigId = 0;
			this.DelayTime = 0;
			this.NullMask = 0;
		}
	}
}
