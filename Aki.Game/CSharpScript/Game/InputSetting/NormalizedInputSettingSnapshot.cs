using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FF5 RID: 28661
	public class NormalizedInputSettingSnapshot
	{
		// Token: 0x04024603 RID: 148995
		[Nullable(2)]
		public string KeyboardStorageLang;

		// Token: 0x04024604 RID: 148996
		[Nullable(1)]
		public List<NormalizedOneDeviceInputSetting> DeviceSettings = new List<NormalizedOneDeviceInputSetting>();
	}
}
