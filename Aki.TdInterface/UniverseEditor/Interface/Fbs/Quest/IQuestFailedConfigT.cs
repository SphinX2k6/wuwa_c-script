using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FEA RID: 16362
	public class IQuestFailedConfigT
	{
		// Token: 0x170072D1 RID: 29393
		// (get) Token: 0x060178D9 RID: 96473 RVA: 0x003657C4 File Offset: 0x003639C4
		// (set) Token: 0x060178DA RID: 96474 RVA: 0x003657CC File Offset: 0x003639CC
		public EOnlineParticipateRule OnlineParticipateRule { get; set; }

		// Token: 0x170072D2 RID: 29394
		// (get) Token: 0x060178DB RID: 96475 RVA: 0x003657D5 File Offset: 0x003639D5
		// (set) Token: 0x060178DC RID: 96476 RVA: 0x003657DD File Offset: 0x003639DD
		public byte NullMask { get; set; }

		// Token: 0x060178DD RID: 96477 RVA: 0x003657E6 File Offset: 0x003639E6
		public IQuestFailedConfigT()
		{
			this.OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer;
			this.NullMask = 0;
		}
	}
}
