using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006598 RID: 26008
	public class IDestroyQuestT
	{
		// Token: 0x1700C125 RID: 49445
		// (get) Token: 0x0602D1DB RID: 184795 RVA: 0x0063037A File Offset: 0x0062E57A
		// (set) Token: 0x0602D1DC RID: 184796 RVA: 0x00630382 File Offset: 0x0062E582
		public int QuestId { get; set; }

		// Token: 0x1700C126 RID: 49446
		// (get) Token: 0x0602D1DD RID: 184797 RVA: 0x0063038B File Offset: 0x0062E58B
		// (set) Token: 0x0602D1DE RID: 184798 RVA: 0x00630393 File Offset: 0x0062E593
		public bool IsDestroy { get; set; }

		// Token: 0x1700C127 RID: 49447
		// (get) Token: 0x0602D1DF RID: 184799 RVA: 0x0063039C File Offset: 0x0062E59C
		// (set) Token: 0x0602D1E0 RID: 184800 RVA: 0x006303A4 File Offset: 0x0062E5A4
		public byte NullMask { get; set; }

		// Token: 0x0602D1E1 RID: 184801 RVA: 0x006303AD File Offset: 0x0062E5AD
		public IDestroyQuestT()
		{
			this.QuestId = 0;
			this.IsDestroy = false;
			this.NullMask = 0;
		}
	}
}
