using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F3F RID: 24383
	[NullableContext(1)]
	public interface IWheelTowerSettlementViewButtonData
	{
		// Token: 0x17008F7C RID: 36732
		// (get) Token: 0x0603DF21 RID: 253729
		// (set) Token: 0x0603DF22 RID: 253730
		string Name { get; set; }

		// Token: 0x17008F7D RID: 36733
		// (get) Token: 0x0603DF23 RID: 253731
		// (set) Token: 0x0603DF24 RID: 253732
		Action OnClick { get; set; }

		// Token: 0x17008F7E RID: 36734
		// (get) Token: 0x0603DF25 RID: 253733
		// (set) Token: 0x0603DF26 RID: 253734
		EConfirmBoxConfigId? ConfirmBoxId { get; set; }
	}
}
