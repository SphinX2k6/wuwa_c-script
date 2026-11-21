using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043DB RID: 17371
	[NullableContext(1)]
	[Nullable(0)]
	public class KeySettingDeviceInfo : IKeySettingDeviceInfo
	{
		// Token: 0x170057D8 RID: 22488
		// (get) Token: 0x0602BE5E RID: 179806 RVA: 0x00C54260 File Offset: 0x00C52460
		// (set) Token: 0x0602BE5F RID: 179807 RVA: 0x00C54268 File Offset: 0x00C52468
		public EKeySettingDeviceType DeviceType { get; set; }

		// Token: 0x170057D9 RID: 22489
		// (get) Token: 0x0602BE60 RID: 179808 RVA: 0x00C54271 File Offset: 0x00C52471
		// (set) Token: 0x0602BE61 RID: 179809 RVA: 0x00C54279 File Offset: 0x00C52479
		public string NameTextId { get; set; } = "";
	}
}
