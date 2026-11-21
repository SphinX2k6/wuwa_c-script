using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E4 RID: 29156
	public class IModifyActorMaterialParamBySplineProgressTargetT
	{
		// Token: 0x1700D578 RID: 54648
		// (get) Token: 0x06032B90 RID: 207760 RVA: 0x006DA14E File Offset: 0x006D834E
		// (set) Token: 0x06032B91 RID: 207761 RVA: 0x006DA156 File Offset: 0x006D8356
		public ECommonTargetType Type { get; set; }

		// Token: 0x06032B92 RID: 207762 RVA: 0x006DA15F File Offset: 0x006D835F
		public IModifyActorMaterialParamBySplineProgressTargetT()
		{
			this.Type = ECommonTargetType.Player;
		}
	}
}
