using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CBB RID: 27835
	public class IPhotographCameraTransformBaseT
	{
		// Token: 0x1700CF3C RID: 53052
		// (get) Token: 0x060310E1 RID: 200929 RVA: 0x006A85E6 File Offset: 0x006A67E6
		// (set) Token: 0x060310E2 RID: 200930 RVA: 0x006A85EE File Offset: 0x006A67EE
		public EPhotographCameraTransform Type { get; set; }

		// Token: 0x060310E3 RID: 200931 RVA: 0x006A85F7 File Offset: 0x006A67F7
		public IPhotographCameraTransformBaseT()
		{
			this.Type = EPhotographCameraTransform.Absolute;
		}
	}
}
