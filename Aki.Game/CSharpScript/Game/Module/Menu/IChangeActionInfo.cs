using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053F4 RID: 21492
	[NullableContext(1)]
	public interface IChangeActionInfo
	{
		// Token: 0x17008404 RID: 33796
		// (get) Token: 0x06036F05 RID: 225029
		// (set) Token: 0x06036F06 RID: 225030
		EInputControllerType InputControllerType { get; set; }

		// Token: 0x17008405 RID: 33797
		// (get) Token: 0x06036F07 RID: 225031
		// (set) Token: 0x06036F08 RID: 225032
		KeySettingRowData KeySettingRowData { get; set; }

		// Token: 0x17008406 RID: 33798
		// (get) Token: 0x06036F09 RID: 225033
		// (set) Token: 0x06036F0A RID: 225034
		Action<bool> OnConfirmCallback { get; set; }
	}
}
