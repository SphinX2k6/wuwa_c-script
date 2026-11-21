using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000163 RID: 355
	[RequiredMember]
	public class Sequence : ISequence
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x00038F1D File Offset: 0x0003711D
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x00038F25 File Offset: 0x00037125
		[RequiredMember]
		public int Node { get; set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00038F2E File Offset: 0x0003712E
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00038F36 File Offset: 0x00037136
		public int? ArrivedByEdgeId { get; set; }

		// Token: 0x06000C65 RID: 3173 RVA: 0x00038F3F File Offset: 0x0003713F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public Sequence()
		{
		}
	}
}
