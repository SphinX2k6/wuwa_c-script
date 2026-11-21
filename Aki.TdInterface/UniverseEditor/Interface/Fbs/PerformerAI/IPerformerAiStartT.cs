using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047DE RID: 18398
	public class IPerformerAiStartT
	{
		// Token: 0x1700804D RID: 32845
		// (get) Token: 0x0601B291 RID: 111249 RVA: 0x003D98DF File Offset: 0x003D7ADF
		// (set) Token: 0x0601B292 RID: 111250 RVA: 0x003D98E7 File Offset: 0x003D7AE7
		public EPerformerAiNodeType Type { get; set; }

		// Token: 0x1700804E RID: 32846
		// (get) Token: 0x0601B293 RID: 111251 RVA: 0x003D98F0 File Offset: 0x003D7AF0
		// (set) Token: 0x0601B294 RID: 111252 RVA: 0x003D98F8 File Offset: 0x003D7AF8
		public int Id { get; set; }

		// Token: 0x1700804F RID: 32847
		// (get) Token: 0x0601B295 RID: 111253 RVA: 0x003D9901 File Offset: 0x003D7B01
		// (set) Token: 0x0601B296 RID: 111254 RVA: 0x003D9909 File Offset: 0x003D7B09
		public string Desc { get; set; }

		// Token: 0x17008050 RID: 32848
		// (get) Token: 0x0601B297 RID: 111255 RVA: 0x003D9912 File Offset: 0x003D7B12
		// (set) Token: 0x0601B298 RID: 111256 RVA: 0x003D991A File Offset: 0x003D7B1A
		public List<TPerformerAiDecoratorUnion> Decorators { get; set; }

		// Token: 0x17008051 RID: 32849
		// (get) Token: 0x0601B299 RID: 111257 RVA: 0x003D9923 File Offset: 0x003D7B23
		// (set) Token: 0x0601B29A RID: 111258 RVA: 0x003D992B File Offset: 0x003D7B2B
		public bool _FoldedForTree { get; set; }

		// Token: 0x17008052 RID: 32850
		// (get) Token: 0x0601B29B RID: 111259 RVA: 0x003D9934 File Offset: 0x003D7B34
		// (set) Token: 0x0601B29C RID: 111260 RVA: 0x003D993C File Offset: 0x003D7B3C
		public TPerformerAiNodeUnion Child { get; set; }

		// Token: 0x17008053 RID: 32851
		// (get) Token: 0x0601B29D RID: 111261 RVA: 0x003D9945 File Offset: 0x003D7B45
		// (set) Token: 0x0601B29E RID: 111262 RVA: 0x003D994D File Offset: 0x003D7B4D
		public byte NullMask { get; set; }

		// Token: 0x0601B29F RID: 111263 RVA: 0x003D9956 File Offset: 0x003D7B56
		public IPerformerAiStartT()
		{
			this.Type = EPerformerAiNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.Child = null;
			this.NullMask = 0;
		}
	}
}
