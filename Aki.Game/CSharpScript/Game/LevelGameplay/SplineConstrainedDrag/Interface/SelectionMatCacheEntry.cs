using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface
{
	// Token: 0x02005B99 RID: 23449
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class SelectionMatCacheEntry : ISelectionMatCacheEntry
	{
		// Token: 0x17006DF3 RID: 28147
		// (get) Token: 0x06039AD5 RID: 236245 RVA: 0x01031B5D File Offset: 0x0102FD5D
		// (set) Token: 0x06039AD6 RID: 236246 RVA: 0x01031B65 File Offset: 0x0102FD65
		[Nullable(2)]
		public ItemMaterialControllerActorData Asset { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006DF4 RID: 28148
		// (get) Token: 0x06039AD7 RID: 236247 RVA: 0x01031B6E File Offset: 0x0102FD6E
		// (set) Token: 0x06039AD8 RID: 236248 RVA: 0x01031B76 File Offset: 0x0102FD76
		[RequiredMember]
		public HashSet<int> RefHolders { get; set; }

		// Token: 0x06039AD9 RID: 236249 RVA: 0x01031B7F File Offset: 0x0102FD7F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SelectionMatCacheEntry()
		{
		}
	}
}
