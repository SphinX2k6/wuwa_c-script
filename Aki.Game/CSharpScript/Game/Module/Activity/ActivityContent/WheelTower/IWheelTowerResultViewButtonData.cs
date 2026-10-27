using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F41 RID: 24385
	[NullableContext(1)]
	public interface IWheelTowerResultViewButtonData
	{
		// Token: 0x17008F82 RID: 36738
		// (get) Token: 0x0603DF2E RID: 253742
		// (set) Token: 0x0603DF2F RID: 253743
		string Name { get; set; }

		// Token: 0x17008F83 RID: 36739
		// (get) Token: 0x0603DF30 RID: 253744
		// (set) Token: 0x0603DF31 RID: 253745
		Action OnClick { get; set; }

		// Token: 0x17008F84 RID: 36740
		// (get) Token: 0x0603DF32 RID: 253746
		// (set) Token: 0x0603DF33 RID: 253747
		EConfirmBoxConfigId? ConfirmBoxId { get; set; }
	}
}
