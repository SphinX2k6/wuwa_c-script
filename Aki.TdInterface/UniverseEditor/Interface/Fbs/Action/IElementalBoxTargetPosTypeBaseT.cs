using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA2 RID: 27810
	public class IElementalBoxTargetPosTypeBaseT
	{
		// Token: 0x1700CBFC RID: 52220
		// (get) Token: 0x0602FEBE RID: 196286 RVA: 0x0068604E File Offset: 0x0068424E
		// (set) Token: 0x0602FEBF RID: 196287 RVA: 0x00686056 File Offset: 0x00684256
		public EElementalBoxTargetPosType Type { get; set; }

		// Token: 0x0602FEC0 RID: 196288 RVA: 0x0068605F File Offset: 0x0068425F
		public IElementalBoxTargetPosTypeBaseT()
		{
			this.Type = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
		}
	}
}
