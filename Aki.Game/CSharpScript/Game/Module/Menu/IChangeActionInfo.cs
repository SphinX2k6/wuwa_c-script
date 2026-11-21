using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043D7 RID: 17367
	[NullableContext(1)]
	public interface IChangeActionInfo
	{
		// Token: 0x170057D0 RID: 22480
		// (get) Token: 0x0602BE4D RID: 179789
		// (set) Token: 0x0602BE4E RID: 179790
		EInputControllerType InputControllerType { get; set; }

		// Token: 0x170057D1 RID: 22481
		// (get) Token: 0x0602BE4F RID: 179791
		// (set) Token: 0x0602BE50 RID: 179792
		KeySettingRowData KeySettingRowData { get; set; }

		// Token: 0x170057D2 RID: 22482
		// (get) Token: 0x0602BE51 RID: 179793
		// (set) Token: 0x0602BE52 RID: 179794
		Action<bool> OnConfirmCallback { get; set; }
	}
}
