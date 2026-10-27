using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200629D RID: 25245
	public class ICameraPosAndRotT
	{
		// Token: 0x1700BC6F RID: 48239
		// (get) Token: 0x0602B9E3 RID: 178659 RVA: 0x00601356 File Offset: 0x005FF556
		// (set) Token: 0x0602B9E4 RID: 178660 RVA: 0x0060135E File Offset: 0x005FF55E
		public IVectorInfoT CameraOffset { get; set; }

		// Token: 0x1700BC70 RID: 48240
		// (get) Token: 0x0602B9E5 RID: 178661 RVA: 0x00601367 File Offset: 0x005FF567
		// (set) Token: 0x0602B9E6 RID: 178662 RVA: 0x0060136F File Offset: 0x005FF56F
		public IVectorInfoT CameraRotate { get; set; }

		// Token: 0x0602B9E7 RID: 178663 RVA: 0x00601378 File Offset: 0x005FF578
		public ICameraPosAndRotT()
		{
			this.CameraOffset = null;
			this.CameraRotate = null;
		}
	}
}
