using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000156 RID: 342
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class EulerStrokeJudge : IEulerStrokeJudge
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x000380DD File Offset: 0x000362DD
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x000380E5 File Offset: 0x000362E5
		[RequiredMember]
		public EEulerStrokeKind Kind { get; set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x000380EE File Offset: 0x000362EE
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x000380F6 File Offset: 0x000362F6
		[RequiredMember]
		public bool CanDrawInOneStroke { get; set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x000380FF File Offset: 0x000362FF
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x00038107 File Offset: 0x00036307
		[RequiredMember]
		public bool Connected { get; set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00038110 File Offset: 0x00036310
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x00038118 File Offset: 0x00036318
		[RequiredMember]
		public List<int> OddNodeIds { get; set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00038121 File Offset: 0x00036321
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x00038129 File Offset: 0x00036329
		public int? SuggestedStartId { get; set; }

		// Token: 0x06000BDA RID: 3034 RVA: 0x00038132 File Offset: 0x00036332
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public EulerStrokeJudge()
		{
		}
	}
}
