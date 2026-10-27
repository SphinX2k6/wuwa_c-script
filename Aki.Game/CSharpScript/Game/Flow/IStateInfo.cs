using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x02007244 RID: 29252
	[NullableContext(1)]
	public interface IStateInfo
	{
		// Token: 0x17009E4A RID: 40522
		// (get) Token: 0x06047B76 RID: 293750
		// (set) Token: 0x06047B77 RID: 293751
		int Id { get; set; }

		// Token: 0x17009E4B RID: 40523
		// (get) Token: 0x06047B78 RID: 293752
		// (set) Token: 0x06047B79 RID: 293753
		string Name { get; set; }

		// Token: 0x17009E4C RID: 40524
		// (get) Token: 0x06047B7A RID: 293754
		// (set) Token: 0x06047B7B RID: 293755
		bool? _folded { get; set; }

		// Token: 0x17009E4D RID: 40525
		// (get) Token: 0x06047B7C RID: 293756
		// (set) Token: 0x06047B7D RID: 293757
		IActionInfo[] Actions { get; set; }
	}
}
