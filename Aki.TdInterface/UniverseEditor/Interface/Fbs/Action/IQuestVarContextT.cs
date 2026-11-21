using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200757A RID: 30074
	public class IQuestVarContextT
	{
		// Token: 0x1700DD29 RID: 56617
		// (get) Token: 0x06034BE7 RID: 216039 RVA: 0x00717988 File Offset: 0x00715B88
		// (set) Token: 0x06034BE8 RID: 216040 RVA: 0x00717990 File Offset: 0x00715B90
		public EVarContext Type { get; set; }

		// Token: 0x1700DD2A RID: 56618
		// (get) Token: 0x06034BE9 RID: 216041 RVA: 0x00717999 File Offset: 0x00715B99
		// (set) Token: 0x06034BEA RID: 216042 RVA: 0x007179A1 File Offset: 0x00715BA1
		public int Id { get; set; }

		// Token: 0x06034BEB RID: 216043 RVA: 0x007179AA File Offset: 0x00715BAA
		public IQuestVarContextT()
		{
			this.Type = EVarContext.None;
			this.Id = 0;
		}
	}
}
