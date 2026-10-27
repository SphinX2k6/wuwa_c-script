using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047C7 RID: 18375
	public class IEntityOwnerQuestT
	{
		// Token: 0x170083FA RID: 33786
		// (get) Token: 0x0601C5FD RID: 116221 RVA: 0x00403D94 File Offset: 0x00401F94
		// (set) Token: 0x0601C5FE RID: 116222 RVA: 0x00403D9C File Offset: 0x00401F9C
		public EEntityOwnerType Type { get; set; }

		// Token: 0x170083FB RID: 33787
		// (get) Token: 0x0601C5FF RID: 116223 RVA: 0x00403DA5 File Offset: 0x00401FA5
		// (set) Token: 0x0601C600 RID: 116224 RVA: 0x00403DAD File Offset: 0x00401FAD
		public int QuestId { get; set; }

		// Token: 0x0601C601 RID: 116225 RVA: 0x00403DB6 File Offset: 0x00401FB6
		public IEntityOwnerQuestT()
		{
			this.Type = EEntityOwnerType.Quest;
			this.QuestId = 0;
		}
	}
}
