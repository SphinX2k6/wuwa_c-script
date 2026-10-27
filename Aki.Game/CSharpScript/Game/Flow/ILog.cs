using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x02007249 RID: 29257
	[NullableContext(1)]
	public interface ILog
	{
		// Token: 0x17009E59 RID: 40537
		// (get) Token: 0x06047B96 RID: 293782
		// (set) Token: 0x06047B97 RID: 293783
		string Level { get; set; }

		// Token: 0x17009E5A RID: 40538
		// (get) Token: 0x06047B98 RID: 293784
		// (set) Token: 0x06047B99 RID: 293785
		string Content { get; set; }
	}
}
