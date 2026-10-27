using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FF0 RID: 28656
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalizedActionOverride
	{
		// Token: 0x040245E9 RID: 148969
		public string ActionName = "";

		// Token: 0x040245EA RID: 148970
		public EInputBindingType BindingType;

		// Token: 0x040245EB RID: 148971
		public EKeySettingExclusiveType ExclusiveType;

		// Token: 0x040245EC RID: 148972
		public int Version;

		// Token: 0x040245ED RID: 148973
		public List<string> KeyNameList = new List<string>();
	}
}
