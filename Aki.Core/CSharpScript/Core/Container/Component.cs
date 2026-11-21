using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000161 RID: 353
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class Component : IComponent
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00038EE2 File Offset: 0x000370E2
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00038EEA File Offset: 0x000370EA
		[RequiredMember]
		public Dictionary<int, int> Degree { get; set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00038EF3 File Offset: 0x000370F3
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x00038EFB File Offset: 0x000370FB
		[RequiredMember]
		public Dictionary<int, List<IAdjItem>> Adj { get; set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00038F04 File Offset: 0x00037104
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x00038F0C File Offset: 0x0003710C
		[RequiredMember]
		public int EdgeCount { get; set; }

		// Token: 0x06000C5C RID: 3164 RVA: 0x00038F15 File Offset: 0x00037115
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public Component()
		{
		}
	}
}
