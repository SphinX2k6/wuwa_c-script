using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D9E RID: 15774
	public class ICompareActorVarInChildQuestT
	{
		// Token: 0x17006C82 RID: 27778
		// (get) Token: 0x06015EBA RID: 89786 RVA: 0x0032A598 File Offset: 0x00328798
		// (set) Token: 0x06015EBB RID: 89787 RVA: 0x0032A5A0 File Offset: 0x003287A0
		public IActorRefT ActorRef { get; set; }

		// Token: 0x17006C83 RID: 27779
		// (get) Token: 0x06015EBC RID: 89788 RVA: 0x0032A5A9 File Offset: 0x003287A9
		// (set) Token: 0x06015EBD RID: 89789 RVA: 0x0032A5B1 File Offset: 0x003287B1
		public string Var1 { get; set; }

		// Token: 0x17006C84 RID: 27780
		// (get) Token: 0x06015EBE RID: 89790 RVA: 0x0032A5BA File Offset: 0x003287BA
		// (set) Token: 0x06015EBF RID: 89791 RVA: 0x0032A5C2 File Offset: 0x003287C2
		public ECompare Compare { get; set; }

		// Token: 0x17006C85 RID: 27781
		// (get) Token: 0x06015EC0 RID: 89792 RVA: 0x0032A5CB File Offset: 0x003287CB
		// (set) Token: 0x06015EC1 RID: 89793 RVA: 0x0032A5D3 File Offset: 0x003287D3
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x06015EC2 RID: 89794 RVA: 0x0032A5DC File Offset: 0x003287DC
		public ICompareActorVarInChildQuestT()
		{
			this.ActorRef = null;
			this.Var1 = null;
			this.Compare = ECompare.Eq;
			this.Var2 = null;
		}
	}
}
