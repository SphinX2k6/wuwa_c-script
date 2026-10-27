using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040A4 RID: 16548
	public class IRepeaterBtNodeT
	{
		// Token: 0x170074CB RID: 29899
		// (get) Token: 0x0601819F RID: 98719 RVA: 0x00379C5A File Offset: 0x00377E5A
		// (set) Token: 0x060181A0 RID: 98720 RVA: 0x00379C62 File Offset: 0x00377E62
		public EBtNode Type { get; set; }

		// Token: 0x170074CC RID: 29900
		// (get) Token: 0x060181A1 RID: 98721 RVA: 0x00379C6B File Offset: 0x00377E6B
		// (set) Token: 0x060181A2 RID: 98722 RVA: 0x00379C73 File Offset: 0x00377E73
		public int Id { get; set; }

		// Token: 0x170074CD RID: 29901
		// (get) Token: 0x060181A3 RID: 98723 RVA: 0x00379C7C File Offset: 0x00377E7C
		// (set) Token: 0x060181A4 RID: 98724 RVA: 0x00379C84 File Offset: 0x00377E84
		public string Desc { get; set; }

		// Token: 0x170074CE RID: 29902
		// (get) Token: 0x060181A5 RID: 98725 RVA: 0x00379C8D File Offset: 0x00377E8D
		// (set) Token: 0x060181A6 RID: 98726 RVA: 0x00379C95 File Offset: 0x00377E95
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x170074CF RID: 29903
		// (get) Token: 0x060181A7 RID: 98727 RVA: 0x00379C9E File Offset: 0x00377E9E
		// (set) Token: 0x060181A8 RID: 98728 RVA: 0x00379CA6 File Offset: 0x00377EA6
		public bool _FoldedForTree { get; set; }

		// Token: 0x170074D0 RID: 29904
		// (get) Token: 0x060181A9 RID: 98729 RVA: 0x00379CAF File Offset: 0x00377EAF
		// (set) Token: 0x060181AA RID: 98730 RVA: 0x00379CB7 File Offset: 0x00377EB7
		public bool Disabled { get; set; }

		// Token: 0x170074D1 RID: 29905
		// (get) Token: 0x060181AB RID: 98731 RVA: 0x00379CC0 File Offset: 0x00377EC0
		// (set) Token: 0x060181AC RID: 98732 RVA: 0x00379CC8 File Offset: 0x00377EC8
		public TBtNodeUnion Child { get; set; }

		// Token: 0x170074D2 RID: 29906
		// (get) Token: 0x060181AD RID: 98733 RVA: 0x00379CD1 File Offset: 0x00377ED1
		// (set) Token: 0x060181AE RID: 98734 RVA: 0x00379CD9 File Offset: 0x00377ED9
		public int MaxRepeatTimes { get; set; }

		// Token: 0x170074D3 RID: 29907
		// (get) Token: 0x060181AF RID: 98735 RVA: 0x00379CE2 File Offset: 0x00377EE2
		// (set) Token: 0x060181B0 RID: 98736 RVA: 0x00379CEA File Offset: 0x00377EEA
		public IConditionGroupT ExitCondition { get; set; }

		// Token: 0x170074D4 RID: 29908
		// (get) Token: 0x060181B1 RID: 98737 RVA: 0x00379CF3 File Offset: 0x00377EF3
		// (set) Token: 0x060181B2 RID: 98738 RVA: 0x00379CFB File Offset: 0x00377EFB
		public byte NullMask { get; set; }

		// Token: 0x060181B3 RID: 98739 RVA: 0x00379D04 File Offset: 0x00377F04
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
