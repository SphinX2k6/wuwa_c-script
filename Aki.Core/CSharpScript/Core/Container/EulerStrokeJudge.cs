using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200015B RID: 347
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class EulerStrokeJudge : IEulerStrokeJudge
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00038E20 File Offset: 0x00037020
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x00038E28 File Offset: 0x00037028
		[RequiredMember]
		public EEulerStrokeKind Kind { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00038E31 File Offset: 0x00037031
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x00038E39 File Offset: 0x00037039
		[RequiredMember]
		public bool CanDrawInOneStroke { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00038E42 File Offset: 0x00037042
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x00038E4A File Offset: 0x0003704A
		[RequiredMember]
		public bool Connected { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00038E53 File Offset: 0x00037053
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x00038E5B File Offset: 0x0003705B
		[RequiredMember]
		public List<int> OddNodeIds { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00038E64 File Offset: 0x00037064
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00038E6C File Offset: 0x0003706C
		public int? SuggestedStartId { get; set; }

		// Token: 0x06000C39 RID: 3129 RVA: 0x00038E75 File Offset: 0x00037075
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public EulerStrokeJudge()
		{
		}
	}
}
