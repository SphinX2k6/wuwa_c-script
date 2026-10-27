using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053F7 RID: 21495
	[NullableContext(1)]
	public interface IKeySettingDeviceInfo
	{
		// Token: 0x1700840A RID: 33802
		// (get) Token: 0x06036F12 RID: 225042
		// (set) Token: 0x06036F13 RID: 225043
		EKeySettingDeviceType DeviceType { get; set; }

		// Token: 0x1700840B RID: 33803
		// (get) Token: 0x06036F14 RID: 225044
		// (set) Token: 0x06036F15 RID: 225045
		string NameTextId { get; set; }
	}
}
