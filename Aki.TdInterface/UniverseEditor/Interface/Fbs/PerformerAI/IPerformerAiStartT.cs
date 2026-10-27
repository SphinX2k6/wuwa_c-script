using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200437C RID: 17276
	public class IPerformerAiStartT
	{
		// Token: 0x17007A18 RID: 31256
		// (get) Token: 0x06019B03 RID: 105219 RVA: 0x003ADEB7 File Offset: 0x003AC0B7
		// (set) Token: 0x06019B04 RID: 105220 RVA: 0x003ADEBF File Offset: 0x003AC0BF
		public EPerformerAiNodeType Type { get; set; }

		// Token: 0x17007A19 RID: 31257
		// (get) Token: 0x06019B05 RID: 105221 RVA: 0x003ADEC8 File Offset: 0x003AC0C8
		// (set) Token: 0x06019B06 RID: 105222 RVA: 0x003ADED0 File Offset: 0x003AC0D0
		public int Id { get; set; }

		// Token: 0x17007A1A RID: 31258
		// (get) Token: 0x06019B07 RID: 105223 RVA: 0x003ADED9 File Offset: 0x003AC0D9
		// (set) Token: 0x06019B08 RID: 105224 RVA: 0x003ADEE1 File Offset: 0x003AC0E1
		public string Desc { get; set; }

		// Token: 0x17007A1B RID: 31259
		// (get) Token: 0x06019B09 RID: 105225 RVA: 0x003ADEEA File Offset: 0x003AC0EA
		// (set) Token: 0x06019B0A RID: 105226 RVA: 0x003ADEF2 File Offset: 0x003AC0F2
		public List<TPerformerAiDecoratorUnion> Decorators { get; set; }

		// Token: 0x17007A1C RID: 31260
		// (get) Token: 0x06019B0B RID: 105227 RVA: 0x003ADEFB File Offset: 0x003AC0FB
		// (set) Token: 0x06019B0C RID: 105228 RVA: 0x003ADF03 File Offset: 0x003AC103
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007A1D RID: 31261
		// (get) Token: 0x06019B0D RID: 105229 RVA: 0x003ADF0C File Offset: 0x003AC10C
		// (set) Token: 0x06019B0E RID: 105230 RVA: 0x003ADF14 File Offset: 0x003AC114
		public TPerformerAiNodeUnion Child { get; set; }

		// Token: 0x17007A1E RID: 31262
		// (get) Token: 0x06019B0F RID: 105231 RVA: 0x003ADF1D File Offset: 0x003AC11D
		// (set) Token: 0x06019B10 RID: 105232 RVA: 0x003ADF25 File Offset: 0x003AC125
		public byte NullMask { get; set; }

		// Token: 0x06019B11 RID: 105233 RVA: 0x003ADF2E File Offset: 0x003AC12E
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
