using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Comic
{
	// Token: 0x02005B8C RID: 23436
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ComicPanelOpenParam : IComicPanelOpenParam
	{
		// Token: 0x17008CD8 RID: 36056
		// (get) Token: 0x0603B4AE RID: 242862 RVA: 0x00E21797 File Offset: 0x00E1F997
		// (set) Token: 0x0603B4AF RID: 242863 RVA: 0x00E2179F File Offset: 0x00E1F99F
		public int ComicConfigId { get; set; }

		// Token: 0x17008CD9 RID: 36057
		// (get) Token: 0x0603B4B0 RID: 242864 RVA: 0x00E217A8 File Offset: 0x00E1F9A8
		// (set) Token: 0x0603B4B1 RID: 242865 RVA: 0x00E217B0 File Offset: 0x00E1F9B0
		[RequiredMember]
		public Action OnSkip { get; set; }

		// Token: 0x17008CDA RID: 36058
		// (get) Token: 0x0603B4B2 RID: 242866 RVA: 0x00E217B9 File Offset: 0x00E1F9B9
		// (set) Token: 0x0603B4B3 RID: 242867 RVA: 0x00E217C1 File Offset: 0x00E1F9C1
		[RequiredMember]
		public Action OnComplete { get; set; }

		// Token: 0x0603B4B4 RID: 242868 RVA: 0x00E217CA File Offset: 0x00E1F9CA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ComicPanelOpenParam()
		{
		}
	}
}
