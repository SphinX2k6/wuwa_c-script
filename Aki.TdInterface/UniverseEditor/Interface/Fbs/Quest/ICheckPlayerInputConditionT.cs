using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D5F RID: 15711
	public class ICheckPlayerInputConditionT
	{
		// Token: 0x17006BD2 RID: 27602
		// (get) Token: 0x06015BC9 RID: 89033 RVA: 0x00322A09 File Offset: 0x00320C09
		// (set) Token: 0x06015BCA RID: 89034 RVA: 0x00322A11 File Offset: 0x00320C11
		public EChildQuest Type { get; set; }

		// Token: 0x17006BD3 RID: 27603
		// (get) Token: 0x06015BCB RID: 89035 RVA: 0x00322A1A File Offset: 0x00320C1A
		// (set) Token: 0x06015BCC RID: 89036 RVA: 0x00322A22 File Offset: 0x00320C22
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006BD4 RID: 27604
		// (get) Token: 0x06015BCD RID: 89037 RVA: 0x00322A2B File Offset: 0x00320C2B
		// (set) Token: 0x06015BCE RID: 89038 RVA: 0x00322A33 File Offset: 0x00320C33
		public ICheckPlayerPressButtonT CheckInput { get; set; }

		// Token: 0x06015BCF RID: 89039 RVA: 0x00322A3C File Offset: 0x00320C3C
		public ICheckPlayerInputConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.CheckInput = null;
		}
	}
}
