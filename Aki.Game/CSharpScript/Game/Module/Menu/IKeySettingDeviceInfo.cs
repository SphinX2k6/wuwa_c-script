using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043DA RID: 17370
	[NullableContext(1)]
	public interface IKeySettingDeviceInfo
	{
		// Token: 0x170057D6 RID: 22486
		// (get) Token: 0x0602BE5A RID: 179802
		// (set) Token: 0x0602BE5B RID: 179803
		EKeySettingDeviceType DeviceType { get; set; }

		// Token: 0x170057D7 RID: 22487
		// (get) Token: 0x0602BE5C RID: 179804
		// (set) Token: 0x0602BE5D RID: 179805
		string NameTextId { get; set; }
	}
}
