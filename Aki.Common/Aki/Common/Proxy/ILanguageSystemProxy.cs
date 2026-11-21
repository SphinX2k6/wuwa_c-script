using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000022 RID: 34
	[NullableContext(1)]
	public interface ILanguageSystemProxy
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000155 RID: 341
		// (set) Token: 0x06000156 RID: 342
		bool GmShowLanguageKey { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000157 RID: 343
		// (set) Token: 0x06000158 RID: 344
		string GmReplaceTextContent { get; set; }

		// Token: 0x06000159 RID: 345
		string GetCultureOrDefault([Nullable(2)] string culture);
	}
}
