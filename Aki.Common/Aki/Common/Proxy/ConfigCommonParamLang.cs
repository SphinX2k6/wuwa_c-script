using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x0200001E RID: 30
	[NullableContext(2)]
	[Nullable(0)]
	public class ConfigCommonParamLang
	{
		// Token: 0x06000138 RID: 312 RVA: 0x0000E9E1 File Offset: 0x0000CBE1
		public static string GetLocalText(int id, string culture = null)
		{
			Func<int, string, string> getLocalTextFunc = ConfigCommonParamLang.GetLocalTextFunc;
			if (getLocalTextFunc == null)
			{
				return null;
			}
			return getLocalTextFunc(id, culture);
		}

		// Token: 0x04000226 RID: 550
		public static Func<int, string, string> GetLocalTextFunc;
	}
}
