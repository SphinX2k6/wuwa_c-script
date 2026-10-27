using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FF1 RID: 28657
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalizedAxisOverride
	{
		// Token: 0x040245EE RID: 148974
		public string AxisName = "";

		// Token: 0x040245EF RID: 148975
		public EInputBindingType BindingType;

		// Token: 0x040245F0 RID: 148976
		public EKeySettingExclusiveType ExclusiveType;

		// Token: 0x040245F1 RID: 148977
		public int Version;

		// Token: 0x040245F2 RID: 148978
		public Dictionary<string, float> KeyScaleMap = new Dictionary<string, float>();
	}
}
