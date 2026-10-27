using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface
{
	// Token: 0x02006A3B RID: 27195
	[NullableContext(1)]
	public interface ISelectionMatCacheEntry
	{
		// Token: 0x1700990C RID: 39180
		// (get) Token: 0x06043A83 RID: 277123
		// (set) Token: 0x06043A84 RID: 277124
		[Nullable(2)]
		ItemMaterialControllerActorData Asset { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700990D RID: 39181
		// (get) Token: 0x06043A85 RID: 277125
		// (set) Token: 0x06043A86 RID: 277126
		HashSet<int> RefHolders { get; set; }
	}
}
