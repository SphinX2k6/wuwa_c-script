using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x0200001D RID: 29
	[NullableContext(2)]
	[Nullable(0)]
	public class ConfigCommonParamLang
	{
		// Token: 0x060000CB RID: 203 RVA: 0x0000B215 File Offset: 0x00009415
		public static string GetLocalText(int id, string culture = null)
		{
			Func<int, string, string> getLocalTextFunc = ConfigCommonParamLang.GetLocalTextFunc;
			if (getLocalTextFunc == null)
			{
				return null;
			}
			return getLocalTextFunc(id, culture);
		}

		// Token: 0x04000221 RID: 545
		public static Func<int, string, string> GetLocalTextFunc;
	}
}
