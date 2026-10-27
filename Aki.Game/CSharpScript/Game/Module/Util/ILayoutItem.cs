using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048CA RID: 18634
	[NullableContext(2)]
	public interface ILayoutItem<TILayoutItemItem>
	{
		// Token: 0x17007986 RID: 31110
		// (get) Token: 0x06030B71 RID: 199537
		// (set) Token: 0x06030B72 RID: 199538
		[Nullable(1)]
		object Key { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17007987 RID: 31111
		// (get) Token: 0x06030B73 RID: 199539
		// (set) Token: 0x06030B74 RID: 199540
		TILayoutItemItem Value { get; set; }
	}
}
