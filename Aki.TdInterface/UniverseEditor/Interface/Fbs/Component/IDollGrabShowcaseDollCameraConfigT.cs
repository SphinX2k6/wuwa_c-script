using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050A9 RID: 20649
	public class IDollGrabShowcaseDollCameraConfigT
	{
		// Token: 0x17009612 RID: 38418
		// (get) Token: 0x060212C3 RID: 135875 RVA: 0x0049C003 File Offset: 0x0049A203
		// (set) Token: 0x060212C4 RID: 135876 RVA: 0x0049C00B File Offset: 0x0049A20B
		public IShowcaseFullViewCameraConfigT FullViewCamera { get; set; }

		// Token: 0x17009613 RID: 38419
		// (get) Token: 0x060212C5 RID: 135877 RVA: 0x0049C014 File Offset: 0x0049A214
		// (set) Token: 0x060212C6 RID: 135878 RVA: 0x0049C01C File Offset: 0x0049A21C
		public IDollComboCameraT DollCamera { get; set; }

		// Token: 0x060212C7 RID: 135879 RVA: 0x0049C025 File Offset: 0x0049A225
		public IDollGrabShowcaseDollCameraConfigT()
		{
			this.FullViewCamera = null;
			this.DollCamera = null;
		}
	}
}
