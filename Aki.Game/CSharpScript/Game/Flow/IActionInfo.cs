using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063C2 RID: 25538
	[NullableContext(1)]
	public interface IActionInfo
	{
		// Token: 0x1700759F RID: 30111
		// (get) Token: 0x0603DF28 RID: 253736
		// (set) Token: 0x0603DF29 RID: 253737
		string Name { get; set; }

		// Token: 0x170075A0 RID: 30112
		// (get) Token: 0x0603DF2A RID: 253738
		// (set) Token: 0x0603DF2B RID: 253739
		bool? Async { get; set; }

		// Token: 0x170075A1 RID: 30113
		// (get) Token: 0x0603DF2C RID: 253740
		// (set) Token: 0x0603DF2D RID: 253741
		[Nullable(2)]
		object Params { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
