using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface
{
	// Token: 0x02005B98 RID: 23448
	[NullableContext(1)]
	public interface ISelectionMatCacheEntry
	{
		// Token: 0x17006DF1 RID: 28145
		// (get) Token: 0x06039AD1 RID: 236241
		// (set) Token: 0x06039AD2 RID: 236242
		[Nullable(2)]
		ItemMaterialControllerActorData Asset { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006DF2 RID: 28146
		// (get) Token: 0x06039AD3 RID: 236243
		// (set) Token: 0x06039AD4 RID: 236244
		HashSet<int> RefHolders { get; set; }
	}
}
