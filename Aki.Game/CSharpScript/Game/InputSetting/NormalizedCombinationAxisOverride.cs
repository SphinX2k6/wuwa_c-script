using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FF3 RID: 28659
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalizedCombinationAxisOverride
	{
		// Token: 0x040245F8 RID: 148984
		public string AxisName = "";

		// Token: 0x040245F9 RID: 148985
		public EInputBindingType BindingType;

		// Token: 0x040245FA RID: 148986
		public EKeySettingExclusiveType ExclusiveType;

		// Token: 0x040245FB RID: 148987
		public int Version;

		// Token: 0x040245FC RID: 148988
		public Dictionary<string, string> KeyMap = new Dictionary<string, string>();
	}
}
