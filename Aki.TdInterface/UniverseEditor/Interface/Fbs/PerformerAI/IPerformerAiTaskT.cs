using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200437F RID: 17279
	public class IPerformerAiTaskT
	{
		// Token: 0x17007A28 RID: 31272
		// (get) Token: 0x06019B3F RID: 105279 RVA: 0x003AE8D6 File Offset: 0x003ACAD6
		// (set) Token: 0x06019B40 RID: 105280 RVA: 0x003AE8DE File Offset: 0x003ACADE
		public EPerformerAiNodeType Type { get; set; }

		// Token: 0x17007A29 RID: 31273
		// (get) Token: 0x06019B41 RID: 105281 RVA: 0x003AE8E7 File Offset: 0x003ACAE7
		// (set) Token: 0x06019B42 RID: 105282 RVA: 0x003AE8EF File Offset: 0x003ACAEF
		public int Id { get; set; }

		// Token: 0x17007A2A RID: 31274
		// (get) Token: 0x06019B43 RID: 105283 RVA: 0x003AE8F8 File Offset: 0x003ACAF8
		// (set) Token: 0x06019B44 RID: 105284 RVA: 0x003AE900 File Offset: 0x003ACB00
		public string Desc { get; set; }

		// Token: 0x17007A2B RID: 31275
		// (get) Token: 0x06019B45 RID: 105285 RVA: 0x003AE909 File Offset: 0x003ACB09
		// (set) Token: 0x06019B46 RID: 105286 RVA: 0x003AE911 File Offset: 0x003ACB11
		public List<TPerformerAiDecoratorUnion> Decorators { get; set; }

		// Token: 0x17007A2C RID: 31276
		// (get) Token: 0x06019B47 RID: 105287 RVA: 0x003AE91A File Offset: 0x003ACB1A
		// (set) Token: 0x06019B48 RID: 105288 RVA: 0x003AE922 File Offset: 0x003ACB22
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007A2D RID: 31277
		// (get) Token: 0x06019B49 RID: 105289 RVA: 0x003AE92B File Offset: 0x003ACB2B
		// (set) Token: 0x06019B4A RID: 105290 RVA: 0x003AE933 File Offset: 0x003ACB33
		public IActionInfoT Action { get; set; }

		// Token: 0x17007A2E RID: 31278
		// (get) Token: 0x06019B4B RID: 105291 RVA: 0x003AE93C File Offset: 0x003ACB3C
		// (set) Token: 0x06019B4C RID: 105292 RVA: 0x003AE944 File Offset: 0x003ACB44
		public byte NullMask { get; set; }

		// Token: 0x06019B4D RID: 105293 RVA: 0x003AE94D File Offset: 0x003ACB4D
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
