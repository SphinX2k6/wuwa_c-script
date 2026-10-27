using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F6 RID: 26614
	public class IFlowCameraShakeT
	{
		// Token: 0x1700C590 RID: 50576
		// (get) Token: 0x0602E57F RID: 189823 RVA: 0x006537D9 File Offset: 0x006519D9
		// (set) Token: 0x0602E580 RID: 189824 RVA: 0x006537E1 File Offset: 0x006519E1
		public string CameraShakeBp { get; set; }

		// Token: 0x0602E581 RID: 189825 RVA: 0x006537EA File Offset: 0x006519EA
		public IFlowCameraShakeT()
		{
			this.CameraShakeBp = null;
		}
	}
}
