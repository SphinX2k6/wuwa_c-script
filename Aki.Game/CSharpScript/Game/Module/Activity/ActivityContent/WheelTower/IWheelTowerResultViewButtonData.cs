using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F28 RID: 20264
	[NullableContext(1)]
	public interface IWheelTowerResultViewButtonData
	{
		// Token: 0x17006354 RID: 25428
		// (get) Token: 0x06032EC9 RID: 208585
		// (set) Token: 0x06032ECA RID: 208586
		string Name { get; set; }

		// Token: 0x17006355 RID: 25429
		// (get) Token: 0x06032ECB RID: 208587
		// (set) Token: 0x06032ECC RID: 208588
		Action OnClick { get; set; }

		// Token: 0x17006356 RID: 25430
		// (get) Token: 0x06032ECD RID: 208589
		// (set) Token: 0x06032ECE RID: 208590
		EConfirmBoxConfigId? ConfirmBoxId { get; set; }
	}
}
