using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006172 RID: 24946
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalizedAxisOverride
	{
		// Token: 0x0401F8A4 RID: 129188
		public string AxisName = "";

		// Token: 0x0401F8A5 RID: 129189
		public EInputBindingType BindingType;

		// Token: 0x0401F8A6 RID: 129190
		public EKeySettingExclusiveType ExclusiveType;

		// Token: 0x0401F8A7 RID: 129191
		public int Version;

		// Token: 0x0401F8A8 RID: 129192
		public Dictionary<string, float> KeyScaleMap = new Dictionary<string, float>();
	}
}
