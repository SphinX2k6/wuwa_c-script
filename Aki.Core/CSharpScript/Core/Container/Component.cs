using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200015C RID: 348
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class Component : IComponent
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0003819F File Offset: 0x0003639F
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x000381A7 File Offset: 0x000363A7
		[RequiredMember]
		public Dictionary<int, int> Degree { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x000381B0 File Offset: 0x000363B0
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x000381B8 File Offset: 0x000363B8
		[RequiredMember]
		public Dictionary<int, List<IAdjItem>> Adj { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x000381C1 File Offset: 0x000363C1
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x000381C9 File Offset: 0x000363C9
		[RequiredMember]
		public int EdgeCount { get; set; }

		// Token: 0x06000BFD RID: 3069 RVA: 0x000381D2 File Offset: 0x000363D2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public Component()
		{
		}
	}
}
