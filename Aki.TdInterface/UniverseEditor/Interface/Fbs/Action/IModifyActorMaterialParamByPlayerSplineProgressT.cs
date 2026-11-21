using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D2 RID: 29138
	public class IModifyActorMaterialParamByPlayerSplineProgressT
	{
		// Token: 0x1700D559 RID: 54617
		// (get) Token: 0x06032AF6 RID: 207606 RVA: 0x006D8D2E File Offset: 0x006D6F2E
		// (set) Token: 0x06032AF7 RID: 207607 RVA: 0x006D8D36 File Offset: 0x006D6F36
		public ECommonTargetType Type { get; set; }

		// Token: 0x06032AF8 RID: 207608 RVA: 0x006D8D3F File Offset: 0x006D6F3F
		public IModifyActorMaterialParamByPlayerSplineProgressT()
		{
			this.Type = ECommonTargetType.Player;
		}
	}
}
