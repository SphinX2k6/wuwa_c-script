using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F66 RID: 20326
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class QuickHackHighlightPreProcessResult : IQuickHackHighlightPreProcessResult
	{
		// Token: 0x17007F53 RID: 32595
		// (get) Token: 0x06034129 RID: 213289 RVA: 0x00C36B8A File Offset: 0x00C34D8A
		// (set) Token: 0x0603412A RID: 213290 RVA: 0x00C36B92 File Offset: 0x00C34D92
		[RequiredMember]
		public HashSet<EntityHandle> NewOnScreenTargetSet { get; set; }

		// Token: 0x17007F54 RID: 32596
		// (get) Token: 0x0603412B RID: 213291 RVA: 0x00C36B9B File Offset: 0x00C34D9B
		// (set) Token: 0x0603412C RID: 213292 RVA: 0x00C36BA3 File Offset: 0x00C34DA3
		[RequiredMember]
		public HashSet<EntityHandle> NewLockTargetSet { get; set; }

		// Token: 0x0603412D RID: 213293 RVA: 0x00C36BAC File Offset: 0x00C34DAC
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public QuickHackHighlightPreProcessResult()
		{
		}
	}
}
