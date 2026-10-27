using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200593C RID: 22844
	public class ISlotShapeT
	{
		// Token: 0x1700AB7B RID: 43899
		// (get) Token: 0x06026A86 RID: 158342 RVA: 0x00553052 File Offset: 0x00551252
		// (set) Token: 0x06026A87 RID: 158343 RVA: 0x0055305A File Offset: 0x0055125A
		public IVectorInfoT Center { get; set; }

		// Token: 0x1700AB7C RID: 43900
		// (get) Token: 0x06026A88 RID: 158344 RVA: 0x00553063 File Offset: 0x00551263
		// (set) Token: 0x06026A89 RID: 158345 RVA: 0x0055306B File Offset: 0x0055126B
		public IVectorInfoT Size { get; set; }

		// Token: 0x1700AB7D RID: 43901
		// (get) Token: 0x06026A8A RID: 158346 RVA: 0x00553074 File Offset: 0x00551274
		// (set) Token: 0x06026A8B RID: 158347 RVA: 0x0055307C File Offset: 0x0055127C
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x06026A8C RID: 158348 RVA: 0x00553085 File Offset: 0x00551285
		public ISlotShapeT()
		{
			this.Center = null;
			this.Size = null;
			this.Rotator = null;
		}
	}
}
