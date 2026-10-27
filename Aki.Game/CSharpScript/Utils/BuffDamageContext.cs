using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004515 RID: 17685
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffDamageContext : BaseContext, IExpressionContext
	{
		// Token: 0x170073F1 RID: 29681
		// (get) Token: 0x0602D835 RID: 186421 RVA: 0x00A45D19 File Offset: 0x00A43F19
		// (set) Token: 0x0602D836 RID: 186422 RVA: 0x00A45D21 File Offset: 0x00A43F21
		public EContextType ContextType { get; set; }

		// Token: 0x04018552 RID: 99666
		public IBuffDamageParam DamageParam;

		// Token: 0x04018553 RID: 99667
		public Partial_RequirementPayload Payload;

		// Token: 0x04018554 RID: 99668
		public long ContextId;

		// Token: 0x04018555 RID: 99669
		public BaseDamageComponent Victim;
	}
}
