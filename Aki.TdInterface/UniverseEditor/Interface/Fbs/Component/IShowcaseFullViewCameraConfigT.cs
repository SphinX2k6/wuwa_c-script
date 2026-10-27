using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200590F RID: 22799
	public class IShowcaseFullViewCameraConfigT
	{
		// Token: 0x1700AAE5 RID: 43749
		// (get) Token: 0x06026886 RID: 157830 RVA: 0x0054EE73 File Offset: 0x0054D073
		// (set) Token: 0x06026887 RID: 157831 RVA: 0x0054EE7B File Offset: 0x0054D07B
		public float Fov { get; set; }

		// Token: 0x1700AAE6 RID: 43750
		// (get) Token: 0x06026888 RID: 157832 RVA: 0x0054EE84 File Offset: 0x0054D084
		// (set) Token: 0x06026889 RID: 157833 RVA: 0x0054EE8C File Offset: 0x0054D08C
		public IPosAndRotT PosAndRot { get; set; }

		// Token: 0x0602688A RID: 157834 RVA: 0x0054EE95 File Offset: 0x0054D095
		public IShowcaseFullViewCameraConfigT()
		{
			this.Fov = 0f;
			this.PosAndRot = null;
		}
	}
}
