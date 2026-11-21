using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006767 RID: 26471
	public class IActorTurnToEntityDataT
	{
		// Token: 0x1700C079 RID: 49273
		// (get) Token: 0x0602CDE0 RID: 183776 RVA: 0x00622A54 File Offset: 0x00620C54
		// (set) Token: 0x0602CDE1 RID: 183777 RVA: 0x00622A5C File Offset: 0x00620C5C
		public EActorTurnToMode Type { get; set; }

		// Token: 0x1700C07A RID: 49274
		// (get) Token: 0x0602CDE2 RID: 183778 RVA: 0x00622A65 File Offset: 0x00620C65
		// (set) Token: 0x0602CDE3 RID: 183779 RVA: 0x00622A6D File Offset: 0x00620C6D
		public int EntityId { get; set; }

		// Token: 0x0602CDE4 RID: 183780 RVA: 0x00622A76 File Offset: 0x00620C76
		public IActorTurnToEntityDataT()
		{
			this.Type = EActorTurnToMode.Talker;
			this.EntityId = 0;
		}
	}
}
