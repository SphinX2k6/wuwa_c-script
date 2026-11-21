using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C00 RID: 27648
	public class IDestroyQuestT
	{
		// Token: 0x1700CAB4 RID: 51892
		// (get) Token: 0x0602F95F RID: 194911 RVA: 0x0067C53E File Offset: 0x0067A73E
		// (set) Token: 0x0602F960 RID: 194912 RVA: 0x0067C546 File Offset: 0x0067A746
		public int QuestId { get; set; }

		// Token: 0x1700CAB5 RID: 51893
		// (get) Token: 0x0602F961 RID: 194913 RVA: 0x0067C54F File Offset: 0x0067A74F
		// (set) Token: 0x0602F962 RID: 194914 RVA: 0x0067C557 File Offset: 0x0067A757
		public bool IsDestroy { get; set; }

		// Token: 0x1700CAB6 RID: 51894
		// (get) Token: 0x0602F963 RID: 194915 RVA: 0x0067C560 File Offset: 0x0067A760
		// (set) Token: 0x0602F964 RID: 194916 RVA: 0x0067C568 File Offset: 0x0067A768
		public byte NullMask { get; set; }

		// Token: 0x0602F965 RID: 194917 RVA: 0x0067C571 File Offset: 0x0067A771
		public IDestroyQuestT()
		{
			this.QuestId = 0;
			this.IsDestroy = false;
			this.NullMask = 0;
		}
	}
}
