using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005342 RID: 21314
	public class IGroupAiMonsterMemberT
	{
		// Token: 0x17009C90 RID: 40080
		// (get) Token: 0x06022DB4 RID: 142772 RVA: 0x004D43D1 File Offset: 0x004D25D1
		// (set) Token: 0x06022DB5 RID: 142773 RVA: 0x004D43D9 File Offset: 0x004D25D9
		public int EntityId { get; set; }

		// Token: 0x17009C91 RID: 40081
		// (get) Token: 0x06022DB6 RID: 142774 RVA: 0x004D43E2 File Offset: 0x004D25E2
		// (set) Token: 0x06022DB7 RID: 142775 RVA: 0x004D43EA File Offset: 0x004D25EA
		public IPosAndRotT RelativeTransform { get; set; }

		// Token: 0x17009C92 RID: 40082
		// (get) Token: 0x06022DB8 RID: 142776 RVA: 0x004D43F3 File Offset: 0x004D25F3
		// (set) Token: 0x06022DB9 RID: 142777 RVA: 0x004D43FB File Offset: 0x004D25FB
		public IGroupAiMonsterMemberActionTagAttachT ActionTagAttach { get; set; }

		// Token: 0x06022DBA RID: 142778 RVA: 0x004D4404 File Offset: 0x004D2604
		public IGroupAiMonsterMemberT()
		{
			this.EntityId = 0;
			this.RelativeTransform = null;
			this.ActionTagAttach = null;
		}
	}
}
