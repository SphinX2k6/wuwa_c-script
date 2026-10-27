using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FBE RID: 28606
	public class ISetBattleTagConfigT
	{
		// Token: 0x1700D467 RID: 54375
		// (get) Token: 0x060328FE RID: 207102 RVA: 0x006D2C18 File Offset: 0x006D0E18
		// (set) Token: 0x060328FF RID: 207103 RVA: 0x006D2C20 File Offset: 0x006D0E20
		public int EntityId { get; set; }

		// Token: 0x1700D468 RID: 54376
		// (get) Token: 0x06032900 RID: 207104 RVA: 0x006D2C29 File Offset: 0x006D0E29
		// (set) Token: 0x06032901 RID: 207105 RVA: 0x006D2C31 File Offset: 0x006D0E31
		public int TagConfigId { get; set; }

		// Token: 0x1700D469 RID: 54377
		// (get) Token: 0x06032902 RID: 207106 RVA: 0x006D2C3A File Offset: 0x006D0E3A
		// (set) Token: 0x06032903 RID: 207107 RVA: 0x006D2C42 File Offset: 0x006D0E42
		public int DelayTime { get; set; }

		// Token: 0x1700D46A RID: 54378
		// (get) Token: 0x06032904 RID: 207108 RVA: 0x006D2C4B File Offset: 0x006D0E4B
		// (set) Token: 0x06032905 RID: 207109 RVA: 0x006D2C53 File Offset: 0x006D0E53
		public byte NullMask { get; set; }

		// Token: 0x06032906 RID: 207110 RVA: 0x006D2C5C File Offset: 0x006D0E5C
		public ISetBattleTagConfigT()
		{
			this.EntityId = 0;
			this.TagConfigId = 0;
			this.DelayTime = 0;
			this.NullMask = 0;
		}
	}
}
