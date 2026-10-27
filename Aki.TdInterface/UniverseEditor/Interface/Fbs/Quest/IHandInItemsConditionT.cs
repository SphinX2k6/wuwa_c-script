using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E94 RID: 16020
	public class IHandInItemsConditionT
	{
		// Token: 0x17006F36 RID: 28470
		// (get) Token: 0x060169D2 RID: 92626 RVA: 0x003446EA File Offset: 0x003428EA
		// (set) Token: 0x060169D3 RID: 92627 RVA: 0x003446F2 File Offset: 0x003428F2
		public EChildQuest Type { get; set; }

		// Token: 0x17006F37 RID: 28471
		// (get) Token: 0x060169D4 RID: 92628 RVA: 0x003446FB File Offset: 0x003428FB
		// (set) Token: 0x060169D5 RID: 92629 RVA: 0x00344703 File Offset: 0x00342903
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006F38 RID: 28472
		// (get) Token: 0x060169D6 RID: 92630 RVA: 0x0034470C File Offset: 0x0034290C
		// (set) Token: 0x060169D7 RID: 92631 RVA: 0x00344714 File Offset: 0x00342914
		public IHandInItemsT HandInItems { get; set; }

		// Token: 0x17006F39 RID: 28473
		// (get) Token: 0x060169D8 RID: 92632 RVA: 0x0034471D File Offset: 0x0034291D
		// (set) Token: 0x060169D9 RID: 92633 RVA: 0x00344725 File Offset: 0x00342925
		public List<TItemVariableUnion> ItemVars { get; set; }

		// Token: 0x17006F3A RID: 28474
		// (get) Token: 0x060169DA RID: 92634 RVA: 0x0034472E File Offset: 0x0034292E
		// (set) Token: 0x060169DB RID: 92635 RVA: 0x00344736 File Offset: 0x00342936
		public IAddInteractOptionT AddOption { get; set; }

		// Token: 0x17006F3B RID: 28475
		// (get) Token: 0x060169DC RID: 92636 RVA: 0x0034473F File Offset: 0x0034293F
		// (set) Token: 0x060169DD RID: 92637 RVA: 0x00344747 File Offset: 0x00342947
		public byte NullMask { get; set; }

		// Token: 0x060169DE RID: 92638 RVA: 0x00344750 File Offset: 0x00342950
		public IHandInItemsConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.HandInItems = null;
			this.ItemVars = null;
			this.AddOption = null;
			this.NullMask = 0;
		}
	}
}
