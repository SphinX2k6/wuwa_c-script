using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064C6 RID: 25798
	public class IConstantCameraShakeT
	{
		// Token: 0x1700BFFA RID: 49146
		// (get) Token: 0x0602CBFA RID: 183290 RVA: 0x006269FE File Offset: 0x00624BFE
		// (set) Token: 0x0602CBFB RID: 183291 RVA: 0x00626A06 File Offset: 0x00624C06
		public ECameraShakeType Type { get; set; }

		// Token: 0x0602CBFC RID: 183292 RVA: 0x00626A0F File Offset: 0x00624C0F
		public IConstantCameraShakeT()
		{
			this.Type = ECameraShakeType.Constant;
		}
	}
}
