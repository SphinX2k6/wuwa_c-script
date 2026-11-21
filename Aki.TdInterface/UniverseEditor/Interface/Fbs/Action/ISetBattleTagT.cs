using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007784 RID: 30596
	public class ISetBattleTagT
	{
		// Token: 0x1700E034 RID: 57396
		// (get) Token: 0x06035B4A RID: 219978 RVA: 0x0073257B File Offset: 0x0073077B
		// (set) Token: 0x06035B4B RID: 219979 RVA: 0x00732583 File Offset: 0x00730783
		public ESetBattleStateType Type { get; set; }

		// Token: 0x1700E035 RID: 57397
		// (get) Token: 0x06035B4C RID: 219980 RVA: 0x0073258C File Offset: 0x0073078C
		// (set) Token: 0x06035B4D RID: 219981 RVA: 0x00732594 File Offset: 0x00730794
		public List<ISetEntityTagT> SetTags { get; set; }

		// Token: 0x06035B4E RID: 219982 RVA: 0x0073259D File Offset: 0x0073079D
		public ISetBattleTagT()
		{
			this.Type = ESetBattleStateType.SetBattleTag;
			this.SetTags = null;
		}
	}
}
