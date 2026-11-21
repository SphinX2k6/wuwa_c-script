using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004563 RID: 17763
	public class IShowUiConditionT
	{
		// Token: 0x17007C19 RID: 31769
		// (get) Token: 0x06019D65 RID: 105829 RVA: 0x003AFD89 File Offset: 0x003ADF89
		// (set) Token: 0x06019D66 RID: 105830 RVA: 0x003AFD91 File Offset: 0x003ADF91
		public EChildQuest Type { get; set; }

		// Token: 0x17007C1A RID: 31770
		// (get) Token: 0x06019D67 RID: 105831 RVA: 0x003AFD9A File Offset: 0x003ADF9A
		// (set) Token: 0x06019D68 RID: 105832 RVA: 0x003AFDA2 File Offset: 0x003ADFA2
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007C1B RID: 31771
		// (get) Token: 0x06019D69 RID: 105833 RVA: 0x003AFDAB File Offset: 0x003ADFAB
		// (set) Token: 0x06019D6A RID: 105834 RVA: 0x003AFDB3 File Offset: 0x003ADFB3
		public TShowUiUnion UiType { get; set; }

		// Token: 0x17007C1C RID: 31772
		// (get) Token: 0x06019D6B RID: 105835 RVA: 0x003AFDBC File Offset: 0x003ADFBC
		// (set) Token: 0x06019D6C RID: 105836 RVA: 0x003AFDC4 File Offset: 0x003ADFC4
		public bool KeepUiOpen { get; set; }

		// Token: 0x17007C1D RID: 31773
		// (get) Token: 0x06019D6D RID: 105837 RVA: 0x003AFDCD File Offset: 0x003ADFCD
		// (set) Token: 0x06019D6E RID: 105838 RVA: 0x003AFDD5 File Offset: 0x003ADFD5
		public byte NullMask { get; set; }

		// Token: 0x06019D6F RID: 105839 RVA: 0x003AFDDE File Offset: 0x003ADFDE
		public IShowUiConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.UiType = null;
			this.KeepUiOpen = false;
			this.NullMask = 0;
		}
	}
}
