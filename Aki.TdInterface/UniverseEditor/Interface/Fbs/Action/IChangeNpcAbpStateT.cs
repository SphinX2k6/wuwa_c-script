using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200630C RID: 25356
	public class IChangeNpcAbpStateT
	{
		// Token: 0x1700BD4B RID: 48459
		// (get) Token: 0x0602BDA7 RID: 179623 RVA: 0x00607E5B File Offset: 0x0060605B
		// (set) Token: 0x0602BDA8 RID: 179624 RVA: 0x00607E63 File Offset: 0x00606063
		public int EntityId { get; set; }

		// Token: 0x1700BD4C RID: 48460
		// (get) Token: 0x0602BDA9 RID: 179625 RVA: 0x00607E6C File Offset: 0x0060606C
		// (set) Token: 0x0602BDAA RID: 179626 RVA: 0x00607E74 File Offset: 0x00606074
		public string AbpState { get; set; }

		// Token: 0x0602BDAB RID: 179627 RVA: 0x00607E7D File Offset: 0x0060607D
		public IChangeNpcAbpStateT()
		{
			this.EntityId = 0;
			this.AbpState = null;
		}
	}
}
