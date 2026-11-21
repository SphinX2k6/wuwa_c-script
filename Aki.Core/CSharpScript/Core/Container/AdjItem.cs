using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200015D RID: 349
	[RequiredMember]
	public class AdjItem : IAdjItem
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00038E7D File Offset: 0x0003707D
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x00038E85 File Offset: 0x00037085
		[RequiredMember]
		public int To { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00038E8E File Offset: 0x0003708E
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00038E96 File Offset: 0x00037096
		[RequiredMember]
		public int EdgeId { get; set; }

		// Token: 0x06000C42 RID: 3138 RVA: 0x00038E9F File Offset: 0x0003709F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public AdjItem()
		{
		}
	}
}
