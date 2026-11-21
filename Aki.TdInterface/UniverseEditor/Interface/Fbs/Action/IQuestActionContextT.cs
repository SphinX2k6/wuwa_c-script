using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007574 RID: 30068
	public class IQuestActionContextT
	{
		// Token: 0x1700DD1E RID: 56606
		// (get) Token: 0x06034BB9 RID: 215993 RVA: 0x00717561 File Offset: 0x00715761
		// (set) Token: 0x06034BBA RID: 215994 RVA: 0x00717569 File Offset: 0x00715769
		public string Type { get; set; }

		// Token: 0x1700DD1F RID: 56607
		// (get) Token: 0x06034BBB RID: 215995 RVA: 0x00717572 File Offset: 0x00715772
		// (set) Token: 0x06034BBC RID: 215996 RVA: 0x0071757A File Offset: 0x0071577A
		public bool IsChildQuestOfDungeon { get; set; }

		// Token: 0x1700DD20 RID: 56608
		// (get) Token: 0x06034BBD RID: 215997 RVA: 0x00717583 File Offset: 0x00715783
		// (set) Token: 0x06034BBE RID: 215998 RVA: 0x0071758B File Offset: 0x0071578B
		public byte NullMask { get; set; }

		// Token: 0x06034BBF RID: 215999 RVA: 0x00717594 File Offset: 0x00715794
		public IQuestActionContextT()
		{
			this.Type = null;
			this.IsChildQuestOfDungeon = false;
			this.NullMask = 0;
		}
	}
}
