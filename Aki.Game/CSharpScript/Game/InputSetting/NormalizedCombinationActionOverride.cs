using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006173 RID: 24947
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalizedCombinationActionOverride
	{
		// Token: 0x0401F8A9 RID: 129193
		public string ActionName = "";

		// Token: 0x0401F8AA RID: 129194
		public EInputBindingType BindingType;

		// Token: 0x0401F8AB RID: 129195
		public EKeySettingExclusiveType ExclusiveType;

		// Token: 0x0401F8AC RID: 129196
		public int Version;

		// Token: 0x0401F8AD RID: 129197
		public Dictionary<string, string> KeyMap = new Dictionary<string, string>();
	}
}
