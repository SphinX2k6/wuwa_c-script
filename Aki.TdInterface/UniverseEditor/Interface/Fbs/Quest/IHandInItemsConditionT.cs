using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042CF RID: 17103
	public class IHandInItemsConditionT
	{
		// Token: 0x1700751E RID: 29982
		// (get) Token: 0x06018009 RID: 98313 RVA: 0x0036D46E File Offset: 0x0036B66E
		// (set) Token: 0x0601800A RID: 98314 RVA: 0x0036D476 File Offset: 0x0036B676
		public EChildQuest Type { get; set; }

		// Token: 0x1700751F RID: 29983
		// (get) Token: 0x0601800B RID: 98315 RVA: 0x0036D47F File Offset: 0x0036B67F
		// (set) Token: 0x0601800C RID: 98316 RVA: 0x0036D487 File Offset: 0x0036B687
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007520 RID: 29984
		// (get) Token: 0x0601800D RID: 98317 RVA: 0x0036D490 File Offset: 0x0036B690
		// (set) Token: 0x0601800E RID: 98318 RVA: 0x0036D498 File Offset: 0x0036B698
		public IHandInItemsT HandInItems { get; set; }

		// Token: 0x17007521 RID: 29985
		// (get) Token: 0x0601800F RID: 98319 RVA: 0x0036D4A1 File Offset: 0x0036B6A1
		// (set) Token: 0x06018010 RID: 98320 RVA: 0x0036D4A9 File Offset: 0x0036B6A9
		public List<TItemVariableUnion> ItemVars { get; set; }

		// Token: 0x17007522 RID: 29986
		// (get) Token: 0x06018011 RID: 98321 RVA: 0x0036D4B2 File Offset: 0x0036B6B2
		// (set) Token: 0x06018012 RID: 98322 RVA: 0x0036D4BA File Offset: 0x0036B6BA
		public IAddInteractOptionT AddOption { get; set; }

		// Token: 0x17007523 RID: 29987
		// (get) Token: 0x06018013 RID: 98323 RVA: 0x0036D4C3 File Offset: 0x0036B6C3
		// (set) Token: 0x06018014 RID: 98324 RVA: 0x0036D4CB File Offset: 0x0036B6CB
		public byte NullMask { get; set; }

		// Token: 0x06018015 RID: 98325 RVA: 0x0036D4D4 File Offset: 0x0036B6D4
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
