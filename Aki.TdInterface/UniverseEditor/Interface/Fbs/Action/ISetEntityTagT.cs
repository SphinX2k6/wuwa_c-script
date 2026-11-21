using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B0 RID: 30640
	public class ISetEntityTagT
	{
		// Token: 0x1700E088 RID: 57480
		// (get) Token: 0x06035CCE RID: 220366 RVA: 0x0073522F File Offset: 0x0073342F
		// (set) Token: 0x06035CCF RID: 220367 RVA: 0x00735237 File Offset: 0x00733437
		public int EntityId { get; set; }

		// Token: 0x1700E089 RID: 57481
		// (get) Token: 0x06035CD0 RID: 220368 RVA: 0x00735240 File Offset: 0x00733440
		// (set) Token: 0x06035CD1 RID: 220369 RVA: 0x00735248 File Offset: 0x00733448
		public string GameplayTag { get; set; }

		// Token: 0x1700E08A RID: 57482
		// (get) Token: 0x06035CD2 RID: 220370 RVA: 0x00735251 File Offset: 0x00733451
		// (set) Token: 0x06035CD3 RID: 220371 RVA: 0x00735259 File Offset: 0x00733459
		public ESetEntityTagType SetType { get; set; }

		// Token: 0x1700E08B RID: 57483
		// (get) Token: 0x06035CD4 RID: 220372 RVA: 0x00735262 File Offset: 0x00733462
		// (set) Token: 0x06035CD5 RID: 220373 RVA: 0x0073526A File Offset: 0x0073346A
		public float DelayTime { get; set; }

		// Token: 0x1700E08C RID: 57484
		// (get) Token: 0x06035CD6 RID: 220374 RVA: 0x00735273 File Offset: 0x00733473
		// (set) Token: 0x06035CD7 RID: 220375 RVA: 0x0073527B File Offset: 0x0073347B
		public bool BeforeHide { get; set; }

		// Token: 0x1700E08D RID: 57485
		// (get) Token: 0x06035CD8 RID: 220376 RVA: 0x00735284 File Offset: 0x00733484
		// (set) Token: 0x06035CD9 RID: 220377 RVA: 0x0073528C File Offset: 0x0073348C
		public byte NullMask { get; set; }

		// Token: 0x06035CDA RID: 220378 RVA: 0x00735295 File Offset: 0x00733495
		public ISetEntityTagT()
		{
			this.EntityId = 0;
			this.GameplayTag = null;
			this.SetType = ESetEntityTagType.Add;
			this.DelayTime = 0f;
			this.BeforeHide = false;
			this.NullMask = 0;
		}
	}
}
