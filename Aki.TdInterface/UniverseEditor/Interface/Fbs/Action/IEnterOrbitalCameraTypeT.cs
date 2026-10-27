using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066C7 RID: 26311
	public class IEnterOrbitalCameraTypeT
	{
		// Token: 0x1700C382 RID: 50050
		// (get) Token: 0x0602DBDE RID: 187358 RVA: 0x00641E3E File Offset: 0x0064003E
		// (set) Token: 0x0602DBDF RID: 187359 RVA: 0x00641E46 File Offset: 0x00640046
		public EEnterOrbitalCameraType Type { get; set; }

		// Token: 0x0602DBE0 RID: 187360 RVA: 0x00641E4F File Offset: 0x0064004F
		public IEnterOrbitalCameraTypeT()
		{
			this.Type = EEnterOrbitalCameraType.ControlByMove;
		}
	}
}
