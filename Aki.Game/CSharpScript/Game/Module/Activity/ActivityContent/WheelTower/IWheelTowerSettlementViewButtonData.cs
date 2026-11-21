using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F26 RID: 20262
	[NullableContext(1)]
	public interface IWheelTowerSettlementViewButtonData
	{
		// Token: 0x1700634E RID: 25422
		// (get) Token: 0x06032EBC RID: 208572
		// (set) Token: 0x06032EBD RID: 208573
		string Name { get; set; }

		// Token: 0x1700634F RID: 25423
		// (get) Token: 0x06032EBE RID: 208574
		// (set) Token: 0x06032EBF RID: 208575
		Action OnClick { get; set; }

		// Token: 0x17006350 RID: 25424
		// (get) Token: 0x06032EC0 RID: 208576
		// (set) Token: 0x06032EC1 RID: 208577
		EConfirmBoxConfigId? ConfirmBoxId { get; set; }
	}
}
