using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Wrapper.Out
{
	// Token: 0x02000F60 RID: 3936
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public static class WrapperSetting
	{
		// Token: 0x0600582E RID: 22574 RVA: 0x000D7984 File Offset: 0x000D5B84
		public static bool IsSkipVerifyField(string interfaceName, string fieldName)
		{
			HashSet<string> hashSet;
			return WrapperSetting.SkipVerifyFields.TryGetValue(interfaceName, out hashSet) && hashSet.Contains(fieldName);
		}

		// Token: 0x040032A5 RID: 12965
		public const bool UseFb = true;

		// Token: 0x040032A6 RID: 12966
		public const int UniverseEditorConfigPakchunkIndex = 43;

		// Token: 0x040032A7 RID: 12967
		public static readonly Dictionary<string, HashSet<string>> SkipVerifyFields = new Dictionary<string, HashSet<string>>
		{
			{
				"IEntityBundleChildInfo",
				new HashSet<string>
				{
					"DiffDataByBundle"
				}
			}
		};
	}
}
