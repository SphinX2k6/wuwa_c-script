using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006171 RID: 24945
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalizedActionOverride
	{
		// Token: 0x0401F89F RID: 129183
		public string ActionName = "";

		// Token: 0x0401F8A0 RID: 129184
		public EInputBindingType BindingType;

		// Token: 0x0401F8A1 RID: 129185
		public EKeySettingExclusiveType ExclusiveType;

		// Token: 0x0401F8A2 RID: 129186
		public int Version;

		// Token: 0x0401F8A3 RID: 129187
		public List<string> KeyNameList = new List<string>();
	}
}
