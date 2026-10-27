using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C47 RID: 15431
	public class ISphereTriggerTipShapeT
	{
		// Token: 0x17006A56 RID: 27222
		// (get) Token: 0x06015531 RID: 87345 RVA: 0x00315F41 File Offset: 0x00314141
		// (set) Token: 0x06015532 RID: 87346 RVA: 0x00315F49 File Offset: 0x00314149
		public ETriggerTipShape Type { get; set; }

		// Token: 0x17006A57 RID: 27223
		// (get) Token: 0x06015533 RID: 87347 RVA: 0x00315F52 File Offset: 0x00314152
		// (set) Token: 0x06015534 RID: 87348 RVA: 0x00315F5A File Offset: 0x0031415A
		public IVectorInfoT Center { get; set; }

		// Token: 0x17006A58 RID: 27224
		// (get) Token: 0x06015535 RID: 87349 RVA: 0x00315F63 File Offset: 0x00314163
		// (set) Token: 0x06015536 RID: 87350 RVA: 0x00315F6B File Offset: 0x0031416B
		public int Radius { get; set; }

		// Token: 0x06015537 RID: 87351 RVA: 0x00315F74 File Offset: 0x00314174
		public ISphereTriggerTipShapeT()
		{
			this.Type = ETriggerTipShape.Box;
			this.Center = null;
			this.Radius = 0;
		}
	}
}
