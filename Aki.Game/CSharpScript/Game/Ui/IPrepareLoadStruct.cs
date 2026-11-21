using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035F6 RID: 13814
	[NullableContext(1)]
	public interface IPrepareLoadStruct
	{
		// Token: 0x17004927 RID: 18727
		// (get) Token: 0x060232DC RID: 144092
		string ResourceId { get; }

		// Token: 0x17004928 RID: 18728
		// (get) Token: 0x060232DD RID: 144093
		Func<int> CacheCount { get; }
	}
}
