using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200630F RID: 25359
	public class IChangeNpcPerformStateT
	{
		// Token: 0x1700BD50 RID: 48464
		// (get) Token: 0x0602BDBF RID: 179647 RVA: 0x0060808F File Offset: 0x0060628F
		// (set) Token: 0x0602BDC0 RID: 179648 RVA: 0x00608097 File Offset: 0x00606297
		public int EntityId { get; set; }

		// Token: 0x1700BD51 RID: 48465
		// (get) Token: 0x0602BDC1 RID: 179649 RVA: 0x006080A0 File Offset: 0x006062A0
		// (set) Token: 0x0602BDC2 RID: 179650 RVA: 0x006080A8 File Offset: 0x006062A8
		public string State { get; set; }

		// Token: 0x0602BDC3 RID: 179651 RVA: 0x006080B1 File Offset: 0x006062B1
		public IChangeNpcPerformStateT()
		{
			this.EntityId = 0;
			this.State = null;
		}
	}
}
