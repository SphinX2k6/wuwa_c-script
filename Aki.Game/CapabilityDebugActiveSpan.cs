using System;
using System.Runtime.CompilerServices;

// Token: 0x02000235 RID: 565
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class CapabilityDebugActiveSpan : ICapabilityDebugActiveSpan
{
	// Token: 0x17000530 RID: 1328
	// (get) Token: 0x060022DC RID: 8924 RVA: 0x000D9529 File Offset: 0x000D7729
	// (set) Token: 0x060022DD RID: 8925 RVA: 0x000D9531 File Offset: 0x000D7731
	[RequiredMember]
	public string CapabilityId { get; set; }

	// Token: 0x17000531 RID: 1329
	// (get) Token: 0x060022DE RID: 8926 RVA: 0x000D953A File Offset: 0x000D773A
	// (set) Token: 0x060022DF RID: 8927 RVA: 0x000D9542 File Offset: 0x000D7742
	[RequiredMember]
	public string GameObjectId { get; set; }

	// Token: 0x17000532 RID: 1330
	// (get) Token: 0x060022E0 RID: 8928 RVA: 0x000D954B File Offset: 0x000D774B
	// (set) Token: 0x060022E1 RID: 8929 RVA: 0x000D9553 File Offset: 0x000D7753
	[RequiredMember]
	public string ClassName { get; set; }

	// Token: 0x17000533 RID: 1331
	// (get) Token: 0x060022E2 RID: 8930 RVA: 0x000D955C File Offset: 0x000D775C
	// (set) Token: 0x060022E3 RID: 8931 RVA: 0x000D9564 File Offset: 0x000D7764
	[RequiredMember]
	public double StartTime { get; set; }

	// Token: 0x17000534 RID: 1332
	// (get) Token: 0x060022E4 RID: 8932 RVA: 0x000D956D File Offset: 0x000D776D
	// (set) Token: 0x060022E5 RID: 8933 RVA: 0x000D9575 File Offset: 0x000D7775
	[RequiredMember]
	public double EndTime { get; set; }

	// Token: 0x060022E6 RID: 8934 RVA: 0x000D957E File Offset: 0x000D777E
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public CapabilityDebugActiveSpan()
	{
	}
}
