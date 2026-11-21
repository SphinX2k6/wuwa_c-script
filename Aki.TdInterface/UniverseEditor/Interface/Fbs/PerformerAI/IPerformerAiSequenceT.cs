using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047DB RID: 18395
	public class IPerformerAiSequenceT
	{
		// Token: 0x1700803D RID: 32829
		// (get) Token: 0x0601B24E RID: 111182 RVA: 0x003D8CEF File Offset: 0x003D6EEF
		// (set) Token: 0x0601B24F RID: 111183 RVA: 0x003D8CF7 File Offset: 0x003D6EF7
		public EPerformerAiNodeType Type { get; set; }

		// Token: 0x1700803E RID: 32830
		// (get) Token: 0x0601B250 RID: 111184 RVA: 0x003D8D00 File Offset: 0x003D6F00
		// (set) Token: 0x0601B251 RID: 111185 RVA: 0x003D8D08 File Offset: 0x003D6F08
		public int Id { get; set; }

		// Token: 0x1700803F RID: 32831
		// (get) Token: 0x0601B252 RID: 111186 RVA: 0x003D8D11 File Offset: 0x003D6F11
		// (set) Token: 0x0601B253 RID: 111187 RVA: 0x003D8D19 File Offset: 0x003D6F19
		public string Desc { get; set; }

		// Token: 0x17008040 RID: 32832
		// (get) Token: 0x0601B254 RID: 111188 RVA: 0x003D8D22 File Offset: 0x003D6F22
		// (set) Token: 0x0601B255 RID: 111189 RVA: 0x003D8D2A File Offset: 0x003D6F2A
		public List<TPerformerAiDecoratorUnion> Decorators { get; set; }

		// Token: 0x17008041 RID: 32833
		// (get) Token: 0x0601B256 RID: 111190 RVA: 0x003D8D33 File Offset: 0x003D6F33
		// (set) Token: 0x0601B257 RID: 111191 RVA: 0x003D8D3B File Offset: 0x003D6F3B
		public bool _FoldedForTree { get; set; }

		// Token: 0x17008042 RID: 32834
		// (get) Token: 0x0601B258 RID: 111192 RVA: 0x003D8D44 File Offset: 0x003D6F44
		// (set) Token: 0x0601B259 RID: 111193 RVA: 0x003D8D4C File Offset: 0x003D6F4C
		public List<TPerformerAiNodeUnion> Children { get; set; }

		// Token: 0x17008043 RID: 32835
		// (get) Token: 0x0601B25A RID: 111194 RVA: 0x003D8D55 File Offset: 0x003D6F55
		// (set) Token: 0x0601B25B RID: 111195 RVA: 0x003D8D5D File Offset: 0x003D6F5D
		public byte NullMask { get; set; }

		// Token: 0x0601B25C RID: 111196 RVA: 0x003D8D66 File Offset: 0x003D6F66
		public IPerformerAiSequenceT()
		{
			this.Type = EPerformerAiNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.Children = null;
			this.NullMask = 0;
		}
	}
}
