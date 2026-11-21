using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F2F RID: 16175
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class QuickHackHighlightPreProcessResult : IQuickHackHighlightPreProcessResult
	{
		// Token: 0x17005303 RID: 21251
		// (get) Token: 0x06028F97 RID: 167831 RVA: 0x00B8032A File Offset: 0x00B7E52A
		// (set) Token: 0x06028F98 RID: 167832 RVA: 0x00B80332 File Offset: 0x00B7E532
		[RequiredMember]
		public HashSet<EntityHandle> NewOnScreenTargetSet { get; set; }

		// Token: 0x17005304 RID: 21252
		// (get) Token: 0x06028F99 RID: 167833 RVA: 0x00B8033B File Offset: 0x00B7E53B
		// (set) Token: 0x06028F9A RID: 167834 RVA: 0x00B80343 File Offset: 0x00B7E543
		[RequiredMember]
		public HashSet<EntityHandle> NewLockTargetSet { get; set; }

		// Token: 0x06028F9B RID: 167835 RVA: 0x00B8034C File Offset: 0x00B7E54C
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public QuickHackHighlightPreProcessResult()
		{
		}
	}
}
