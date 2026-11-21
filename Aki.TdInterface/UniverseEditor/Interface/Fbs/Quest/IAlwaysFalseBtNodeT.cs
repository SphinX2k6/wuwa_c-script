using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004113 RID: 16659
	public class IAlwaysFalseBtNodeT
	{
		// Token: 0x170070CA RID: 28874
		// (get) Token: 0x06016D89 RID: 93577 RVA: 0x00343298 File Offset: 0x00341498
		// (set) Token: 0x06016D8A RID: 93578 RVA: 0x003432A0 File Offset: 0x003414A0
		public EBtNode Type { get; set; }

		// Token: 0x170070CB RID: 28875
		// (get) Token: 0x06016D8B RID: 93579 RVA: 0x003432A9 File Offset: 0x003414A9
		// (set) Token: 0x06016D8C RID: 93580 RVA: 0x003432B1 File Offset: 0x003414B1
		public int Id { get; set; }

		// Token: 0x170070CC RID: 28876
		// (get) Token: 0x06016D8D RID: 93581 RVA: 0x003432BA File Offset: 0x003414BA
		// (set) Token: 0x06016D8E RID: 93582 RVA: 0x003432C2 File Offset: 0x003414C2
		public string Desc { get; set; }

		// Token: 0x170070CD RID: 28877
		// (get) Token: 0x06016D8F RID: 93583 RVA: 0x003432CB File Offset: 0x003414CB
		// (set) Token: 0x06016D90 RID: 93584 RVA: 0x003432D3 File Offset: 0x003414D3
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x170070CE RID: 28878
		// (get) Token: 0x06016D91 RID: 93585 RVA: 0x003432DC File Offset: 0x003414DC
		// (set) Token: 0x06016D92 RID: 93586 RVA: 0x003432E4 File Offset: 0x003414E4
		public bool _FoldedForTree { get; set; }

		// Token: 0x170070CF RID: 28879
		// (get) Token: 0x06016D93 RID: 93587 RVA: 0x003432ED File Offset: 0x003414ED
		// (set) Token: 0x06016D94 RID: 93588 RVA: 0x003432F5 File Offset: 0x003414F5
		public bool Disabled { get; set; }

		// Token: 0x170070D0 RID: 28880
		// (get) Token: 0x06016D95 RID: 93589 RVA: 0x003432FE File Offset: 0x003414FE
		// (set) Token: 0x06016D96 RID: 93590 RVA: 0x00343306 File Offset: 0x00341506
		public TBtNodeUnion Child { get; set; }

		// Token: 0x170070D1 RID: 28881
		// (get) Token: 0x06016D97 RID: 93591 RVA: 0x0034330F File Offset: 0x0034150F
		// (set) Token: 0x06016D98 RID: 93592 RVA: 0x00343317 File Offset: 0x00341517
		public byte NullMask { get; set; }

		// Token: 0x06016D99 RID: 93593 RVA: 0x00343320 File Offset: 0x00341520
		public IAlwaysFalseBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.Child = null;
			this.NullMask = 0;
		}
	}
}
