using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006174 RID: 24948
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalizedCombinationAxisOverride
	{
		// Token: 0x0401F8AE RID: 129198
		public string AxisName = "";

		// Token: 0x0401F8AF RID: 129199
		public EInputBindingType BindingType;

		// Token: 0x0401F8B0 RID: 129200
		public EKeySettingExclusiveType ExclusiveType;

		// Token: 0x0401F8B1 RID: 129201
		public int Version;

		// Token: 0x0401F8B2 RID: 129202
		public Dictionary<string, string> KeyMap = new Dictionary<string, string>();
	}
}
