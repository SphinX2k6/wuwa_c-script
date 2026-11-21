using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044E5 RID: 17637
	public class IRepeaterBtNodeT
	{
		// Token: 0x17007AD1 RID: 31441
		// (get) Token: 0x06019840 RID: 104512 RVA: 0x003A3BAA File Offset: 0x003A1DAA
		// (set) Token: 0x06019841 RID: 104513 RVA: 0x003A3BB2 File Offset: 0x003A1DB2
		public EBtNode Type { get; set; }

		// Token: 0x17007AD2 RID: 31442
		// (get) Token: 0x06019842 RID: 104514 RVA: 0x003A3BBB File Offset: 0x003A1DBB
		// (set) Token: 0x06019843 RID: 104515 RVA: 0x003A3BC3 File Offset: 0x003A1DC3
		public int Id { get; set; }

		// Token: 0x17007AD3 RID: 31443
		// (get) Token: 0x06019844 RID: 104516 RVA: 0x003A3BCC File Offset: 0x003A1DCC
		// (set) Token: 0x06019845 RID: 104517 RVA: 0x003A3BD4 File Offset: 0x003A1DD4
		public string Desc { get; set; }

		// Token: 0x17007AD4 RID: 31444
		// (get) Token: 0x06019846 RID: 104518 RVA: 0x003A3BDD File Offset: 0x003A1DDD
		// (set) Token: 0x06019847 RID: 104519 RVA: 0x003A3BE5 File Offset: 0x003A1DE5
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007AD5 RID: 31445
		// (get) Token: 0x06019848 RID: 104520 RVA: 0x003A3BEE File Offset: 0x003A1DEE
		// (set) Token: 0x06019849 RID: 104521 RVA: 0x003A3BF6 File Offset: 0x003A1DF6
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007AD6 RID: 31446
		// (get) Token: 0x0601984A RID: 104522 RVA: 0x003A3BFF File Offset: 0x003A1DFF
		// (set) Token: 0x0601984B RID: 104523 RVA: 0x003A3C07 File Offset: 0x003A1E07
		public bool Disabled { get; set; }

		// Token: 0x17007AD7 RID: 31447
		// (get) Token: 0x0601984C RID: 104524 RVA: 0x003A3C10 File Offset: 0x003A1E10
		// (set) Token: 0x0601984D RID: 104525 RVA: 0x003A3C18 File Offset: 0x003A1E18
		public TBtNodeUnion Child { get; set; }

		// Token: 0x17007AD8 RID: 31448
		// (get) Token: 0x0601984E RID: 104526 RVA: 0x003A3C21 File Offset: 0x003A1E21
		// (set) Token: 0x0601984F RID: 104527 RVA: 0x003A3C29 File Offset: 0x003A1E29
		public int MaxRepeatTimes { get; set; }

		// Token: 0x17007AD9 RID: 31449
		// (get) Token: 0x06019850 RID: 104528 RVA: 0x003A3C32 File Offset: 0x003A1E32
		// (set) Token: 0x06019851 RID: 104529 RVA: 0x003A3C3A File Offset: 0x003A1E3A
		public IConditionGroupT ExitCondition { get; set; }

		// Token: 0x17007ADA RID: 31450
		// (get) Token: 0x06019852 RID: 104530 RVA: 0x003A3C43 File Offset: 0x003A1E43
		// (set) Token: 0x06019853 RID: 104531 RVA: 0x003A3C4B File Offset: 0x003A1E4B
		public byte NullMask { get; set; }

		// Token: 0x06019854 RID: 104532 RVA: 0x003A3C54 File Offset: 0x003A1E54
		public IRepeaterBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.Child = null;
			this.MaxRepeatTimes = 0;
			this.ExitCondition = null;
			this.NullMask = 0;
		}
	}
}
