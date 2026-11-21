using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003437 RID: 13367
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffDamageContext : BaseContext, IExpressionContext
	{
		// Token: 0x170046A9 RID: 18089
		// (get) Token: 0x06021F05 RID: 139013 RVA: 0x00971B29 File Offset: 0x0096FD29
		// (set) Token: 0x06021F06 RID: 139014 RVA: 0x00971B31 File Offset: 0x0096FD31
		public EContextType ContextType { get; set; }

		// Token: 0x04012B7A RID: 76666
		public IBuffDamageParam DamageParam;

		// Token: 0x04012B7B RID: 76667
		public Partial_RequirementPayload Payload;

		// Token: 0x04012B7C RID: 76668
		public long ContextId;

		// Token: 0x04012B7D RID: 76669
		public BaseDamageComponent Victim;
	}
}
