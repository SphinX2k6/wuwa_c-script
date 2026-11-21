using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047C0 RID: 18368
	public class IPerformerAiConditionDecoratorT
	{
		// Token: 0x17007FED RID: 32749
		// (get) Token: 0x0601B0C8 RID: 110792 RVA: 0x003D4F11 File Offset: 0x003D3111
		// (set) Token: 0x0601B0C9 RID: 110793 RVA: 0x003D4F19 File Offset: 0x003D3119
		public EPerformerAiDecoratorType Type { get; set; }

		// Token: 0x17007FEE RID: 32750
		// (get) Token: 0x0601B0CA RID: 110794 RVA: 0x003D4F22 File Offset: 0x003D3122
		// (set) Token: 0x0601B0CB RID: 110795 RVA: 0x003D4F2A File Offset: 0x003D312A
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17007FEF RID: 32751
		// (get) Token: 0x0601B0CC RID: 110796 RVA: 0x003D4F33 File Offset: 0x003D3133
		// (set) Token: 0x0601B0CD RID: 110797 RVA: 0x003D4F3B File Offset: 0x003D313B
		public bool Reverse { get; set; }

		// Token: 0x17007FF0 RID: 32752
		// (get) Token: 0x0601B0CE RID: 110798 RVA: 0x003D4F44 File Offset: 0x003D3144
		// (set) Token: 0x0601B0CF RID: 110799 RVA: 0x003D4F4C File Offset: 0x003D314C
		public EPerformerAiAbortType AbortType { get; set; }

		// Token: 0x17007FF1 RID: 32753
		// (get) Token: 0x0601B0D0 RID: 110800 RVA: 0x003D4F55 File Offset: 0x003D3155
		// (set) Token: 0x0601B0D1 RID: 110801 RVA: 0x003D4F5D File Offset: 0x003D315D
		public byte NullMask { get; set; }

		// Token: 0x0601B0D2 RID: 110802 RVA: 0x003D4F66 File Offset: 0x003D3166
		public IPerformerAiConditionDecoratorT()
		{
			this.Type = EPerformerAiDecoratorType.Condition;
			this.Condition = null;
			this.Reverse = false;
			this.AbortType = EPerformerAiAbortType.None;
			this.NullMask = 0;
		}
	}
}
