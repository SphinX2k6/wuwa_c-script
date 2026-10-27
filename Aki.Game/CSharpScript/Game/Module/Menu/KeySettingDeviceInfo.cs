using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053F8 RID: 21496
	[NullableContext(1)]
	[Nullable(0)]
	public class KeySettingDeviceInfo : IKeySettingDeviceInfo
	{
		// Token: 0x1700840C RID: 33804
		// (get) Token: 0x06036F16 RID: 225046 RVA: 0x00D04E1C File Offset: 0x00D0301C
		// (set) Token: 0x06036F17 RID: 225047 RVA: 0x00D04E24 File Offset: 0x00D03024
		public EKeySettingDeviceType DeviceType { get; set; }

		// Token: 0x1700840D RID: 33805
		// (get) Token: 0x06036F18 RID: 225048 RVA: 0x00D04E2D File Offset: 0x00D0302D
		// (set) Token: 0x06036F19 RID: 225049 RVA: 0x00D04E35 File Offset: 0x00D03035
		public string NameTextId { get; set; } = "";
	}
}
