using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E76 RID: 28278
	public class IFlowCameraShakeT
	{
		// Token: 0x1700CF46 RID: 53062
		// (get) Token: 0x06030DC5 RID: 200133 RVA: 0x006A0F1D File Offset: 0x0069F11D
		// (set) Token: 0x06030DC6 RID: 200134 RVA: 0x006A0F25 File Offset: 0x0069F125
		public string CameraShakeBp { get; set; }

		// Token: 0x06030DC7 RID: 200135 RVA: 0x006A0F2E File Offset: 0x0069F12E
		public IFlowCameraShakeT()
		{
			this.CameraShakeBp = null;
		}
	}
}
