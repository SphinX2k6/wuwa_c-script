using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Menu;

namespace CSharpScript.Game.Module.KeySetting
{
	// Token: 0x0200477F RID: 18303
	[NullableContext(1)]
	[Nullable(0)]
	public class KeySettingDeviceInfoClass : IKeySettingDeviceInfo
	{
		// Token: 0x17005C9B RID: 23707
		// (get) Token: 0x0602DF4B RID: 188235 RVA: 0x00CDC424 File Offset: 0x00CDA624
		// (set) Token: 0x0602DF4C RID: 188236 RVA: 0x00CDC42C File Offset: 0x00CDA62C
		public EKeySettingDeviceType DeviceType { get; set; }

		// Token: 0x17005C9C RID: 23708
		// (get) Token: 0x0602DF4D RID: 188237 RVA: 0x00CDC435 File Offset: 0x00CDA635
		// (set) Token: 0x0602DF4E RID: 188238 RVA: 0x00CDC43D File Offset: 0x00CDA63D
		public string NameTextId { get; set; } = "";
	}
}
