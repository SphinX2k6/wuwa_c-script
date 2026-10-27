using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Menu;

namespace CSharpScript.Game.Module.KeySetting
{
	// Token: 0x020057A8 RID: 22440
	[NullableContext(1)]
	[Nullable(0)]
	public class KeySettingDeviceInfoClass : IKeySettingDeviceInfo
	{
		// Token: 0x170088D3 RID: 35027
		// (get) Token: 0x0603903B RID: 233531 RVA: 0x00D8D668 File Offset: 0x00D8B868
		// (set) Token: 0x0603903C RID: 233532 RVA: 0x00D8D670 File Offset: 0x00D8B870
		public EKeySettingDeviceType DeviceType { get; set; }

		// Token: 0x170088D4 RID: 35028
		// (get) Token: 0x0603903D RID: 233533 RVA: 0x00D8D679 File Offset: 0x00D8B879
		// (set) Token: 0x0603903E RID: 233534 RVA: 0x00D8D681 File Offset: 0x00D8B881
		public string NameTextId { get; set; } = "";
	}
}
