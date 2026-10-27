using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FF2 RID: 28658
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalizedCombinationActionOverride
	{
		// Token: 0x040245F3 RID: 148979
		public string ActionName = "";

		// Token: 0x040245F4 RID: 148980
		public EInputBindingType BindingType;

		// Token: 0x040245F5 RID: 148981
		public EKeySettingExclusiveType ExclusiveType;

		// Token: 0x040245F6 RID: 148982
		public int Version;

		// Token: 0x040245F7 RID: 148983
		public Dictionary<string, string> KeyMap = new Dictionary<string, string>();
	}
}
