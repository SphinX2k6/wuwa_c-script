using System;
using System.Runtime.CompilerServices;

namespace Aki.Common.Proxy
{
	// Token: 0x02000021 RID: 33
	[NullableContext(1)]
	public interface ILanguageSystemProxy
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000E8 RID: 232
		// (set) Token: 0x060000E9 RID: 233
		bool GmShowLanguageKey { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000EA RID: 234
		// (set) Token: 0x060000EB RID: 235
		string GmReplaceTextContent { get; set; }

		// Token: 0x060000EC RID: 236
		string GetCultureOrDefault([Nullable(2)] string culture);
	}
}
