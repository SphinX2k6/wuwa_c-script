using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043E3 RID: 17379
	public class IPlayerHavingItemCountT
	{
		// Token: 0x170077BB RID: 30651
		// (get) Token: 0x06018AFF RID: 101119 RVA: 0x0038500C File Offset: 0x0038320C
		// (set) Token: 0x06018B00 RID: 101120 RVA: 0x00385014 File Offset: 0x00383214
		public EBindingProgressType Type { get; set; }

		// Token: 0x170077BC RID: 30652
		// (get) Token: 0x06018B01 RID: 101121 RVA: 0x0038501D File Offset: 0x0038321D
		// (set) Token: 0x06018B02 RID: 101122 RVA: 0x00385025 File Offset: 0x00383225
		public int ItemId { get; set; }

		// Token: 0x06018B03 RID: 101123 RVA: 0x0038502E File Offset: 0x0038322E
		public IPlayerHavingItemCountT()
		{
			this.Type = EBindingProgressType.PlayerHavingItemCount;
			this.ItemId = 0;
		}
	}
}
