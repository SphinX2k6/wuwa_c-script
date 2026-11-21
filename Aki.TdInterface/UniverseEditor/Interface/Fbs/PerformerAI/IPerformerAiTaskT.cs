using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047E1 RID: 18401
	public class IPerformerAiTaskT
	{
		// Token: 0x1700805D RID: 32861
		// (get) Token: 0x0601B2CD RID: 111309 RVA: 0x003DA2FE File Offset: 0x003D84FE
		// (set) Token: 0x0601B2CE RID: 111310 RVA: 0x003DA306 File Offset: 0x003D8506
		public EPerformerAiNodeType Type { get; set; }

		// Token: 0x1700805E RID: 32862
		// (get) Token: 0x0601B2CF RID: 111311 RVA: 0x003DA30F File Offset: 0x003D850F
		// (set) Token: 0x0601B2D0 RID: 111312 RVA: 0x003DA317 File Offset: 0x003D8517
		public int Id { get; set; }

		// Token: 0x1700805F RID: 32863
		// (get) Token: 0x0601B2D1 RID: 111313 RVA: 0x003DA320 File Offset: 0x003D8520
		// (set) Token: 0x0601B2D2 RID: 111314 RVA: 0x003DA328 File Offset: 0x003D8528
		public string Desc { get; set; }

		// Token: 0x17008060 RID: 32864
		// (get) Token: 0x0601B2D3 RID: 111315 RVA: 0x003DA331 File Offset: 0x003D8531
		// (set) Token: 0x0601B2D4 RID: 111316 RVA: 0x003DA339 File Offset: 0x003D8539
		public List<TPerformerAiDecoratorUnion> Decorators { get; set; }

		// Token: 0x17008061 RID: 32865
		// (get) Token: 0x0601B2D5 RID: 111317 RVA: 0x003DA342 File Offset: 0x003D8542
		// (set) Token: 0x0601B2D6 RID: 111318 RVA: 0x003DA34A File Offset: 0x003D854A
		public bool _FoldedForTree { get; set; }

		// Token: 0x17008062 RID: 32866
		// (get) Token: 0x0601B2D7 RID: 111319 RVA: 0x003DA353 File Offset: 0x003D8553
		// (set) Token: 0x0601B2D8 RID: 111320 RVA: 0x003DA35B File Offset: 0x003D855B
		public IActionInfoT Action { get; set; }

		// Token: 0x17008063 RID: 32867
		// (get) Token: 0x0601B2D9 RID: 111321 RVA: 0x003DA364 File Offset: 0x003D8564
		// (set) Token: 0x0601B2DA RID: 111322 RVA: 0x003DA36C File Offset: 0x003D856C
		public byte NullMask { get; set; }

		// Token: 0x0601B2DB RID: 111323 RVA: 0x003DA375 File Offset: 0x003D8575
		public IPerformerAiTaskT()
		{
			this.Type = EPerformerAiNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.Action = null;
			this.NullMask = 0;
		}
	}
}
