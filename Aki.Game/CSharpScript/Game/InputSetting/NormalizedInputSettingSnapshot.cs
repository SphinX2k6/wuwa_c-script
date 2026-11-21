using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006176 RID: 24950
	public class NormalizedInputSettingSnapshot
	{
		// Token: 0x0401F8B9 RID: 129209
		[Nullable(2)]
		public string KeyboardStorageLang;

		// Token: 0x0401F8BA RID: 129210
		[Nullable(1)]
		public List<NormalizedOneDeviceInputSetting> DeviceSettings = new List<NormalizedOneDeviceInputSetting>();
	}
}
