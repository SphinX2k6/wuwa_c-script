using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F41 RID: 16193
	public class QuestStateValueT
	{
		// Token: 0x17006DAA RID: 28074
		// (get) Token: 0x0601605D RID: 90205 RVA: 0x00329C2A File Offset: 0x00327E2A
		// (set) Token: 0x0601605E RID: 90206 RVA: 0x00329C32 File Offset: 0x00327E32
		public EQuestState Value { get; set; }

		// Token: 0x0601605F RID: 90207 RVA: 0x00329C3B File Offset: 0x00327E3B
		public QuestStateValueT()
		{
			this.Value = EQuestState.InActive;
		}
	}
}
