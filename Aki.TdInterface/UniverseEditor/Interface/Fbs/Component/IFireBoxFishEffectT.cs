using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005259 RID: 21081
	public class IFireBoxFishEffectT
	{
		// Token: 0x17009A69 RID: 39529
		// (get) Token: 0x060224B1 RID: 140465 RVA: 0x004C148B File Offset: 0x004BF68B
		// (set) Token: 0x060224B2 RID: 140466 RVA: 0x004C1493 File Offset: 0x004BF693
		public EGraph3dEffectType Type { get; set; }

		// Token: 0x17009A6A RID: 39530
		// (get) Token: 0x060224B3 RID: 140467 RVA: 0x004C149C File Offset: 0x004BF69C
		// (set) Token: 0x060224B4 RID: 140468 RVA: 0x004C14A4 File Offset: 0x004BF6A4
		public string Effect { get; set; }

		// Token: 0x060224B5 RID: 140469 RVA: 0x004C14AD File Offset: 0x004BF6AD
		public IFireBoxFishEffectT()
		{
			this.Type = EGraph3dEffectType.FireBoxFish;
			this.Effect = null;
		}
	}
}
