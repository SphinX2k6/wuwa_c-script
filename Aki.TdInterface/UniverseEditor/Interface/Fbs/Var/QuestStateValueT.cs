using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B3F RID: 15167
	public class QuestStateValueT
	{
		// Token: 0x1700680F RID: 26639
		// (get) Token: 0x06014BB3 RID: 84915 RVA: 0x0030399A File Offset: 0x00301B9A
		// (set) Token: 0x06014BB4 RID: 84916 RVA: 0x003039A2 File Offset: 0x00301BA2
		public EQuestState Value { get; set; }

		// Token: 0x06014BB5 RID: 84917 RVA: 0x003039AB File Offset: 0x00301BAB
		public QuestStateValueT()
		{
			this.Value = EQuestState.InActive;
		}
	}
}
