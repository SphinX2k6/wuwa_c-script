using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E8 RID: 26344
	public class IEntityPos2T
	{
		// Token: 0x1700C3C4 RID: 50116
		// (get) Token: 0x0602DCEB RID: 187627 RVA: 0x00643B85 File Offset: 0x00641D85
		// (set) Token: 0x0602DCEC RID: 187628 RVA: 0x00643B8D File Offset: 0x00641D8D
		public EPos2 Type { get; set; }

		// Token: 0x1700C3C5 RID: 50117
		// (get) Token: 0x0602DCED RID: 187629 RVA: 0x00643B96 File Offset: 0x00641D96
		// (set) Token: 0x0602DCEE RID: 187630 RVA: 0x00643B9E File Offset: 0x00641D9E
		public int EntityId { get; set; }

		// Token: 0x1700C3C6 RID: 50118
		// (get) Token: 0x0602DCEF RID: 187631 RVA: 0x00643BA7 File Offset: 0x00641DA7
		// (set) Token: 0x0602DCF0 RID: 187632 RVA: 0x00643BAF File Offset: 0x00641DAF
		public IVectorInfoT Offset { get; set; }

		// Token: 0x0602DCF1 RID: 187633 RVA: 0x00643BB8 File Offset: 0x00641DB8
		public IEntityPos2T()
		{
			this.Type = EPos2.Player;
			this.EntityId = 0;
			this.Offset = null;
		}
	}
}
