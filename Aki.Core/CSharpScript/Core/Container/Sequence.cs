using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200015E RID: 350
	[RequiredMember]
	public class Sequence : ISequence
	{
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x000381DA File Offset: 0x000363DA
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x000381E2 File Offset: 0x000363E2
		[RequiredMember]
		public int Node { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x000381EB File Offset: 0x000363EB
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x000381F3 File Offset: 0x000363F3
		public int? ArrivedByEdgeId { get; set; }

		// Token: 0x06000C06 RID: 3078 RVA: 0x000381FC File Offset: 0x000363FC
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public Sequence()
		{
		}
	}
}
