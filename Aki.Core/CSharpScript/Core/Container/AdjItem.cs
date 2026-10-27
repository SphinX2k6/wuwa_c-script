using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000158 RID: 344
	[RequiredMember]
	public class AdjItem : IAdjItem
	{
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0003813A File Offset: 0x0003633A
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00038142 File Offset: 0x00036342
		[RequiredMember]
		public int To { get; set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0003814B File Offset: 0x0003634B
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00038153 File Offset: 0x00036353
		[RequiredMember]
		public int EdgeId { get; set; }

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0003815C File Offset: 0x0003635C
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public AdjItem()
		{
		}
	}
}
