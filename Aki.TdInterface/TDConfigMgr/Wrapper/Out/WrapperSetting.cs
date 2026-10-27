using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Wrapper.Out
{
	// Token: 0x02000E4F RID: 3663
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public static class WrapperSetting
	{
		// Token: 0x060052B2 RID: 21170 RVA: 0x000CB7D0 File Offset: 0x000C99D0
		static WrapperSetting()
		{
			WrapperSetting.UseFb = true;
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x000CB804 File Offset: 0x000C9A04
		public static bool IsSkipVerifyField(string interfaceName, string fieldName)
		{
			HashSet<string> hashSet;
			return WrapperSetting.SkipVerifyFields.TryGetValue(interfaceName, out hashSet) && hashSet.Contains(fieldName);
		}

		// Token: 0x04002FAE RID: 12206
		public const int UniverseEditorConfigPakchunkIndex = 43;

		// Token: 0x04002FAF RID: 12207
		public static bool UseFb = true;

		// Token: 0x04002FB0 RID: 12208
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
