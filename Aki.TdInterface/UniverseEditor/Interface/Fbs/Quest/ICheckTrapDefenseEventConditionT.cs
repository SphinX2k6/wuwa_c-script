using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D80 RID: 15744
	public class ICheckTrapDefenseEventConditionT
	{
		// Token: 0x17006C0A RID: 27658
		// (get) Token: 0x06015CCF RID: 89295 RVA: 0x00324891 File Offset: 0x00322A91
		// (set) Token: 0x06015CD0 RID: 89296 RVA: 0x00324899 File Offset: 0x00322A99
		public EChildQuest Type { get; set; }

		// Token: 0x17006C0B RID: 27659
		// (get) Token: 0x06015CD1 RID: 89297 RVA: 0x003248A2 File Offset: 0x00322AA2
		// (set) Token: 0x06015CD2 RID: 89298 RVA: 0x003248AA File Offset: 0x00322AAA
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006C0C RID: 27660
		// (get) Token: 0x06015CD3 RID: 89299 RVA: 0x003248B3 File Offset: 0x00322AB3
		// (set) Token: 0x06015CD4 RID: 89300 RVA: 0x003248BB File Offset: 0x00322ABB
		public TCheckTrapDefenseEventUnion Config { get; set; }

		// Token: 0x06015CD5 RID: 89301 RVA: 0x003248C4 File Offset: 0x00322AC4
		public ICheckTrapDefenseEventConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Config = null;
		}
	}
}
