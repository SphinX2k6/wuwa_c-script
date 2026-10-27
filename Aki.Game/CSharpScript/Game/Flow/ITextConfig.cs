using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x02007246 RID: 29254
	[NullableContext(1)]
	public interface ITextConfig
	{
		// Token: 0x17009E53 RID: 40531
		// (get) Token: 0x06047B88 RID: 293768
		// (set) Token: 0x06047B89 RID: 293769
		string Text { get; set; }

		// Token: 0x17009E54 RID: 40532
		// (get) Token: 0x06047B8A RID: 293770
		// (set) Token: 0x06047B8B RID: 293771
		string Sound { get; set; }

		// Token: 0x17009E55 RID: 40533
		// (get) Token: 0x06047B8C RID: 293772
		// (set) Token: 0x06047B8D RID: 293773
		string EsKey { get; set; }
	}
}
