using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006300 RID: 25344
	public class IChangeIconT
	{
		// Token: 0x1700BD2F RID: 48431
		// (get) Token: 0x0602BD2D RID: 179501 RVA: 0x00606FAB File Offset: 0x006051AB
		// (set) Token: 0x0602BD2E RID: 179502 RVA: 0x00606FB3 File Offset: 0x006051B3
		public int Icon { get; set; }

		// Token: 0x1700BD30 RID: 48432
		// (get) Token: 0x0602BD2F RID: 179503 RVA: 0x00606FBC File Offset: 0x006051BC
		// (set) Token: 0x0602BD30 RID: 179504 RVA: 0x00606FC4 File Offset: 0x006051C4
		public bool ChangeWhenSelectedInCurrentTalk { get; set; }

		// Token: 0x1700BD31 RID: 48433
		// (get) Token: 0x0602BD31 RID: 179505 RVA: 0x00606FCD File Offset: 0x006051CD
		// (set) Token: 0x0602BD32 RID: 179506 RVA: 0x00606FD5 File Offset: 0x006051D5
		public IConditionGroupT ChangeWhenMatchConditions { get; set; }

		// Token: 0x1700BD32 RID: 48434
		// (get) Token: 0x0602BD33 RID: 179507 RVA: 0x00606FDE File Offset: 0x006051DE
		// (set) Token: 0x0602BD34 RID: 179508 RVA: 0x00606FE6 File Offset: 0x006051E6
		public byte NullMask { get; set; }

		// Token: 0x0602BD35 RID: 179509 RVA: 0x00606FEF File Offset: 0x006051EF
		public IChangeIconT()
		{
			this.Icon = 0;
			this.ChangeWhenSelectedInCurrentTalk = false;
			this.ChangeWhenMatchConditions = null;
			this.NullMask = 0;
		}
	}
}
