using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x02007243 RID: 29251
	[NullableContext(1)]
	public interface IActionInfo
	{
		// Token: 0x17009E47 RID: 40519
		// (get) Token: 0x06047B70 RID: 293744
		// (set) Token: 0x06047B71 RID: 293745
		string Name { get; set; }

		// Token: 0x17009E48 RID: 40520
		// (get) Token: 0x06047B72 RID: 293746
		// (set) Token: 0x06047B73 RID: 293747
		bool? Async { get; set; }

		// Token: 0x17009E49 RID: 40521
		// (get) Token: 0x06047B74 RID: 293748
		// (set) Token: 0x06047B75 RID: 293749
		[Nullable(2)]
		object Params { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
