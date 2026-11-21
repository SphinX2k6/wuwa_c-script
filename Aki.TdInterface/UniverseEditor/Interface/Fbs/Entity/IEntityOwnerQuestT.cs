using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C2F RID: 19503
	public class IEntityOwnerQuestT
	{
		// Token: 0x17008A3B RID: 35387
		// (get) Token: 0x0601DDD2 RID: 122322 RVA: 0x00430030 File Offset: 0x0042E230
		// (set) Token: 0x0601DDD3 RID: 122323 RVA: 0x00430038 File Offset: 0x0042E238
		public EEntityOwnerType Type { get; set; }

		// Token: 0x17008A3C RID: 35388
		// (get) Token: 0x0601DDD4 RID: 122324 RVA: 0x00430041 File Offset: 0x0042E241
		// (set) Token: 0x0601DDD5 RID: 122325 RVA: 0x00430049 File Offset: 0x0042E249
		public int QuestId { get; set; }

		// Token: 0x0601DDD6 RID: 122326 RVA: 0x00430052 File Offset: 0x0042E252
		public IEntityOwnerQuestT()
		{
			this.Type = EEntityOwnerType.Quest;
			this.QuestId = 0;
		}
	}
}
