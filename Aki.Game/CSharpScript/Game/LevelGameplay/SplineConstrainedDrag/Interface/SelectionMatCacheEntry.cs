using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface
{
	// Token: 0x02006A3C RID: 27196
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class SelectionMatCacheEntry : ISelectionMatCacheEntry
	{
		// Token: 0x1700990E RID: 39182
		// (get) Token: 0x06043A87 RID: 277127 RVA: 0x0108D355 File Offset: 0x0108B555
		// (set) Token: 0x06043A88 RID: 277128 RVA: 0x0108D35D File Offset: 0x0108B55D
		[Nullable(2)]
		public ItemMaterialControllerActorData Asset { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700990F RID: 39183
		// (get) Token: 0x06043A89 RID: 277129 RVA: 0x0108D366 File Offset: 0x0108B566
		// (set) Token: 0x06043A8A RID: 277130 RVA: 0x0108D36E File Offset: 0x0108B56E
		[RequiredMember]
		public HashSet<int> RefHolders { get; set; }

		// Token: 0x06043A8B RID: 277131 RVA: 0x0108D377 File Offset: 0x0108B577
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SelectionMatCacheEntry()
		{
		}
	}
}
