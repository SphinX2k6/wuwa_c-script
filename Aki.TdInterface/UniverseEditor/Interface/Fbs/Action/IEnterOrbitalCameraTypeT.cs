using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D41 RID: 27969
	public class IEnterOrbitalCameraTypeT
	{
		// Token: 0x1700CD33 RID: 52531
		// (get) Token: 0x060303FB RID: 197627 RVA: 0x0068F0F2 File Offset: 0x0068D2F2
		// (set) Token: 0x060303FC RID: 197628 RVA: 0x0068F0FA File Offset: 0x0068D2FA
		public EEnterOrbitalCameraType Type { get; set; }

		// Token: 0x060303FD RID: 197629 RVA: 0x0068F103 File Offset: 0x0068D303
		public IEnterOrbitalCameraTypeT()
		{
			this.Type = EEnterOrbitalCameraType.ControlByMove;
		}
	}
}
