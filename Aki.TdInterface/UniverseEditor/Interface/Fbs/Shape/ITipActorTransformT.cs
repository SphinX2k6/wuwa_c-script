using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C59 RID: 15449
	public class ITipActorTransformT
	{
		// Token: 0x17006A92 RID: 27282
		// (get) Token: 0x060155F3 RID: 87539 RVA: 0x00317560 File Offset: 0x00315760
		// (set) Token: 0x060155F4 RID: 87540 RVA: 0x00317568 File Offset: 0x00315768
		public ETipsActorTransformType Type { get; set; }

		// Token: 0x17006A93 RID: 27283
		// (get) Token: 0x060155F5 RID: 87541 RVA: 0x00317571 File Offset: 0x00315771
		// (set) Token: 0x060155F6 RID: 87542 RVA: 0x00317579 File Offset: 0x00315779
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006A94 RID: 27284
		// (get) Token: 0x060155F7 RID: 87543 RVA: 0x00317582 File Offset: 0x00315782
		// (set) Token: 0x060155F8 RID: 87544 RVA: 0x0031758A File Offset: 0x0031578A
		public IVectorInfoT Rot { get; set; }

		// Token: 0x060155F9 RID: 87545 RVA: 0x00317593 File Offset: 0x00315793
		public ITipActorTransformT()
		{
			this.Type = ETipsActorTransformType.Absolute;
			this.Pos = null;
			this.Rot = null;
		}
	}
}
